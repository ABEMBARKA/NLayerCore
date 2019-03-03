using System;
using System.Collections.Generic;

namespace NLayerCore.ScaffoldDb.Models
{
    public partial class FactAdditionalInternationalProductDescription
    {
        public int ProductKey { get; set; }
        public string CultureName { get; set; }
        public string ProductDescription { get; set; }
    }
}
