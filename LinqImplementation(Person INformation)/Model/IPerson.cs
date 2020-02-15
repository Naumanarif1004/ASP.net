using Enumeration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
         int Age { get; set; }
       bool IsAdult { get; set; }
      PersonType personType { get; set; }
    }
}
