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
    public partial class AddQuote : Form
    {
        //private Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            //_mainMenu = mainMenu;
            
            var materials = new List<Desk.DesktopMaterial>();

            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>()
                .ToList();
        }

        private void cancelQuotesButton_Click(object sender, EventArgs e)
        {
            
            Close();
        }


        private void GetQuoteButton_Click(object sender, EventArgs e)
        {
            String strMaterial = MaterialInput.Text;
            decimal ShipmentNum = Convert.ToDecimal(ShippingInput.Text);
            string NameText = NameInput.Text;
            decimal MaterialNum;
               
            if (strMaterial.Equals("oak"))
            {
                MaterialNum = 1;

            }
            else if (strMaterial.Equals("roseWood"))
            {
                MaterialNum = 2;
            }
            else if (strMaterial.Equals("venner"))
            {
                MaterialNum = 3;
            }
            else if (strMaterial.Equals("pine"))
            {
                MaterialNum = 4;
            }
            else if (strMaterial.Equals("laminate"))
            {
                MaterialNum = 5;
            }
            else
            {
                return;
            }

          

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
