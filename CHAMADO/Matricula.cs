using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CHAMADO
{
    public partial class Matricula : Form
    {
        private DataGridView dgvChamadosCliente;
        private string connString = "Host=localhost;Username=postgres;Password=030125;Database=pim";
        public Matricula()
        {
            InitializeComponent();
            dgvChamadosCliente = new DataGridView();
            dgvChamadosCliente.Location = new Point(30, 90); // posição no formulário
            dgvChamadosCliente.Size = new Size(600, 300);    // largura e altura
            this.Controls.Add(dgvChamadosCliente);
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            string matricula = textMatricula.Text.Trim();

            if (string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Digite a matrícula.");
                return;
            }

            string connectionString = "Host=localhost;Username=postgres;Password=030125;Database=pim";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM pim WHERE matricula = @matricula";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("matricula", matricula);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvChamadosCliente.DataSource = dt;
                    }
                }
            }

        }

        private void botnovo_Click(object sender, EventArgs e)
        {
            novochamado novaTela = new novochamado();
            novaTela.ShowDialog();
            this.Show();
        }

        private void buttonOP_Click(object sender, EventArgs e)
        {
            telaoperador novaTela = new telaoperador();
            novaTela.ShowDialog();
            this.Show();
        }





    }
}
