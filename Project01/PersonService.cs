using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class PersonService
    {
        //Quest16
        public PersonFullInfo SetPersonFullInfo(string name, string floor, int age, int weight, int height, PersonFullInfo personFullInfo)
        {
            PersonFullInfo personFullInfoSer = new PersonFullInfo();
            personFullInfoSer.name = name;
            personFullInfoSer.floor = floor;
            personFullInfoSer.age = age;
            personFullInfoSer.weight = weight;
            personFullInfoSer.height = height;
            personFullInfo = personFullInfoSer;
            return personFullInfo;
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
            PersonParams maxAgePersonS = new PersonParams();
            if (waifuOne.age > waifuTwo.age)
            {
                maxAgePersonS = waifuOne;
            }
            if (waifuOne.age < waifuTwo.age)
            {
                maxAgePersonS = waifuTwo;
            }
            if (waifuOne.age == waifuTwo.age)
            {
                Console.WriteLine("У них одинаковые возраста, я хз чо делать");
            }
            return maxAgePersonS;
        }
        public void WriteParams(PersonParams waifuWithMaxAge)
        {
            Console.WriteLine(waifuWithMaxAge.age);
            Console.WriteLine(waifuWithMaxAge.weight);
            Console.WriteLine(waifuWithMaxAge.height);
        }
    }
}
