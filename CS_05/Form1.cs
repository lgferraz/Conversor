using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDollar_Click(object sender, EventArgs e)
        {
            Conversor convert = new Conversor();
            string valor = txtDollar.Text;
            string cotacao = txtCot.Text;
            lbDollar.Text = convert.Dollar(valor, cotacao);
        }

        private void btnCelcius_Click(object sender, EventArgs e)
        {
            Conversor convert = new Conversor();
            string valor = txtCelcius.Text;
            lbCelcius.Text = convert.Celcius(valor);
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            Conversor convert = new Conversor();
            string valor = txtFahrenheit.Text;
            lbFahrenheit.Text = convert.Fahrenheit(valor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
