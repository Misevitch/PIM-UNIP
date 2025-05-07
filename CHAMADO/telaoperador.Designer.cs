namespace CHAMADO
{
    partial class telaoperador
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
            this.txt1 = new System.Windows.Forms.Label();
            this.buttonatualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.ButtonPesquisarid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt1.Location = new System.Drawing.Point(21, 22);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(115, 25);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "Chamados";
            // 
            // buttonatualizar
            // 
            this.buttonatualizar.Location = new System.Drawing.Point(718, 22);
            this.buttonatualizar.Name = "buttonatualizar";
            this.buttonatualizar.Size = new System.Drawing.Size(57, 23);
            this.buttonatualizar.TabIndex = 2;
            this.buttonatualizar.Text = "Atualizar";
            this.buttonatualizar.UseVisualStyleBackColor = true;
            this.buttonatualizar.Click += new System.EventHandler(this.buttonatualizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Novo chamado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botnovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquise o chamado :";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(231, 60);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 5;
            // 
            // ButtonPesquisarid
            // 
            this.ButtonPesquisarid.Location = new System.Drawing.Point(348, 58);
            this.ButtonPesquisarid.Name = "ButtonPesquisarid";
            this.ButtonPesquisarid.Size = new System.Drawing.Size(75, 23);
            this.ButtonPesquisarid.TabIndex = 6;
            this.ButtonPesquisarid.Text = "Pesquisar";
            this.ButtonPesquisarid.UseVisualStyleBackColor = true;
            this.ButtonPesquisarid.Click += new System.EventHandler(this.ButtonPesquisarid_Click);
            // 
            // telaoperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonPesquisarid);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonatualizar);
            this.Controls.Add(this.txt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "telaoperador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tela de chamados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Button buttonatualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Button ButtonPesquisarid;
    }
}

