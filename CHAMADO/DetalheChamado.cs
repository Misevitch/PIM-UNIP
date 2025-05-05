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
    public partial class DetalheChamado : Form
    {
        private string connString = "Host=localhost;Username=postgres;Password=030125;Database=pim";
        private int chamadoId;

        public DetalheChamado(int id)
        {
            InitializeComponent();
            chamadoId = id;

        }

        private void DetalheChamado_Load(object sender, EventArgs e)
        {
            ConfigurarComboStatus();
            ConfigurarComboOperador();
            CarregarChamado();
        }

        private void ConfigurarComboStatus()
        {
            comboStatus.Items.Clear();
            comboStatus.Items.Add("Aberto");
            comboStatus.Items.Add("Em andamento");
            comboStatus.Items.Add("Resolvido");
            comboStatus.Items.Add("Fechado");
        }
        private void ConfigurarComboOperador()
        {
            comboOperador.Items.Clear();
            comboOperador.Items.Add("Eduarda");
            comboOperador.Items.Add("Manoela");
            comboOperador.Items.Add("Jordan");
            comboOperador.Items.Add("Henrique");
            comboOperador.Items.Add("Ana");
            comboOperador.Items.Add("Lucas");
            comboOperador.Items.Add("Miguel");
        }

        private void CarregarChamado()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT matricula, descricao, status, operador, data_abertura FROM pim WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", chamadoId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMatricula.Text = reader.GetString(0);
                            txtDescricao.Text = reader.GetString(1);
                            comboStatus.SelectedItem = reader.GetString(2);
                            comboOperador.SelectedItem = reader.IsDBNull(3) ? null : reader.GetString(3);
                            txtData.Text = reader.GetDateTime(4).ToString("dd/MM/yyyy HH:mm");
                        }
                        else
                        {
                            MessageBox.Show("Chamado não encontrado!");
                            this.Close();
                        }
                    }
                }
            }
        }

    }
}
