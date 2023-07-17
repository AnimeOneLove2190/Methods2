using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class PersonService
    {
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
    }
}
