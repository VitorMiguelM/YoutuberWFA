using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Canal
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
            if ((nomePessoa.Trim() == null) || (nomePessoa.Trim().Count() < 3))
            {
                throw new Exception ("O campo \"Nome\" Deve ser preenchido corretamente !!");
            }
            this.NomePessoa = nomePessoa;
        }

        public void SetSobrenome(string sobrenome)
        {
            if ((sobrenome.Trim() == null) || (sobrenome.Trim().Count() < 3))
            {
               throw new Exception ("O campo \"Sobrenome\" deve ser preenchido corretamente !!");
            }
            this.Sobrenome = sobrenome;
        }

        public void SetApelido(string apelido)
        {
            if (apelido.Trim() == null)
            {
                throw new Exception ("O campo \"Apelido\" deve ser preenchido !!");
            }
            this.Apelido = apelido;
        }

        public void SetNomeDoCanal(string nomeDoCanal)
        {
            if (nomeDoCanal.Trim() == null)
            {
                throw new Exception ("O campo \"Nome do canal\" deve ser preenchido !!");
            }
            this.NomeDoCanal = nomeDoCanal;
        }

        public void SetQuantidadeInscritos(int quantidadeInscritos)
        {
            if (quantidadeInscritos < 0)
            {
                 throw new Exception ("O campo \"Quantidade de inscritos\" deve ser preenchido corretamente !!");
            }
            this.QuantidadeInscritos = quantidadeInscritos;
        }

        public void SetPlataforma(string plataforma)
        {
            if (plataforma == null)
            {
                throw new Exception("O campo \"Plataforma\" deve ser preenchido !!");
            }
            this.Plataforma = plataforma;
        }

        public void SetCategoriaDosJogos(string categoriaDosJogos)
        {
            if (categoriaDosJogos == null)
            {
                throw new Exception("O campo \"Categoria dos jogos\" deve ser preenchido !!");
            }
            this.CategoriaDosJogos = categoriaDosJogos;
        }

        public void SetQuantidadeVisualizacoes(long quantidadeVisualizacoes)
        {
            if ((quantidadeVisualizacoes < 0) || (quantidadeVisualizacoes > 8000000000))
            {
                throw new Exception("O campo \"Quantidade de visualizações\" deve ser preenchido corretamente !!\n Talvez o número informado seja inválido");
            }
            this.QuantidadeVisualizacoes = quantidadeVisualizacoes;
        }

        public void SetQuantidadeLikes(int quantidadeLikes)
        {
            if ((quantidadeLikes < 0) || (quantidadeLikes > 8000000000))
            {
                throw new Exception("O campo \"Quantidade de likes\" deve ser preenchido corretamente !!\n Talvez o número informado seja inválido");
            }
            this.QuantidadeLikes = quantidadeLikes;
        }

        public void SetRendaPorVideo(double rendaPorVideo)
        {
            if ((rendaPorVideo < 0) || (rendaPorVideo > 1000000000))
            {
                throw new Exception("O campo \"Renda por vídeo\" deve ser preenchido corretamente !!\n Talvez o número informado seja inválido");
            }
            this.RendaPorVideo = rendaPorVideo;
        }

        public void SetNacionalidade(string nacionalidade)
        {
            if (nacionalidade == null)
            {
                throw new Exception("O campo \"Nacionalidade\" deve ser preenchido corretamente !!");
            }
            this.Nacionalidade = nacionalidade;
        }

        public void SetQuantidadeVideosUpados(int quantidadeVideosUpados)
        {
            if ((quantidadeVideosUpados < 0) || (quantidadeVideosUpados > 200000000))
            {
                throw new Exception("O campo \"Quantidade de vídeos upados\" deve ser preenchido corretamente !!\n Talvez o número informado seja inválido");
            }
            this.QuantidadeVideosUpados = quantidadeVideosUpados;
        }

        public void SetDescricaoDoCanal(string descricaoDoCanal)
        {
            if (descricaoDoCanal == null)
            {
                throw new Exception("O campo \"Descrição do canal\" deve ser preenchido !!");
            }
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
        public string GetDescricaoDoCanal() { return DescricaoDoCanal; }

    }
}
