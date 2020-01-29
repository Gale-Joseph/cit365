using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Gale
{
   
    public class DeskQuote
    {

        string quoteDate = DateTime.Now.ToString();
        //general members:
        public Desk desk { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string currentDate;
        
        
        //desk specs
        public int deliveryTime = 14;

        //unit price list
        public int basePrice = 200;
        int saPrice = 1;
        public int drawerPrice = 50;
        public int surfacePrice;
        public int deliveryPrice { get; set; }        
        
        //methods


     
        public int getDeliveryPrice(int width, int depth, int deliveryTime)
        {
            int sa = width * depth;
            int total;
            switch (deliveryTime)
            {
                case 3:
                    if (sa < 1000)
                    {
                        total = 60;
                    }
                    else if(sa >=1000 && sa <=2000){
                        total = 70;
                    }
                    else
                    {
                        total = 80;
                    }
                    break;
                case 5:
                    if (sa < 1000)
                    {
                        total = 40;
                    }
                    else if (sa >= 1000 && sa <= 2000)
                    {
                        total = 50;
                    }
                    else
                    {
                        total = 60;
                    }
                    break;
                case 7:
                    if (sa < 1000)
                    {
                        total = 30;
                    }
                    else if (sa >= 1000 && sa <= 2000)
                    {
                        total = 35;
                    }
                    else
                    {
                        total = 40;
                    }
                    break;
                default:
                    total = 0;
                    break;
            }

            return total;
        }

        public int getArea()
        {
           return this.desk.Width * this.desk.Depth;
        }
        public int getSurfacePrice(Desk desk)
        {
            int surfacePrice = (int)desk.Surface;
            return surfacePrice;
        }
        public int getTotal(Desk desk)
        {
            saPrice *= desk.Width * desk.Depth;
            drawerPrice *= desk.Drawers;
            surfacePrice = getSurfacePrice(desk);
            /*deliveryPrice = getDeliveryPrice(desk.Width,desk.Depth,this.deliveryTime);*/
            deliveryPrice = 100;
            int total = basePrice + saPrice + drawerPrice + surfacePrice + deliveryPrice;            

            return total;
        }
    }
}
