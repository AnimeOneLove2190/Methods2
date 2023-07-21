using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class PersonService
    {
        //Quest16
        public PersonFullInfo GetPersonFullInfo(PersonInfo waifuInfo, PersonParams waifuParams)
        {
            PersonFullInfo personFullInfoSer = new PersonFullInfo();
            personFullInfoSer.name = waifuInfo.name;
            personFullInfoSer.floor = waifuInfo.floor;
            personFullInfoSer.age = waifuParams.age;
            personFullInfoSer.weight = waifuParams.weight;
            personFullInfoSer.height = waifuParams.height;
            return personFullInfoSer;
        }
        public void WritePerson(PersonFullInfo personFullInfo)
        {
            Console.WriteLine(personFullInfo.name);
            Console.WriteLine(personFullInfo.floor);
            Console.WriteLine(personFullInfo.age);
            Console.WriteLine(personFullInfo.weight);
            Console.WriteLine(personFullInfo.height);
        }
        //Quest17
        public PersonParams CheckMaxAge(PersonParams waifuOne, PersonParams waifuTwo)
        {
            if (waifuOne.age > waifuTwo.age)
            {
                return waifuOne;
            }
            return waifuTwo;
        }
        public void WriteParams(PersonParams waifuWithMaxAge)
        {
            Console.WriteLine(waifuWithMaxAge.age);
            Console.WriteLine(waifuWithMaxAge.weight);
            Console.WriteLine(waifuWithMaxAge.height);
        }
    }
}
