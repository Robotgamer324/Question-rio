using BLL;
using Models;

namespace UIWindowsForms
{
    public partial class FormPrincipal : Form
    {
        public int id;
        //public int i;
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
            
           
            while (id >= 0)
                using (FormQuestionario frm = new FormQuestionario(id))
                {
                    frm.ShowDialog();
                    id = frm.IDs + 1;
                    
                }
        }
    }
}
