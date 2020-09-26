using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFinal
{
    public partial class AdicionarResultado : Form
    {
        public AdicionarResultado()
        {
            InitializeComponent();
        }
        public List<Jogador> lista = null;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) label9.Text = label1.Text;
            groupBox5.Visible = true;
            maskedTextBox5.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) label9.Text = label2.Text;
            groupBox5.Visible = true;
            maskedTextBox5.Visible = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) label10.Text = label3.Text;
            groupBox5.Visible = true;
            maskedTextBox5.Visible = true;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) label10.Text = label4.Text;
            groupBox5.Visible = true;
            maskedTextBox5.Visible = true;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true) label11.Text = label5.Text;
            groupBox6.Visible = true;
            maskedTextBox6.Visible = true;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true) label11.Text = label6.Text;
            groupBox6.Visible = true;
            maskedTextBox6.Visible = true;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true) label12.Text = label7.Text;
            groupBox6.Visible = true;
            maskedTextBox6.Visible = true;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true) label12.Text = label8.Text;
            groupBox6.Visible = true;
            maskedTextBox6.Visible = true;

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true) label13.Text = label9.Text;
            groupBox7.Visible = true;
            maskedTextBox7.Visible = true;

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true) label13.Text = label10.Text;
            groupBox7.Visible = true;
            maskedTextBox7.Visible = true;

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true) label14.Text = label11.Text;
            groupBox7.Visible = true;
            maskedTextBox7.Visible = true;

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true) label14.Text = label12.Text;
            groupBox7.Visible = true;
            maskedTextBox7.Visible = true;

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true) label15.Text = label13.Text;
           

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true) label15.Text = label14.Text;

        }
    }
}
