using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Build
    {
        string address;
        double length;
        double widht;
        double height;

        double Lenght
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                    length = Math.Abs(value);
                else
                    length = value;

            }
        }
        double Widht
        {
            get
            {
                return widht;
            }
            set
            {
                if (value < 0)
                    widht = Math.Abs(value);
                else
                    widht = value;

            }
        }
        double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = Math.Abs(value);
                else
                    height = value;

            }
        }

        public Build(string address, double lenght, double widht, double height)
        {
            this.address = address;
            this.Lenght = lenght;
            this.Widht = widht;
            this.Height = height;  
        }

        public string Print()
        {
            return $"{address} {length} {widht} {height}";
        }
    }
}
