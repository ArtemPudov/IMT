using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndexMasBody;
using System;
namespace IndexMasBodyTest
{
    
    [TestClass]
    public class IndexMasBodyTest
    {
        [TestMethod]
        public void T_IMT()
        {
            double indexMB;
            double height = 1.7;
            double weight = 70;
            indexMB = Math.Round(weight / (height * height), 2);
            
            Assert.AreEqual(indexMB,24.22);

        }


        [TestMethod]
        public void T_to16()
        {
            double indexMB = 16;

            string s = IMT.IMT1(indexMB);

            Assert.AreEqual(s, "ИМТ = "+indexMB.ToString()+ " - выраженный дефицит массы тела.");

        }


        [TestMethod]
        public void T_to18_5()
        {
            double indexMB = 18.5;

            string s = IMT.IMT1(indexMB);

            Assert.AreEqual(s, "ИМТ = " + indexMB.ToString() + " - недостаточная (дефицит)масса тела. ");

        }

        [TestMethod]
        public void T_to24_99()
        {
            double indexMB = 24.99;

            string s = IMT.IMT1(indexMB);

            Assert.AreEqual(s, "ИМТ = " + indexMB.ToString() + " - норма ");

        }

        [TestMethod]
        public void T_to30()
        {
            double indexMB = 30;

            string s = IMT.IMT1(indexMB);

            Assert.AreEqual(s, "ИМТ = " + indexMB.ToString() + " - избыточная масса тела(предожирение) ");

        }

        [TestMethod]
        public void T_to35()
        {
            double indexMB = 35;

            string s = IMT.IMT1(indexMB);

            Assert.AreEqual(s, "ИМТ = " + indexMB.ToString() + " - ожирение первой степени ");

        }

        public void T_to40()
        {
            double indexMB = 40;

            string s = IMT.IMT1(indexMB);

            Assert.AreEqual(s, "ИМТ = " + indexMB.ToString() + " - ожирение второй степени ");

        }
        public void T_from40()
        {
            double indexMB = 41;

            string s = IMT.IMT1(indexMB);

            Assert.AreEqual(s, "ИМТ = " + indexMB.ToString() + " - ожирение третьей степени(морбидное) ");

        }

    }
}
