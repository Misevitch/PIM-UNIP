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
    public partial class telacliente : Form
    {
        private DataGridView dgvChamados;
        private string connString = "Host=localhost;Username=postgres;Password=030125;Database=chamados";

        public telacliente()
        {
            InitializeComponent();
            dgvChamados = new DataGridView();
            dgvChamados.Location = new Point(30, 60); // posição no formulário
            dgvChamados.Size = new Size(650, 350);    // largura e altura
            this.Controls.Add(dgvChamados);
        }


        private void CarregarChamados()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT id, descricao, data_criacao FROM chamados ORDER BY data_criacao DESC";
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

        private void telacliente_Load(object sender, EventArgs e)
        {
            CarregarChamados();
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
