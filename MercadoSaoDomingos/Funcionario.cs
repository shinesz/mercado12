using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{
    class Funcionario
    {
        // declarar variaveis 
        private int codigoFuncionario;
        private string nomeCompleto;
        private string telefone;
        private string endereco;
        private string cpf;
        private string sexo;
        private double salario;
        private string cargo;

        public Funcionario()
        {
            AcessarCodigoFuncionario = 0;
            AcessarNome = "";
            AcessarTelefone = "";
            AcessarEndereco = "";
            AcessarCpf = "";
            AcessarSexo = "";
            AcessarSalario = 0;
            AcessarCargo = "";

        }// fim construtor


        //desenvolver os metodos gets e sets

        public int AcessarCodigoFuncionario
        {
            get
            {

                return codigoFuncionario;
            }
            set
            {
                this.codigoFuncionario = value;
            }
        }//fim do acessar codigo
        public string AcessarNome
        {
            get
            {

                return nomeCompleto;
            }
            set
            {
                this.nomeCompleto = value;
            }
        }//fim do acessar nome
        public string AcessarTelefone
        {
            get
            {

                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//fim do acessar telefone

        public string AcessarEndereco
        {
            get
            {

                return endereco;
            }
            set
            {
                this.endereco = value;
            }
        }//fim do acessar endereco

        public string AcessarSexo
        {
            get
            {

                return sexo;
            }
            set
            {
                this.sexo = value;
            }
        }//fim do acessar sexo

        public string AcessarCpf
        {
            get
            {

                return cpf;
            }
            set
            {
                this.cpf = value;
            }
        }//fim do acessar cpf
        

        public double AcessarSalario
        {
            get
            {

                return salario;
            }
            set
            {
                this.salario = value;
            }
        }//fim do acessar quantidade de compras

        public string AcessarCargo
        {
            get
            {

                return cargo;
            }
            set
            {
                this.cargo= value;
            }
        }//fim do acessar valor total gasto

        public void Cadastrar(int codigo, string nome, string telefone, string endereco, string cpf, string sexo, double salario, string cargo)
        {
            AcessarCodigoFuncionario = codigoFuncionario;
            AcessarNome = nome;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;
            AcessarCpf = cpf;
            AcessarSexo = sexo;
            AcessarSalario = salario;
            AcessarCargo= cargo;
        }


        public string Consultar(int codigoFuncionario)
        {
            if (AcessarCodigoFuncionario == codigoFuncionario)
            {
                return "Código: " + AcessarCodigoFuncionario +
                       "\nNome Completo: " + AcessarNome +
                       "\nTelefone: " + AcessarTelefone +
                       "\nEndereço: " + AcessarEndereco +
                       "\nCpf: " + AcessarCpf +
                       "\nSexo: " + AcessarSexo +
                       "\nCargo: " + AcessarCargo+
                       "\nSalario:" + AcessarSalario;
            }
            else
            {
                return "Código Informado Não é Valido!";
            }
        }//fim do método consultar

        public string AtualizarNome(int codigoFuncionario, string nome)
        {
            if (AcessarCodigoFuncionario == codigoFuncionario)
            {
                AcessarNome = nome;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizarNome

        public string AtualizarTelefone(int codigoFuncionario, string telefone)
        {
            if (AcessarCodigoFuncionario == codigoFuncionario)
            {
                AcessarTelefone = telefone;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do método atualizar telefone

        public string AtualizarEndereco(int codigoFuncionario, string endereco)
        {
            if (AcessarCodigoFuncionario == codigoFuncionario)
            {
                AcessarEndereco = endereco;
                return "Endereço atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método Atualizar Endereço


        public string AtualizarSexo(int codigoFuncionario, string sexo)
        {
            if (AcessarCodigoFuncionario == codigoFuncionario)
            {
                AcessarSexo = sexo;
                return "Sexo atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar sexo



        public string AtualizarSalario(int codigoFuncionario, double salario)
        {
            if (AcessarCodigoFuncionario == codigoFuncionario)
            {
                AcessarSalario= salario;
                return "Salario atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar quantidade 



        public string AtualizarCargo(int codigoFuncionario, string cargo)
        {
            if (AcessarCodigoFuncionario == codigoFuncionario)
            {
                AcessarCargo = cargo;
                return "Cargo atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar valor 


        public string Excluir(int codigoFuncionario)
        {
            if (AcessarCodigoFuncionario == codigoFuncionario)
            {
                AcessarCodigoFuncionario = 0;
                AcessarNome = "";
                AcessarTelefone = "";
                AcessarEndereco = "";
                AcessarCpf = "";
                AcessarSexo = "";
                AcessarCargo = "";
                AcessarSalario= 0;

                return "Dados excluídos com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do excluir

    }
}
