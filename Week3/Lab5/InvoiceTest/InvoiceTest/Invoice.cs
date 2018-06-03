using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTest
{
    class Invoice
    {
        private string part_number;
        private string description;
        private int quantity;
        private decimal price_per_item;

         public Invoice(string number, string description, int quantity, decimal price)
        {
            this.part_number = number;
            this.description = description;
            this.quantity = quantity;
            this.price_per_item = price;
        }

        public string getPartNumber()
        {
            return this.part_number;
        }

        public void setPartNumber(string num)
        {
            this.part_number = num;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string des)
        {
            this.description = des;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public void setQuantity(int quantity)
        {
            if (quantity >= 0) {
                this.quantity = quantity;
            }
        }

        public decimal getPrice()
        {
            return this.price_per_item;
        }

        public void setPrice(decimal price)
        {
            if (price > 0)
            {
                this.price_per_item = price;
            }
            
        }

        public decimal getInvoiceAmount()
        {
            return this.price_per_item * this.quantity;
        }

    }
}
