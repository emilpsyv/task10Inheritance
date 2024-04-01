using Devices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mobile :
//string[] SimCards field-ı var.
//Mobile classından obyekt yaranan zaman SimCardCount parametrini məcbur qəbul edir.
//SimCardCount minimum 1 maksimum 2 ola bilər.
//Bu parametr SimCards field-inin uzunluğunu təyin edir.
//AddNumber, RemoveNumber, GetNumbers methodları ilə istifadəçi nömrələrə
//baxa, nömrə əlavə və ya nömrənin indeksini bildirərək silə bilər.
namespace devices.Models
{
    internal class Mobile : Device
    {
        public string[] SimCards;





        public Mobile(int SimCardCount , double width, double height, double weight) : base( width,  height,  weight)
        {
            if (SimCardCount == 1 || SimCardCount == 2)
            {
                SimCards = new string[SimCardCount];
            }

            else 
            {
                Console.WriteLine("nomre 1 veya 2 olmalidir");
                Console.ReadKey();
            }
        }



        public void AddNumber()
        {
            if (SimCards.Length == 1)
            {
                Console.WriteLine("add number");
                string num1 = Console.ReadLine();
                SimCards[SimCards.Length - 1] = num1;
                Console.WriteLine("number added");
            }
            else if (SimCards.Length == 2)
            {
                Console.WriteLine("add numbers");
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                SimCards[SimCards.Length - 2] = num1;
                SimCards[SimCards.Length - 1] = num2;
                Console.WriteLine("nums added");
            }
        }

        public void GetNumber()
        {
            Console.WriteLine($"{"index"} {"|"} {"nums"}");

            for (int i = 0; i < SimCards.Length; i++)
            {
                Console.WriteLine($"{i}     {"|"} {SimCards[i]}" );
            }
        }
        public void RemoveNumber(int index)
        {


            Console.WriteLine($"{index} {"indexdeki nomre silindi "}");
            SimCards[index] = null;

        }
        public void RemoveNumIndex(int index)
        {
            Console.WriteLine($"{index}{"ci"} {"index silindi "}");
            string[] newArr = new string[SimCards.Length-1];
            int j = 0;
            for (int i = 0;i < SimCards.Length;i++) 
            {
                if (index != i) 
                {
                    newArr[j]= SimCards[i];
                    j++;
                }
            }
            SimCards = newArr;
        }









    
    }
}




    






    

        

        


    

