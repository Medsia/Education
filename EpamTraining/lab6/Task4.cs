using System;


namespace lab6
{
    internal class Task4
    {
        struct Filmography
        {
            public string title;
            public string genre;
            public string country;
            public double p1, p2, p3;
        }
        static Tuple<string, string, double, string> Corteg(string title1, string year1, string country1, double price1)
        {
            string p = title1, code, otv;
            double sum, sr;
            Filmography[] fg = new Filmography[6];
            fg[0].title = "Терминатор";
            fg[0].genre = "Боевик";
            fg[0].country = "США";
            fg[0].p1 = 4; fg[0].p2 = 8; fg[0].p3 = 9;
            fg[1].title = "Брат";
            fg[1].genre = "Драма,Боевик";
            fg[1].country = "Россия";
            fg[1].p1 = 10; fg[1].p2 = 7; fg[1].p3 = 8;
            fg[2].title = "Бойцовский клуб";
            fg[2].genre = "Триллер";
            fg[2].country = "США";
            fg[2].p1 = 8; fg[2].p2 = 15; fg[2].p3 = 20;
            fg[3].title = "Большой Стэн";
            fg[3].genre = "Комедия";
            fg[3].country = "США";
            fg[3].p1 = 10; fg[3].p2 = 13; fg[3].p3 = 11;
            fg[4].title = "Про уродов и людей";
            fg[4].genre = "Драма";
            fg[4].country = "Россия";
            fg[4].p1 = 15; fg[4].p2 = 5; fg[4].p3 = 21;
            fg[5].title = "Амели";
            fg[5].genre = "Романтика";
            fg[5].country = "Франция";
            fg[5].p1 = 11; fg[5].p2 = 7; fg[5].p3 = 13;
            int nom = 0;
            for (int i = 0; i <= 5; i++)
                if (fg[i].title == title1)
                {
                    nom = i;
                    break;
                }
            if (nom != 0)
            {
                code = fg[nom].genre + "-" + year1;
                sum = fg[nom].p1 + fg[nom].p2 + fg[nom].p3 + price1;
                sr = sum / 4;
            }
            else { code = "unknown"; sr = price1; }
            if (country1 == fg[nom].country) otv = "Да";
            else otv = "Нет";           
            return Tuple.Create<string, string, double, string>(p, code, sr, otv);
        }

            public static void task4()
        {        
            Console.WriteLine("Год =");
            string year = Console.ReadLine();
            Console.WriteLine("Название =");
            string title = Console.ReadLine();
            Console.WriteLine("Страна =");
            string county = Console.ReadLine();
            Console.WriteLine("Цена =");
            double price = Convert.ToDouble(Console.ReadLine());
            var myTuple = Corteg(title, year, county, price);
            Console.WriteLine("Название:{0}\n" + "Код: {1}\n"+ "Cредняя цена:{2}\n" + "Совпадает ли страна: {3}\n", myTuple.Item1, myTuple.Item2, myTuple.Item3, myTuple.Item4);
            Console.ReadLine();
        }
    }
}
    

