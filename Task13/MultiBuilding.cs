using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class MultiBuilding:Build
    {
        int floor;

        public MultiBuilding(string address, double lenght, double widht, double height, int floor)
            : base(address, lenght, widht, height)
        {
            this.floor = floor;
        }
        int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < 0)
                    floor = Math.Abs(value);
                else
                    floor = value;

            }
        }
        private string Print()
        {
            string result = base.Print();
            result += $" {Floor}";
            return result;
        }
    }
}
