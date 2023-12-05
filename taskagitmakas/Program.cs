using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace taskagitmakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            
            string user;
            string ai;
            bool playagain = true;
            string cevap;

            Random rm = new Random();
            rm.Next(1, 3);
            Console.WriteLine("Taş Kağıt Makas Oyununa Hoşgeldiniz!");
            Console.WriteLine("");
            while (playagain)
            {
             

                user = "";
                ai = "";
                while(user!= "TAŞ" && user != "KAĞIT" && user != "MAKAS")
                {

                    Console.Write("Taş mı Kağıt mı Makas mı? :"); user = Console.ReadLine().ToUpper();
                   
                }
                
                switch (rm.Next(1,3))
                {
                    case 1:
                        ai = "TAŞ";
                        break;
                        case 2:
                        ai = "KAĞIT";
                        break;
                        case 3:
                        ai = "MAKAS";
                        break;
                       
                }
                Console.WriteLine("Senin Seçtiğin : "+user);
                Console.WriteLine("Bilgisayarın Seçtiği :" + ai);
                
                

                switch (user)
                {
                    case "TAŞ":
                        if (ai == "TAŞ")
                        {
                            Console.WriteLine("Berabere!");
                        }
                        else if (ai == "KAĞIT")
                        {
                            Console.WriteLine("Kaybettin!");
                        }
                        else
                        {
                            Console.WriteLine("Kazandın!");
                        }
                        break;
                    case "KAĞIT":

                        if (ai == "KAĞIT")
                        {
                            Console.WriteLine("Berabere!");
                        }
                        else if (ai == "MAKAS")
                        {
                            Console.WriteLine("Kaybettin!");
                        }
                        else
                        {
                            Console.WriteLine("Kazandın!");
                        }
                        break;
                    case "MAKAS":

                        if (ai == "MAKAS")
                        {
                            Console.WriteLine("Berabere!");
                        }
                        else if (ai == "TAŞ")
                        {
                            Console.WriteLine("Kaybettin!");
                        }
                        else
                        {
                            Console.WriteLine("Kazandın!");
                        }
                        break;
                }
                Console.Write("Bir Daha Oynamak İster misiniz? (E/H)");
                cevap = Console.ReadLine().ToUpper();
                if( cevap == "E")
                {
                   playagain = true;
                }
                else
                {
                    playagain= false;
                    Console.WriteLine("Görüşmek Üzere");
                }
            }

            Console.ReadKey();



        }
    }
}
