using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yılan
{
    public partial class yılan : Form
    {
        private int yilanParcaAdet;
        private int yilanBoyut=20;
        public yılan()
        {
            InitializeComponent();
            Sifirla();
            YilanYerleştir();

        }
        private void yılan_Load(object sender, EventArgs e)
        {
            //Sifirla();
            //YilanYerleştir();
        }
        private void Sifirla()
        {
            yilanParcaAdet = 0;
            
        }
        private Label yilanParcaOlustur(int locationX,int locationY)
        {
            yilanParcaAdet++;
            Label parca = new Label()
            {
                Name = "yilan parçası " + yilanParcaAdet,
                BackColor = Color.Red,
                Width = yilanBoyut,
                Height = yilanBoyut,
                Location=new Point(locationX,locationY)
            };
            this.yilanalanı.Controls.Add(parca);
            return parca;
        }
        private void YilanYerleştir()
        {
            var yilanBas = yilanParcaOlustur(0, 0);
            var locationX = (yilanalanı.Width / 2) - (yilanBas.Width / 2);
            var locationY = (yilanalanı.Height / 2) - (yilanBas.Height / 2);
            yilanBas.Location = new Point(locationX, locationY);
        } 
        private void kolay_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void zor_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void skor_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = adtext.Text.Trim();
            if (ad == "")
            {
                MessageBox.Show("Lütfen adınızı giriniz.");
                return;
            }
           // oyuncu = ad;
            Text = "Yılan Oyunu - " + ad;
            Refresh();
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yardımbtn_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
