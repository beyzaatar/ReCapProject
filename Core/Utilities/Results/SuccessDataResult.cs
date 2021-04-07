using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
        public SuccessDataResult(T data):base(data,true)
        {

        }
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        //çalıştığımız T'nin default versiyonu. data ya karşılık gelir.
        //örneğin default tipi int tir.ama bir şey döndürmek istemiyoruz intin defaultu geçsin deriz.
        public SuccessDataResult():base(default,true) 
        {

        }
    }
}
