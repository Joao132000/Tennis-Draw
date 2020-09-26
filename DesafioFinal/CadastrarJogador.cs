using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFinal
{
    public partial class CadastrarJogador : Form
    {
        public CadastrarJogador()
        {
            InitializeComponent();
        }
        public List<Jogador> lista = null;
        Jogador j = null;

        int y = 0;
        private void cmdNomeJogador_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "")
            {
                j = new Jogador();
                j.Nome = textBox1.Text;
                lista.Add(j);
                y++;
                lblNumJog.Text = "Numero de Jogadores cadastrados: " + y.ToString();
            }
            textBox1.Clear();          
        }
    }
}
