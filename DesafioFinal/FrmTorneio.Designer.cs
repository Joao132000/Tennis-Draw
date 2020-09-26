namespace DesafioFinal
{
    partial class FrmTorneio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarJogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarChavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarJogadoresToolStripMenuItem,
            this.gerarChavesToolStripMenuItem,
            this.adicionarResultadoToolStripMenuItem,
            this.visualizarToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 210);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarJogadoresToolStripMenuItem
            // 
            this.cadastrarJogadoresToolStripMenuItem.Name = "cadastrarJogadoresToolStripMenuItem";
            this.cadastrarJogadoresToolStripMenuItem.Size = new System.Drawing.Size(1046, 41);
            this.cadastrarJogadoresToolStripMenuItem.Text = "Cadastrar Jogadores";
            this.cadastrarJogadoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarJogadoresToolStripMenuItem_Click);
            // 
            // gerarChavesToolStripMenuItem
            // 
            this.gerarChavesToolStripMenuItem.Name = "gerarChavesToolStripMenuItem";
            this.gerarChavesToolStripMenuItem.Size = new System.Drawing.Size(1046, 41);
            this.gerarChavesToolStripMenuItem.Text = "Gerar chave";
            this.gerarChavesToolStripMenuItem.Click += new System.EventHandler(this.gerarChavesToolStripMenuItem_Click);
            // 
            // adicionarResultadoToolStripMenuItem
            // 
            this.adicionarResultadoToolStripMenuItem.Name = "adicionarResultadoToolStripMenuItem";
            this.adicionarResultadoToolStripMenuItem.Size = new System.Drawing.Size(1046, 41);
            this.adicionarResultadoToolStripMenuItem.Text = "Adicionar resultado";
            this.adicionarResultadoToolStripMenuItem.Click += new System.EventHandler(this.adicionarResultadoToolStripMenuItem_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(1046, 41);
            this.visualizarToolStripMenuItem.Text = "Visualizar chave";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesafioFinal.Properties.Resources.Tenis_2;
            this.pictureBox1.Location = new System.Drawing.Point(410, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTorneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmTorneio";
            this.Text = "Torneio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarJogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarChavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

