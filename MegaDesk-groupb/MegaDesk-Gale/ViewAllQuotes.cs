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
    public partial class ViewAllQuotes : Form
    {
        //create an empty list for deskquotes
        public List<DeskQuote> AllQuotes;
        public ViewAllQuotes()
        {
            InitializeComponent();

            // start with all of the existing quotes (from quotes.json file)
            AllQuotes = Json.GetQuotes();

            //update the grid by calling custom-made updateGridView
            updateGridView(AllQuotes);
        }

        // Update the visual component with the new quotes
        private void updateGridView(List<DeskQuote> quotes)
        {

            //create a datatable 
            DataTable data = new DataTable();

            //customize column names
            data.Columns.Add("Customer Name");
            data.Columns.Add("Order Date");
            data.Columns.Add("Desk Width");
            data.Columns.Add("Desk Depth");
            data.Columns.Add("Total Price");

            //add data below columns
            foreach (DeskQuote quote in quotes)
            {
                data.Rows.Add(quote.firstName + " " + quote.lastName, quote.currentDate, quote.desk.Width, quote.desk.Depth, quote.getTotal(quote.desk));
            }

            allQuotesGridView.DataSource = data;
        }

        private void viewQuoteExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormState.MainPage.Show();

        }


    }
}
