using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SearchQuote : Form
    {
        public SearchQuote()
        {
            InitializeComponent();
        }

        private void SearchQuote_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
