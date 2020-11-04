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
    public partial class Form3 : Form
    {
        int indeks = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FileStream veriOku = new FileStream("veriler.txt", FileMode.Open, FileAccess.Read);
            StreamReader verioku = new StreamReader(veriOku);
            
           
            
                string[] satirlar = verioku.ReadToEnd().Split('\n');//satırları tuttuğumuz dizi
                verioku.Close();
                veriOku.Close();
               
           
                for (int i = 0; i < satirlar.Length - 1; i++)
                {
                    string[] kelimeler = satirlar[i].Split(' ');//satırlar[i]daki kelimeler
                    Listele1.AppendText(kelimeler[1] + ' ' + kelimeler[2] + ' ' + kelimeler[3]);
                    if (kelimeler[0].Substring(0, 1) == "k")
                    {
                        if (i % 2 == 0) Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Bold);
                        Listele1.Select(indeks, kelimeler[1].Length);
                        Listele1.SelectionColor = Color.Red;
                        indeks += kelimeler[1].Length + 1; //+1 boşluğu da almak için aldık veysel doğan olsun diye yoksa doğa da kalır
                    }
                    if (kelimeler[0].Substring(0, 1) == "y")
                    {
                        if (i % 2 == 0) Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Bold);
                        Listele1.Select(indeks, kelimeler[1].Length);
                        Listele1.SelectionColor = Color.Green;
                        indeks += kelimeler[1].Length + 1;
                    }
                    if (kelimeler[0].Substring(0, 1) == "m")
                    {
                        if (i % 2 == 0) Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Bold);
                        Listele1.Select(indeks, kelimeler[1].Length);
                        Listele1.SelectionColor = Color.Blue;
                        indeks += kelimeler[1].Length + 1;
                    }
                    if (kelimeler[0].Substring(1, 1) == "k")
                    {
                        if (i % 2 == 0) Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Bold);
                        Listele1.Select(indeks, kelimeler[2].Length);
                        Listele1.SelectionColor = Color.Red;
                        indeks += kelimeler[2].Length + 1;
                    }
                    if (kelimeler[0].Substring(1, 1) == "y")
                    {
                        if (i % 2 == 0) Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Bold);
                        Listele1.Select(indeks, kelimeler[2].Length);
                        Listele1.SelectionColor = Color.Green;
                        indeks += kelimeler[2].Length + 1;
                    }
                    if (kelimeler[0].Substring(1, 1) == "m")
                    {
                        if (i % 2 == 0) Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Bold);
                        Listele1.Select(indeks, kelimeler[2].Length);
                        Listele1.SelectionColor = Color.Blue;
                        indeks += kelimeler[2].Length + 1;
                    }

                if (i % 2 == 0) Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Bold);
                else Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Regular);
                if (kelimeler[0].Substring(2, 1) == "k")
                    {
                  
                        Listele1.Select(indeks, kelimeler[3].Length);
                        Listele1.SelectionColor = Color.Red;
                        indeks += kelimeler[3].Length;
                    }
                    if (kelimeler[0].Substring(2, 1) == "y")
                    {

                      
                        Listele1.Select(indeks, kelimeler[3].Length);
                        Listele1.SelectionColor = Color.Green;
                        indeks += kelimeler[3].Length;
                    }
                    if (kelimeler[0].Substring(2, 1) == "m")
                    {
                       
                        Listele1.Select(indeks, kelimeler[3].Length);
                        Listele1.SelectionColor = Color.Blue;
                        indeks += kelimeler[3].Length;
                    }

                if (i % 2 == 0) Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Bold);
                else Listele1.SelectionFont = new Font(Listele1.Font, FontStyle.Regular);
            }
            }

        private void Listele1_KeyPress(object sender, KeyPressEventArgs e)
        {
                    e.Handled = true;
        }
    }
            }
        
    
    

