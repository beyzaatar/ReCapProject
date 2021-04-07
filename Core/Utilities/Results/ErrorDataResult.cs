using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //çalıştığımız T'nin default versiyonu. data ya karşılık gelir.
        //örneğin default tipi int tir.ama bir şey döndürmek istemiyoruz intin defaultu geçsin deriz.
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
