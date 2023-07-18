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
            PersonParams misatoParamsOne = new PersonParams();
            misatoParamsOne.age = 29;
            misatoParamsOne.weight = 47;
            misatoParamsOne.height = 163;
            PersonParams asunaParamsOne = new PersonParams();
            asunaParamsOne.age = 19;
            asunaParamsOne.weight = 54;
            asunaParamsOne.height = 168;
            PersonFullInfo personFullInfoMisato = new PersonFullInfo();
            PersonService personServiceSetInfo = new PersonService();
            personFullInfoMisato = personServiceSetInfo.SetPersonFullInfo(misatoInfo.name, misatoInfo.floor, misatoParamsOne.age, misatoParamsOne.weight, misatoParamsOne.height, personFullInfoMisato);
            PersonService writeService = new PersonService();
            writeService.WritePerson(personFullInfoMisato);
            PersonFullInfo personFullInfoAsuna = new PersonFullInfo();
            personFullInfoAsuna = personServiceSetInfo.SetPersonFullInfo(asunaInfo.name, asunaInfo.floor, asunaParamsOne.age, asunaParamsOne.weight, asunaParamsOne.height, personFullInfoAsuna);
            writeService.WritePerson(personFullInfoAsuna);
            //Quest17
            PersonParams misatoParamsTwo = new PersonParams();
            misatoParamsTwo.age = 29;
            misatoParamsTwo.weight = 47;
            misatoParamsTwo.height = 163;
            PersonParams asunaParamsTwo = new PersonParams();
            asunaParamsTwo.age = 19;
            asunaParamsTwo.weight = 54;
            asunaParamsTwo.height = 168;
            PersonService checkMaxAge = new PersonService();
            PersonParams personWithMaxAge = checkMaxAge.CheckMaxAge(misatoParamsTwo, asunaParamsTwo);
            PersonService wrritePersonWithMaxAge = new PersonService();
            wrritePersonWithMaxAge.WriteParams(personWithMaxAge);
        }
    }
}
