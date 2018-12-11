using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        //private Form _mainMenu;

        public SearchQuotes()
        {
            InitializeComponent();

            //assign private variables
            //_mainMenu = mainMenu;

            //set default state
            //comboSurfaceMaterial.SelectedIndex = 0;
            //loadGrid();

        }

     
        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void comboSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            if (combo.SelectedIndex == 0)
            {
                //loadGrid();
            }
            else
            {

            }
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
