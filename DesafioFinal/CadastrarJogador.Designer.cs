namespace DesafioFinal
{
    partial class CadastrarJogador
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNomeJogador = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumJog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Jogador";
            // 
            // cmdNomeJogador
            // 
            this.cmdNomeJogador.Location = new System.Drawing.Point(327, 176);
            this.cmdNomeJogador.Name = "cmdNomeJogador";
            this.cmdNomeJogador.Size = new System.Drawing.Size(134, 23);
            this.cmdNomeJogador.TabIndex = 2;
            this.cmdNomeJogador.Text = "Cadastrar";
            this.cmdNomeJogador.UseVisualStyleBackColor = true;
            this.cmdNomeJogador.Click += new System.EventHandler(this.cmdNomeJogador_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblNumJog
            // 
            this.lblNumJog.AutoSize = true;
            this.lblNumJog.Location = new System.Drawing.Point(67, 236);
            this.lblNumJog.Name = "lblNumJog";
            this.lblNumJog.Size = new System.Drawing.Size(175, 13);
            this.lblNumJog.TabIndex = 4;
            this.lblNumJog.Text = "Numero de Jogadores cadastrados:";
            // 
            // CadastrarJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumJog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdNomeJogador);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarJogador";
            this.Text = "CadastrarJogador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdNomeJogador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumJog;
    }
}