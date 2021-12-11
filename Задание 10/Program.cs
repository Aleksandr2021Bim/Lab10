using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую инженер! \nвведите угол и переведите его в радианы");
            Console.WriteLine("Введите значение угла в градусах");
            double gradus = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение угла в минутах");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение угла в секундах");
            double sec = double.Parse(Console.ReadLine());

            Corner corner = new Corner(gradus, min, sec);

            Console.WriteLine("Значение угла в радианах" + corner.ToRadians());
            Console.ReadKey();
        }



        public class Corner
        {
            double gradus;
            double min;
            double sec;

            public double Gradus
            {
                get
                {
                    return gradus;
                }
                set
                {
                    if (value >= 0 && value < 360)
                    {
                        gradus = value;
                    }
                    else
                        gradus = 0;
                }
            }

            public double Min
            {
                get
                {
                    return min;
                }
                set
                {
                    if (value >= 0 && value < 60)
                    {
                        min = value;
                    }
                    else
                        min = 0;
                }
            }


            public double Sec
            {
                get
                {
                    return sec;
                }
                set
                {
                    if (value >= 0 && value < 60)
                    {
                        sec = value;
                    }
                    else
                        sec = 0;
                }
            }

        }

        public double ToRadian()
        {
            var radians = (Gradus + Min / 60 + Sec / 3600) * (Math.PI) / 180;
            return radians;
        }
    }
  




    
    
