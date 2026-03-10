using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022400060
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double nilaiAwal;
            if (!double.TryParse(textBox1.Text, out nilaiAwal))
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string satuanAwal = comboBox1.Text;
            string satuanAkhir = comboBox2.Text;
            double hasil = 0;
            double celcius = 0;

            if (satuanAwal == "Celcius") celcius = nilaiAwal;
            else if (satuanAwal == "Farenheit") celcius = (nilaiAwal - 32) * 5 / 9;
            else if (satuanAwal == "Kelvin") celcius = nilaiAwal - 273.15;
            else if (satuanAwal == "Reamur") celcius = nilaiAwal * 5 / 4;

            if (satuanAkhir == "Celcius") hasil= celcius;
            else if (satuanAkhir == "Farenheit") hasil = (celcius * 9/5) +32;
            else if (satuanAkhir == "Kelvin") hasil = celcius  + 273.15 ;
            else if (satuanAkhir == "Reamur") hasil = celcius *4/5 ;

            textBox2.Text = hasil.ToString("0.##");
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

        
    }
}
