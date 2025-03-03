﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.NewIntegrationViewModel
{
    public class GarmentLeftoverWarehouseExpenditureFabricViewModel
    {
        public int Id { get; set; }
        public string ExpenditureNo { get; set; }
        public DateTimeOffset? ExpenditureDate { get; set; }
        public string ExpenditureDestination { get; set; }
        public UnitViewModel UnitExpenditure { get; set; }
        public BuyerViewModel Buyer { get; set; }
        public string EtcRemark { get; set; }
        public string Remark { get; set; }
        public string LocalSalesNoteNo { get; set; }
        public int LocalSalesNoteId { get; set; }
        public double QtyKG { get; set; }
        public bool IsUsed { get; set; }

        public List<GarmentLeftoverWarehouseExpenditureFabricItemViewModel> Items { get; set; }
    }

    public class GarmentLeftoverWarehouseExpenditureFabricItemViewModel
    {
        public int Id { get; set; }
        public int StockId { get; set; }

        public UnitViewModel Unit { get; set; }

        public string PONo { get; set; }

        public double Quantity { get; set; }

        public UomViewModel Uom { get; set; }
        public double BasicPrice { get; set; }
    }
}
