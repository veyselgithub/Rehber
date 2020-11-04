using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace rehber
{
    public partial class Form2 : Form
    {
        string norenk;
        string adrenk;
        string soyadrenk;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
            lblYazi1.Text = txtAd.Text + " " + txtSoyad.Text + " " + txtNo.Text;
            StreamWriter SW = new StreamWriter("veriler.txt",true);
            SW.WriteLine(adrenk+soyadrenk+norenk+" "+lblYazi1.Text);
            SW.Close();
        }

      

        private void adRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adRenk.SelectedItem.ToString() == "kırmızı") adrenk = "k";
            if (adRenk.SelectedItem.ToString() == "yeşil") adrenk = "y";
            if (adRenk.SelectedItem.ToString() == "mavi") adrenk = "m";
        }

        private void soyadRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soyadRenk.SelectedItem.ToString() == "kırmızı") soyadrenk = "k";
            if (soyadRenk.SelectedItem.ToString() == "yeşil") soyadrenk = "y";
            if (soyadRenk.SelectedItem.ToString() == "mavi") soyadrenk = "m";
        }
        private void noRenk_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (noRenk.SelectedItem.ToString() == "kırmızı") norenk = "k";
            if (noRenk.SelectedItem.ToString() == "yeşil") norenk = "y";
            if (noRenk.SelectedItem.ToString() == "mavi") norenk = "m";
        }

        private void adRenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void soyadRenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void noRenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

}
