/* This class is used to calculate the price of a desk;
 * A DeskQuote object and Desk object are created in AddQuote.cs once the user starts entering data;
 * As the user enters data, that data is added to the DeskQuote object and Desk object;
 * Most of these functions are executed when the final quote is displayed in DisplayQuote.cs(the next page)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Gale
{
   
    public class DeskQuote
    {
        /*member variables: */
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string currentDate; //set in the AddQuote form
        public int deliveryTime = 14; //standard delivery is 14

        /*constructor*/
        public Desk desk { get; set; }

        /*methods */

        /*Create GetRushOrder() method per assignment directions and 
         * return a multidimensional array with quote prices from rushOrderPrices.txt*/
        public int[,] GetRushOrder()
        {
            //create a 3x3 multidemensional array
            int[,] priceGrid = new int[3, 3];

            try
            {
                //read everything from text file and store in 1d array
                string[] lines = System.IO.File.ReadAllLines(@"..\..\rushOrderPrices.txt");

                //create a counter which will represent which integer from txt file is being stored
                int lineCount = 0;

                //cycle through rows first
                for (int r = 0; r < 3; r++)
                {
                    //each row will have 3 columns to cycle through:
                    for (int c = 0; c < 3; c++)
                    {
                        //populate priceGrid with value at current row and column
                        //populate priceGrid from txt file based on current lineCount counter
                        priceGrid[r, c] = int.Parse(lines[lineCount]);

                        //up the lineCount counter by 1
                        lineCount++;
                    }
                }

                //return the priceGrid for the purpose of extracting correct price in getDeliveryPrice
                return priceGrid;
            }
            //fill up priceGrid with -1 so that getDeliveryPrice() will return -1
            //if getDeliveryPrice()==-1 on DisplayQuote, then an error on DisplayQuote will show
            catch (Exception ex)
            {
               
                for (int r = 0; r < 3; r++)
                {
                    //each row will have 3 columns to cycle through:
                    for (int c = 0; c < 3; c++)
                    {

                        priceGrid[r, c] = -1;

                    }
                }  
                return priceGrid;
            }
        }

        /* getDeliveryPrice is not particularly written well and gets cumbersome to fill out, but
         * as of 1/30/20 it makes the program function correctly*/
        public int getDeliveryPrice(int width, int depth, int deliveryTime)
        {
            //calculate the surface area from paramenters
            int sa = width * depth;

            //create an empty total for population
            int total;

            //determine column for 2d array; prices based on assignment specs
            int col;
            if (sa < 1000)
            {
                col = 0;
            }
            else if(sa >=1000 && sa <= 2000)
            {
                col = 1;
            }
            else
            {
                col = 2;
            }

            //determine price based on delivery day from function paramter
            switch (deliveryTime)
            {
                case 3:
                    total = GetRushOrder()[0, col];

                    break;
                case 5:
                    total = GetRushOrder()[1, col];
                    break;
                case 7:
                    total = GetRushOrder()[2, col];
                    break;
                default:
                    total = 0;
                    break;
            }

            return total;
        }

        /*gets the surface area of desk for pricing*/
        public int getArea()
        {
           return this.desk.Width * this.desk.Depth;
        }

        /*get price of surface based on material'*/
        public int getSurfacePrice(Desk desk)
        {
            /*use (int)object.enumType to get numeric value of enum*/
            int surfacePrice = (int)desk.Surface;
            return surfacePrice;
        }

       
        /*this creates a total based on desk object specs defined by user input*/
        public int getTotal(Desk desk)
        {
            /*unit pricing structure variables:*/
            int basePrice = 200;
            int saPrice = 1; 
            int drawerPrice = 50;

        saPrice *= desk.Width * desk.Depth;
            drawerPrice *= desk.Drawers;
            int surfacePrice = getSurfacePrice(desk);
            int deliveryPrice = getDeliveryPrice(desk.Width, desk.Depth, this.deliveryTime);
            int total = basePrice + saPrice + drawerPrice + surfacePrice + deliveryPrice;
            return total;
        }

      

    }
}
