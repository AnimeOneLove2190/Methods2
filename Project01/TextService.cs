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
    }
}
