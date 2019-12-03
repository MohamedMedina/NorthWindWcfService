using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWcfService
{
    class DALProducts
    {

       public  List<Product> GetProducts() {

            SqlConnection con = new SqlConnection("Data Source =\\.EGCA1-0098; Initial Catalog = Northwind; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("select ProductID ,ProductName,UnitPrice from Products",con);
            if (con.State == System.Data.ConnectionState.Closed)

                con.Open();
            var reader = cmd.ExecuteReader();

            List<Product> pds = new List<Product>();
            while (reader.Read())
            {

                Product p = new Product()
                {

                    ProductID = Convert.ToInt32(reader["ProductID"]),
                    
                    ProductName = reader["ProductName"].ToString(),
                    Price = Convert.ToInt32(reader["UnitPrice"])





                };
                pds.Add(p);
            }
            return pds;
                    
        }
    }
}
