using System.Collections.Generic;

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
                    Specifications = "Графический чип:	GeForce GTX 1050 Ti"+
                                     "Интерфейс:	PCI Express x16 3.0"+
                                     "Макс. частота ядра: 1430 МГц"+
                                     "Кол-во шейдерных процессоров: 768"+
                                     "Техпроцесс: 14 нм"+
                                     "Объём памяти: 4 ГБ"+
                                     "Тип памяти: GDDR5"
                },
                new Goods()
                {
                    Type = "Processor",
                    Name = "AMD Ryzen 5 3600",
                    Price = 6539.0,
                    Description = "Some description",
                    Specifications = "Серия: AMD Ryzen 5" +
                                    "Модель: Ryzen 5 3600" +
                                    "Сокет: AM4" +
                                    "Микроархитектура: Zen 2" +
                                    "Ядро: Matisse" +
                                    "Техпроцесс: 7 нм" +
                                    "Количество ядер: 6"
                },
                new Goods()
                {
                    Type = "Motherboard",
                    Name = "MSI B450 Tomahawk Max",
                    Price = 2789.0,
                    Description = "Some description",
                    Specifications = "Форм-фактор: ATX"+
                                     "Модель: B450 Tomahawk Max"+
                                     "Тип разъёма для процессора: AM4"+
                                     "Поддержка процессоров:	1-е, 2-е и 3-е поколение AMD Ryzen, Athlon"+
                                     "Чипсет: AMD B450"+
                                     "Поддерживаемые типы памяти: DIMM DDR4"+
                                     "Количество слотов памяти:	4"
                },
                new Goods()
                {
                    Type = "Hard Driver",
                    Name = "Seagate BarraCuda ST2000DM008 2TB",
                    Price = 1451.99,
                    Description = "Some description",
                    Specifications = "Форм-фактор: 3.5"+
                                     "Ёмкость накопителя: 1 ТБ"+
                                     "Интерфейc: SATA"+
                                     "Пропускная способность интерфейса: 6 Гбит/с"+
                                     "Объём буфера: 64 МБ"+
                                     "Скорость вращения шпинделя: 5900 об/мин."+
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