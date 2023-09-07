using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace LR18._2
{
    internal class Program
    {
    static double koren(double a)
    {
        return Math.Sqrt(Math.Pow(a, 2));
    }
        static double pow(double a)
        {
            return Math.Pow(a, 2);
        }
        static double korenrizn(double a,double b)
        {
            return Math.Sqrt(Math.Pow((a - b),2));
        }
        static double powrizn(double a, double b)
        {
            return Math.Pow((a - b), 2);
        }
        static void Main(string[] args)
        {
            double Ax, Ay, Bx, By, Cx, Cy, Dx, Dy;
            Console.WriteLine("Введіть координати точки А:");
            while (!double.TryParse(Console.ReadLine(), out Ax))
            {
                Console.WriteLine("Некоректний ввід. Введіть координату ще раз:");
            }
            while (!double.TryParse(Console.ReadLine(), out Ay))
            {
                Console.WriteLine("Некоректний ввід. Введіть координату ще раз:");
            }

            Console.WriteLine("Введіть координати точки B:");
            while (!double.TryParse(Console.ReadLine(), out Bx))
            {
                Console.WriteLine("Некоректний ввід. Введіть координату ще раз:");
            }
            while (!double.TryParse(Console.ReadLine(), out By))
            {
                Console.WriteLine("Некоректний ввід. Введіть координату ще раз:");
            }

            Console.WriteLine("Введіть координати точки C:");
            while (!double.TryParse(Console.ReadLine(), out Cx))
            {
                Console.WriteLine("Некоректний ввід. Введіть координату ще раз:");
            }
            while (!double.TryParse(Console.ReadLine(), out Cy))
            {
                Console.WriteLine("Некоректний ввід. Введіть координату ще раз:");
            }

            Console.WriteLine("Введіть координати точки D:");
            while (!double.TryParse(Console.ReadLine(), out Dx))
            {
                Console.WriteLine("Некоректний ввід. Введіть координату ще раз:");
            }
            while (!double.TryParse(Console.ReadLine(), out Dy))
            {
                Console.WriteLine("Некоректний ввід. Введіть координату ще раз:");
            }
            double AO = koren(Ax) + pow(Ay);
            double AC = korenrizn(Ax,Cx) + powrizn(Ay,Cy);
            double OC = koren(Cx) + pow(Cy);
            double perACO = AO + AC + OC;
        
        

            double BO = koren(Bx) + pow(By);
            double BD = korenrizn(Bx,Dx) + powrizn(By,Dy);
            double OD = koren(Dx) + pow(Dy);
            double perBOD = BO + BD + OD;

           
            double riz = Math.Abs(perACO - perBOD);

            
            MessageBox.Show("Різниця периметрів трикутників АОС і ВОD: " + riz);
        }
    }
}
