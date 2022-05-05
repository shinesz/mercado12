using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{


    class Cliente
    {

        // declarar variaveis 
        private int codigoCliente;
        private string nomeCompleto;
        private string telefone;
        private string endereco;
        private string cpf;
        private string sexo;
        private string email;
        private int quantidadeDeCompras;
        private double valorTotalGasto;

        public Cliente()
        {
            AcessarCodigoCliente = 0;
            AcessarNome = "";
            AcessarTelefone = "";
            AcessarEndereco = "";
            AcessarCpf = "";
            AcessarSexo = "";
            AcessarEmail = "";
            AcessarQuantidadeDeCompras = 0 ;
            AcessarValorTotalGasto = 0;

        }// fim construtor
        

        //desenvolver os metodos gets e sets
        
        public int AcessarCodigoCliente
        {
            get{

                return codigoCliente;
            }
            set
           {
                this.codigoCliente = value;
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
        public string AcessarEmail
        {
            get
            {

                return email;
            }
            set
            {
                this.email = value;
            }
        }//fim do acessar email

        public int AcessarQuantidadeDeCompras
        {
            get
            {

                return quantidadeDeCompras;
            }
            set
            {
                this.quantidadeDeCompras = value;
            }
        }//fim do acessar quantidade de compras

        public double AcessarValorTotalGasto
        {
            get
            {

                return valorTotalGasto;
            }
            set
            {
                this.valorTotalGasto= value;
            }
        }//fim do acessar valor total gasto

        public void Cadastrar(int codigoCliente, string nome, string telefone, string endereco, string cpf, string sexo, string email, int quantidadeDeCompras, double valorTotalGasto)
        {
            AcessarCodigoCliente = codigoCliente;
            AcessarNome = nome;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;
            AcessarCpf = cpf;
            AcessarSexo = sexo;
            AcessarEmail = email;
            AcessarQuantidadeDeCompras = quantidadeDeCompras;
            AcessarValorTotalGasto = valorTotalGasto;
        }

        public string Consultar(int codigoCliente)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                return "Código: " + AcessarCodigoCliente +
                       "\nNome Completo: " + AcessarNome +
                       "\nTelefone: " + AcessarTelefone +
                       "\nEndereço: " + AcessarEndereco +
                       "\nCpf: " + AcessarCpf +
                       "\nSexo: " + AcessarSexo +
                       "\nEmail: " + AcessarEmail +
                       "\nQuantidade de compras: " + AcessarQuantidadeDeCompras +
                       "\nValor total gasto:" + AcessarValorTotalGasto;                      
            }
            else
            {
                return "Código Informado Não é Valido!";
            }
        }//fim do método consultar

        public string AtualizarNome(int codigoCliente, string nome)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                AcessarNome = nome;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizarNome

        public string AtualizarTelefone(int codigoCliente, string telefone)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                AcessarTelefone = telefone;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do método atualizar telefone

        public string AtualizarEndereco(int codigoCliente, string endereco)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                AcessarEndereco = endereco;
                return "Endereço atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método Atualizar Endereço


        public string AtualizarSexo(int codigoCliente, string sexo)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                AcessarSexo = sexo;
                return "Sexo atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar sexo



        public string AtualizarEmail(int codigoCliente, string email)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                AcessarEmail= email;
                return "Email atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar email



        public string AtualizarQuantidadeDeCompras(int codigoCliente, int quantidadeDeCompras)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                AcessarQuantidadeDeCompras = quantidadeDeCompras;
                return "Quantidade de compras atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar quantidade 



        public string AtualizarValorTotalGasto(int codigoCliente, double valorTotalGasto)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                AcessarValorTotalGasto = valorTotalGasto;
                return "Valor total gasto atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar valor 


        public string Excluir(int codigoCliente)
        {
            if (AcessarCodigoCliente == codigoCliente)
            {
                AcessarCodigoCliente = 0;
                AcessarNome = "";
                AcessarTelefone = "";
                AcessarEndereco = "";
                AcessarCpf = "";
                AcessarSexo = "";
                AcessarEmail = "";
                AcessarQuantidadeDeCompras = 0;
                AcessarValorTotalGasto = 0;

                return "Dados excluídos com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do excluir


    }// fim class cliente

}// fim projeto
