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
    public partial class telaoperador : Form
    {
        private DataGridView dgvChamados;
        private string connString = "Host=localhost;Username=postgres;Password=030125;Database=pim";

        public telaoperador()
        {
            InitializeComponent();
            dgvChamados = new DataGridView();
            dgvChamados.Location = new Point(30, 90); // posição no formulário
            dgvChamados.Size = new Size(600, 300);    // largura e altura
            this.Controls.Add(dgvChamados);
            dgvChamados.CellDoubleClick += dgvChamados_CellDoubleClick;
            dgvChamados.ReadOnly = true;
            CarregarChamados();

        }


        private void CarregarChamados()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM pim WHERE status IN ('Aberto', 'Em andamento') ORDER BY id ASC";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvChamados.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }
        private void buttonatualizar_Click(object sender, EventArgs e)
        {
            CarregarChamados();
        }

        private void dgvChamados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int chamadoId = Convert.ToInt32(dgvChamados.Rows[e.RowIndex].Cells["id"].Value);

                // Abre o novo formulário e passa o ID do chamado
                DetalheChamado detalhesForm = new DetalheChamado(chamadoId);
                detalhesForm.ShowDialog();
            }
        }

        private void ButtonPesquisarid_Click(object sender, EventArgs e)
        {
            string id = textid.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Digite algum ID.");
                return;
            }

            string connectionString = "Host=localhost;Username=postgres;Password=030125;Database=pim";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM pim WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", int.Parse(id));

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvChamados.DataSource = dt;
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



    }
}

