using System;
using System.Collections.Generic;

namespace NLayerCore.ScaffoldDb.Models
{
    public partial class DimSalesTerritory
    {
        public DimSalesTerritory()
        {
            DimEmployee = new HashSet<DimEmployee>();
            DimGeography = new HashSet<DimGeography>();
            FactInternetSales = new HashSet<FactInternetSales>();
            FactResellerSales = new HashSet<FactResellerSales>();
            FactResellerSalesXlCci = new HashSet<FactResellerSalesXlCci>();
            FactResellerSalesXlPageCompressed = new HashSet<FactResellerSalesXlPageCompressed>();
        }

        public int SalesTerritoryKey { get; set; }
        public int? SalesTerritoryAlternateKey { get; set; }
        public string SalesTerritoryRegion { get; set; }
        public string SalesTerritoryCountry { get; set; }
        public string SalesTerritoryGroup { get; set; }
        public byte[] SalesTerritoryImage { get; set; }

        public virtual ICollection<DimEmployee> DimEmployee { get; set; }
        public virtual ICollection<DimGeography> DimGeography { get; set; }
        public virtual ICollection<FactInternetSales> FactInternetSales { get; set; }
        public virtual ICollection<FactResellerSales> FactResellerSales { get; set; }
        public virtual ICollection<FactResellerSalesXlCci> FactResellerSalesXlCci { get; set; }
        public virtual ICollection<FactResellerSalesXlPageCompressed> FactResellerSalesXlPageCompressed { get; set; }
    }
}
