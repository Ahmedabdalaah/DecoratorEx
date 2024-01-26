using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx
{
    internal class SellNotification : SellDecorator
    {
        public string SetNotification(string custom_id, string product_name)
        {
            return $"{custom_id} sell {product_name} in {DateTime.Now}";
        }
        public override string SellProduct(string custom_Id, string product_Name)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.SellProduct(custom_Id, product_Name));
            sb.AppendLine(SetNotification(custom_Id, product_Name));
            return sb.ToString();
        }
    }
}
