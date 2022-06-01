using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MercadoSaoDomingos
{
    class DAO
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

        public int[] codigoCliente;//Vetor de código
        public string[] nomeCompleto;//Vetor de nome
        public string[] telefone;//Vetor de telefone
        public string[] endereco;//Vetor de endereço
        public string[] cpf; // veto cpf 
        public string [] email; // vetor email 
        public string[] sexo; // vetor sexo 
        public double[] valorTotalGasto; // vetor valor
        public int[] quantidadeDeCompras; // quantidade 

        //----------------------------------------------------------------
        
        
    
        //



        public DAO()
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
        public void Inserir(string nomeCompleto, string telefone, string endereco, string cpf, string sexo, string email, int quantidadeDeCompras,  double valorTotalGasto)
        {
            try
            {
                
                //Preparo o código para inserção no banco
                dados = "('','" + nomeCompleto + "','" + telefone + "','" + endereco + "','" + cpf + "','"+ sexo + "','" + email + "','" + quantidadeDeCompras + "','" + valorTotalGasto + "')";
                comando = "Insert into Cliente(codigoCliente, nomeCompleto, telefone, endereco, cpf, sexo, email, quantidadeDeCompras, valorTotalGasto) values" + dados;
              
                
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
            string query = "select * from Cliente";//Coletar os dados do BD

            //Instanciar
            codigoCliente = new int[100];
            nomeCompleto = new string[100];
            telefone = new string[100];
            endereco = new string[100];
            cpf = new string[100]; 
            sexo = new string[100];
            email = new string[100];
            quantidadeDeCompras= new int[100];
            valorTotalGasto = new double[100];



            //Preencher com valores iniciais
            for (i = 0; i < 100; i++)
            {
                codigoCliente[i] = 0;
                nomeCompleto[i] = "";
                telefone[i] = "";
                endereco[i] = "";
                cpf[i] = ""; 
                sexo[i] = "";
                email[i] = "";
                quantidadeDeCompras[i] = 0;
                valorTotalGasto[i] = 0;


               
                
                
           
            
            }//fim do for

            //Criando o comando para consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigoCliente[i] = Convert.ToInt32(leitura["codigoCliente"]);
                nomeCompleto[i] = leitura["nomeCompleto"] +"";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                cpf[i] = leitura["cpf"] + "";
                sexo[i] = leitura["sexo"] + "";
                email[i] = leitura["email"] + "";
                quantidadeDeCompras[i] = Convert.ToInt32(leitura["quantidadeDeCompras"]);
                valorTotalGasto[i] = Convert.ToInt32(leitura["valorTotalGasto"]);
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
                msg += "Código: " + codigoCliente[i] +
                       ", Nome: " + nomeCompleto[i] +
                       ", Telefone: " + telefone[i] +
                       ", Endereço: " + endereco[i] +
                       ", CPF : " + cpf[i] +
                       ", Sexo: " + sexo[i] +
                       ", Email: " + email[i] +
                       ", Quantidade de compras : " + quantidadeDeCompras[i] +
                       ", Valor total gasto : " + valorTotalGasto[i] +
                       "\n\n";
            }//fim do for

            return msg;
        }//fim do método consultarTudo

        public string ConsultarTudo(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (codigoCliente[i] == cod)
                {
                    msg = "Código: " + codigoCliente[i] +
                       ", Nome: " + nomeCompleto[i] +
                       ", Telefone: " + telefone[i] +
                       ", Endereço: " + endereco[i] +
                       ", CPF: " + cpf[i] +
                       ", Sexo: " + sexo[i] +
                       ", Email: " + email[i] +
                       ", Quantidade de compras: " + quantidadeDeCompras[i] +
                        ", Valor Total Gasto: " + valorTotalGasto[i] +
                       "\n\n";
                    return msg;
                }
            }//fim do for
            return "Código informado não encontrado!";
        }//fim do consultar

        public string Atualizar(int codigoCliente, string campo, string novoDado)
        {
            try
            {
                string query = "update Cliente set " + campo + " = '" + novoDado + "' where codigoCliente = '" + codigoCliente + "'";
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

        public string Deletar(int codigoCliente)
        {
            try
            {
                string query = "delete from Cliente where codigoCliente = '" + codigoCliente + "'";
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


    }
}
