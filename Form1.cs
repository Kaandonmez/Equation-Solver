using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Equation_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Equ
        {
            public double katsayi_x_kare, katsayi_x;
            public int sabit;
            public double delta;
            public double kok1, kok2;
            string[] isaretler;
            string[] elemanlar;

            public Equ()
            {

            }

            public Equ(string main_equ)
            {


                string backup1 = main_equ;
                string backup2 = main_equ;





                elemanlar = backup1.Split('+', '-');

                isaretler = backup2.Split('x', 'X');


                int x_kare = main_equ.IndexOf("X");

                int x = main_equ.IndexOf("x");



                if (x_kare < x)
                {
                    f_x_kare();
                    disc();
                    kok();
                }

                else
                {
                    f_x();
                    disc();
                    kok();
                }

            }

            void f_x_kare()
            {

                katsayi_x_kare = Convert.ToDouble(isaretler[0]);
                katsayi_x = Convert.ToDouble(isaretler[1]);
                sabit = Int32.Parse(isaretler[2]);



            }

            void f_x()
            {
                katsayi_x = Convert.ToDouble(isaretler[0]);
                katsayi_x_kare = Convert.ToDouble(isaretler[1]);
                sabit = Int32.Parse(isaretler[2]);
            }

            void disc()
            {
                double b_kare = Math.Pow(katsayi_x, 2);

                delta = b_kare - (4 * katsayi_x_kare * sabit);

            }


            void kok()
            {
                if (delta > 0)
                {
                    kok1 = (-(katsayi_x) + Math.Sqrt(delta)) / (2 * katsayi_x_kare);
                    kok2 = (-(katsayi_x) - Math.Sqrt(delta)) / (2 * katsayi_x_kare);
                    
                }
                else if (delta == 0)
                {
                    kok1 = (-(katsayi_x) + Math.Sqrt(delta)) / 2 * katsayi_x_kare;
                    kok2 = (-(katsayi_x) - Math.Sqrt(delta)) / 2 * katsayi_x_kare;

                }

                else if (delta < 0)
                {
                    kok1 = kok2 = 0;

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("(1) x² li ifade yerine X(büyük x) kullanınız." +
            //    "\n(Ör:3x²+4x+4 için 3X+4x+4)" +
            //    "\n\n(2) Eğer x'li ifadenin katsayısı 1 ise 1 ,olmayan x li ifade için katsayıya 0 yazınız. " +
            //    "\n(Ör:x²+x+4 için 1X+1x+4)" +
            //    "\n(Ör:2x²+5 için 2X+0x+5 yada 0x+2X+5)","Program Kullanımı Hakkında",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information,
            //    MessageBoxDefaultButton.Button1);
            string[] ornek_denklem = { "1X-1x-6", " 3X-5x+0", "2X+1x-1", "1X-5x+6" };
            denklem_txt.Text = ornek_denklem[2];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string denk = this.denklem_txt.Text;
            Equ denklem = new Equ(denk);
            kok1.Text = denklem.kok1.ToString();
            kok2.Text = denklem.kok2.ToString();
            toplami.Text = (denklem.kok1 + denklem.kok2).ToString();
            carpimi.Text = (denklem.kok1 * denklem.kok2).ToString();
            disk_txt.Text = denklem.delta.ToString();

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] ornek_denklem = { "1X-1x-6", " 3X-5x+0", "2X+1x-1", "1X-5x+6" };
            int random_denklem = rnd.Next(4);
            denklem_txt.Text = ornek_denklem[random_denklem];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) x² li ifade yerine X(büyük x) kullanınız." +
                "\n(Ör:3x²+4x+4 için 3X+4x+4)" +
                "\n\n(2) Eğer x'li ifadenin katsayısı 1 ise 1 ,olmayan x li ifade için katsayıya 0 yazınız. " +
                "\n(Ör:x²+x+4 için 1X+1x+4)" +
                "\n(Ör:2x²+5 için 2X+0x+5 yada 0x+2X+5)", "Program Kullanımı Hakkında",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }
    }

    
}