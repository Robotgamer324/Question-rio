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
    public partial class FormIntroducao : Form
    {
        public int id_categoria;
        public FormIntroducao(int _idCategoriaMaisFrequente)
        {
            id_categoria = _idCategoriaMaisFrequente;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormIntroducao_Load(object sender, EventArgs e)
        {
            label1.Text = id_categoria.ToString();
        }
    }
}
