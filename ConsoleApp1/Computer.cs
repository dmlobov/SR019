using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer
    {
        public string Code { get; set; } // Код Компьютерв
        public string Brand { get; set; }  // Марка компьютера
        public string Processor { get; set; }  // Тип процессора
        public double Freqproc { get; set; }  // Частота работы процессора
        public int RAM { get; set; }  // Объем оперативной памяти
        public int HardDisk { get; set; }  // Объем жесткого диска
        public int VideoMemory { get; set; }  // Объем памяти видеокарты
        public double Price { get; set; }  // стоимость компьютера
        public int Quantity { get; set; }  // кол-во экземпляров в наличие
    }
}
