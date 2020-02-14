/* This form creates a Desk and DeskQuote object
 * This form populates each object with user input
 * The user enters form by clicking on "Add quote" on Main Menu
 * The user exits the form by clicking "Submit" button on this form
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
    public partial class AddQuote : Form
    {
        /*Create desk and deskquote objects for user input*/
        Desk newDesk = new Desk();
        DeskQuote newQuote = new DeskQuote();

        /*Constructor*/
        public AddQuote()
        {
            InitializeComponent();
        }

        /*Convert datepicker value to a customized string and store in newQuote object*/
        private void dateBox_Leave(object sender, EventArgs e)
        {
            newQuote.currentDate = dateBox.Value.ToString("dd MMM yyyy");
        }

        /*validate firstname: ensure that a value is put in*/
        private void firstName_Validate(object sender, EventArgs e)
        {
            string rawInputFirst = fnBox.Text;
            
            if(rawInputFirst == "")
            {
                firstNameE.Text = "Please enter a first name";
            }
            else
            {
                /*add to Desk Quote object: */
                newQuote.firstName = rawInputFirst;
               
            }
        }

        /*validate lastname: ensure that a value is put in*/
        private void lastName_Validate(object sender, EventArgs e)
        {
            string rawInputLast = lnBox.Text;
            if (rawInputLast == "")
            {
                lastNameE.Text = "Please enter a last name";
            }
            else
            {
                /*add to Desk Quote object: */
                newQuote.lastName = rawInputLast;
           
            }
        }


        /*validate widthbox for correct number range and integers*/
        private void widthBox_Validate(object sender, EventArgs e)
        {
            string input = widthBox.Text;
            widthE.Text = "";
            try
            {
                int result = Int32.Parse(input);
                if (result < 24 || result > 96)
                {
                    widthE.Text = "Please enter a minimum of 24 or maximum of 96";
                    widthBox.Text = "";
                }
                /*add to Desk Object*/
                newDesk.Width = result;
                
            }
            catch (FormatException)
            {
                widthE.Text = "Please type a valid number between 24 and 96";
                widthBox.Text = "";
            }
        }

        /*validate depthbox for correct number range and integers, but using Key down event*/
        private void depthBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*put user input into a string variable*/
            string input = depthBox.Text;


            /*set the depthE.Text to empty in case an exisiting error message is present*/
            depthE.Text = "";

            /*create a for loop to validate each character against special characters and non-digits*/
            for (int ctr = 0; ctr < input.Length; ctr++)
            {
                if (Char.IsControl(input, ctr) || !Char.IsDigit(input, ctr))
                {
                    depthE.Text = "Invalid character entered.";
                    
                }
            }

            if (input.Length==0)
            {
                depthE.Text = "Please enter an integer between 12 and 48";
            }


            try
            {
                int result = Int32.Parse(input);
                if (result < 12 || result > 48)
                {
                    depthE.Text = "Please enter an integer between 12 and 48";
                
                }
                else
                {
                    newDesk.Depth = result;
                }
            }
            catch
            {
                depthE.Text = "Please enter an integer between 12 and 48";
              
            }
            
        }

        /*validate depthbox when leaving field (instead of keying down)*/
        private void depthBox_Validate(object sender, EventArgs e)
        {
            string input = depthBox.Text;
            depthE.Text = "";
            try
            {
                int result = Int32.Parse(input);
                if (result < 12 || result > 48)
                {
                    depthE.Text = "Please enter an integer between 12 and 48";
                    depthBox.Text = "";

                }
                else
                {
                    //add to Desk object
                    newDesk.Depth = result;
                }

            }
            catch (FormatException)
            {
                depthE.Text = "Please enter an integer between 12 and 48";
                depthBox.Text = "";
            }
        }



        /*validating drawerbox input using keydown*/
        private void drawerBox_KeyDown(object sender, KeyEventArgs e)
        {
            //put user input into a string variable
            string input = drawerBox.Text;


            //set the label9.Text to empty in case an exisiting error message is present
            drawerE.Text = "";

            //create a for loop to validate each character against special characters and non-digits
            for (int ctr = 0; ctr < input.Length; ctr++)
            {
                if (Char.IsControl(input, ctr) || !Char.IsDigit(input, ctr))
                {
                    drawerE.Text = "Invalid character entered.";
                }

            }

        }

        /*validate drawerbox when leaving field*/
        private void drawerBox_Validate(object sender, EventArgs e)
        {
            string input = drawerBox.Text;
            drawerE.Text = "";
            try
            {
                int result = Int32.Parse(input);
                if (result < 0 || result > 7)
                {
                    drawerE.Text = "Please enter an integer between 0 and 7";
                    drawerBox.Text = "";
                } else
                {
                    //add to Desk object
                    newDesk.Drawers = result;
                    
                }

            }
            catch (FormatException)
            {
                drawerE.Text = "Please enter an integer between 0 and 7";
                drawerBox.Text = "";
            }
        }

        /*validating materialbox input when leaving box - Event Arg*/
        private void materialBox_Validate(object sender, EventArgs e)
        {
            string rawInput = (string)materialBox.SelectedItem;
            if (rawInput != null)
            {
                string input = rawInput.ToLower();
                materialE.Text = "";

                /* (enum type)Enum.Parse(Type,String) converts any string into enumerated object*/
                newDesk.Surface = (Material)Enum.Parse(typeof(Material), input);

            }
            if (rawInput == null)
            {
                materialE.Text = "Please select a value";
            }
        }

        /*validating deliverybox input when leaving box - Event Arg*/
        private void deliveryBox_Validate(object sender, EventArgs e)
        {
            //validate for no entry:
            string rawInput = (string)rushBox.SelectedItem;
            if(rawInput == null)
            {
                newQuote.deliveryTime = 14;

            }
            else
            {
                int input = int.Parse(rawInput);
                if (input == 0)
                {
                    /* since default time is 14 for no rush delivery, store 14 to object deliveryTime:
                     * 0 is option in case user accidently chooses a number field*/
                    newQuote.deliveryTime = 14;
                }
                else
                {
                    newQuote.deliveryTime = input;
                }
                
            }

        }

        /*exit button to main menu:*/
        private void exitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }


        /*submit button: ensure all fields are not empty*/
        private void submitQuote_Click(object sender, EventArgs e)
        {

            //add newDesk object to newQuote object: 
            newQuote.desk = newDesk;

            //validate that all fields are filled in before showing quote:
            if (fnBox.TextLength==0||lnBox.TextLength==0||widthBox.TextLength==0
                ||depthBox.TextLength==0||drawerBox.TextLength==0||materialBox.SelectedItem==null)
            {
                submitE.Text = "Please fill out all required fields";

            }
            //if everything is filled in, proceed to processing:
            else
            {
                //store quote to JSON file calling private function
                
                Json.Store(newQuote);
                
                //send to confirmation page viewQuote
                DisplayQuote viewQuote = new DisplayQuote();
                viewQuote.Tag = this;

                //use function in DisplayQuote class to put objects on next page:
                viewQuote.getQuote(newQuote);
                viewQuote.Show(this);
                this.Hide();

            }

        }

        /*This button returns user to main menu*/
        private void exitAddQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show(this);
            this.Hide();
        }

        /*private function for storing to JSON file, only used in AddQuote.cs class*/

    }
}
