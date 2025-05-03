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
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt1.Location = new System.Drawing.Point(21, 22);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(201, 25);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "Minhas solicitações";
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
            // chamadosclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonatualizar);
            this.Controls.Add(this.txt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "chamadosclientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tela de chamados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Button buttonatualizar;
    }
}

