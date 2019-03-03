﻿using System;
using System.Collections.Generic;

namespace NLayerCore.ScaffoldDb.Models
{
    public partial class DimDate
    {
        public DimDate()
        {
            FactCallCenter = new HashSet<FactCallCenter>();
            FactCurrencyRate = new HashSet<FactCurrencyRate>();
            FactInternetSalesDueDateKeyNavigation = new HashSet<FactInternetSales>();
            FactInternetSalesOrderDateKeyNavigation = new HashSet<FactInternetSales>();
            FactInternetSalesShipDateKeyNavigation = new HashSet<FactInternetSales>();
            FactProductInventory = new HashSet<FactProductInventory>();
            FactResellerSalesDueDateKeyNavigation = new HashSet<FactResellerSales>();
            FactResellerSalesOrderDateKeyNavigation = new HashSet<FactResellerSales>();
            FactResellerSalesShipDateKeyNavigation = new HashSet<FactResellerSales>();
            FactResellerSalesXlCciDueDateKeyNavigation = new HashSet<FactResellerSalesXlCci>();
            FactResellerSalesXlCciOrderDateKeyNavigation = new HashSet<FactResellerSalesXlCci>();
            FactResellerSalesXlCciShipDateKeyNavigation = new HashSet<FactResellerSalesXlCci>();
            FactResellerSalesXlPageCompressedDueDateKeyNavigation = new HashSet<FactResellerSalesXlPageCompressed>();
            FactResellerSalesXlPageCompressedOrderDateKeyNavigation = new HashSet<FactResellerSalesXlPageCompressed>();
            FactResellerSalesXlPageCompressedShipDateKeyNavigation = new HashSet<FactResellerSalesXlPageCompressed>();
            FactSalesQuota = new HashSet<FactSalesQuota>();
            FactSurveyResponse = new HashSet<FactSurveyResponse>();
        }

        public int DateKey { get; set; }
        public DateTime FullDateAlternateKey { get; set; }
        public byte DayNumberOfWeek { get; set; }
        public string EnglishDayNameOfWeek { get; set; }
        public string SpanishDayNameOfWeek { get; set; }
        public string FrenchDayNameOfWeek { get; set; }
        public byte DayNumberOfMonth { get; set; }
        public short DayNumberOfYear { get; set; }
        public byte WeekNumberOfYear { get; set; }
        public string EnglishMonthName { get; set; }
        public string SpanishMonthName { get; set; }
        public string FrenchMonthName { get; set; }
        public byte MonthNumberOfYear { get; set; }
        public byte CalendarQuarter { get; set; }
        public short CalendarYear { get; set; }
        public byte CalendarSemester { get; set; }
        public byte FiscalQuarter { get; set; }
        public short FiscalYear { get; set; }
        public byte FiscalSemester { get; set; }

        public virtual ICollection<FactCallCenter> FactCallCenter { get; set; }
        public virtual ICollection<FactCurrencyRate> FactCurrencyRate { get; set; }
        public virtual ICollection<FactInternetSales> FactInternetSalesDueDateKeyNavigation { get; set; }
        public virtual ICollection<FactInternetSales> FactInternetSalesOrderDateKeyNavigation { get; set; }
        public virtual ICollection<FactInternetSales> FactInternetSalesShipDateKeyNavigation { get; set; }
        public virtual ICollection<FactProductInventory> FactProductInventory { get; set; }
        public virtual ICollection<FactResellerSales> FactResellerSalesDueDateKeyNavigation { get; set; }
        public virtual ICollection<FactResellerSales> FactResellerSalesOrderDateKeyNavigation { get; set; }
        public virtual ICollection<FactResellerSales> FactResellerSalesShipDateKeyNavigation { get; set; }
        public virtual ICollection<FactResellerSalesXlCci> FactResellerSalesXlCciDueDateKeyNavigation { get; set; }
        public virtual ICollection<FactResellerSalesXlCci> FactResellerSalesXlCciOrderDateKeyNavigation { get; set; }
        public virtual ICollection<FactResellerSalesXlCci> FactResellerSalesXlCciShipDateKeyNavigation { get; set; }
        public virtual ICollection<FactResellerSalesXlPageCompressed> FactResellerSalesXlPageCompressedDueDateKeyNavigation { get; set; }
        public virtual ICollection<FactResellerSalesXlPageCompressed> FactResellerSalesXlPageCompressedOrderDateKeyNavigation { get; set; }
        public virtual ICollection<FactResellerSalesXlPageCompressed> FactResellerSalesXlPageCompressedShipDateKeyNavigation { get; set; }
        public virtual ICollection<FactSalesQuota> FactSalesQuota { get; set; }
        public virtual ICollection<FactSurveyResponse> FactSurveyResponse { get; set; }
    }
}
