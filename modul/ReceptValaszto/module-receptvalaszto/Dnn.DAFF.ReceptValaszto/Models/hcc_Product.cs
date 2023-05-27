using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Models
{

    [TableName("hcc_Product")]
    [PrimaryKey(nameof(Id), AutoIncrement = true)]
    [Scope("ModuleId")]
    public class hcc_Product
    {
        public int Id { get; set; }
        public Guid bvin { get; set; }
        public string SKU { get; set; }
        public Guid ProductTypeId { get; set; }
        public decimal ListPrice { get; set; }
        public decimal SitePrice { get; set; }
        public decimal SiteCost { get; set; }
        public int TaxEempt { get; set; }
        public string TaxClass { get; set; }
        public int NonShipping { get; set; }
        public int ShipSeparately { get; set; }
        public int ShippingMode { get; set; }
        public decimal ShippingWeight { get; set; }
        public decimal ShippingLength { get; set; }
        public decimal ShippingWidth { get; set; }
        public decimal ShippingHeight { get; set; }
        public int Status { get; set; }
        public string ImageFileSmall { get; set; }
        public string ImageFileMedium { get; set; }
        public DateTime CreationDate { get; set; }
        public int MinimumQty { get; set; }
        public Guid ManufacturerID { get; set; }
        public Guid VendorID { get; set; }
        public int GiftWrapAllowed { get; set; }
        public decimal ExtraShipFee { get; set; }
        public DateTime LastUpdated { get; set; }
        public string TemplateName { get; set; }
        public string PreContentColumnId { get; set; }
        public string PostContentColumnId { get; set; }
        public string RewriteUrl { get; set; }
        public string CustomProperties { get; set; }
        public decimal GiftWrapPrice { get; set; }
        public Int64 StoreId { get; set; }
        public Boolean Featured { get; set; }
        public Boolean AllowReviews { get; set; }
        public int OutOfStockMode { get; set; }
        public Boolean IsAvailableForSale { get; set; }
        public Boolean IsUserPrice { get; set; }
        public Boolean HideQty { get; set; }
        public Boolean IsSearchable { get; set; }
        public Boolean IsBundle { get; set; }
        public Boolean IsGiftCard { get; set; }
        public Boolean IsRecurring { get; set; }
        public int RecurringInterval { get; set; }
        public int RecurringIntervalType { get; set; }
        public int ShippingCharge { get; set; }

    }
}