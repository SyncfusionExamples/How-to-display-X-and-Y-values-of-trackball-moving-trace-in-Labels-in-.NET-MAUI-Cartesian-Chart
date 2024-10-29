using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayTrackballValues
{
    public class ViewModel
    {
        public ObservableCollection<Model> ProductSalesDetails { get; set; }

        public ViewModel()
        {
            ProductSalesDetails = new ObservableCollection<Model>();

            ProductSalesDetails.Add(new Model() { ProductASales = 5,  ProductBSales = 5,  ProductCSales = 5,  Date = new DateTime(2001, 01, 05) });
            ProductSalesDetails.Add(new Model() { ProductASales = 10, ProductBSales = 15, ProductCSales = 13, Date = new DateTime(2001, 03, 06) });
            ProductSalesDetails.Add(new Model() { ProductASales = 15, ProductBSales = 20, ProductCSales = 25, Date = new DateTime(2001, 05, 07) });
            ProductSalesDetails.Add(new Model() { ProductASales = 10, ProductBSales = 15, ProductCSales = 20, Date = new DateTime(2001, 07, 08) });
            ProductSalesDetails.Add(new Model() { ProductASales = 25, ProductBSales = 20, ProductCSales = 35, Date = new DateTime(2001, 09, 09) });
            ProductSalesDetails.Add(new Model() { ProductASales = 35, ProductBSales = 40, ProductCSales = 50, Date = new DateTime(2001, 11, 10) });

        }
    }
}
