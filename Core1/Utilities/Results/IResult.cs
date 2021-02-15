using System;
using System.Collections.Generic;
using System.Text;

namespace Core1.Utilities.Results
{
    //Temel void fonksiyonları için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
