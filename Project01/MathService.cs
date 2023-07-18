using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class MathService
    {
        //Quest02
        public bool IsInsideInterval(int numberMin, int numberMax, int numberInput)
        {
            bool result = (numberInput > numberMin) && (numberInput < numberMax);
            return result;
        }
        //Quest03
        public int GetCathetus(int numberMin, int numberMax)
        {
            int result = numberMax - numberMin;
            return result;
        }
        public double GetHypotenuse(double sideOne, double sideTwo)
        {
            double resOne = (sideOne) * (sideOne) + (sideTwo) * (sideTwo);
            double resTwo = Math.Sqrt(resOne);
            return resTwo;
        }
        //Quest04
            public bool IsEven(int number)
        {
            int resultOne = number % 2;
            bool resuktTwo = resultOne == 0;
            return resuktTwo;
        }
        //Quest05
        public double GetDegrees(double c)
        {
            double f = 1.8 * c + 32;
            return f;
        }
        //Quest07
        public int GetArea(int length, int width)
        {
            int result = length * width;
            return result;
        }
        //Quest08
        public int GetCapacity(int length, int width, int height)
        {
            int result = length * width * height;
            return result;
        }
        //Quest10
        public string Swap(ref int numberOne, ref int numberTwo)
        {
            int numberIntermediate = numberOne;
            numberOne = numberTwo;
            numberTwo = numberIntermediate;
            string result = $"{numberOne} {numberTwo}";
            return result;
        }
        //Quest11
        public int GetMaxNumberOfTwo(int numOne, int numTwo)
        {
            if (numOne >= numTwo)
            {
                int numMin = numTwo;
                numTwo = numOne;
                numOne = numMin;
            }
            int numMax = numTwo;
            return numMax;
        }
        //Quest13
        public int GetMinNumberOfTwo(int numOne, int numTwo)
        {
            if (numOne <= numTwo)
            {
                int numMax = numTwo;
                numTwo = numOne;
                numOne = numMax;
            }
            int numMin = numTwo;
            return numMin;
        }
        //Quest18
        public int PerformOperation(int numberOne, int numberTwo, Operation operation)
        {
            int resultFin = 0;
            if (operation == (Operation)1)
            {
                int resultInt = numberOne + numberTwo;
                resultFin = resultInt;
            }
            if (operation == (Operation)2)
            {
                int resultInt = numberOne * numberTwo;
                resultFin = resultInt;
            }
            if (operation == (Operation)3)
            {
                int resultInt = numberOne / numberTwo;
                resultFin = resultInt;
            }
            if (operation == (Operation)4)
            {
                int resultInt = numberOne - numberTwo;
                resultFin = resultInt;
            }
            return resultFin;
        }
    }
}
