namespace CHAMADO
{
    partial class novochamado
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
            this.labelnumchamado = new System.Windows.Forms.Label();
            this.textBoxnumchamado = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.labeldescricao = new System.Windows.Forms.Label();
            this.textBoxdescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelnumchamado
            // 
            this.labelnumchamado.AutoSize = true;
            this.labelnumchamado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelnumchamado.Location = new System.Drawing.Point(26, 77);
            this.labelnumchamado.Name = "labelnumchamado";
            this.labelnumchamado.Size = new System.Drawing.Size(109, 13);
            this.labelnumchamado.TabIndex = 0;
            this.labelnumchamado.Text = "Numero do chamado:";
            // 
            // textBoxnumchamado
            // 
            this.textBoxnumchamado.Location = new System.Drawing.Point(138, 74);
            this.textBoxnumchamado.Name = "textBoxnumchamado";
            this.textBoxnumchamado.Size = new System.Drawing.Size(190, 20);
            this.textBoxnumchamado.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt1.Location = new System.Drawing.Point(23, 27);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(160, 25);
            this.txt1.TabIndex = 2;
            this.txt1.Text = "Novo Chamado";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelemail.Location = new System.Drawing.Point(26, 123);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(79, 13);
            this.labelemail.TabIndex = 0;
            this.labelemail.Text = "E-mail utilizado:";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(138, 123);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(190, 20);
            this.textBoxemail.TabIndex = 1;
            // 
            // labeldescricao
            // 
            this.labeldescricao.AutoSize = true;
            this.labeldescricao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeldescricao.Location = new System.Drawing.Point(26, 169);
            this.labeldescricao.Name = "labeldescricao";
            this.labeldescricao.Size = new System.Drawing.Size(94, 13);
            this.labeldescricao.TabIndex = 0;
            this.labeldescricao.Text = "Descriçao do erro:";
            // 
            // textBoxdescricao
            // 
            this.textBoxdescricao.Location = new System.Drawing.Point(138, 169);
            this.textBoxdescricao.Multiline = true;
            this.textBoxdescricao.Name = "textBoxdescricao";
            this.textBoxdescricao.Size = new System.Drawing.Size(190, 20);
            this.textBoxdescricao.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.textBoxdescricao);
            this.Controls.Add(this.labeldescricao);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.textBoxnumchamado);
            this.Controls.Add(this.labelnumchamado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Novo Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnumchamado;
        private System.Windows.Forms.TextBox textBoxnumchamado;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label labeldescricao;
        private System.Windows.Forms.TextBox textBoxdescricao;
    }
}