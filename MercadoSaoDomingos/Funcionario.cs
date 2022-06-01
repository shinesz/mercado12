using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MercadoSaoDomingos
{
    class Funcionario
    {
        public MySqlConnection conexao;


        //Modificar a estrutura de data

        //

        public string dados;
        public string comando;
        public string resultado;
        public int i;
        public double a;
        public string msg;
        public int contador;
        public int cod;

        //---------------------- vetores funcionario -------------------------

        public int[] codigoFuncionario;//Vetor de código
        public string[] nomeCompleto;//Vetor de nome
        public string[] telefone;//Vetor de telefone
        public string[] endereco;//Vetor de endereço
        public string[] cpf; // vetor cpf 
        public string[] sexo; // vetor sexo 
        public double[] horaTrabalhada; // vetor valor
        public string [] cargo; // quantidade 

        //----------------------------------------------------------------



        //



        public Funcionario()
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
        public void Inserir(string nomeCompleto, string telefone, string endereco, string cpf, string sexo, string cargo,double horaTrabalhada)
        {
            try
            {

                //Preparo o código para inserção no banco
                dados = "('','" + nomeCompleto + "','" + telefone + "','" + endereco + "','" + cpf + "','" + sexo + "','" + cargo + "','" + horaTrabalhada + "')";
                comando = "Insert into Funcionario(codigoFuncionario, nomeCompleto, telefone, endereco, cpf, sexo, cargo, horaTrabalhada) values" + dados;


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
            string query = "select * from Funcionario";//Coletar os dados do BD

            //Instanciar
            codigoFuncionario = new int[100];
            nomeCompleto = new string[100];
            telefone = new string[100];
            endereco = new string[100];
            cpf = new string[100];
            sexo = new string[100];
            cargo = new string[100];
            horaTrabalhada = new double[100];



            //Preencher com valores iniciais
            for (i = 0; i < 100; i++)
            {
                codigoFuncionario[i] = 0;
                nomeCompleto[i] = "";
                telefone[i] = "";
                endereco[i] = "";
                cpf[i] = "";
                sexo[i] = "";
                cargo[i] = "";
                horaTrabalhada[i] = 0;







            }//fim do for

            //Criando o comando para consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigoFuncionario[i] = Convert.ToInt32(leitura["codigoFuncionario"]);
                nomeCompleto[i] = leitura["nomeCompleto"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                cpf[i] = leitura["cpf"] + "";
                sexo[i] = leitura["sexo"] + "";
                cargo[i] = leitura["cargo"] + "";
                horaTrabalhada[i] = Convert.ToInt32(leitura["horaTrabalhada"]);
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
                msg += "Código: " + codigoFuncionario[i] +
                       ", Nome: " + nomeCompleto[i] +
                       ", Telefone: " + telefone[i] +
                       ", Endereço: " + endereco[i] +
                       ", CPF : " + cpf[i] +
                       ", Sexo: " + sexo[i] +
                       ", Cargo: " + cargo[i] +
                       ", Salário : " + horaTrabalhada[i] +
                       "\n\n";
            }//fim do for

            return msg;
        }//fim do método consultarTudo

        public string ConsultarTudo(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (codigoFuncionario[i] == cod)
                {
                    msg = "Código: " + codigoFuncionario[i] +
                       ", Nome: " + nomeCompleto[i] +
                       ", Telefone: " + telefone[i] +
                       ", Endereço: " + endereco[i] +
                       ", CPF: " + cpf[i] +
                       ", Sexo: " + sexo[i] +
                       ", Cargo: " + cargo[i] +
                       ", Hora trabalhada : " + horaTrabalhada[i] +
                       "\n\n";
                    return msg;
                }
            }//fim do for
            return "Código informado não encontrado!";
        }//fim do consultar

        public string Atualizar(int codigoFuncionario, string campo, string novoDado)
        {
            try
            {
                string query = "update Funcionario set " + campo + " = '" + novoDado + "' where codigoFuncionario = '" + codigoFuncionario + "'";
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

        public string Deletar(int codigoFuncionario)
        {
            try
            {
                string query = "delete from Funcionario where codigoFuncionario = '" + codigoFuncionario + "'";
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

        public string CalcularSalario(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            { 
                if (codigoFuncionario[i] == cod)
                {
                    a = horaTrabalhada[i] * 60;
                    msg = "RS" + a;
                    return msg;
                }
            }
            return "Este código é invalido";
                 

        }//fim do deletar
      
        


    }
}
