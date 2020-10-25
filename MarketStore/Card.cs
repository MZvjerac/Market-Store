using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Card : ICalculation
    {
        private int clientID;
        private string name;
        private string surname;
        private int phoneNumber;
        private double turnover;        
        private double discount;
        private double total;
       

        public int ClientID { get { return clientID; } set { clientID = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int PhoneNumber { get { return phoneNumber;} set { phoneNumber = value; } }
        public double Turnover { get { return turnover; } set { turnover = value; } }       
        public double Discount { get { return discount; } set { discount = value; } }
        public double Total { get { return total; } set { total = value; } }

        public Card(int ClientID, string Name, string Surname, int PhoneNumber,  float Turnover, float Discount, float Total)
        {
            clientID = ClientID;
            name = Name;
            surname = Surname;
            phoneNumber = PhoneNumber;
            turnover = Turnover;            
            discount = Discount;
            total = Total;
        }

        public Card() { }

        

        public virtual string report(double purchaseValue)
        {
           
            throw new NotImplementedException();
        }
    }
}
