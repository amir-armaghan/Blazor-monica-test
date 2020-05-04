using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Application.Convertor
{
    public interface IMonicaOutputMapper<T>
    {
        T Convert(StreamReader data);
    }
}
