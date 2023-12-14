using McDonaldsOrderList.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace McDonaldsOrderList
{
    public partial class Form1 : Form
    {
        List<Order> _AllOrders = new List<Order>();
        List<Order> _readyOrders = new List<Order>();
        List<Order> _preparingOrders = new List<Order>();


        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(960, 800);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            JsonVeriDinle("192.168.184.214");

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            ResponsiveTasarim();
            UpdateOrders();
        }


        public void ResponsiveTasarim()
        {
            // Form genişliğinin %2'si kadar boşluk bırak
            float spacePercentage = 2f;
            int spacing = (int)(this.Width * (spacePercentage / 100));

            // Her iki panelin toplam alabileceği genişliği hesapla
            int totalAvailableWidth = this.Width - spacing;

            // Her panel için genişlik
            int panelWidth = totalAvailableWidth / 2;

            // readyPanel ve preparingPanel'in genişliklerini ve konumlarını ayarla
            readyPanel.Width = panelWidth;
            preparingPanel.Width = panelWidth;

            // preparingPanel sol tarafta olacak, dolayısıyla konumu (0,0) olarak başlar
            preparingPanel.Location = new Point(0, preparingPanel.Location.Y);

            // readyPanel sağ tarafta olacak, dolayısıyla konumu preparingPanel'in genişliği + boşluk kadar olacak
            readyPanel.Location = new Point(preparingPanel.Width + spacing, readyPanel.Location.Y);

            // preparingOrdersPanel ve orderReadyPanel'in genişliklerini ve konumlarını ayarla
            preparingOrdersPanel.Width = panelWidth;
            orderReadyPanel.Width = panelWidth;

            // preparingOrdersPanel sol tarafta olacak, dolayısıyla konumu (0,0) olarak başlar
            preparingOrdersPanel.Location = new Point(0, preparingOrdersPanel.Location.Y);

            // orderReadyPanel sağ tarafta olacak, dolayısıyla konumu preparingOrdersPanel'in genişliği + boşluk kadar olacak
            orderReadyPanel.Location = new Point(preparingOrdersPanel.Width + spacing, orderReadyPanel.Location.Y);

            // readyLabel konumlarını ayarla
            readyLabel.Location = new Point(
           (orderReadyPanel.Width - readyLabel.Width) / 2,
               readyLabel.Location.Y
                     );
            // preparingLabel'in konumlarını ayarla
            preparingLabel.Location = new Point(
                (preparingOrdersPanel.Width - preparingLabel.Width) / 2,
                preparingLabel.Location.Y
            );
        }

        public void SeperateOrders()
        {

            // readyOrders ve preparingOrders listelerini temizle
            _readyOrders.Clear();
            _preparingOrders.Clear();

            // AllOrders listesindeki siparişleri hazırlanıyor ve hazır olarak ayır
            foreach (Order order in _AllOrders)
            {
                if (order.OrderStatus.ToLower() == "hazırlanıyor")
                {
                    _preparingOrders.Add(order);
                }
                else if (order.OrderStatus == "hazır")
                {
                    _readyOrders.Add(order);
                }
            }
        }

        public void UpdateOrders()
        {
            preparingOrdersPanel.Controls.Clear();
            orderReadyPanel.Controls.Clear();
            // readyOrders ve preparingOrders listelerini güncelle
            //InitializeMockOrders();
            SeperateOrders();
            AddOrdersIntoPanel(orderReadyPanel, _readyOrders);
            AddOrdersIntoPanel(preparingOrdersPanel, _preparingOrders);

        }

      

        public void AddOrdersIntoPanel(Panel panelName, List<Order> orderList)
        {

            orderList = orderList.OrderByDescending(o => o.Id).ToList();
            // Panel içindeki önceki kontrolleri temizle
            panelName.Controls.Clear();

            // Margin değerlerini hesapla
            int marginTopBottom = (int)(panelName.Height * 0.02);
            int marginLeftRight = (int)(panelName.Width * 0.04);

            // GroupBox'ın genişliğini ve yüksekliğini hesapla
            int groupBoxWidth = panelName.Width - (marginLeftRight * 2);
            // GroupBox'ın yüksekliğini sabit bir değere ayarla, örneğin panel yüksekliğinin 1/10'u
            int groupBoxHeight = panelName.Height / 10;

            int currentTopPosition = marginTopBottom;

            // Her bir order için bir GroupBox oluştur ve panele ekle
            foreach (Order order in orderList)
            {
                // GroupBox oluştur
                GroupBox groupBox = new GroupBox();
                groupBox.Width = groupBoxWidth;
                groupBox.Height = groupBoxHeight;
                groupBox.Location = new Point(marginLeftRight, currentTopPosition);
                groupBox.BackColor = Color.Black;

                // Siparişin ID'sini gösteren Label oluştur
                Label label = new Label();
                label.Text = order.Id.ToString();
                label.ForeColor = Color.White;
                label.BackColor = Color.Black;
                label.TextAlign = ContentAlignment.MiddleCenter; // Label'ı ortala
                label.Dock = DockStyle.Fill; // Label'ı GroupBox içinde doldur
                label.Font = new Font("Arial", groupBoxHeight * 0.5f, FontStyle.Bold, GraphicsUnit.Pixel); // Font boyutunu responsive olarak ayarla

                groupBox.Controls.Add(label);

                // GroupBox'ı panele ekle
                panelName.Controls.Add(groupBox);

                // Sonraki GroupBox için üst pozisyonu güncelle
                currentTopPosition += groupBoxHeight + marginTopBottom;
            }
        }

        //public void InitializeMockOrders()
        //{

        //    // AllOrders listesini temizle
        //    _AllOrders.Clear();

        //    // 10 adet sipariş oluştur ve AllOrders listesine ekle
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Order order = new Order();
        //        order.Id = i + 1;
        //        order.OrderStatus = i % 5 == 0 ? "hazır" : "hazırlanıyor";
        //        if (order.OrderStatus.ToLower() == "hazır")
        //        {
        //            Console.Beep();
        //        }
        //        if (order.OrderStatus.ToLower() != "teslim")
        //        {
        //            _AllOrders.Add(order);

        //        }
        //    }
        //}


        public void JsonVeriDinle(string IpAddress= "192.168.88.1" , int port = 1071)
        {
            // Dinleyici kişinin IP adresini alır. Yani Göndericinin Gönderdiği IP adresi ile aynı olmalıdır !!!!
            IPAddress localAddr = IPAddress.Parse(IpAddress);
          
            // Dinlenecek portu belirle
            TcpListener server = new TcpListener(IPAddress.Any, port); // Dinleyici veri ile gönderici verinin portu aynı olmalıdır !!!!
            server.Start();

            Task.Run(() => // Asenkron iş parçacığında server dinlemeye başlar
            {
                while (true)
                {
                    try
                    {
                        using (TcpClient client = server.AcceptTcpClient())
                        using (NetworkStream stream = client.GetStream())
                        {
                            byte[] lengthBytes = new byte[4];
                            stream.Read(lengthBytes, 0, 4);
                            int length = BitConverter.ToInt32(lengthBytes, 0);

                            byte[] jsonBytes = new byte[length];
                            stream.Read(jsonBytes, 0, jsonBytes.Length);

                            string jsonString = Encoding.UTF8.GetString(jsonBytes);

                            List<Order> receivedOrders = JsonSerializer.Deserialize<List<Order>>(jsonString);

                            // UI güncellemeleri UI thread'inde yapılmalı
                            this.Invoke((MethodInvoker)delegate
                            {
                                _AllOrders.Clear();
                                foreach (Order order in receivedOrders)
                                {
                                    if (order.OrderStatus.ToLower() != "teslim")
                                    {
                                        _AllOrders.Add(order);
                                        UpdateOrders(); // UI güncellemesi
                                    }
                                }


                            });
                        }
                    }
                    catch (Exception e)
                    {

                        continue;
                    }
                }
            });

           
        }
    }
}
