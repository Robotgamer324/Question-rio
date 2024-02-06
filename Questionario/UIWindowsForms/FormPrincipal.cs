using DAL;
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
            bindingSourcePergunta.DataSource = new Pergunta
        }
    }
}
