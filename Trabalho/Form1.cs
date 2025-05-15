using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

    }
}
