using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using лр_5_2Б;

namespace лр_5_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            HardDrive[] HardDrive1;
            Console.Write("Введiть кiлькiсть жорстких дискiв: ");
            int number_drivers = int.Parse(Console.ReadLine());
            HardDrive1 = new HardDrive[number_drivers];
            for (int i = 0; i < number_drivers; i++)
            {
                Console.Write("Введiть виробника жорсткого диска: "); 
                string manufacturer = Console.ReadLine();
                Console.Write("Введiть назву моделi: "); string model = Console.ReadLine();
                Console.Write("Введiть обсяг жорсткого диска (у гiгабайтах): "); 
                string capacityGB = Console.ReadLine();
                Console.Write("Введiть тип iнтерфейсу: "); 
                string interfacetype = Console.ReadLine();
                Console.Write("Введiть кiлькiсть обертiв за хвилину: ");
                string rpm = Console.ReadLine();
                Console.Write("Введiть цiну: "); string price = Console.ReadLine();
                Console.Write("Чи є жорсткий диск SSD? (y-так, n-нi) ");
                ConsoleKeyInfo isSSD = Console.ReadKey(); Console.WriteLine();
                HardDrive HardDrive_ = new HardDrive();

                HardDrive_.manufacturer = manufacturer;
                HardDrive_.model = model;
                HardDrive_.capacityGB = double.Parse(capacityGB);
                HardDrive_.interfacetype = interfacetype;
                HardDrive_.rpm = int.Parse(rpm);
                HardDrive_.price = double.Parse(price);
                HardDrive_.isSSD = isSSD.Key == ConsoleKey.Y ? true : false;
                HardDrive1[i] = HardDrive_;
            }
            foreach (HardDrive h in HardDrive1)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Данi про об'єкт {0}: ");
                Console.WriteLine("--------------------------------");

                Console.WriteLine("Виробник жорсткого диску: " + h.manufacturer);
                Console.WriteLine("Модель: " + h.model);
                Console.WriteLine("Обсяг жорсткого диска (у гiгабайтах): " + h.capacityGB.ToString());
                Console.WriteLine("Тип iнтерфейсу: " + h.interfacetype);
                Console.WriteLine("Кiлькiсть обертiв за хвилину: " + h.rpm.ToString());
                Console.WriteLine("Цiна: " + h.price.ToString("0.000"));
                Console.WriteLine(h.isSSD ? "Має жорсткий диск SSD" : "Немає жорсткого диску SSD");
            }
            Console.ReadKey();
        }
    } 
          
}
