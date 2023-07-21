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
        public void ClearTextFile(TextFile personOne)
        {
            personOne.description = "Description deleted";
            personOne.weight = 0;
        }
        //Quest21
        public void AddedTextFile(TextFile person, string meow)
        {
            person.description = $"{person.description} {meow}";
        }
    }
}
