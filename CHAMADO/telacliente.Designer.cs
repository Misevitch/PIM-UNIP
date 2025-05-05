namespace CHAMADO
{
    partial class telacliente
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
            this.buttonatualizar = new System.Windows.Forms.Button();
            this.botnovo = new System.Windows.Forms.Button();
            this.buttonOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minhas solicitações";
            // 
            // buttonatualizar
            // 
            this.buttonatualizar.Location = new System.Drawing.Point(560, 19);
            this.buttonatualizar.Name = "buttonatualizar";
            this.buttonatualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonatualizar.TabIndex = 2;
            this.buttonatualizar.Text = "Atualizar";
            this.buttonatualizar.UseVisualStyleBackColor = true;
            this.buttonatualizar.Click += new System.EventHandler(this.buttonatualizar_Click);
            // 
            // botnovo
            // 
            this.botnovo.Location = new System.Drawing.Point(669, 19);
            this.botnovo.Name = "botnovo";
            this.botnovo.Size = new System.Drawing.Size(75, 23);
            this.botnovo.TabIndex = 2;
            this.botnovo.Text = "+ Novo Chamado";
            this.botnovo.UseVisualStyleBackColor = true;
            this.botnovo.Click += new System.EventHandler(this.botnovo_Click);
            // 
            // buttonOP
            // 
            this.buttonOP.Location = new System.Drawing.Point(701, 415);
            this.buttonOP.Name = "buttonOP";
            this.buttonOP.Size = new System.Drawing.Size(75, 23);
            this.buttonOP.TabIndex = 2;
            this.buttonOP.Text = "Operador";
            this.buttonOP.UseVisualStyleBackColor = true;
            this.buttonOP.Click += new System.EventHandler(this.buttonOP_Click);
            // 
            // telacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOP);
            this.Controls.Add(this.botnovo);
            this.Controls.Add(this.buttonatualizar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "telacliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.telacliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonatualizar;
        private System.Windows.Forms.Button botnovo;
        private System.Windows.Forms.Button buttonOP;
    }
}