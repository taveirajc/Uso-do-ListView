using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Uso_do_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSql.CharacterCasing = CharacterCasing.Upper;  //força a digitação do SQL em maiúscula
            Mostra(0); // VALOR 0 É PARA MOSTRAR TODOS OS REGISTROS AO EXECUTAR O PROGRAMA
        }

        private void Mostra(int MODO)
        {
            // ESSE CAMINHO É A PASTA BIN DO PROJETO
            var caminhoBanco = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "cadastro.accdb");
            txtBd.Text = caminhoBanco;

            //define a string de conexão            
            string sDBstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + caminhoBanco;

            //cria o objeto connection
            OleDbConnection conn = new OleDbConnection(sDBstr);

            try
            {
                //limpa o listview
                lvwResultado.Columns.Clear();
                lvwResultado.Items.Clear();

                //abre a conexao
                conn.Open();

                //cria um comando oledb
                OleDbCommand cmd = conn.CreateCommand();

                if (MODO == 0)  // É A PRIMEIRA VEZ QUE ESTÁ RODANDO O PROGRAMA. MOSTRA TODOS OS REGISTROS              
                    //define o tipo do comando como texto 
                    cmd.CommandText = "SELECT * from CLIENTES";
                else
                    cmd.CommandText = txtSql.Text.ToString(); // EXECUTA O SQL DIGITADO PELO USUÁRIO

                //executa o comando e gera um datareader
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)  // SE TEM ALGUM REGISTRO
                {
                    //preenche o cabeçalho do listview com os nomes dos campos
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        ColumnHeader ch = new ColumnHeader();
                        ch.Text = dr.GetName(i);
                        lvwResultado.Columns.Add(ch);
                    }

                    //DEFINE A LARGURA DAS COLUNAS
                    lvwResultado.Columns[0].Width =  50;  // COLUNA CÓDIGO
                    lvwResultado.Columns[1].Width = 140;  // COLUNA NOME
                    lvwResultado.Columns[2].Width = 140;  // COLUNA ENDEREÇO
                    lvwResultado.Columns[3].Width = 100;  // COLUNA CIDADE
                    lvwResultado.Columns[4].Width =  60;  // COLUNA ESTADO
                    lvwResultado.Columns[5].Width =  60;  // COLUNA CEP
                    lvwResultado.Columns[6].Width =  80;  // COLUNA TELEFONE

                    //define um item listview
                    ListViewItem item;

                    //inicia leitura do datareader
                    while (dr.Read())
                    {
                        item = new ListViewItem();
                        item.Text = dr.GetValue(0).ToString();

                        //preenche o listview com itens
                        for (int i = 1; i < dr.FieldCount; i++)
                        {
                            item.SubItems.Add(dr.GetValue(i).ToString());
                        }
                        lvwResultado.Items.Add(item);
                    }
                    //fecha o datareader
                    dr.Close();
                }
                else  // SE NÃO TEM REGISTRO DE ACORDO COM O SQL DIGITADO.......
                {
                    label3.Text = "Nenhum registro encontrado nessas condições. Veja a tabela acima.";
                    System.Console.Beep();
                    Mostra(0);
                }
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show("Ocorreu um erro durante a execução da instrução SQL." +
                        "Erro : " + ex.Message, "SQL");
            }
            finally
            {
                //fecha a conexao
                conn.Close();
            }
        }
    
        private void cmdExecuta_Click(object sender, EventArgs e)
        {
            Mostra(1); // O VALOR 1 SIGNIFICA QUE O SQL EXECUTADO SERÁ O DIGITADO
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }                
 }

