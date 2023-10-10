using System;
using System.Linq;
using System.Windows.Forms;
using SvetlanaS.DBContext;

namespace SvetlanaS
{
    public partial class MainForm : Form
    {
        private Model1 model = new Model1();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = model.Users.ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new FormAddUser().ShowDialog();
            dataGridView.DataSource = model.Users.ToList();
        }
    }
}
