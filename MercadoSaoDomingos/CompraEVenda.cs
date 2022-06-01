using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MercadoSaoDomingos
{
    class CompraEVenda
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
        
        //---------------------- vetores compra e venda -------------------------

        public int[] codigoCompra;//Vetor de código
        public int[] quantidade;//Vetor de quantidade
        public string[] cpf; // veto cpf 
        public double[] valor; // vetor valor
       
        //----------------------------------------------------------------
        
        
    
        //



        public CompraEVenda()
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
        public void Inserir (double valor,string cpf)
        {
            try
            {
                
                //Preparo o código para inserção no banco
                dados = "('','" + valor + "','" + cpf + "')";
                comando = "Insert into Compra(codigoCompra, valor, cpf) values" + dados;
             
                
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
            string query = "select * from Compra";//Coletar os dados do BD

            //Instanciar
            codigoCompra = new int[100];
            cpf = new string[100]; 
            quantidade= new int[100];
            valor = new double[100];



            //Preencher com valores iniciais
            for (i = 0; i < 100; i++)
            {
                codigoCompra[i] = 0;
                cpf[i] = ""; 
                quantidade[i] = 0;
                valor[i] = 0;


            }//fim do for

            //Criando o comando para consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigoCompra[i] = Convert.ToInt32(leitura["codigoCompra"]);
                cpf[i] = leitura["cpf"] + "";
                
                valor[i] = Convert.ToInt32(leitura["valor"]);
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
                msg += "Código: " + codigoCompra[i] +
                       ", CPF : " + cpf[i] +    
                       ", Valor : " + valor[i] +
                       "\n\n";
            }//fim do for

            return msg;
        }//fim do método consultarTudo

        public string ConsultarTudo(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (codigoCompra[i] == cod)
                {
                    msg = "Código: " + codigoCompra[i] +
                       ", CPF: " + cpf[i] +
                        ", Valor : " + valor[i] +
                       "\n\n";
                    return msg;
                }
            }//fim do for
            return "Código informado não encontrado!";
        }//fim do consultar

        public string Atualizar(int codigoCompra, string campo, string novoDado)
        {  
            try
            {
                string query = "update Compra set " + campo + " = '" + novoDado + "' where codigoCompra = '" + codigoCompra + "'";
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

        public string Deletar(int codigoCompra)
        {
            try
            {
                string query = "delete from Compra where codigo = '" + codigoCompra + "'";
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

        
        public int Contar()
        {
            for (i = 0; i < ; i++)
            { }
                return i++;
        }


        public string ConsultarCpf(string cod)
        {

            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (cpf[i] == cod)
                {
                    msg = " Código: " + codigoCompra[i] +
                       "\n CPF: " + cpf[i] +
                       "\n Quantidade de compras: " + Contar() + 
                       "\n Valor : " + valor[i] +
                       "\n\n";
                    return msg;
                }
            }//fim do for
            return "Código informado não encontrado!";
        }//fim do consultar




    }// fim compra e venda 
}// fim projeto




