using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindowsForms
{

    public partial class FormQuestionario : Form
    {
        public int IDs;
        public FormQuestionario()
        {
            InitializeComponent();
        }

        private void checkedListBoxRespostas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxRespostas.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBoxRespostas.Items.Count; i++)
                {
                    if (i != checkedListBoxRespostas.SelectedIndex)
                    {
                        checkedListBoxRespostas.SetItemChecked(i, false);
                    }
                }
            }
            else if (checkedListBoxRespostas.SelectedIndex >= 0) // Verifique se um item está selecionado
            {
                string itemSelecionado = checkedListBoxRespostas.SelectedItem.ToString(); // Obtém o texto do item selecionado
                if (itemSelecionado == "Sim") // Verifica se o item selecionado é "Sim"
                {
                    int idPergunta = 0; // Assuma um valor inicial ou obtenha de outra forma
                    if (checkedListBoxRespostas.Items.Count > 0) // Verifique se a lista não está vazia
                    {
                        // Obtenha o ID da pergunta associado ao primeiro item da lista
                        idPergunta = IDs;// Insira aqui o código para obter o ID da pergunta

                // Salve o ID da pergunta
                // ... (Insira aqui o código para salvar o ID da pergunta)
                    }
                }
            }
        }
            // ...
    

        private void buttonProximo_Click(object sender, EventArgs e)
        {
           
            checkedListBoxRespostas.ClearSelected();
            

            FormQuestionario_Load(this, EventArgs.Empty);         
        }


        public void FormQuestionario_Load(object sender, EventArgs e)
        {
            IDs++;
            labelPergunta.Text = new PerguntasBLL().BuscarPorId(IDs).pergunta;
            if (labelPergunta.Text=="")
            {
                using (FormIntroducao frm = new FormIntroducao())
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
