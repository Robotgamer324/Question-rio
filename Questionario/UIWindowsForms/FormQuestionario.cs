using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using Models;
using UIWindowsForms; // Adicione este namespace

namespace UIWindowsForms
{
    public partial class FormQuestionario : Form
    {
        public int IDs;
        public int i;
        public int idCategoriaMaisFrequente;
        public bool sair = true;
        private FormPrincipal _formPrincipal;

        public FormQuestionario(int _id, FormPrincipal formPrincipal)
        {
            InitializeComponent();
            IDs = _id;
            _formPrincipal = formPrincipal;

            if (IDs == 0)
            {
                IDs = 1;
            }

            CarregarPergunta();
            if(sair=false) 
            {
                _formPrincipal.sair = false; 
            };
        }

        private void CarregarPergunta()
        {
            PerguntasBLL perguntasBLL = new PerguntasBLL();
            Perguntas pergunta = perguntasBLL.BuscarPorId(IDs);

            labelPergunta.Text = pergunta.pergunta;
            idCategoriaMaisFrequente = pergunta.id_categoria;

            if (labelPergunta.Text == "")
            {
                idCategoriaMaisFrequente=  UtilityHelper.GetMostFrequentValueFromList(_formPrincipal._categoriasSelecionadas);
                IDs = -1;

                using (FormIntroducao frm = new FormIntroducao(idCategoriaMaisFrequente, this))
                {
                    frm.ShowDialog();
                    _formPrincipal.sair=false;
                }
                
            }
            
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void SalvarResposta()
        {
            if (radioButtonSim.Checked)
            {
                _formPrincipal.SaveSelectedCategoria(new PerguntasBLL().BuscarPorId(IDs).id_categoria);
            }
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            SalvarResposta();
        }

        public void buttonSair_Click(object sender, EventArgs e)
        {
            _formPrincipal.sair = sair= false;
            this.Close();
        }
    }
}
