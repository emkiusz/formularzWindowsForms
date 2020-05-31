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

namespace formularz
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        private string rand_text;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {
                rand_text += rand.Next(0, 9);
            }
            string txt = textBox1.Text + "\n" + textBox2.Text + "\n" + comboBox1.Text + "\n" + dateTimePicker1.Value.ToString("yyyyddMM") + rand_text;
            MessageBox.Show(txt);
            txt = textBox1.Text + " " + textBox2.Text + ", " + comboBox1.Text + ", " + dateTimePicker1.Value.ToString("yyyyddMM") + rand_text;
            File.AppendAllText("dane.txt", txt+Environment.NewLine);
            rand_text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.Text = "Białystok";
            comboBox1.SelectedValue ="Białystok";
        }
    }
}
