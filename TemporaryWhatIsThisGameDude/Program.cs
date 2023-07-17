using System;

namespace TemporaryWhatIsThisGameDude
{
    class Program
    {
        static void Main(string[] args)
        {
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
