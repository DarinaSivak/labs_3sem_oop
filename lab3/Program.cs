using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            airline flight1 = new airline ("Санкт-Петербург", 29, "Bombardier", "10:30", "суббота", "Санкт-Петербург", "пятница");
            airline flight2 = new airline ("Лондон", 875, "Embraer", "23:46", "понедельник", "Санкт-Петербург", "понедельник");
            airline flight3 = new airline ("Санкт-Петербург", 12, "ARJ-21", "19:34", "четверг", "Лондон", "среда");

            airline[] flights = new airline[3];
            flights[0] = flight1;
            flights[1] = flight2;
            flights[2] = flight3;

            airline.NumOfAirline();

            airline closed = new airline(); //вызов закрытого конструктора

            Partial newPartial = new Partial();
            newPartial.partialFunc();

            Console.WriteLine("GetType : " + flight1.GetType());
            Console.WriteLine("ToString : " + flight1.ToString());
            Console.WriteLine("GetHashCode : " + flight1.GetHashCode());
            Console.WriteLine("Equals: " + flight1.Equals(flight2));

            Console.WriteLine("введите пункт назначения : ");
            string consoleDest = Console.ReadLine();
            Console.WriteLine("список рейсов для заданного пункта назначения : ");
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].destination == consoleDest)
                {
                    Console.WriteLine("номер рейса : " + flights[i].flightNumber);
                }
            }

            Console.WriteLine("введите день недели : ");
            string consoleDay = Console.ReadLine();
            Console.WriteLine("список рейсов для заданного дня недели : ");
            for (int i = 0; i < flights.Length; i++)
            {
                if (flights[i].weekday == consoleDay)
                {
                    Console.WriteLine("номер рейса : " + flights[i].flightNumber);
                }
            }

            var anonymousType = new {destination = "Москва", departureTime = "06:21", flightNumber = 95};
            Console.WriteLine("анонимный тип : " + anonymousType.GetType());
        }
    }
}
