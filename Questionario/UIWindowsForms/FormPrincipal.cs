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
            int i = 1;
            int id = 1;
            while (id > 0)
                using (FormQuestionario frm = new FormQuestionario(id, i))
                {
                    frm.ShowDialog();
                    id = frm.IDs + 1;
                    i = frm.i + 1;
                }
        }
    }
}
