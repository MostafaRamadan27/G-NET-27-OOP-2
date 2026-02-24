using Assignment1_OOP.Class;
using Assignment1_OOP.Enum;
using Assignment1_OOP.Struct;

namespace Assignment1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Q1 
            //A)
            //Field Must be Private 
            // in method must put validation before withdraw 
            // B)
            // 1- make field private   2- put validation before withdraw in method
            // c) 
            // because user can put invalid data 
            #endregion

            #region Q2
            // field  => 1- direct data storage / 2- no validations / 3- break encapsulation
            // property => 1- controlled access / 2- can validate / 3- enforce encapsulation

            // property can cotain logic 

            // private int _number1;
            // private int _number2;

            // public int calculatedNumber {
            //   get {
            //     return _number1 + _number2;
            //   }
            //   
            // }
            #endregion


            #region Q3 
            //a) indexer => allow object to be indexed like array 
            // b) error out of range => TO Make it safe use validation in indexer to check if index is in range before accessing the element
            // c) yes class can have multiple indexers with different parameter types 
            // if i need to search with two different way like like in library Example when ineed to search by index ot ISBN 
            #endregion


            #region Q4
            // a) Static mean the member belong to type itself // it shared for all object and can be accessed without creating an instance of the class 
            // b) cant access item directly because its not static only access with instance of class
            #endregion
            #endregion


            #region Part 02 Practical (Extending the Movie Ticket Booking System)
            //Cinema cinema = new Cinema();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter data for Ticket {i + 1}");

            //    Console.Write("Movie Name: ");
            //    string movieName = Console.ReadLine();

            //    Console.Write("Ticket Type (0 = Regular, 1 = VIP, 2 = Premium): ");
            //    TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //    Console.Write("Seat Row (A-Z): ");
            //    char row = char.Parse(Console.ReadLine());

            //    Console.Write("Seat Number: ");
            //    int column = int.Parse(Console.ReadLine());

            //    Console.Write("Price: ");
            //    decimal price = decimal.Parse(Console.ReadLine());

            //    SeatLocation seat = new SeatLocation
            //    {
            //        Row = row,
            //        Column = column
            //    };
            //    Ticket ticket = new Ticket(movieName, type, seat, price);
               
            //    cinema.AddTicket(ticket);
            //}
            //Console.WriteLine("--- All Tickets ---");

            //for (int i = 0; i < 3; i++)
            //{
            //    Ticket t = cinema[i];

            //    if (t != null)
            //    {
                    
            //        Console.Write($"TicketId# {t.TicketId} |");
            //        Console.Write($"MovieName: {t.MovieName} |");
            //        Console.Write($"Type: {t.Type} |");
            //        Console.Write($"Seat {t.Seat.Row} - {t.Seat.Column} |");
            //        Console.Write($"Price: {t.Price}  |");
            //        Console.Write($"Price After Tax: {t.PriceAfterTax}");
            //    }
            //}
            //Console.Write("Enter movie name to search: ");
            //string searchName = Console.ReadLine();

            //Ticket found = cinema.GetMovieName(searchName);

            //if (found != null)
            //{

            //    Console.Write($"Ticket #{found.TicketId} |");
            //    Console.Write($"type #{found._type} |");
            //    Console.Write($"Seat #{found.Seat} |");
            //    Console.Write($"Price #{found.Price} |");
           
            //}
            //else
            //{
            //    Console.WriteLine("Movie not found.");
            //}

        
            //Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            //Console.WriteLine("Booking References:");
            //Console.WriteLine(BookingHelper.GenerateBookingReference());
            //Console.WriteLine(BookingHelper.GenerateBookingReference());

            //double discountTotal = BookingHelper.CalcGroupDiscount(5, 80);
            //Console.WriteLine($"\nGroup Discount Total (5 tickets × 80 EGP): {discountTotal} EGP");
        }
        #endregion



    
    }
}
