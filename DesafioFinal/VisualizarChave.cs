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
    public partial class VisualizarChave : Form
    {
        public VisualizarChave()
        {
            InitializeComponent();
        }

        public AdicionarResultado adicionar = null;


        private void VisualizarChave_Load(object sender, EventArgs e)
        {
            label1.Text = adicionar.label1.Text;
            label2.Text = adicionar.label2.Text;
            label3.Text = adicionar.label3.Text;
            label4.Text = adicionar.label4.Text;
            label5.Text = adicionar.label5.Text;
            label6.Text = adicionar.label6.Text;
            label7.Text = adicionar.label7.Text;
            label8.Text = adicionar.label8.Text;
            label9.Text = adicionar.label9.Text;
            label10.Text = adicionar.label10.Text;
            label11.Text = adicionar.label11.Text;
            label12.Text = adicionar.label12.Text;
            label13.Text = adicionar.label13.Text;
            label14.Text = adicionar.label14.Text;
            label15.Text = adicionar.label15.Text;

            if (label15.Text != "") progressBar1.Value = 100;
            else if ((label13.Text != "") && (label14.Text != "")) progressBar1.Value = 80;
            else if ((label9.Text != "") && (label10.Text != "") && (label11.Text != "") && (label12.Text != "")) progressBar1.Value = 60;
            else progressBar1.Value = 0;

            if (progressBar1.Value == 100) label16.Text = "Torneio Concluido";
        }

        private void VisualizarChave_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Cyan, 20, 50, 100, 50);
            e.Graphics.DrawLine(Pens.Black, 20, 100, 100, 100);
            e.Graphics.DrawLine(Pens.Black, 20, 150, 100, 150);
            e.Graphics.DrawLine(Pens.Black, 20, 200, 100, 200);
            e.Graphics.DrawLine(Pens.Black, 20, 250, 100, 250);
            e.Graphics.DrawLine(Pens.Black, 20, 300, 100, 300);
            e.Graphics.DrawLine(Pens.Black, 20, 350, 100, 350);
            e.Graphics.DrawLine(Pens.Black, 20, 400, 100, 400);

            e.Graphics.DrawLine(Pens.Black, 210, 75, 290, 75);
            e.Graphics.DrawLine(Pens.Black, 210, 175, 290, 175);
            e.Graphics.DrawLine(Pens.Black, 210, 275, 290, 275);
            e.Graphics.DrawLine(Pens.Black, 210, 375, 290, 375);

            e.Graphics.DrawLine(Pens.Black, 400, 125, 480, 125);
            e.Graphics.DrawLine(Pens.Black, 400, 325, 480, 325);

            e.Graphics.DrawLine(Pens.Black, 565, 225, 645, 225);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
