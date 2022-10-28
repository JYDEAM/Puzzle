using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Form1 : Form
    {
        int Cont;

        public Form1()
        {
            InitializeComponent();
        }


        public void Cambio_Button(Button butt1, Button butt2)
        {
            if (butt2.Text == "")
            {
                butt2.Text = butt1.Text;
                butt1.Text = "";
                Cont = Cont + 1;
                textBox1.Text = "Numero de Clics = " + Cont;
            }
            


        }
        public void Juego_Ganado()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15")

            {
                MessageBox.Show("Excelente a Ganado!!", "Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


        public void Barajar_Puzzle()
        {
            int[] aleatorio = new int[16];
            int i;
            int Ver_Filas;
            Boolean flag = false;
            i = 1;
            do
            {
                Random alet = new Random();
                Ver_Filas = Convert.ToInt32((alet.Next(0, 15)) + 1);
                for (int j = 1; j <= i; j++)
                {
                    if (aleatorio[j] == Ver_Filas)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    aleatorio[i] = Ver_Filas;
                    i = i + 1;
                }
            }
            while (i <= 15);
           /* string[] vector2 = aleatorio.Select(j => j.ToString()).ToArray();

            button1.Text = vector2[0];
            button2.Text = vector2[1];
            button3.Text = vector2[2];
            button4.Text = vector2[3];
            button5.Text = vector2[4];
            button6.Text = vector2[5];
            button7.Text = vector2[6];
            button8.Text = vector2[7];
            button9.Text = vector2[8];
            button10.Text = vector2[9];
            button11.Text = vector2[10]; 
            button12.Text = vector2[11];
            button13.Text = vector2[12];
            button14.Text = vector2[13];
            button15.Text = vector2[14];
            button16.Text = vector2[15];*/


            button1.Text = Convert.ToString(aleatorio[1]);
            button2.Text = Convert.ToString(aleatorio[2]);
            button3.Text = Convert.ToString(aleatorio[3]);
            button4.Text = Convert.ToString(aleatorio[4]);
            button5.Text = Convert.ToString(aleatorio[5]);
            button6.Text = Convert.ToString(aleatorio[6]);
            button7.Text = Convert.ToString(aleatorio[7]);
            button8.Text = Convert.ToString(aleatorio[8]);
            button9.Text = Convert.ToString(aleatorio[9]);
            button10.Text = Convert.ToString(aleatorio[10]);
            button11.Text = Convert.ToString(aleatorio[11]);
            button12.Text = Convert.ToString(aleatorio[12]);
            button13.Text = Convert.ToString(aleatorio[13]);
            button14.Text = Convert.ToString(aleatorio[14]);
            button15.Text = Convert.ToString(aleatorio[15]);
            button16.Text = "";


            /*for (int j = 0; j < vector2.Length; j++)
            {
                if (vector2[j].Equals("16"))
                {
                    vector2[j] = " ";
                }

            }*/



        }

    

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Desea salir del juego", "Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.No)

            {
                e.Cancel = true;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Barajar_Puzzle();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (button1.Text != "")
            //{
            // button2.Text = button1.Text;
            // button1.Text = "";
            //}//*
            Cambio_Button(button1, button2);
            Cambio_Button(button1, button5);
            Juego_Ganado();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cambio_Button(button2, button1);
            Cambio_Button(button2, button3);
            Cambio_Button(button2, button6);
            Juego_Ganado();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Cambio_Button(button3, button2);
            Cambio_Button(button3, button4);
            Cambio_Button(button3, button7);
            Juego_Ganado(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cambio_Button(button4, button3);
            Cambio_Button(button4, button8);
            Juego_Ganado();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cambio_Button(button5, button1);
            Cambio_Button(button5, button6);
            Cambio_Button(button5, button9);
            Juego_Ganado();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cambio_Button(button6, button2);
            Cambio_Button(button6, button5);
            Cambio_Button(button6, button7);
            Cambio_Button(button6, button10);
            Juego_Ganado();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cambio_Button(button7, button3);
            Cambio_Button(button7, button6);
            Cambio_Button(button7, button8);
            Cambio_Button(button7, button11);
            Juego_Ganado();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cambio_Button(button8, button4);
            Cambio_Button(button8, button7);
            Cambio_Button(button8, button12);
            Juego_Ganado();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cambio_Button(button9, button5);
            Cambio_Button(button9, button10);
            Cambio_Button(button9, button13);
            Juego_Ganado();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Cambio_Button(button10, button6);
            Cambio_Button(button10, button9);
            Cambio_Button(button10, button11);
            Cambio_Button(button10, button14);
            Juego_Ganado();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cambio_Button(button11, button7);
            Cambio_Button(button11, button10);
            Cambio_Button(button11, button12);
            Cambio_Button(button11, button15);
            Juego_Ganado();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cambio_Button(button12, button8);
            Cambio_Button(button12, button11);
            Cambio_Button(button12, button16);
            Juego_Ganado();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Cambio_Button(button13, button9);
            Cambio_Button(button13, button14);
            Juego_Ganado();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cambio_Button(button14, button10);
            Cambio_Button(button14, button13);
            Cambio_Button(button14, button15);
            Juego_Ganado();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cambio_Button(button15, button11);
            Cambio_Button(button15, button16);
            Cambio_Button(button15, button14);
            Juego_Ganado();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Cambio_Button(button16, button12);
            Cambio_Button(button16, button15);
            Juego_Ganado();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Barajar_Puzzle();
            textBox1.Clear();

           // this.Refresh();
           // this.Hide();

           // Form1 New_Game = new Form1();
           // New_Game.Show();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Desea salir del juego", "Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)

            {
                Application.ExitThread();
            }
        }
    }
}
