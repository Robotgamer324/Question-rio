using BLL;
using Models;

namespace UIWindowsForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void bindingSourcePergunta_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            using (FormQuestionario frm = new FormQuestionario())
            {
                frm.ShowDialog();
            }
        }
    }
}
