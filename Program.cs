using System;

namespace Lesson_2_4
{
    internal class Program
    {
        static void Main()
        {
            ushort value;
            Console.WriteLine("Введите трехзначное число");
            try
            {
                value = (ushort)Convert.ToUInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Введено не корректное значение");
                throw;
            }

            if (value < 100 || value > 999)
            {
                Console.WriteLine("Введено не трехзначное число");
                return;
            }

            ushort firstNumber, midleNumber, lastNumber;

            firstNumber = (ushort)(value / 100);
            midleNumber = (ushort)(value / 10 % 10);
            lastNumber = (ushort)(value % 10);

            ushort result = (ushort)(lastNumber * 100 + midleNumber * 10 + firstNumber);

            Console.WriteLine(result);
        }
    }
}
