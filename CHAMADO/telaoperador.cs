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
            dgvChamados.Location = new Point(30, 60); // posição no formulário
            dgvChamados.Size = new Size(650, 300);    // largura e altura
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
                    string query = "SELECT id, matricula, descricao, status, operador, data_abertura FROM pim ORDER BY id ASC";
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






        private void botnovo_Click(object sender, EventArgs e)
        {
            novochamado novaTela = new novochamado();
            novaTela.ShowDialog();
            this.Show();
        }



    }
}

