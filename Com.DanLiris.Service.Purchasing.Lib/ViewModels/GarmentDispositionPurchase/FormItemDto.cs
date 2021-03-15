﻿using Com.DanLiris.Service.Purchasing.Lib.Models.GarmentDispositionPurchaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.GarmentDispositionPurchase
{
    public class FormItemDto
    {
        public int Id { get; set; }
        public string EPONo { get; set; }
        public int EPOId { get; set; }
        public bool IsUseVat { get; set; }
        public double VatValue { get; set; }
        public bool IsUseIncomeTax { get; set; }
        public double IncomeTaxValue { get; set; }
        public string IncomeTaxName { get; set; }
        public double IncomeTaxRate { get; set; }
        public int IncomeTaxId { get; set; }
        public int CurrencyId { get; set; }
        public double CurrencyRate { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsDispositionCreated { get; set; }
        public bool IsDispositionPaid { get; set; }
        public int GarmentDispositionPurchaseId { get; set; }
        public double DispositionAmountPaid { get; set; }
        public double DispositionAmountCreated { get; set; }
        public double DispositionQuantityCreated { get; set; }
        public double DispositionQuantityPaid { get; set; }
        public List<FormDetailDto> Details { get; set; }
    }
}
