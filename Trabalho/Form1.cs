using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gabriel_BDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gabriel_BDDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.gabriel_BDDataSet.Usuarios);

        }



        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "Digite o ID ou Nome do usuário")
            {
                txtPesquisa.Text = "";
                txtPesquisa.ForeColor = Color.Black;
            }
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                txtPesquisa.Text = "Digite o ID ou Nome do usuário";
                txtPesquisa.ForeColor = Color.Gray;
            }
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                string termoPesquisa = txtPesquisa.Text.Trim();

                if (string.IsNullOrWhiteSpace(termoPesquisa))
                {
                    MessageBox.Show("Digite um nome ou ID para pesquisar.");
                    return;
                }

                // Acessa a tabela de usuários do DataSet
                var tabela = gabriel_BDDataSet.Usuarios;

                // Usa LINQ para procurar por ID (se for número) ou por Nome
                DataRow[] resultado;

                int id;
                if (int.TryParse(termoPesquisa, out id))
                {
                    resultado = tabela.Select($"ID = {id}");
                }
                else
                {
                    resultado = tabela.Select($"Nome LIKE '%{termoPesquisa}%'");
                }

                if (resultado.Length > 0)
                {
                    // Cria nova tabela temporária apenas com os resultados encontrados
                    DataTable resultadoTabela = tabela.Clone(); // mesma estrutura
                    foreach (DataRow row in resultado)
                    {
                        resultadoTabela.ImportRow(row);
                    }

                    // Exibe no DataGridView
                    dataGridView1.DataSource = resultadoTabela;

                    // Seleciona a primeira linha (destaque visual)
                    dataGridView1.ClearSelection();
                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows[0].Selected = true;
                    }

                    MessageBox.Show("Usuário encontrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum usuário encontrado.");
                    dataGridView1.DataSource = null; // Limpa resultado anterior
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message);
            }
        }
        private string connectionString = @"Data Source= 192.168.1.190,1433\SQLEXPRESS;Initial Catalog=Gabriel_BD;User ID=Gabriel_BD;Password=Gabriel/00;";







        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string idTexto = txtExcluir.Text.Trim();

            if (string.IsNullOrWhiteSpace(idTexto))
            {
                MessageBox.Show("Por favor, digite um ID válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Primeiro, verifica se o usuário existe
                    string queryBusca = "SELECT Nome FROM Usuarios WHERE ID = @ID";
                    SqlCommand cmdBusca = new SqlCommand(queryBusca, conn);
                    cmdBusca.Parameters.AddWithValue("@ID", idTexto);

                    object resultado = cmdBusca.ExecuteScalar();

                    if (resultado != null)
                    {
                        string nomeUsuario = resultado.ToString();
                        DialogResult confirmacao = MessageBox.Show($"Tem certeza que deseja excluir o usuário \"{nomeUsuario}\"?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmacao == DialogResult.Yes)
                        {
                            string queryDelete = "DELETE FROM Usuarios WHERE ID = @ID";
                            SqlCommand cmdDelete = new SqlCommand(queryDelete, conn);
                            cmdDelete.Parameters.AddWithValue("@ID", idTexto);

                            int linhasAfetadas = cmdDelete.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir o usuário. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}

