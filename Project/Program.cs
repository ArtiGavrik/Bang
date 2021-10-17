using System;
using Gavrilov;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите параметры: ");
                float a = Int32.Parse(Console.ReadLine());
                float b = Int32.Parse(Console.ReadLine());
                float c = Int32.Parse(Console.ReadLine());
                GavrilovLog.I().Log($"Введено уравнение: {a}x^2 + {b}x + {c} = 0");
                Kvad Yow = new Kvad();
                GavrilovLog.I().Log("Корни уравнения " + String.Join("; ", Yow.Solve(a, b, c)));
            }
            catch (GavrilovException ex)
            {
                GavrilovLog.I().Log(ex.Message);
            }
            GavrilovLog.I().Write();
        }
    }
}