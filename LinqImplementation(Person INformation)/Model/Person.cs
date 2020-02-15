using Enumeration;
using System;

namespace Model
{
    public class Person:IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAdult { get; set; }
        public PersonType personType { get; set; }
        public override string ToString()
        {
            return $"Person Id   {Id} ---  Person Name  {Name}  ---   Person Age   {Age}  ----  IsAdult  {IsAdult} ----   Person Type   {personType}";
        }
    }
}
