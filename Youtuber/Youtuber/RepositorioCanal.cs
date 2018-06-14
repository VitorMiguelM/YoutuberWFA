using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Youtuber
{
    [Serializable]
    class RepositorioCanal
    {
        List<Canal> canais = new List<Canal>();

        public RepositorioCanal()
        {
            if (File.Exists(Cadastro_Youtuber.Arquivo_Canal))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(Cadastro_Youtuber.Arquivo_Canal);
                canais = ((RepositorioCanal)binaryReader.Deserialize(stream)).ObterCanal();
            }
        }

        public  void AdicionarCanal(Canal canal)
        {
           canais.Add(canal);
            
            CriarArquivo();
        }

        public void CriarArquivo()
        {
            BinaryFormatter binaryWritter = new BinaryFormatter();
            Stream stream = new FileStream(Cadastro_Youtuber.Arquivo_Canal, FileMode.Create, FileAccess.Write);
            binaryWritter.Serialize(stream, this);
            stream.Close();
        }

        public List<Canal> ObterCanal()
        {
            return canais;
        }

        
        internal void EditarCanal(Canal canal, int posicao)
        {
            canais[posicao] = canal;
            CriarArquivo();
        }

        internal void ApagarCanal(string nomeDoCanal)
        {
            foreach (Canal canal in canais)
            {
                if (canal.GetNomeDoCanal() == nomeDoCanal)
                {
                    canais.Remove(canal);
                    CriarArquivo();
                    return;
                }
            }
        }
        



        



    
    }
}
