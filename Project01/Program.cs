using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quest01
            TextService service = new TextService();
            string inputNameOne = Console.ReadLine();
            string resultOne = service.GetGreetings(inputNameOne);
            Console.WriteLine(resultOne);
            //Quest02
            MathService serviceOne = new MathService();
            bool result = serviceOne.IsInsideInterval(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
            //Quest03
            Point pointOne = new Point();
            pointOne.x = int.Parse(Console.ReadLine());
            pointOne.y = int.Parse(Console.ReadLine());
            Point pointTwo = new Point();
            pointTwo.x = int.Parse(Console.ReadLine());
            pointTwo.y = int.Parse(Console.ReadLine());
            int CatheusX = 0;
            int CatheusY = 0;
            if (pointOne.x > pointTwo.x)
            {
                MathService serviceCat = new MathService();
                int resultBl = serviceCat.GetCathetus(pointTwo.y, pointOne.x);
                CatheusX = resultBl;
            }
            if (pointOne.x < pointTwo.x)
            {
                MathService serviceCat = new MathService();
                int resultBl = serviceCat.GetCathetus(pointOne.x, pointTwo.y);
                CatheusX = resultBl;
            }
            if (pointOne.y > pointTwo.y)
            {
                MathService serviceCat = new MathService();
                int resultBl = serviceCat.GetCathetus(pointTwo.y, pointOne.x);
                CatheusY = resultBl;
            }
            if (pointOne.y < pointTwo.y)
            {
                MathService serviceCat = new MathService();
                int resultBl = serviceCat.GetCathetus(pointOne.x, pointTwo.y);
                CatheusY = resultBl;
            }
            MathService serviceHyp = new MathService();
            double Hypotenuse = serviceHyp.GetHypotenuse(CatheusX, CatheusY);
            Console.WriteLine(Hypotenuse);
            //Quest04
            int numberOne = int.Parse(Console.ReadLine());
            MathService serviceThree = new MathService();
            bool resultThree = serviceThree.IsEven(numberOne);
            Console.WriteLine(resultThree);
            //Quest05
            double inputC = double.Parse(Console.ReadLine());
            MathService serviceFour = new MathService();
            double outputF = serviceFour.GetDegrees(inputC);
            Console.WriteLine(outputF);
            //Quest06
            string inputCity = Console.ReadLine();
            string inputStreet = Console.ReadLine();
            string inputHouse = Console.ReadLine();
            string inputApart = Console.ReadLine();
            TextService serviceFive = new TextService();
            string output = serviceFive.GetAddress(inputCity, inputStreet, inputHouse, inputApart);
            Console.WriteLine(output);
            //Quest07
            int inputWidth = int.Parse(Console.ReadLine());
            int inputLength = int.Parse(Console.ReadLine());
            MathService serviceSix = new MathService();
            int resultFour = serviceSix.GetArea(inputLength, inputWidth);
            Console.WriteLine(resultFour);
            //Quest08
            int inputWidthOne = int.Parse(Console.ReadLine());
            int inputLengthOne = int.Parse(Console.ReadLine());
            int inputHeight = int.Parse(Console.ReadLine());
            MathService serviceSeven = new MathService();
            int resultFive = serviceSeven.GetCapacity(inputLengthOne, inputWidthOne, inputHeight);
            Console.WriteLine(resultFive);
            //Quest09
            int inputMinutes = int.Parse(Console.ReadLine());
            CalendarService serviceEight = new CalendarService();
            int resultSix = serviceEight.GetHoursInMinutes(inputMinutes);
            Console.WriteLine(resultSix);
            //Quest10
            int inputNumberOne = int.Parse(Console.ReadLine());
            int inputNumberTwo = int.Parse(Console.ReadLine());
            MathService serviceNine = new MathService();
            string resultSeven = serviceNine.Swap(ref inputNumberOne, ref inputNumberTwo);
            Console.WriteLine(result);
            //Quest11
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            MathService serviceMaxNumOfTwo = new MathService();
            int numMax = serviceMaxNumOfTwo.GetMaxNumberOfTwo(numOne, numTwo);
            Console.WriteLine(numMax);
            //Quest13
            int inputMinNumOne = int.Parse(Console.ReadLine());
            int inputMinNumTwo = int.Parse(Console.ReadLine());
            MathService serviceMinNumOfTwo = new MathService();
            int numMin = serviceMinNumOfTwo.GetMaxNumberOfTwo(inputMinNumOne, inputMinNumTwo);
            Console.WriteLine(numMin);
            //Quest15
            int numOfMonth = int.Parse(Console.ReadLine());
            CalendarService serviceNameOfSeason = new CalendarService();
            string nameOfSeason = serviceNameOfSeason.GetSeason(numOfMonth);
            Console.WriteLine(nameOfSeason);
            //Quest16
            PersonInfo misatoInfo = new PersonInfo();
            misatoInfo.name = "Misato Katsuragi";
            misatoInfo.floor = "Female";
            PersonInfo asunaInfo = new PersonInfo();
            asunaInfo.name = "Yuuki Asuna";
            asunaInfo.floor = "Female";
            PersonParams misatoParams = new PersonParams();
            misatoParams.age = 29;
            misatoParams.weight = 47;
            misatoParams.height = 163;
            PersonParams asunaParams = new PersonParams();
            asunaParams.age = 19;
            asunaParams.weight = 54;
            asunaParams.height = 168;
            PersonFullInfo personFullInfoMisato = new PersonFullInfo();
            PersonService personServiceSetInfo = new PersonService();
            personFullInfoMisato = personServiceSetInfo.SetPersonFullInfo(misatoInfo.name, misatoInfo.floor, misatoParams.age, misatoParams.weight, misatoParams.height, personFullInfoMisato);
            Console.WriteLine(personFullInfoMisato.name);
            Console.WriteLine(personFullInfoMisato.floor);
            Console.WriteLine(personFullInfoMisato.age);
            Console.WriteLine(personFullInfoMisato.weight);
            Console.WriteLine(personFullInfoMisato.height);
            PersonFullInfo personFullInfoAsuna = new PersonFullInfo();
            personFullInfoAsuna = personServiceSetInfo.SetPersonFullInfo(asunaInfo.name, asunaInfo.floor, asunaParams.age, asunaParams.weight, asunaParams.height, personFullInfoAsuna);
            Console.WriteLine(personFullInfoAsuna.name);
            Console.WriteLine(personFullInfoAsuna.floor);
            Console.WriteLine(personFullInfoAsuna.age);
            Console.WriteLine(personFullInfoAsuna.weight);
            Console.WriteLine(personFullInfoAsuna.height);
        }
    }
}
