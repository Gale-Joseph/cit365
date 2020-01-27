using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Gale
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void viewQuoteExitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show(this);
            this.Hide();
        }
    }
}
