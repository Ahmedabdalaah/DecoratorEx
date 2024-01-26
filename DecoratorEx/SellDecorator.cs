using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorEx
{
    internal abstract class SellDecorator : ProductSell
    {
        protected ProductSell notificationPro;
        public void setProduct(ProductSell service)
        {
            notificationPro = service;
        }
        public override string SellProduct(string custom_Id, string product_Name)
        {
            if(notificationPro != null)
            {
                return notificationPro.SellProduct(custom_Id, product_Name);
            }
            else
            {
                return " Error : notification is not intilized";
            }
        }
    }
    }

