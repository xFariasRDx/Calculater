using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;



namespace Interfax.Calculater
{
    public partial class Form1 : Form
    {
        string Nada = "";
        double Num1;
        double Num2;
        string Operador;

        public Form1()
        {
            InitializeComponent();
        }

        ApplicationFirst.Calculater.Logica Logica = new ApplicationFirst.Calculater.Logica();

        private void Start()
        {
            if (Screensita.Text == "" || Screensita.Text == ".")
            {
                Screensita.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "0";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Start();
            Screensita.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Start();
            if (Screensita.Text.Length == 1)
                {
                    Screensita.Text = "";
                }
            else
                {
                    Screensita.Text = Screensita.Text.Substring(0, Screensita.Text.Length - 1);
                }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Screensita.Text = Screensita.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
            Operador = "+";
            Num1 = double.Parse(Screensita.Text);
            Screensita.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Start();
            Operador = "-";
            Num1 = double.Parse(Screensita.Text);
            Screensita.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Start();
            Operador = "*";
            Num1 = double.Parse(Screensita.Text);
            Screensita.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Start();
            Operador = "/";
            Num1 = double.Parse(Screensita.Text);
            Screensita.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Start();
                Num2 = double.Parse(Screensita.Text);
                double sum;
                double res;
                double mul;
                double div;

                if (Operador == "+")
                {
                    sum = Logica.Sumar(Num1, Num2);
                    Screensita.Text = sum.ToString();
                }
                else if (Operador == "-")
                {
                    res = Logica.Restar(Num1, Num2);
                    Screensita.Text = res.ToString();
                }
                else if (Operador == "*")
                {
                    mul = Logica.Multiplicar(Num1, Num2);
                    Screensita.Text = mul.ToString();
                }
                else if (Operador == "/")
                {
                    div = Logica.Dividir(Num1, Num2);
                    Screensita.Text = div.ToString();
                }
                else
                {
                    Screensita.Text = Nada.ToString();
                }

            }
            catch (Exception N) { Screensita.Text = "Syntax E."; }
            //Start();
            //Num2 = double.Parse(Screensita.Text);
            //double sum;
            //double res;
            //double mul;
            //double div;

            //if (Operador == "+")
            //{
            //    sum = Logica.Sumar(Num1, Num2);
            //    Screensita.Text = sum.ToString();
            //}
            //else if (Operador == "-")
            //{
            //    res = Logica.Restar(Num1, Num2);
            //    Screensita.Text = res.ToString();
            //}
            //else if (Operador == "*")
            //{
            //    mul = Logica.Multiplicar(Num1, Num2);
            //    Screensita.Text = mul.ToString();
            //}
            //else if (Operador == "/")
            //{
            //    div = Logica.Dividir(Num1, Num2);
            //    Screensita.Text = div.ToString();
            //}
            //else
            //{
            //    Screensita.Text = Nada.ToString();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
