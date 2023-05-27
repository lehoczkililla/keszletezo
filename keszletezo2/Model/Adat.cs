using System;

namespace keszletezo.Model
{
    public struct Adat
    {
        public String bvin { get; set; }
        public String ProductBvin { get; set; }
        public String VariantId { get; set; }
        public int QuantityOnHand { get; set; }
        public int QuantityReserved { get; set; }
        public int QuantityAvailableForSale { get; set; }
        public int LowStockPoint { get; set; }
        public DateTime LastUpdated { get; set; }
        public long StoreId { get; set; }
        public int OutOfStockPoint { get; set; }
        public String ProductName { get; set; }

    }
}
