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
            this.txt1 = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.labeldescricao = new System.Windows.Forms.Label();
            this.textBoxdescricao = new System.Windows.Forms.TextBox();
            this.buttoncriarchamado = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelemail.Location = new System.Drawing.Point(26, 93);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(61, 16);
            this.labelemail.TabIndex = 0;
            this.labelemail.Text = "Matricula";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(164, 92);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(278, 20);
            this.textBoxemail.TabIndex = 1;
            // 
            // labeldescricao
            // 
            this.labeldescricao.AutoSize = true;
            this.labeldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldescricao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeldescricao.Location = new System.Drawing.Point(26, 169);
            this.labeldescricao.Name = "labeldescricao";
            this.labeldescricao.Size = new System.Drawing.Size(132, 18);
            this.labeldescricao.TabIndex = 0;
            this.labeldescricao.Text = "Descriçao do erro:";
            // 
            // textBoxdescricao
            // 
            this.textBoxdescricao.Location = new System.Drawing.Point(164, 167);
            this.textBoxdescricao.Multiline = true;
            this.textBoxdescricao.Name = "textBoxdescricao";
            this.textBoxdescricao.Size = new System.Drawing.Size(278, 141);
            this.textBoxdescricao.TabIndex = 1;
            // 
            // buttoncriarchamado
            // 
            this.buttoncriarchamado.Location = new System.Drawing.Point(491, 353);
            this.buttoncriarchamado.Name = "buttoncriarchamado";
            this.buttoncriarchamado.Size = new System.Drawing.Size(107, 29);
            this.buttoncriarchamado.TabIndex = 3;
            this.buttoncriarchamado.Text = "Criar chamado";
            this.buttoncriarchamado.UseVisualStyleBackColor = true;
            this.buttoncriarchamado.Click += new System.EventHandler(this.buttoncriarchamado_Click_1);
            // 
            // novochamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoncriarchamado);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.textBoxdescricao);
            this.Controls.Add(this.labeldescricao);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.labelemail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "novochamado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label labeldescricao;
        private System.Windows.Forms.TextBox textBoxdescricao;
        private System.Windows.Forms.Button buttoncriarchamado;
    }
}