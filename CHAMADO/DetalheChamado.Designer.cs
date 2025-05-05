namespace CHAMADO
{
    partial class DetalheChamado
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
            this.labelMatr = new System.Windows.Forms.Label();
            this.labelErro = new System.Windows.Forms.Label();
            this.labelOperador = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboOperador = new System.Windows.Forms.ComboBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labeldata = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMatr
            // 
            this.labelMatr.AutoSize = true;
            this.labelMatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMatr.Location = new System.Drawing.Point(21, 45);
            this.labelMatr.Name = "labelMatr";
            this.labelMatr.Size = new System.Drawing.Size(112, 25);
            this.labelMatr.TabIndex = 0;
            this.labelMatr.Text = "Matricula :";
            // 
            // labelErro
            // 
            this.labelErro.AutoSize = true;
            this.labelErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelErro.Location = new System.Drawing.Point(21, 111);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(64, 25);
            this.labelErro.TabIndex = 1;
            this.labelErro.Text = "Erro :";
            // 
            // labelOperador
            // 
            this.labelOperador.AutoSize = true;
            this.labelOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOperador.Location = new System.Drawing.Point(21, 218);
            this.labelOperador.Name = "labelOperador";
            this.labelOperador.Size = new System.Drawing.Size(114, 25);
            this.labelOperador.TabIndex = 2;
            this.labelOperador.Text = "Operador :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelStatus.Location = new System.Drawing.Point(21, 284);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(85, 25);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status :";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(141, 288);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(199, 21);
            this.comboStatus.TabIndex = 4;
            // 
            // comboOperador
            // 
            this.comboOperador.FormattingEnabled = true;
            this.comboOperador.Location = new System.Drawing.Point(141, 222);
            this.comboOperador.Name = "comboOperador";
            this.comboOperador.Size = new System.Drawing.Size(199, 21);
            this.comboOperador.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(141, 51);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(199, 20);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(141, 111);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(199, 72);
            this.txtDescricao.TabIndex = 6;
            // 
            // labeldata
            // 
            this.labeldata.AutoSize = true;
            this.labeldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeldata.Location = new System.Drawing.Point(21, 365);
            this.labeldata.Name = "labeldata";
            this.labeldata.Size = new System.Drawing.Size(69, 25);
            this.labeldata.TabIndex = 3;
            this.labeldata.Text = "Data :";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(141, 370);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(199, 20);
            this.txtData.TabIndex = 6;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(372, 432);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.Text = "Salvar";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // DetalheChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(801, 495);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.comboOperador);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.labeldata);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelOperador);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.labelMatr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DetalheChamado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalheChamado";
            this.Load += new System.EventHandler(this.DetalheChamado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMatr;
        private System.Windows.Forms.Label labelErro;
        private System.Windows.Forms.Label labelOperador;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboOperador;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label labeldata;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button buttonUp;
    }
}