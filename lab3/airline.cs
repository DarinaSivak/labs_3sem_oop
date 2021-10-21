using System;

namespace lab3 
{
    public class airline
    {
        public string destination;
        public string Destination 
        {
            set 
            {
                if (destination == null)
                {
                    Console.WriteLine("пункт назначения не задан !");
                }
                else
                {
                    destination = value;
                }
            }
            get 
            {
                return destination;
            }
        }

        public int flightNumber;
        public int FlightNumber { get; set; }

        public string typeOfAirplane;
        public string TypeOfAirplane 
        {
            set 
            {
                if (typeOfAirplane == null)
                {
                    Console.WriteLine("тип самолета не задан !");
                }
                else
                {
                    typeOfAirplane = value;
                }
            }
            get 
            {
                return typeOfAirplane;
            }
        }

        public string departureTime;
        public string DepartureTime
        {
            set 
            {
                if (departureTime == null)
                {
                    Console.WriteLine("время вылета не задано !");
                }
                else
                {
                    departureTime = value;
                }
            }
            get 
            {
                return departureTime;
            }
        }

        public string weekday;
        public string Weekday
        {
            set 
            {
                if (weekday == null)
                {
                    Console.WriteLine("день недели не задан !");
                }
                else
                {
                    weekday = value;
                }
            }
            get 
            {
                return weekday;
            }
        }

        static short numOfAirline = 0;

        static airline() //статический конструктор
        {
            Console.WriteLine("создан новый рейс");
        }

        public airline (string destination, int flightNumber, string typeOfAirplane, string departureTime, string weekday, string destinationRef, string weekdayRefOut) //конструктор с параметрами
        {
            this.destination = destination;
            this.flightNumber = flightNumber;
            this.typeOfAirplane = typeOfAirplane;
            this.departureTime = departureTime;
            this.weekday = weekday;
            this.destinationRef = destinationRef;
            this.weekdayRefOut = weekdayRefOut; 
            numOfAirline++;
            outPut();
            destRef(ref destinationRef);
            dayRef(ref weekdayRefOut);
            dayOut(out weekdayRefOut);
        }

        private string destinationRef;
        public string DestinationRef
        {
            get {return destinationRef; }
            set {}
        }

        private string weekdayRefOut;
        public string WeekdayRefOut { get; set; }

        public void destRef(ref string destinationRef)
        {
            if (destination == destinationRef)
            {
                Console.WriteLine($"номер рейса : {flightNumber}");
            }
        }
        
        public void dayRef(ref string weekdayRefOut)
        {
            if (weekday == weekdayRefOut)
            {
                Console.WriteLine($"номер рейса : {flightNumber}");
            }
        }

        public void dayOut(out string weekdayRefOut)
        {
            weekdayRefOut = this.weekdayRefOut;
        }

        public void outPut()
        {
            Console.WriteLine($"\nпункт назначения : {destination}");
            Console.WriteLine($"номер рейса : {flightNumber}");
            Console.WriteLine($"тип самолета : {typeOfAirplane}");
            Console.WriteLine($"время вылета : {departureTime}");
            Console.WriteLine($"день недели : {weekday}\n");
        }

        private airline() //конструктор без параметров
        {
            destination = "Светлогорск";
            flightNumber = 293;
            typeOfAirplane = "Boing";
            departureTime = "23:12";
            weekday = "пятница";
            numOfAirline++;
        }

        public airline (string parametr = "default") {} //конструктор с параметром по умолчанию

        public const double E = 2.71; //поле константа

        public readonly int readOnly = 39; //поле только для чтения
        public airline (int ReadOnly)
        {
            readOnly = ReadOnly; // поле для чтения может быть инициализировано или изменено в конструкторе после компиляции
        }

        public static int ID { get; private set; } = 54;

        public static void NumOfAirline() //кол-во объектов
        {
            Console.WriteLine($"количество созданных объектов: {numOfAirline}");
        }

        public override string ToString()
        {
            return $"пункт назначения: {destination}, номер рейса: {flightNumber}, тип самолета: {typeOfAirplane}, время вылета: {departureTime}, день недели: {weekday}";
        }

        public override int GetHashCode()
        {
            return flightNumber.GetHashCode();
        }

        public bool Equals(airline obj)
        {
            airline plane;
            if (obj == null || (plane = obj as airline) == null)
            {
                return false;
            }
            return this.destination == plane.destination;
        }

    }

    public partial class Partial
    {
        public void partialFunc()
        {
                Console.WriteLine("частичный класс");
        }
    }
}