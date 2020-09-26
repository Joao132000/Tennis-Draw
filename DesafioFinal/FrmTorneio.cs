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
    public partial class FrmTorneio : Form
    {
        public FrmTorneio()
        {
            InitializeComponent();
        }

        private int i = 0;
        List<Jogador> lista = new List<Jogador>();

        public AdicionarResultado adicionar = new AdicionarResultado();
        VisualizarChave vizualizar = new VisualizarChave();


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                pictureBox1.Image = Properties.Resources.Fête_du_tennis_2;
                i = 1;
            }
            else if (i == 1)
            {
                pictureBox1.Image = Properties.Resources.tennis_court_Green_Tennis_Ball;
                i = 2;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Tenis_2;
                i = 0;
            }
        }

        
        private void cadastrarJogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarJogador c = new CadastrarJogador();
            c.lista = lista;
            c.ShowDialog();
        }

        private void gerarChavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarChaves g = new GerarChaves();
            g.lista = lista;
            g.adicionar = adicionar;
            g.ShowDialog();
        }

        private void adicionarResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adicionar.ShowDialog();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vizualizar.adicionar = adicionar;
            vizualizar.ShowDialog();
        }

        
    }
}
