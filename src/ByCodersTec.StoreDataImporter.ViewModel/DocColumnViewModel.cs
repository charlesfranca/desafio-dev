﻿using ByCodersTec.StoreDataImporter.Domain;

namespace ByCodersTec.StoreDataImporter.ViewModel
{
    public enum DocDefinitionColumnTypeEnumViewModel
    {
        String,
        Int,
        Decimal,
        Boolean,
        DateTime
    }
    public class DocColumnViewModel : IParseDocColumn
    {
        public string Name { get; set; }
        public string ClassPropName { get; set; }
        public DocDefinitionColumnTypeEnumViewModel Type { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public string Description { get; set; }
        public string ValidationPattern { get; set; }
        public bool IsValid { get; set; }
        public int Length { get; set; }
    }
}