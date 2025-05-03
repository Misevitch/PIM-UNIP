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
    public partial class novochamado : Form
    {
        private string connString = "Host=localhost;Username=postgres;Password=030125;Database=chamados";

        public novochamado()
        {
            InitializeComponent();
        }

        private void buttoncriarchamado_Click_1(object sender, EventArgs e)
        {
            string descricao = textBoxdescricao.Text;

            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, insira uma descrição.");
                return;
            }

            try
            {
                // Inserir no banco de dados
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO chamados (descricao) VALUES (@descricao)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("descricao", descricao);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Chamado registrado com sucesso!");
                    textBoxdescricao.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o chamado: " + ex.Message);
            }
        }


    }
}
