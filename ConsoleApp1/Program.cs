using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Message(name: "Ertugrul");
            Message();
            double result = Sum(3, 5);
            
            string[] sehirler1 = new[] {"Ankara","İzmir"};
            string[] sehirler2 = new[] { "İstanbul", "Adana" };

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
                foreach (string sehi in sehirler2)
                {
                    Console.WriteLine(sehi);
                }
            }

            List<string> yenisehirler1 = new List<string> { "Ankara1", "İzmir1", "İstanbul1" };
            yenisehirler1.Add(item:"Adana1");
            foreach (string sehir in yenisehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.Firstname = "ERTUĞRUL";
            person1.Lastname = "ÖZTÜRK";
            person1.Dateofbirthyear = 1993;
            person1.Nationalidentity = 123;
            Person person2 = new Person();
            person2.Firstname = "Furkan";
            Pttmanager pttmanager = new Pttmanager(new PersonManager());
            pttmanager.GiveHelp(person1);


            Console.ReadLine();
        }

        public static void Message(string name="No Name")
        {
            Console.WriteLine("Heloo!!" + name);
        }

        public static double Sum(int number1,int number2)
        {
            double result = number1 + number2;
            Console.WriteLine("Result ="+result.ToString());
            return result;
        }
    }
    
 }
