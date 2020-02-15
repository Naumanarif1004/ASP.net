using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface ITransection
    {
        int AccountNO { get; set; }
        string Username { get; set; }
        int TransectionBalance { get; set; }
        DateTime TransectionDate { get; set; }
        AccountType Type { get; set; }
        TransectionType TType { get; set; }
        Guid TransectionId { get; set; }
        int AccountBalance { get; set; }
        string Email { get; set; }
        string Phon { get; set; }
    }
}
