namespace DesafioFinal
{
    partial class GerarChaves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jogadores = new System.Windows.Forms.ListBox();
            this.cmdGerarChave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jogadores
            // 
            this.Jogadores.FormattingEnabled = true;
            this.Jogadores.Location = new System.Drawing.Point(76, 81);
            this.Jogadores.Name = "Jogadores";
            this.Jogadores.Size = new System.Drawing.Size(301, 277);
            this.Jogadores.TabIndex = 0;
            // 
            // cmdGerarChave
            // 
            this.cmdGerarChave.Location = new System.Drawing.Point(488, 189);
            this.cmdGerarChave.Name = "cmdGerarChave";
            this.cmdGerarChave.Size = new System.Drawing.Size(141, 96);
            this.cmdGerarChave.TabIndex = 1;
            this.cmdGerarChave.Text = "Gerar Chave";
            this.cmdGerarChave.UseVisualStyleBackColor = true;
            this.cmdGerarChave.Click += new System.EventHandler(this.cmdGerarChave_Click);
            // 
            // GerarChaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdGerarChave);
            this.Controls.Add(this.Jogadores);
            this.Name = "GerarChaves";
            this.Text = "GerarChave";
            this.Load += new System.EventHandler(this.GerarChaves_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Jogadores;
        private System.Windows.Forms.Button cmdGerarChave;
    }
}