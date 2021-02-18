using System;
using System.Collections.Generic;
using System.Xml;

namespace Lecture5_2
{
    public class Goods
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Specifications { get; set; }
        
        public static List<Goods> GetGoods()
        {
            return new List<Goods>
            {
                new Goods()
                {
                    Type = "Graphics Card",
                    Name = "GeForce RTX 2060",
                    Price = 5680.99,
                    Description = "Some description",
                    Specifications = "Графический чип: GeForce GTX 1050 Ti\n"+ Environment.NewLine +
                                     "Интерфейс: PCI Express x16 3.0\n"+ Environment.NewLine +
                                     "Макс. частота ядра: 1430 МГц\n"+ Environment.NewLine +
                                     "Кол-во шейдерных процессоров: 768\n"+ Environment.NewLine +
                                     "Техпроцесс: 14 нм\n"+ Environment.NewLine +
                                     "Объём памяти: 4 ГБ\n"+ Environment.NewLine +
                                     "Тип памяти: GDDR5\n"
                },
                new Goods()
                {
                    Type = "Processor",
                    Name = "AMD Ryzen 5 3600",
                    Price = 6539.0,
                    Description = "Some description",
                    Specifications = "Серия: AMD Ryzen 5" + Environment.NewLine +
                                    "Модель: Ryzen 5 3600" + Environment.NewLine +
                                    "Сокет: AM4" + Environment.NewLine +
                                    "Микроархитектура: Zen 2" + Environment.NewLine +
                                    "Ядро: Matisse" + Environment.NewLine +
                                    "Техпроцесс: 7 нм" + Environment.NewLine +
                                    "Количество ядер: 6"
                },
                new Goods()
                {
                    Type = "Motherboard",
                    Name = "MSI B450 Tomahawk Max",
                    Price = 2789.0,
                    Description = "Some description",
                    Specifications = "Форм-фактор: ATX"+ Environment.NewLine +
                                     "Модель: B450 Tomahawk Max"+ Environment.NewLine +
                                     "Тип разъёма для процессора: AM4"+ Environment.NewLine +
                                     "Поддержка процессоров: 1-е, 2-е и 3-е поколение AMD Ryzen, Athlon"+ Environment.NewLine +
                                     "Чипсет: AMD B450"+ Environment.NewLine +
                                     "Поддерживаемые типы памяти: DIMM DDR4"+ Environment.NewLine +
                                     "Количество слотов памяти: 4"
                },
                new Goods()
                {
                    Type = "Hard Driver",
                    Name = "Seagate BarraCuda ST2000DM008 2TB",
                    Price = 1451.99,
                    Description = "Some description",
                    Specifications = "Форм-фактор: 3.5"+ Environment.NewLine +
                                     "Ёмкость накопителя: 1 ТБ"+ Environment.NewLine +
                                     "Интерфейc: SATA"+ Environment.NewLine +
                                     "Пропускная способность интерфейса: 6 Гбит/с"+ Environment.NewLine +
                                     "Объём буфера: 64 МБ"+ Environment.NewLine +
                                     "Скорость вращения шпинделя: 5900 об/мин."+ Environment.NewLine +
                                     "Максимальный уровень шума: 23 дБ"
                }
            };
        }

        public override string ToString()
        {
            return $"{Type}: {Name}";
        }
    }
}