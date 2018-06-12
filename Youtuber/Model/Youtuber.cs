using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Youtuber
    {
        private string NomePessoa;
        private string Sobrenome;
        private string Apelido;
        private string NomeDoCanal;
        private int QuantidadeInscritos;
        private string Plataforma;
        private string CategoriaDosJogos;
        private long QuantidadeVisualizacoes;
        private int QuantidadeLikes;
        private double RendaPorVideo;
        private string Nacionalidade;
        private int QuantidadeVideosUpados;
        private string DescricaoDoCanal;


        public void SetNomePessoa(string nomePessoa)
        {
            this.NomePessoa = nomePessoa;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }

        public void SetApelido(string apelido)
        {
            this.Apelido = apelido;
        }

        public void SetNomeDoCanal(string nomeDoCanal)
        {
            this.NomeDoCanal = nomeDoCanal;
        }

        public void SetQuantidadeInscritos(int quantidadeInscritos)
        {
            this.QuantidadeInscritos = quantidadeInscritos;
        }

        public void SetPlataforma(string plataforma)
        {
            this.Plataforma = plataforma;
        }

        public void SetCategoriaDosJogos(string categoriaDosJogos)
        {
            this.CategoriaDosJogos = categoriaDosJogos;
        }

        public void SetQuantidadeVisualizacoes(long quantidadeVisualizacoes)
        {
            this.QuantidadeVisualizacoes = quantidadeVisualizacoes;
        }

        public void SetQuantidadeLikes(int quantidadeLikes)
        {
            this.QuantidadeLikes = quantidadeLikes;
        }

        public void SetRendaPorVideo(double rendaPorVideo)
        {
            this.RendaPorVideo = rendaPorVideo;
        }

        public void SetNacionalidade(string nacionalidade)
        {
            this.Nacionalidade = nacionalidade;
        }

        public void SetQuantidadeVideosUpados(int quantidadeVideosUpados)
        {
            this.QuantidadeVideosUpados = quantidadeVideosUpados;
        }

        public void SetDescricaoDoCanal(string descricaoDoCanal)
        {
            this.DescricaoDoCanal = descricaoDoCanal;
        }

        public string GetNomePessoa() { return NomePessoa; }
        public string GetSobrenome() { return Sobrenome; }
        public string GetApelido() { return Apelido; }
        public string GetNomeDoCanal() { return NomeDoCanal; }
        public int GetQuantidadeInscritos() { return QuantidadeInscritos; }
        public string GetPlataforma() { return Plataforma; }
        public string GetCategoriaDosJogos() { return CategoriaDosJogos; }
        public long GetQuantidadeVisualizacoes() { return QuantidadeVisualizacoes; }
        public int GetQuantidadeLikes() { return QuantidadeLikes; }
        public double GetRendaPorVideo() { return RendaPorVideo; }
        public string GetNacionalidade() { return Nacionalidade; }
        public int GetQuantidadeVideosUpados() { return QuantidadeVideosUpados; }

    }
}
