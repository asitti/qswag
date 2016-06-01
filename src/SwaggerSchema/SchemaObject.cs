﻿using System;
using System.Collections.Generic;

namespace SwaggerSchema
{
    public class SchemaObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public object Default { get; set; }
        public double? MultipleOf { get; set; }
        public double? Maximum { get; set; }
        public bool ExclusiveMaximum { get; set; }
        public double? Minimum { get; set; }
        public bool ExclusiveMinimum { get; set; }
        public long? MaxLength { get; set; }
        public long? MinLength { get; set; }
        public string Pattern { get; set; }
        public long? MaxItems { get; set; }
        public long? MinItems { get; set; }
        public bool UniqueItems { get; set; }
        public long? MaxProperties { get; set; }
        public long? MinProperties { get; set; }
        public IList<string> Required { get; set; }
        public IList<object> Enum { get; set; }
        public string Items { get; set; }
        public string AllOf { get; set; }
        public string Properties { get; set; }
        public string AdditionalProperties { get; set; }
        public Uri Id { get; set; }
    }
}