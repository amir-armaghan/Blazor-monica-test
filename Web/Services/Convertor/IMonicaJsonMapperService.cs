﻿using Models.MonicaData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services.Convertor
{
    public interface IMonicaJsonMapperService
    {
        List<MonicaBaseData> Map(StreamReader data);
    }
}
