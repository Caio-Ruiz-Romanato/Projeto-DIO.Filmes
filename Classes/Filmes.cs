using System;

namespace DIO.Filmes
{
    public class Filme : EntidadeBase
    {
        //Atributos 
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Lancamento { get; set; }
        private bool Excluido { get; set; }

        //Método Construtor
        public Filme(int id, Genero genero, string titulo, string descricao, int lancamento)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Lancamento = lancamento;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Lançamento: " + this.Lancamento + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }
    }
}