using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace MegaDesk_Gale
{
    public partial class SearchQuotes : Form
    {

        //create an empty list for deskquotes
        public List<DeskQuote> AllQuotes;
        
        public SearchQuotes()
        {
            // start with all of the existing quotes (from quotes.json file)
            AllQuotes = Json.GetQuotes();

            //turn on window/bring up - required, on all pages
            InitializeComponent();

            //populate dropdown menu
            materialSelect.DataSource = Enum.GetValues(typeof(Material));
            materialSelect.Text = "Select a material";
        }

        //once material is selected, run the following method:
        private void materialSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //materialSelect;
            //create empty material object 
            Material material;

            //fill newly created material object with what was just selected with string value not numeric value
            Enum.TryParse<Material>(materialSelect.SelectedValue.ToString(), out material);

            //fill a list by caling custom-made function filterQuotes
            List<DeskQuote> results = filterQuotes(AllQuotes, material);

            //update the grid by calling custom-made updateGridView
            updateGridView(results);

        }

        private List<DeskQuote> filterQuotes(List<DeskQuote> origQuotes, Material material)
        {
            List<DeskQuote> results = new List<DeskQuote>();

            foreach(var quote in origQuotes){

                //take results of material argument and add those to the list to be returned
                if (quote.desk.Surface == material)
                {
                    results.Add(quote);
                }
            }
            
           return results;
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
            foreach(DeskQuote quote in quotes)
            {
                data.Rows.Add(quote.firstName + " " + quote.lastName, quote.currentDate, quote.desk.Width, quote.desk.Depth, quote.getTotal(quote.desk));
            }

            searchGridView.DataSource = data;
        }

        private void viewQuoteExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormState.MainPage.Show();
        }
    }
}
