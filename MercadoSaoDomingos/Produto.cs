using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSaoDomingos
{
    class Produto
    {
        // declarar variaveis 
        private int codigoProduto;
        private string descricao;
        private int quantidade;
        private string unidadeDeMedida;
        private double valorUnitario;
        private DateTime dataDeFabricacao;
        private DateTime dataDeValidade;
        private string tipoDeProduto;

        public Produto()
        {
            AcessarCodigoProduto = 0;
            AcessarDescricao = "";
            AcessarQuantidade= 0;
            AcessarUnidadeDeMedida = "";
            AcessarValorUnitario = 0;
            AcessarDataDeFabricacao = new DateTime();
            AcessarDataDeValidade = new DateTime();
            AcessarTipoDeProduto= "";

        }// fim construtor


        //desenvolver os metodos gets e sets

        public int AcessarCodigoProduto
        {
            get
            {

                return codigoProduto;
            }
            set
            {
                this.codigoProduto = value;
            }
        }//fim do acessar codigo
        public string AcessarDescricao
        {
            get
            {

                return descricao;
            }
            set
            {
                this.descricao = value;
            }
        }//fim do acessar nome
        public int AcessarQuantidade
        {
            get
            {

                return quantidade;
            }
            set
            {
                this.quantidade = value;
            }
        }//fim do acessar telefone

        public string AcessarUnidadeDeMedida
        {
            get
            {

                return unidadeDeMedida;
            }
            set
            {
                this.unidadeDeMedida = value;
            }
        }//fim do acessar endereco

        public double AcessarValorUnitario
        {
            get
            {

                return valorUnitario;
            }
            set
            {
                this.valorUnitario= value;
            }
        }//fim do acessar sexo

        public DateTime AcessarDataDeFabricacao
        {
            get
            {

                return dataDeFabricacao;
            }
            set
            {
                this.dataDeFabricacao = value;
            }
        }//fim do acessar cpf


        public DateTime AcessarDataDeValidade
        {
            get
            {

                return dataDeValidade;
            }
            set
            {
                this.dataDeValidade = value;
            }
        }//fim do acessar quantidade de compras

        public string AcessarTipoDeProduto
        {
            get
            {

                return tipoDeProduto;
            }
            set
            {
                this.tipoDeProduto = value;
            }
        }//fim do acessar valor total gasto

        public void Cadastrar(int codigoProduto, string descricao, int quantidade, string unidadeDeMedida, double valorUnitario, DateTime dataDeFabricacao, DateTime dataDeValidade, string tipoDeProduto)
        {
            AcessarCodigoProduto = codigoProduto;
            AcessarDescricao = descricao;
            AcessarQuantidade = quantidade;
            AcessarUnidadeDeMedida = unidadeDeMedida;
            AcessarValorUnitario = valorUnitario;
            AcessarDataDeFabricacao = dataDeFabricacao;
            AcessarDataDeValidade = dataDeValidade;
            AcessarTipoDeProduto = tipoDeProduto;
            
        }

        public string Consultar(int codigoProduto)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                return "Código: " + AcessarCodigoProduto +
                       "\nDescrição : " + AcessarDescricao +
                       "\nQuantidade: " + AcessarQuantidade +
                       "\nUnidade de medida: " + AcessarUnidadeDeMedida +
                       "\nValor unitário: " + AcessarValorUnitario +
                       "\nData de Fabricação: " + AcessarDataDeFabricacao +
                       "\nData de Validade: " + AcessarDataDeValidade +
                       "\nTipo de produto:" + AcessarTipoDeProduto;
            }
            else
            {
                return "Código Informado Não é Valido!";
            }
        }//fim do método consultar

        public string AtualizarDescricao(int codigoProduto, string descricao)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarDescricao = descricao;
                return "Descrição Atualizada com Sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        
        }//Fim do método atualizarDescricao

        public string AtualizarQuantidade(int codigoProduto, int quantidade)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarQuantidade = quantidade ;
                return "Quantidade atualizada com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do método atualizar telefone

        public string AtualizarUnidadeDeMedida(int codigoProduto, string unidadeDeMedida)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarUnidadeDeMedida = unidadeDeMedida;
                return " Unidade de medida atualizada com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método Atualizar Endereço


        public string AtualizarValorUnitario(int codigoProduto, double valorUnitario)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarValorUnitario = valorUnitario;
                return "Valor Unitario atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar sexo



        public string AtualizarDataDeFabricacao(int codigoProduto, DateTime dataDeFabricacao)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarDataDeFabricacao = dataDeFabricacao;
                return "Data de fabricação atualizada com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar quantidade 



        public string AtualizarDataDeValidade(int codigoProduto, DateTime dataDeValidade)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarDataDeValidade = dataDeValidade;
                return "Data de validade atualizada com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar quantidade
        public string AtualizarTipoDeProduto(int codigoProduto, string tipoDeProduto)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarTipoDeProduto = tipoDeProduto;
                return "Tipo De Produto atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim atualizar quantidade 

        


        public string Excluir(int codigoProduto)
        {
            if (AcessarCodigoProduto == codigoProduto)
            {
                AcessarCodigoProduto = 0;
                AcessarDescricao = "";
                AcessarQuantidade = 0;
                AcessarUnidadeDeMedida = "";
                AcessarValorUnitario = 0;
                AcessarDataDeFabricacao = new DateTime();
                AcessarDataDeValidade = new DateTime();
                AcessarTipoDeProduto = "";

                return "Dados excluídos com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do excluir
    }
}
