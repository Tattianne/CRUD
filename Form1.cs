using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        string connString = "datasource=localhost;username=root;" +
                    "password=; database = agenda";

        public Form1()
        {
            InitializeComponent();
            //inicializando os componentes do meu listview, de acordo com a tabela no 
            //SQL
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Nome", 150);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Telefone", 100);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar a conexão com o MySQL
                Conexao = new MySqlConnection(connString);
                //Cria a conexão para inserir os dados
                string sql = "INSERT INTO contatos (nome,email,telefone) " +
                    "VALUES ('" + txtNome.Text + "','" + txtEmail.Text + "'," +
                    "'" + txtTelefone.Text + "')";
                //Cria o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                //Abre a conexão
                Conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato salvo com sucesso!!!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao salvar o contato!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fechando a conexão
                Conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(connString);
                //abre a conexão do banco de dados
                Conexao.Open();

                //Cria a string SQL para consultar os dados

                string query = "%" + textBox1.Text + "%";
                //cria a string SQL para inserir dados
                string sql = "SELECT * FROM contatos WHERE nome LIKE @busca OR email LIKE @busca";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.Parameters.AddWithValue("@busca", query);

                MySqlDataReader reader = comando.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                reader[0].ToString(),
                reader[1].ToString(),
                reader[2].ToString(),
                reader[3].ToString(),
            };

                    var linha_listview = new ListViewItem(row);
                    listView1.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar registro no banco: " + ex.Message);
            }
            finally
            {
                if (Conexao != null)
                {
                    Conexao.Close();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria a conexão com o MySQL
                Conexao = new MySqlConnection(connString);

                // Cria a consulta SQL para atualizar o contato
                string sql = "UPDATE contatos SET nome = @nome, email = @email, telefone = @telefone WHERE id = @id";

                // Cria o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                // Adiciona os parâmetros com os valores dos campos de texto
                comando.Parameters.AddWithValue("@nome", txtNome.Text);  // nome do campo
                comando.Parameters.AddWithValue("@email", txtEmail.Text);  // email do campo
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);  // telefone do campo
                comando.Parameters.AddWithValue("@id", txtID.Text);  // id do campo (ou o valor que identifica o contato)

                // Abre a conexão
                Conexao.Open();

                // Executa o comando
                comando.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Contato atualizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro
                MessageBox.Show("Erro ao atualizar o contato! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha a conexão
                Conexao.Close();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o campo ID está vazio
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Por favor, insira o ID do contato que deseja excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cria a conexão com o MySQL
                Conexao = new MySqlConnection(connString);

                // Cria a consulta SQL para deletar o contato
                string sql = "DELETE FROM contatos WHERE id = @id";

                // Cria o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                // Adiciona o parâmetro com o ID do contato
                comando.Parameters.AddWithValue("@id", txtID.Text);

                // Abre a conexão
                Conexao.Open();

                // Executa o comando
                comando.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Contato deletado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro
                MessageBox.Show("Erro ao excluir o contato! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fecha a conexão
                Conexao.Close();
            }
        }
    }
}

