using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFinal
{
    public partial class GerarChaves : Form
    {
        public GerarChaves()
        {
            InitializeComponent();
        }
        public List<Jogador> lista = null;

        public AdicionarResultado adicionar = null;
        
        private void GerarChaves_Load(object sender, EventArgs e)
        {
            Jogadores.Items.Add("Jogadores Inscritos\n");
            foreach (Jogador item in lista)
            {
                Jogadores.Items.Add(item.Nome+"\n");
            }
        }

        private void cmdGerarChave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (i == 3) adicionar.label1.Text = lista[i].Nome;
                if (i == 6) adicionar.label2.Text = lista[i].Nome;
                if (i == 2) adicionar.label3.Text = lista[i].Nome;
                if (i == 0) adicionar.label4.Text = lista[i].Nome;
                if (i == 7) adicionar.label5.Text = lista[i].Nome;
                if (i == 5) adicionar.label6.Text = lista[i].Nome;
                if (i == 1) adicionar.label7.Text = lista[i].Nome;
                if (i == 4) adicionar.label8.Text = lista[i].Nome;

            }

        }
    }
}
