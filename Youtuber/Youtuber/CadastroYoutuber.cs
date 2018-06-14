using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtuber
{
    public partial class Cadastro_Youtuber : Form
    {
        public Cadastro_Youtuber()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        int posicao = -1;
        public static string Arquivo_Canal = "canais";
       
        private void btnCadastrarInformacoes_Click(object sender, EventArgs e)
        {
            Canal canal = new Canal();
            canal.SetNomePessoa(txtNomePessoa.Text);
            canal.SetApelido(txtApelido.Text);
            canal.SetNomeDoCanal(txtNomeCanal.Text);
            canal.SetQuantidadeInscritos(Convert.ToInt32(txtQuantidadeInscritos.Text));
            canal.SetPlataforma(cbPlataforma.SelectedItem.ToString());
            canal.SetCategoriaDosJogos(cbCategoriaJogos.SelectedItem.ToString());
            canal.SetQuantidadeVisualizacoes(Convert.ToInt64(txtQuantidadeVisualizacoes.Text));
            canal.SetQuantidadeLikes(Convert.ToInt32(txtQuantidadeLikes.Text));
            canal.SetRendaPorVideo(Convert.ToDouble(txtRendaPorVideo.Text));
            canal.SetNacionalidade((cbNacionalidade.SelectedItem.ToString()));
            canal.SetQuantidadeVideosUpados(Convert.ToInt32(txtQuantidadeVideosUpados.Text));
            canal.SetDescricaoDoCanal(txtDescricaoCanal.Text);

            RepositorioCanal channel = new RepositorioCanal();
            if (posicao == -1)
            {
                channel.AdicionarCanal(canal);
                MessageBox.Show("Canal adicionado !");

            }
            else
            {
                channel.EditarCanal(canal, posicao);
                MessageBox.Show("Canal editado !");
                
            }

            LimparCampos();
           //AtualizarLista();

        }

        private void AtualizarLista()
        {
            RepositorioCanal channel = new RepositorioCanal();
            
        }

       

        public void LimparCampos()
        {
            txtNomePessoa.Text = "";
            txtSobrenome.Text = "";
            txtApelido.Text = "";
            txtNomeCanal.Text = "";
            txtQuantidadeInscritos.Text = "";
            cbPlataforma.SelectedItem = -1;
            cbCategoriaJogos.SelectedItem = -1;
            txtQuantidadeVisualizacoes.Text = "";
            txtQuantidadeLikes.Text = "";
            txtRendaPorVideo.Text = "";
            cbNacionalidade.SelectedItem = -1;
            txtQuantidadeVideosUpados.Text = "";
            txtDescricaoCanal.Text = "";
        }

        private void EditarCanal()
        {
            if (dgvListagem.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo, por favor.");
                return;
            }

            string nomeDoCanal = dgvListagem.Rows[dgvListagem.CurrentRow.Index].Cells[0].Value.ToString();

            RepositorioCanal channel = new RepositorioCanal();

            foreach (Canal canal in channel.ObterCanal())
            {
                //Esqueci do "Sobrenome", desculpe pela falta de atenção
                txtNomePessoa.Text = canal.GetNomePessoa();
                txtApelido.Text = canal.GetApelido();
                txtNomeCanal.Text = canal.GetNomeDoCanal();
                txtQuantidadeInscritos.Text = Convert.ToString(canal.GetQuantidadeInscritos());
                cbPlataforma.SelectedItem = canal.GetPlataforma();
                cbCategoriaJogos.SelectedItem = canal.GetCategoriaDosJogos();
                txtQuantidadeVisualizacoes.Text = Convert.ToString(canal.GetQuantidadeVisualizacoes());
                txtQuantidadeLikes.Text = Convert.ToString(canal.GetQuantidadeLikes());
                txtRendaPorVideo.Text = Convert.ToString(canal.GetRendaPorVideo());
                cbNacionalidade.SelectedItem = canal.GetNacionalidade();
                txtQuantidadeVideosUpados.Text = Convert.ToString(canal.GetQuantidadeVideosUpados());
                txtDescricaoCanal.Text = canal.GetDescricaoDoCanal();

            }
            LimparCampos();
            //AtualizarLista();

        }
        
        private void AtualizarLista()
        {
            RepositorioCanal chanel = new RepositorioCanal();
            dgvListagem.Rows.Clear();
            foreach (Canal canal in chanel.ObterCanal())
            {
                dgvListagem.Rows.Add(new Object[]{
                    canal.GetNomePessoa(),
                    canal.GetApelido(),
                    canal.GetNomeDoCanal(),
                    canal.GetQuantidadeInscritos(),
                    canal.GetPlataforma(),
                    canal.GetCategoriaDosJogos(),
                    canal.GetQuantidadeVisualizacoes(),
                    canal.GetQuantidadeLikes(),
                    canal.GetRendaPorVideo(),
                    canal.GetNacionalidade(),
                    canal.GetQuantidadeVideosUpados(),
                    canal.GetDescricaoDoCanal()});
            }
        }

        private void ApagarCanal()
        {
            if (dgvListagem.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo, por favor");
                return;
            }

            string nomeDoCanal = dgvListagem.Rows[dgvListagem.CurrentRow.Index].Cells[0].Value.ToString();

            dgvListagem.Rows.RemoveAt(dgvListagem.CurrentRow.Index);
            RepositorioCanal channel = new RepositorioCanal();
            channel.ApagarCanal(nomeDoCanal);
            MessageBox.Show(nomeDoCanal + "Foi apagado com sucesso meu caro !");
        }

        private void btnApagarCanal_Click(object sender, EventArgs e)
        {
            ApagarCanal();
        }

        private void btnEditarInformacoes_Click(object sender, EventArgs e)
        {
            EditarCanal();

        }

        private void dgvListagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListagem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarCanal();
        }

        private void Cadastro_Youtuber_Load(object sender, EventArgs e)
        {

        }

        

        
        
    }
}
