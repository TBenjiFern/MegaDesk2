using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk2
{

    public enum Shipping
    {
        [Description("Rush 3 Days")]
        Rush1,
        [Description("Rush 5 Days")]
        Rush2,
        [Description("Rush 7 Days")]
        Rush3,
        [Description("No Rush")]
        NoRush
    }

    public class DeskQuote
    {

        private int[,] rushOrderPrices;

        private const decimal DEFAULT_DESK_COST = 200.00M;
        private const decimal BASE_SURFACE_AREA_COST = 1.00M;
        private const decimal DRAWER_COST = 50.00M;
        private const decimal OAK_COST = 200.00M;
        private const decimal LAMINATE_COST = 100.00M;
        private const decimal PINE_COST = 50.00M;
        private const decimal ROSEWOOD_COST = 300.00M;
        private const decimal VENEER_COST = 125.00M;



        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Shipping Shipping { get; set; }

        public Desk Desk { get; set; }

        public decimal DeskPrice { get; set; }


        public decimal CalcTotalPrice()
        {
            GetRushOrders();

            int size;

            decimal totalPrice = DEFAULT_DESK_COST;

            int surfaceArea = Desk.Width * Desk.Depth;

            if (surfaceArea > 1000)
            {
                totalPrice += (surfaceArea - 1000) * BASE_SURFACE_AREA_COST;
            }

            if (surfaceArea < 1000)
            {
                size = 0;
            }
            else if (surfaceArea > 2000)
            {
                size = 2;
            }
            else
            {
                size = 1;
            }

            totalPrice += DRAWER_COST * Desk.NumDrawers;

            switch (Desk.DesktopMaterial)
            {
                case DesktopMaterial.Oak:
                    totalPrice += OAK_COST;
                    break;
                case DesktopMaterial.Laminate:
                    totalPrice += LAMINATE_COST;
                    break;
                case DesktopMaterial.Pine:
                    totalPrice += PINE_COST;
                    break;
                case DesktopMaterial.Rosewood:
                    totalPrice += ROSEWOOD_COST;
                    break;
                case DesktopMaterial.Veneer:
                    totalPrice += VENEER_COST;
                    break;
                default:
                    break;
            }

            switch (Shipping)
            {
                case Shipping.Rush1:
                    totalPrice += rushOrderPrices[0, size];
                    break;
                case Shipping.Rush2:
                    totalPrice += rushOrderPrices[1, size];
                    break;
                case Shipping.Rush3:
                    totalPrice += rushOrderPrices[2, size];
                    break;
                case Shipping.NoRush:
                    break;
                default:
                    break;

            }

            return totalPrice;
        }

        private void GetRushOrders()
        {
            rushOrderPrices = new int[3, 3];

            var rushOrderFileName = @"rushOrderPrices.txt";

            try
            {
                string[] rates = File.ReadAllLines(rushOrderFileName);
                int i = 0, j = 0;

                foreach (string rate in rates)
                {
                    rushOrderPrices[i, j] = int.Parse(rate);

                    if (j == 2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Rush Order prices couldn't be loaded");
                throw;
            }
        }


    }
}
