/*This form displays the information from the submitted quote*/
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
    public partial class DisplayQuote : Form
    {
       
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show();
            this.Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            
        } 

        /*This function allows the quote object to be displayed*/
        public void getQuote(DeskQuote quote)
        {
            fnOut.Text = quote.firstName;
            lnOut.Text = quote.lastName;
            basePrice.Text = "$" + 200.ToString();
            dateOut.Text = quote.currentDate.ToString();

            widthOut.Text = "Width: " + quote.desk.Width.ToString() + " in";
            depthOut.Text = "Depth: " + quote.desk.Depth.ToString() + " in";
            saOut.Text = (quote.desk.Width * quote.desk.Depth).ToString() + " sq in";
            saPrice.Text = "$" + quote.getArea().ToString();

            drawerOut.Text = (quote.desk.Drawers).ToString();
            drawerPrice.Text = "$" + (quote.desk.Drawers * 50).ToString();

            materialOut.Text = quote.desk.Surface.ToString();
            materialPrice.Text = "$" + quote.getSurfacePrice(quote.desk).ToString();

            rushOut.Text = (quote.deliveryTime).ToString();
            if (quote.getDeliveryPrice(quote.desk.Width, quote.desk.Depth, quote.deliveryTime) < 0)
            {
                rushPrice.Text = "Error";
                totalPrice.Text = "Error";
            }
            else
            {
                rushPrice.Text = "$" + quote.getDeliveryPrice(quote.desk.Width, quote.desk.Depth, quote.deliveryTime).ToString();

                totalPrice.Text = "$" + quote.getTotal(quote.desk).ToString();
            }  
            

            
        }

        /*Takes user to main menu*/
        private void exitButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormState.MainPage.Show();
        }


    }
}
