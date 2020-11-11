using System;

namespace IndexMasBody
{
    class Program
    {
        static void Main(string[] args)
        {
            double indexMB;
            double height;
            double weight;
            
            try
            {
                //определяем вес 
                Console.WriteLine("Введите вес ");
                weight = double.Parse(Console.ReadLine());
                while (weight <= 0)
                {
                    Console.WriteLine("Введите коректный вес");
                    weight = float.Parse(Console.ReadLine());
                }

                //определяем рост
                Console.WriteLine("Введите рост в см ");
                height = double.Parse(Console.ReadLine());
                while (height <= 0)
                {
                    Console.WriteLine("Введите коректный рост");
                    height = double.Parse(Console.ReadLine());
                }

                //переводим рост в метры 
                height /= 100;

                //вычисляем ИМТ
                indexMB = weight / (height * height);
                indexMB = Math.Round(indexMB, 2);

                //Для простой проверки условий
                //indexMB = float.Parse(Console.ReadLine());


                IMT(indexMB);
            }
            catch
            {
                Console.WriteLine("Зачем вы вводите не числа?");
            }



        }

        //Метод для определения вывода по ИМТ 
        public static void IMT(double indexMB)
        {
             if (indexMB <= 16)
                {
                    Console.WriteLine("ИМТ = {0} - выраженный дефицит массы тела.", indexMB);
                }
                else if (indexMB <= 18.5)
                {
                    Console.WriteLine("ИМТ = {0} - недостаточная (дефицит)масса тела. ", indexMB);
                }
                else if (indexMB <= 24.99)
                {
                    Console.WriteLine("ИМТ = {0} - норма ", indexMB);
                }
                else if (indexMB <= 30)
                {
                    Console.WriteLine("ИМТ = {0} - избыточная масса тела(предожирение) ", indexMB);
                }
                else if (indexMB <= 35)
                {
                    Console.WriteLine("ИМТ = {0} - ожирение первой степени ", indexMB);
                }
                else if (indexMB <= 40)
                {
                    Console.WriteLine("ИМТ = {0} - ожирение второй степени ", indexMB);
                }
                else
                {
                    Console.WriteLine("ИМТ = {0} - ожирение третьей степени(морбидное) ", indexMB);
                }
           
        }
    }
}
