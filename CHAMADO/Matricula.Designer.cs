namespace CHAMADO
{
    partial class Matricula
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
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonePsquisar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite sua Matrícula :";
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(177, 31);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(100, 20);
            this.textMatricula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seus Chamados";
            // 
            // ButtonePsquisar
            // 
            this.ButtonePsquisar.Location = new System.Drawing.Point(335, 31);
            this.ButtonePsquisar.Name = "ButtonePsquisar";
            this.ButtonePsquisar.Size = new System.Drawing.Size(75, 23);
            this.ButtonePsquisar.TabIndex = 3;
            this.ButtonePsquisar.Text = "Pesquisar";
            this.ButtonePsquisar.UseVisualStyleBackColor = true;
            this.ButtonePsquisar.Click += new System.EventHandler(this.ButtonPesquisar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+ Novo Chamado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botnovo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonPesquisar_Click);
            // 
            // buttonOP
            // 
            this.buttonOP.Location = new System.Drawing.Point(734, 399);
            this.buttonOP.Name = "buttonOP";
            this.buttonOP.Size = new System.Drawing.Size(75, 23);
            this.buttonOP.TabIndex = 6;
            this.buttonOP.Text = "Operador";
            this.buttonOP.UseVisualStyleBackColor = true;
            this.buttonOP.Click += new System.EventHandler(this.buttonOP_Click);
            // 
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(853, 446);
            this.Controls.Add(this.buttonOP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonePsquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMatricula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Matricula";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Matricula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonePsquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOP;
    }
}