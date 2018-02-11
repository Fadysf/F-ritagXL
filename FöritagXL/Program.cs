using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace FöritagXL
{
    class Program
    {
        static List<string> RekryterLista = new List<string>();// för admin 
        static List<string> AllTeam = new List<string>();// intervjud list
        static List<string> IQTest = new List<string>();//de som klarade intervju
        static List<object> SlutSats = new List<object>();// för de som klara allt

        //listor fö ralla som admin addar 
        static List<string> arkitekt = new List<string>();
        static List<string> utveklare = new List<string>();
        static List<string> säljare = new List<string>();

        // alla mail som kommer från typsare
        static List<string> MailList = new List<string>();

        // array för att egstera personer i listor
        static Object[] typsareArray = new object[4];
        static List<object> allTypPeron = new List<object>();

        static string name;
        static int åld;
        static string avdelning;
        static int årFaran;
        static int arrayCounter = 0;
        static string desain = "\n ============================== \n";
        static string iqTestUser;
        static string rollIQtest;
        static void Main()
        {

            AllTeam.Add("fady");
            Console.Clear();
            MenyFörAll();


        }

        public static void MenyFörAll()
        {
            Console.WriteLine("\t\t\t\thej och välkomna till föritag XL\n");
            Thread.Sleep(2000);
            Console.WriteLine("\t[1]Rekrytering:");
            Thread.Sleep(2000);
            Console.WriteLine("\t[2]Intervju:");
            Thread.Sleep(2000);
            Console.WriteLine("\t[3]IQ-test:");
            Thread.Sleep(2000);
            Console.WriteLine("\t[4]Slutsats");

            Int32.TryParse(Console.ReadLine(), out int MFA);

            if ((MFA == 0) || (MFA > 4))
            {
                Console.WriteLine("dU har mata in något som inte stämmer");
                Thread.Sleep(3000);
                Console.Clear();
                MenyFörAll();
            }
            switch (MFA)
            {
                case 1:
                    Användare();
                    break;

                case 2:
                    Intervju();
                    break;

                case 3:

                    IQTestRegstering();

                    break;

                case 4:
                    break;

            }
        }

        public static void Användare()
        {
            RekryterLista.Add("aref");
            RekryterLista.Add("fady hadod");


            Console.WriteLine("Skriv ditt name och efter namn");
            string adminKollare;
            adminKollare = Console.ReadLine();
            adminKollare = adminKollare.ToLower();

            if (RekryterLista.Contains(adminKollare))
            {

                Console.Clear();
                Console.WriteLine("hej Admin! du har tillgång till all program delar");
                Thread.Sleep(2000);
                Rek();

            }
            // tre list måste vara med höär inte bara en 


            else
            {
                Console.WriteLine("hej och välkommen som typsare");
                typsare();
            }
        }

        public static void Rek()
        {

            bool loop = true;
            while (loop)
            {
                //meny för adda och vissa inhåll för Rekryterare
                int team = 0;
                Console.Clear();
                Console.WriteLine("1)Lägga till nya personer:\n2)avsluta programet\n3)vissa inhålle för personlist och mail");
                Int32.TryParse(Console.ReadLine(), out int RekMeny);

                if (RekMeny == 0 || RekMeny > 3)
                {
                    Console.WriteLine("Du matade något fel");
                    Thread.Sleep(2000);
                    Rek();

                }

                if (RekMeny == 1)
                {
                    Console.WriteLine("I vilken team vill du ligga den nya person\n 1)Arkitekt\n 2)Utveklare\n 3)Säljer");
                    Int32.TryParse(Console.ReadLine(), out team);
                    if (team == 0 || team > 3)
                    {
                        Console.WriteLine("Du matade något fel");
                        Thread.Sleep(2000);

                    }

                }
                //avsluta program
                else if (RekMeny == 2)
                {
                    Console.WriteLine("Tack! och hej ");

                    Thread.Sleep(6000);
                    Main();
                }

                //vissa inhåll i list
                else if (RekMeny == 3)
                {
                    Console.WriteLine("personer som finns med i team Arktitekt\n");
                    foreach (var per in arkitekt)
                    {

                        Console.WriteLine(per);
                    }

                    Console.WriteLine("personer som finns med i team Utveklare\n");
                    foreach (string per in utveklare)
                    {

                        Console.WriteLine(per);
                    }

                    Console.WriteLine("personer som finns med i team säljare\n");
                    foreach (var per in säljare)
                    {

                        Console.WriteLine(per);
                    }

                    Console.WriteLine("Personer som blev typsad");
                    foreach (var per in typsareArray)
                    {
                        Console.WriteLine(per);
                    }

                    Console.WriteLine("Mail");
                    foreach (var per in MailList)
                    {
                        Console.WriteLine(per);
                    }

                    Console.WriteLine("Tryck på Enter för Meny");
                    Console.ReadKey();
                }


                switch (team)
                {  //rek ska mata in namn som bli sparat i list
                    case 1:
                        try
                        {



                            Console.Clear();
                            Console.WriteLine("\nMata in personen name och efter namn:");
                            name = Console.ReadLine();


                            Console.WriteLine("\nMata in ålden:");
                            åld = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nI vilket Stad");
                            avdelning = Console.ReadLine();


                            Console.WriteLine("\nMata in Antal årserfarenhet inom det området.:\n");
                            årFaran = Convert.ToInt32(Console.ReadLine());


                            arkitekt.Add(desain + ("Name:" + name) + ("\nÅld:" + åld) + ("\nStad:" + avdelning) + ("\nårserfarenhet:" + årFaran) + desain);
                            // adda person så de kan göra intervju
                            name = name.ToLower();
                            AllTeam.Add(name);

                            Console.WriteLine("tack vi har tagit emot dina införmation\n \n Till backa till meny\n");
                            Thread.Sleep(2000);
                        }

                        catch (FormatException)
                        {

                            Console.WriteLine("Du skrev något som inte stämmer, du får börja om");
                            Thread.Sleep(3000);
                            team = 1;

                        }

                        // arkitekt = typsareArray.ToList();


                        // Array.Clear(typsareArray, 0, typsareArray.Length);

                        break;

                    // fixa klar den 

                    case 2:

                        try
                        {



                            Console.Clear();
                            Console.WriteLine("\nMata in personen name och efter namn:");
                            name = Console.ReadLine();


                            Console.WriteLine("\nMata in ålden:");
                            åld = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nI vilket Stad");
                            avdelning = Console.ReadLine();


                            Console.WriteLine("\nMata in Antal årserfarenhet inom det området.:\n");
                            årFaran = Convert.ToInt32(Console.ReadLine());


                            utveklare.Add(desain + ("Name:" + name) + ("\nÅld:" + åld) + ("\nStad:" + avdelning) + ("\nårserfarenhet:" + årFaran) + desain);
                            // adda person så de kan göra intervju
                            name = name.ToLower();
                            AllTeam.Add(name);

                            Console.WriteLine("tack vi har tagit emot dina införmation\n \n Till backa till meny\n");
                            Thread.Sleep(2000);
                        }

                        catch (FormatException)
                        {

                            Console.WriteLine("Du skrev något som inte stämmer, du får börja om");
                            Thread.Sleep(3000);
                            team = 2;

                        }

                        break;

                    case 3:

                        try
                        {



                            Console.Clear();
                            Console.WriteLine("\nMata in personen name och efter namn:");
                            name = Console.ReadLine();


                            Console.WriteLine("\nMata in ålden:");
                            åld = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nI vilket Stad");
                            avdelning = Console.ReadLine();


                            Console.WriteLine("\nMata in Antal årserfarenhet inom det området.:\n");
                            årFaran = Convert.ToInt32(Console.ReadLine());


                            säljare.Add(desain + ("Name:" + name) + ("\nÅld:" + åld) + ("\nStad:" + avdelning) + ("\nårserfarenhet:" + årFaran) + desain);
                            // adda person så de kan göra intervju
                            name = name.ToLower();
                            AllTeam.Add(name);

                            Console.WriteLine("tack vi har tagit emot dina införmation\n \n Till backa till meny\n");
                            Thread.Sleep(2000);
                        }

                        catch (FormatException)
                        {

                            Console.WriteLine("Du skrev något som inte stämmer, du får börja om");
                            Thread.Sleep(3000);
                            team = 3;

                        }
                        break;

                }


            }


        }

        public static void typsare()
        {


            while (true)
            {


                Console.WriteLine("1)typsa om någon person\n" +
                    "2)skicka mail till Rekryterare\n" +
                    "3)Avsluta ");
                Int32.TryParse(Console.ReadLine(), out int typ);

                if (typ == 0 || typ > 4)
                {
                    Console.WriteLine("Du matade något fel");
                    typsare();

                }


                switch (typ)
                {

                    case 1:



                        if (arrayCounter > 3)
                        {
                            Console.WriteLine("\ndu kan tysa en person i taget! ");
                            Thread.Sleep(2000);
                            break;

                        }

                        Console.Clear();
                        Console.WriteLine("\nMata in personen name och efter namn:");
                        name = Console.ReadLine();
                        typsareArray[arrayCounter] = "Name" + name;
                        arrayCounter++;

                        try
                        {

                            Console.WriteLine("\nMata in ålden:");
                            //Int32.TryParse(Console.ReadLine(), out åld);
                            åld = Convert.ToInt32(Console.ReadLine());
                            typsareArray[arrayCounter] = "Åld" + åld;
                            arrayCounter++;

                            Console.WriteLine("\nmata in din avdelning (Arkitekt, Utveklare, Säljare)");
                            avdelning = Console.ReadLine();
                            typsareArray[arrayCounter] = "Avdelning" + avdelning;
                            arrayCounter++;


                            Console.WriteLine("\nMata in Antal årserfarenhet inom det området.:\n");
                            årFaran = Convert.ToInt32(Console.ReadLine());
                            typsareArray[arrayCounter] = "årserfarenhet" + årFaran;
                            arrayCounter++;

                        }

                        catch (FormatException)
                        {

                            Console.WriteLine("Du skrev något som inte stämmer");
                            Thread.Sleep(3000);
                            arrayCounter = (0);
                            typsare();

                        }



                        allTypPeron = typsareArray.ToList();

                        arrayCounter = (0);

                        Console.WriteLine("tack vi har tagit emot dina införmation\n \n Till backa till meny\n");
                        Thread.Sleep(2000);




                        break;


                    case 2:
                        string skickaMail;

                        Console.WriteLine("Du kan skicka mail till\n" +
                            "1)Arkitekt:  aref@hotmil.com\n" +
                            "2)Utveklare: fady@hotmail.com\n" +
                            "3)Säljare: test@hotmail.com");
                        Int32.TryParse(Console.ReadLine(), out int mail);

                        if (mail == 1)
                        {
                            Console.WriteLine("\nskriv ditt medelande som du vill skicka till Arkitekt: aref@hotmil.com");
                            skickaMail = Console.ReadLine();
                            MailList.Add(skickaMail + ("\t Medelande skickat till Aref\t \nmedelande slutar har\n \n"));
                            Console.WriteLine("vi har tagit emot ditt medelande");
                        }

                        else if (mail == 2)
                        {
                            Console.WriteLine("skriv ditt medelande som du vill skicka till Utveklare: fady@hotmail.com");
                            skickaMail = Console.ReadLine();
                            MailList.Add(skickaMail + ("\t medelande skickat till Fady\t \nmedelande slutar har\n \n"));
                            Console.WriteLine("vi har tagit emot ditt medelande");
                        }

                        else if (mail == 3)
                        {
                            Console.WriteLine("skriv ditt medelande som du vill skicka till Säljare: test@hotmail.com");
                            skickaMail = Console.ReadLine();
                            MailList.Add(skickaMail + ("\t medelande skickat till Test\t \nmedelande slutar har\n \n"));
                            Console.WriteLine("vi har tagit emot ditt medelande");
                        }



                        else if (mail == 0 || mail > 3)
                        {
                            Console.WriteLine("fel inmatning försök igen");

                        }
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;



                    case 3:
                        Console.WriteLine("Tack! och hej ");
                        Main();
                        Thread.Sleep(6000);
                        break;

                }



            }

        }

        public static void Intervju()
        {

            Console.WriteLine("hej skriv ditt namn och efter namn");
            string user;
            user = Console.ReadLine();
            user = user.ToLower();

            if (AllTeam.Contains(user))
            {
                chatbot2();
            }

            else
            {
                Console.WriteLine("Tyvärr!ditt namn finns inte med i Rekryteringlist. Du kan inte göra intervju");
                Thread.Sleep(4000);
                Main();
            }

        }

        //public static void chatbot()
        //{
        //    bool chaton = true;
        //    bool hittade = false;
        //    string input;
        //    string output = "";



        //    Console.WriteLine("hej och välkommen till intervju");
        //    Console.WriteLine("bot: hello");

        //    while (chaton)
        //    {
        //        Console.Write("användare: ");
        //        input = Console.ReadLine();

        //        Console.Write("bot:");
        //        switch (input)
        //        {
        //            case "hello":
        //                output = "nu kommer jag att ställa några frågor till dig";
        //                hittade = true;
        //                break;

        //            case "okej":
        //                output = "Berätta lite om dig själv";
        //                hittade = true;
        //                break;

        //            case "jag vet inte":
        //                output = "kan du berätta om hur du är som peroson";
        //                hittade = true;
        //                break;

        //            case "jag heter":
        //                output = "hur är du som peroson";
        //                hittade = true;
        //                break;

        //            case "jag är":
        //                output = "gillar du jobba i grubb eller ensam och varför?";
        //                hittade = true;
        //                break;


        //        }
        //        if (hittade)
        //        {

        //            Console.WriteLine(output);

        //        }

        //        else
        //        {
        //            Console.WriteLine("hittade inget svar");
        //        }

        //        bool gilla = false;
        //        bool postiv = false;

        //        int conter = 0;

        //        foreach (Match item in Regex.Matches(användare, "år"))
        //        {
        //            conter++;
        //        }

        //        foreach (Match item in Regex.Matches(användare, "gillar"))
        //        {
        //            gilla = true;
        //        }

        //        foreach (Match item in Regex.Matches(användare, "glad"))
        //        {
        //            postiv = true;
        //        }

        //        foreach (Match item in Regex.Matches(användare, "snäll"))
        //        {
        //            postiv = true;
        //        }

        //        foreach (Match item in Regex.Matches(användare, "postiv"))
        //        {
        //            postiv = true;
        //        }


        //    }
        //}

        public static void chatbot2()
        {
            string användare;
            bool chaten = true;
            int i = 0;

            Console.WriteLine("Regstera dig med ditt name och efternamn");
            string botregstering;
            botregstering = Console.ReadLine();
            botregstering.ToLower();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("bot: hej");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("användare:");
            användare = Console.ReadLine();

            while (chaten)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("bot:");


                if (användare.Contains("hej!") ||
                    användare.Contains("hej") ||
                    användare.Contains("hi") ||
                    användare.Contains("hello") && (i == 0))
                {

                    Console.WriteLine("kul att ha dig här!\n" +
                        "jag kommer att ställa några frågor till dig");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("användare:");
                    användare = Console.ReadLine();
                    i = 1;



                }

                else if ((i == 1) && användare.Contains("okej") ||
                    användare.Contains("ok") ||
                    användare.Contains("kör") ||
                    användare.Contains("aa") ||
                    användare.Contains("varsågod") ||
                    användare.Contains("aa gärna"))
                {
                    Console.WriteLine("Berätta lite om dig själv(tex din åld, var du bor,har du barn....)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("användare:");
                    användare = Console.ReadLine();
                    i = 2;
                }

                else if ((i == 2) && användare.Contains("år") ||
                    användare.Contains("bor") ||
                    användare.Contains("barn") ||
                    användare.Contains("liver") ||
                    användare.Contains("barn") ||
                    användare.Contains("jag har"))
                {
                    Console.WriteLine("aa låter bra, kan du berätta om hur du är som peroson");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("användare:");
                    användare = Console.ReadLine();
                    i = 3;

                }

                else if ((i == 3) && användare.Contains("postiv") ||
                    användare.Contains("glad") ||
                    användare.Contains("snäll") ||
                    användare.Contains("trevlig") ||
                    användare.Contains("hjälpsam") ||
                    användare.Contains("hälpa"))
                {
                    Console.WriteLine("härligt! berätta om vad du brukar göra i din fritid");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("användare:");
                    användare = Console.ReadLine();
                    i = 4;
                }

                else if ((i == 4) && användare.Contains("jag brukar") ||
                    användare.Contains("tycker") ||
                    användare.Contains("brukar") ||
                    användare.Contains("spela") ||
                    användare.Contains("tycker om"))
                {
                    Console.WriteLine("spännande, sista fråga Arbetar du helst i grupp eller ensam," +
                        "varför");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("användare:");
                    användare = Console.ReadLine();
                    i = 5;

                }

                else if ((i == 5) && användare.Contains("grupp") ||
                    användare.Contains("ensam") ||
                    användare.Contains("båda") ||
                    användare.Contains("helst") ||
                    användare.Contains("spelar inget roll") ||
                    användare.Contains("svårt att säg") ||
                    användare.Contains("hejdå"))
                {
                    Console.WriteLine("Det var trevligt att prata med dig. hejdå");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("användare:");
                    användare = Console.ReadLine();
                    // gör så att användarea addas till iq test
                    IQTest.Add(botregstering);
                    Console.WriteLine("Va bra du klarade intervju nu kan du göra IQ-test");
                    Thread.Sleep(4000);
                    Console.Clear();
                    MenyFörAll();

                }

                else
                {
                    Console.WriteLine("kan du vara snäll och skriva lite mer");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("användare:");
                    användare = Console.ReadLine();
                }








            }


        }

        public static void IQTestRegstering()
        {
            Console.WriteLine("hej igen skriv ditt namn och efter namn");
             
            iqTestUser = Console.ReadLine();
            iqTestUser = iqTestUser.ToLower();

            Console.WriteLine("skriv vilken roll du har");
            rollIQtest = Console.ReadLine();



            if (IQTest.Contains(iqTestUser))
            {
                IQtest();
            }

            else
            {
                Console.WriteLine("Tyvärr!Du måste göra intervju innan du kan köra IQ-test");
                Thread.Sleep(4000);
                iqTestUser = "";
                Main();
            }



        }

        public static void IQtest()
        {
            // för att räka tiden som användare behöver för spel
            Stopwatch minTid = new Stopwatch();

            int tal0 = 0;
            Int32 tal1, tal2, tal3, tal4;
            char starta;
            string test1, test2, test3;
            

            Console.WriteLine("hej och välkomen till  IQtest");
            Thread.Sleep(3000);
            Console.WriteLine("testet består av olika frågor\n" +
                "(obs) programet räknar poängen och tid");
            Thread.Sleep(3000);
            Console.WriteLine("Du får (1) poäng för varja rätt svar\nDu kan alltid gå vidare genom att trcka en gång på (Enter)");
            Console.WriteLine("Du kan starta utmaning genom att trycka på (Y) eller (N) för avsluta av program");
            starta = Convert.ToChar(Console.ReadLine().ToUpper());
           
            while (starta.Equals(Char.Parse("Y")))
            {
                minTid.Start();
                Console.WriteLine("Beräkna:\n" +
                    "2 + 7 + 9 - 8 + 5 * 7 = (?)");
                Console.Write("Din svar: "); 
                Int32.TryParse(Console.ReadLine(), out tal1);
                if (tal1 == 45)
                {
                    tal0 ++ ;
                    
                }
                Console.WriteLine("\n6 + 5 * 3 + 6 * 2 + 5 + 2 = (?)");
                Console.Write("Din svar: ");
                Int32.TryParse(Console.ReadLine(), out tal2);
                if (tal2 == 40)
                {
                    tal0 ++;
                }

                Console.WriteLine("\n8 + 8 / 2 * 3 - (?) = 9");
                Console.Write("Din svar: ");
                Int32.TryParse(Console.ReadLine(), out tal3);
                if (tal3 == 11)
                {
                    tal0++;
                }
                Console.WriteLine("\n(?) - 8 + 2 * 3 = 7");
                Console.Write("Din svar: ");
                Int32.TryParse(Console.ReadLine(), out tal4);
                if (tal4 == 9)
                {
                    tal0++;
                }


                Console.WriteLine("vad saknas");
                Console.WriteLine("\na,a,a,a,b,b,b,b,c,c,c,c,f,f,(?),f");
                Console.Write("Ditt svar: ");
                test1 = Console.ReadLine();
                if (test1 == "f")
                {
                    tal0++;
                }

                Console.WriteLine("\na,b,c,d,e\n" +
                    "b,a,e,c,d\n" +
                    "e,a,(?),d,a\n" +
                    "c,d,e,a,b");
                Console.Write("Ditt svar: ");
                test2 = Console.ReadLine();

                if (test2 == "b")
                {
                    tal0++;
                }


                Console.WriteLine("\na,b,c,d,e\n" +
                    "h,i,j,k,l\n" +
                    "p,q,(?),s,t\n" +
                    "u,v,w,x,y\n");
                Console.Write("Ditt svar: ");
                test3 = Console.ReadLine();
                if (test3 == "r")
                {
                    tal0++;
                }
                minTid.Stop();
                Console.WriteLine("bra nu är du klara med IQ testet bra jobbat.");
                SlutSats.Add("Namn: " + iqTestUser  + "\nRoll: " + rollIQtest +"\npoängen: "+ tal0 + "\nDu klarade teste på: " + minTid.Elapsed);
                Thread.Sleep(4000);
                Console.Clear();
               
                starta = char.Parse("n");
                MenyFörAll();
            }

            if (starta.Equals(Char.Parse("N")))
            {
                Console.WriteLine("hejdå");
                Thread.Sleep(3000);
            }

            else
            {
                Console.WriteLine("du skrev något som inte stämmer");
                Thread.Sleep(2000);
                IQtest();
            }

        }
    }
}
