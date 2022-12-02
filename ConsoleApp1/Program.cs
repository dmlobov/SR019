using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Code = "A001", Brand = "Acer", Processor = "Intel Core", Freqproc = 1.1, RAM = 4, HardDisk = 256, VideoMemory = 4, Price = 12000, Quantity =3},
                new Computer(){Code = "A002", Brand = "Asus", Processor = "Intel Celeron", Freqproc = 1.1, RAM = 8, HardDisk = 512, VideoMemory = 8, Price = 25000, Quantity =20},
                new Computer(){Code = "A003", Brand = "HP", Processor = "AMD Ryzen", Freqproc = 3.5, RAM = 8, HardDisk = 512, VideoMemory = 4, Price = 40000, Quantity =15},
                new Computer(){Code = "A004", Brand = "MSI", Processor = "Intel Core", Freqproc = 4.1, RAM = 8, HardDisk = 256, VideoMemory = 8, Price = 60000, Quantity =0},
                new Computer(){Code = "A005", Brand = "Acer", Processor = "Intel Core", Freqproc = 4.1, RAM = 4, HardDisk = 512, VideoMemory = 4, Price = 78000, Quantity =35},
                new Computer(){Code = "A006", Brand = "Acer", Processor = "AMD Ryzen", Freqproc = 1.1, RAM = 4, HardDisk = 512, VideoMemory = 8, Price = 96000, Quantity =5},
                new Computer(){Code = "A007", Brand = "HP", Processor = "AMD Ryzen", Freqproc = 3.5, RAM = 8, HardDisk = 256, VideoMemory = 4, Price = 45000, Quantity =14},
                new Computer(){Code = "A008", Brand = "NSI", Processor = "Intel Celeron", Freqproc = 3.5, RAM = 8, HardDisk = 256, VideoMemory = 8, Price = 80000, Quantity =17},
                new Computer(){Code = "A009", Brand = "Asus", Processor = "Intel Celeron", Freqproc = 1.1, RAM = 4, HardDisk = 512, VideoMemory = 4, Price = 90000, Quantity =13},
                new Computer(){Code = "A010", Brand = "Acer", Processor = "Intel Core", Freqproc = 4.1, RAM = 4, HardDisk = 256, VideoMemory = 8, Price = 120000, Quantity =25},
            };

            Console.WriteLine("Введите тип процессора");
            string processor = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.Processor == processor).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем оперативной памяти");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.RAM >= ram).ToList();
            Print(computers2);

            Console.WriteLine("Список компьютеров по увеличению стоимости");
            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

            Console.WriteLine("Группировка компьютера по типу процессора");
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.Processor);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer e in gr)
                {
                    Console.WriteLine($"{e.Code}  {e.Brand}  {e.Processor}  {e.Freqproc}  {e.RAM}  {e.HardDisk}  {e.VideoMemory}  {e.Price}  {e.Quantity}");
                }
            }

            Console.WriteLine("Самый бюджетный компьютер");
            Computer computers5 = computers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computers5.Code}  {computers5.Brand}  {computers5.Processor}  {computers5.Freqproc}  {computers5.RAM}  {computers5.HardDisk}  {computers5.VideoMemory}  {computers5.Price}  {computers5.Quantity}");

            Console.WriteLine("Самый дорогой компьютер");
            Computer computers6 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computers6.Code}  {computers6.Brand}  {computers6.Processor}  {computers6.Freqproc}  {computers6.RAM}  {computers6.HardDisk}  {computers6.VideoMemory}  {computers6.Price}  {computers6.Quantity}");

            Console.WriteLine("Наличие модели компьютера в количестве более n шт");
            Console.WriteLine("Введите количество компьютеров");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(computers.Any(x => x.Quantity > n));

            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"{e.Code}  {e.Brand}  {e.Processor}  {e.Freqproc}  {e.RAM}  {e.HardDisk}  {e.VideoMemory}  {e.Price}  {e.Quantity}");
            }
        }
    }
}
