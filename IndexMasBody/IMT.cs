using System;
using System.Collections.Generic;
using System.Text;

namespace IndexMasBody
{
    public class IMT
    {
        public static string IMT1(double indexMB)
        {
            string s;
            if (indexMB <= 16)
            {
                s = "ИМТ = "+indexMB.ToString()+" - выраженный дефицит массы тела.";
            }
            else if (indexMB <= 18.5)
            {
                s = "ИМТ = " + indexMB.ToString() + " - недостаточная (дефицит)масса тела. ";
            }
            else if (indexMB <= 24.99)
            {
                s = "ИМТ = " + indexMB.ToString() + " - норма ";
            }
            else if (indexMB <= 30)
            {
                s = "ИМТ = " + indexMB.ToString() + " - избыточная масса тела(предожирение) ";
            }
            else if (indexMB <= 35)
            {
                s = "ИМТ = " + indexMB.ToString() + " - ожирение первой степени ";
            }
            else if (indexMB <= 40)
            {
                s = "ИМТ = " + indexMB.ToString() + " - ожирение второй степени ";
            }
            else
            {
                s = "ИМТ = " + indexMB.ToString() + " - ожирение третьей степени(морбидное) ";
            }

            return s;

        }
    }
}
