using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3.NorthWindDataSetTableAdapters;
using System.Data;

namespace ClassLibrary3
{
   public class ClsProduct //開放類別給別的方案使用(public)
    {
        public DataTable GetProducts()
        {
            ProductsTableAdapter adapter = new NorthWindDataSetTableAdapters.ProductsTableAdapter();
            global::ClassLibrary3.NorthWindDataSet northwindDataSet1 = new NorthWindDataSet();
            adapter.Fill(northwindDataSet1.Products);

            return northwindDataSet1.Products;
        }
        
    }
}
