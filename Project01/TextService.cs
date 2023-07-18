using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TextService
    {
        //Quest01
        public string GetGreetings(string nameOne)
        {
            string helloOne = $"Привет, {nameOne}!";
            return helloOne;
        }
        //Quest06
        public string GetAddress(string city, string street, string house, string apart)
        {
            string result = $"Город {city}, улица {street}, дом {house}, квартира {apart}";
            return result;
        }
        //Quest19
        public TextFile ConnectedTextFile(TextFile personOne, TextFile personTwo)
        {
            TextFile connectedTextFile = new TextFile
            {
                name = $"{personOne.name}. {personTwo.name}",
                description = $"{personOne.description} {personTwo.description}",
                weight = personOne.weight + personTwo.weight,
            };
            return connectedTextFile;
        }
        //Quest20
        public void DeletedTextFile(TextFile personOne)
        {
            TextFile deleteTextFile = new TextFile
            {
                name = personOne.name,
                description = "Description deleted",
                weight = 0
            };
            Console.WriteLine(deleteTextFile.name);
            Console.WriteLine(deleteTextFile.description);
            Console.WriteLine(deleteTextFile.weight);
        }
        //Quest21
        public void AddedTextFile(TextFile person, string meow)
        {
            TextFile addedTextFile = new TextFile
            {
                description = $"{person.description} {meow}"
            };
            Console.WriteLine(addedTextFile.description);
        }
    }
}
