using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_01._11._22г
{
    public class College
    {
        public College(string name, string training, byte quantity)
        {
            this.Name = name;
            this.Training = training;
            this.Quantity = quantity;
        }
        public College() { }
        public string Name { get; set; }
        public string Training { get; set; }
        public byte Quantity { get; set; }

        public string Display()
        {
            return $"Группа: {Name}. Форма обучения: {Training}. Количество учащихся: {Quantity}";
        }

        public virtual void study()
        {
            Console.WriteLine("");
        }
    }
}
