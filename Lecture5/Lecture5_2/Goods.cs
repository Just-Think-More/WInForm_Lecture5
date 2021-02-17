using System.Collections.Generic;

namespace Lecture5_2
{
    public class Goods
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public static List<Goods> GetGoods()
        {
            return new List<Goods>
            {
                new Goods()
                {
                    Name = "Graphics Card: GeForce RTX 2060",
                    Price = 749.99
                },
                new Goods()
                {
                    Name = "PROCESSOR: Intel Core i9-10900K",
                    Price = 150.00
                },
                new Goods()
                {
                    Name = "MOTHERBOARDS: GIGABYTE Z590I AORUS ULTRA LGA 1200",
                    Price = 302.15
                },
                new Goods()
                {
                    Name = "HARD DRIVES: Seagate BarraCuda ST2000DM008 2TB",
                    Price = 52.99
                }
            };
        }

        public override string ToString()
        {
            return Name;
        }
    }
}