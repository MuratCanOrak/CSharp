using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_01
{
    public partial class Form1 : Form
    {
      
        /// <summary>
        /// /////////////////////////Değiştirdim
        /// </summary>
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

                 MessageBox.Show("Hoş geldiniz.. ");
            
            }

            private void Button1_Click(object sender, EventArgs e)
            {


                MessageBox.Show("SONUÇ:  " + Topla());
                //Topla();


            }

            String Topla()
            {

                int numberOne = Convert.ToInt32(textBox1.Text);
                int numberTwo = Convert.ToInt32(textBox2.Text);

                var sonuc = (numberOne + numberTwo).ToString();

                return sonuc;
            }
            String Cikar()
            {

                int numberOne = Convert.ToInt32(textBox1.Text);
                int numberTwo = Convert.ToInt32(textBox2.Text);

                var sonuc = (numberOne - numberTwo).ToString();
         
                return sonuc;
            }
            String Carp()
            {

                int numberOne = Convert.ToInt32(textBox1.Text);
                int numberTwo = Convert.ToInt32(textBox2.Text);

                var sonuc = (numberOne * numberTwo).ToString();

                return sonuc;
            }

         

        private void BtnCikar_Click_1(object sender, EventArgs e)
        {
                textBox3.Text = Cikar();
        }

        private void BtnCarp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SONUÇ:  " + Carp());
        }
    }

    }


