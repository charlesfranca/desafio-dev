﻿using ByCodersTec.StoreDataImporter.DocParserService.ViewModel;
using ByCodersTec.StoreDataImporter.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByCodersTec.StoreDataImporter.DocParserService.Message
{
    public class ParseDocLineRequest
    {
        public ParseDocLineViewModel DocLine { get; set; }
    }
}