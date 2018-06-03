using System;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Original invoice information");
                Console.Write("Part number: ");
                string number = Console.ReadLine();
                Console.Write("Description: ");
                string description = Console.ReadLine();
                Console.Write("Quantity: ");
                int quantity = Int16.Parse(Console.ReadLine());
                Console.Write("Price: $");
                decimal price = Decimal.Parse(Console.ReadLine());

                Invoice invoice = new Invoice(number, description, quantity, price);
                Console.Write("Invoice amount: $" + invoice.getInvoiceAmount());

                Console.WriteLine("");

                Console.WriteLine("\nUpdated invoice information");
                Console.Write("Part number: ");
                invoice.setPartNumber(Console.ReadLine());
                Console.Write("Description: ");
                invoice.setDescription(Console.ReadLine());
                Console.Write("Quantity: ");
                invoice.setQuantity(Int16.Parse(Console.ReadLine()));
                Console.Write("Price: $");
                invoice.setPrice(Decimal.Parse(Console.ReadLine()));
                Console.Write("Invoice amount: $" + invoice.getInvoiceAmount());
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        
    }
}
