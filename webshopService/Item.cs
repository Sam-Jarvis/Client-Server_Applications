using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace webshopService
{
    [DataContract]
    public class Item
    {
        public Item(string ProductId, string ProductInfo, string Price, string Stock, string OnSale)
        {
            this.ProductId = ProductId;
            this.ProductInfo = ProductInfo;
            this.Price = Price;
            this.Stock = Stock;
            this.OnSale = OnSale;
        }

        [DataMember]
        public string ProductId { get; set; }

        public string ProductInfo { get; set; }

        [DataMember]
        public string Price { get; set; }

        [DataMember]
        public string Stock { get; set; }

        public string OnSale { get; set; }
    }
}
