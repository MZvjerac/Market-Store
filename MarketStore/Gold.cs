using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Gold:Card
    {
        private double initialRate = 2.0;
        private double discountRate;
        private double purchaseValue;

        public double InitialRate { get { return initialRate; } set { initialRate = value; } }
        public double DiscountRate { get { return discountRate; } set { discountRate = value; } }
        public double PurchaseValue { get { return purchaseValue; } set { purchaseValue = value; } }


        public Gold(int ClientID, string Name, string Surname, int PhoneNumber, float Turnover, float Discount, float Total, double InitialRate, double DiscountRate, double PurchaseValue) : base(ClientID, Name, Surname, PhoneNumber, Turnover, Discount, Total)
        {
            this.InitialRate = InitialRate;
            this.DiscountRate = DiscountRate;
            this.PurchaseValue = PurchaseValue;
        }

        public Gold() { }

        public override string report(double PurchaseValue)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nType of card= Gold: \na. Card data: turnover ($)= " + Turnover);
            sb.Append(", purchase value ($)= " + PurchaseValue + "; \n\n" + "b. Output:\n" + "Purchase value($)= " + PurchaseValue);

            if (Turnover>=0 && Turnover < 100)
            {
                try
                {
                sb.Append("\nDiscount rate(%)= " + (DiscountRate = InitialRate));
                sb.Append("\nDiscount($)= " + (Discount = DiscountRate/100 * PurchaseValue));
                sb.Append("\nTotal($)= " + (Total = PurchaseValue - Discount));
                sb.Append("\n----------------------------------------------------------");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR= " + ex.ToString());
                }
                return sb.ToString();
            }
            else if (Turnover >= 100 && Turnover <= 800)
            {
                try
                {
                int rate = 0;

                rate = (int)(Turnover / 100);
                sb.Append("\nDiscount rate(%)= " + (DiscountRate =2+ rate));
                sb.Append("\nDiscount($)= " + (Discount = DiscountRate/100 * PurchaseValue));
                sb.Append("\nTotal($)= " + (Total = PurchaseValue - Discount));
                sb.Append("\n----------------------------------------------------------");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR= " + ex.ToString());
                }
                
                return sb.ToString();
            }    
            else if(Turnover>800)
            {
                try
                {
                sb.Append("\nDiscount rate(%)= " + (DiscountRate = 10));
                sb.Append("\nDiscount($)= " + (Discount = DiscountRate / 100 * PurchaseValue));
                sb.Append("\nTotal($)= " + (Total = PurchaseValue - Discount));
                sb.Append("\n----------------------------------------------------------");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR= " + ex.ToString());
                }

                return sb.ToString();
            }
            else
            {
                sb.Append("\nTURNOVER COULD NOT BE LESS THAN 0 $ !");
                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return report(PurchaseValue);
        }
    }
}
