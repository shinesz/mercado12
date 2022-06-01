using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MercadoSaoDomingos
{
    class Produto
    {
        public MySqlConnection conexao;


        //Modificar a estrutura de data

        //

        public string dados;
        public string comando;
        public string resultado;
        public int i;
        public string msg;
        public int contador;

        //---------------------- vetores cliente -------------------------

        public int[] codigoProduto;//Vetor de código
        public string[] descricao;//Vetor de nome
        public int[] quantidade;//Vetor de telefone
        public string[] unidadeDeMedida;//Vetor de endereço
        public double[] valorUnitario; // vetor cpf 
        public DateTime[] dataDeFabricacao; // vetor sexo 
        public DateTime[] dataDeValidade; // vetor valor
        public string[] tipoDeProduto;// quantidade 

        //----------------------------------------------------------------



        //



        public Produto()
        {
            //Script para conexão do banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=mercadoSaoDomingos;Uid=root;Password=;");
            try
            {
                conexao.Open();//Tentando conectar ao BD
                Console.WriteLine("Conectado com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado!\n\n" + e);//Mostrar o erro em tela
                conexao.Close();//Fechar a conexão com o banco de dados
            }
        }//fim do método construtor

        //Método para inserir dados no BD
        public void Inserir(string descricao, int quantidade, string unidadeDeMedida, double valorUnitario, DateTime dataDeFabricacao, DateTime dataDeValidade, string tipoDeProduto)
        {
            try
            {

                MySqlParameter parameter2 = new MySqlParameter();
                parameter2.ParameterName = "@Date";
                parameter2.MySqlDbType = MySqlDbType.Date;
                parameter2.Value = dataDeFabricacao.Year + "-" + dataDeFabricacao.Month + "-" + dataDeFabricacao.Day;


                MySqlParameter parameter1 = new MySqlParameter();
                parameter1.ParameterName = "@Date";
                parameter1.MySqlDbType = MySqlDbType.Date;
                parameter1.Value = dataDeValidade.Year + "-" + dataDeValidade.Month + "-" + dataDeValidade.Day;

                //Preparo o código para inserção no banco
                dados = "('','" + descricao + "','" + quantidade + "','" + unidadeDeMedida + "','" + valorUnitario + "','" + parameter2.Value + "','" + parameter1.Value + "','" + tipoDeProduto + "')";
                comando = "Insert into Produto(codigoProduto, descricao, quantidade, unidadeDeMedida, valorUnitario, dataDeFabricacao, dataDeValidade, tipoDeProduto) values" + dados;


                //Executar o comando de inserção no banco de dados
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();//Executa o insert no BD
                Console.WriteLine(resultado + " Linhas Afetadas");
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado!\n\n" + e);
                Console.ReadLine();//Manter o programa aberto
            }
        }//fim do método inserir

        public void PreencherVetor()
        {
            string query = "select * from Produto";//Coletar os dados do BD

            //Instanciar
            
            codigoProduto = new int[100];
            descricao = new string[100];
            quantidade = new int [100];
            unidadeDeMedida = new string[100];
            valorUnitario = new double[100];
            dataDeFabricacao= new DateTime [100];
            dataDeValidade = new DateTime[100];
            tipoDeProduto = new string[100];



            //Preencher com valores iniciais
            for (i = 0; i < 100; i++)
            {
                codigoProduto[i] = 0;
                descricao[i] = "";
                quantidade[i] = 0;
                unidadeDeMedida[i] = "";
                valorUnitario[i] = 0;
                dataDeFabricacao[i] = new DateTime();
                dataDeValidade[i] = new DateTime();
                tipoDeProduto[i] = "";



            }//fim do for

            //Criando o comando para consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigoProduto[i] = Convert.ToInt32(leitura["codigoProduto"]);
                descricao[i] = leitura["descricao"] + "";
                quantidade[i] = Convert.ToInt32(leitura["quantidade"]);
                unidadeDeMedida[i] = leitura["unidadeDeMedida"] + "";
                valorUnitario[i] = Convert.ToInt32(leitura["valorUnitario"]);
                dataDeFabricacao[i] = Convert.ToDateTime(leitura["dataDeFabricacao"]);
                dataDeValidade[i] = Convert.ToDateTime(leitura["dataDeValidade"]);
                tipoDeProduto[i] = leitura["tipoDeProduto"] + "";
                i++;
                contador++;
            }//Fim do while

            //Fechar a leitura de dados no banco
            leitura.Close();
        }//fim do método de preenchimento do vetor

        //Método que consulta TODOS OS DADOS no banco de dados
        public string ConsultarTudo()
        {
            //Preencher os vetores
            PreencherVetor();
            msg = "";
            for (i = 0; i < contador; i++)
            {
                msg += "Código: " + codigoProduto[i] +
                       ", Descricao: " + descricao[i] +
                       ", Quantidade: " + quantidade[i] +
                       ", Unidade De Medida: " + unidadeDeMedida[i] +
                       ", Valor Unitário : " + valorUnitario[i] +
                       ", Data De Fabricação: " + dataDeFabricacao[i] +
                       ", Data De Validade: " + dataDeValidade[i] +
                       ", Tipo de Produto : " + tipoDeProduto[i] +
                       "\n\n";
            }//fim do for

            return msg;
        }//fim do método consultarTudo

        public string ConsultarTudo(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (codigoProduto[i] == cod)
                {
                    msg = "Código: " + codigoProduto[i] +
                       ", Descricao: " + descricao[i] +
                       ", Quantidade: " + quantidade[i] +
                       ", Unidade De Medida: " + unidadeDeMedida[i] +
                       ", Valor Unitário : " + valorUnitario[i] +
                       ", Data De Fabricação: " + dataDeFabricacao[i] +
                       ", Data De Validade: " + dataDeValidade[i] +
                       ", Tipo de Produto : " + tipoDeProduto[i] +
                       "\n\n";
                    return msg;
                }
            }//fim do for
            return "Código informado não encontrado!";
        }//fim do consultar

        public string Atualizar(int codigoProduto, string campo, string novoDado)
        {
            try
            {
                string query = "update Produto set " + campo + " = '" + novoDado + "' where codigoProduto = '" + codigoProduto + "'";
                //Executar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + "Linha Afetada";
            }
            catch (Exception e)
            {
                return "Algo deu errado!\n\n" + e;
            }
        }//fim do método Atualizar

        public string Deletar(int codigoProduto)
        {
            try
            {
                string query = "delete from Produto where codigoProduto = '" + codigoProduto + "'";
                //Preparar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                //Mostrar a mensagem em tela
                return resultado + "Linha Afetada";
            }
            catch (Exception e)
            {
                return "Algo deu errado!\n\n" + e;
            }
        }//fim do deletar
        public string ConsultarEstoque()
        {
            //Preencher os vetores
            PreencherVetor();
            msg = "";
            for (i = 0; i < contador; i++)
            {
                msg += "Código: " + codigoProduto[i] +
                       ", Quantidade: " + quantidade[i] +
                       ", Valor Unitário : " + valorUnitario[i] +
                       "\n\n";
            }//fim do for

            return msg;
        }//fim do método consultarTudo

    }
}
