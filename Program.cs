using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Data Source=SRV2\\PUPILS;Initial Catalog=328300538_Shop;Integrated Security=True";
            CategoryDataAccess cda = new CategoryDataAccess();
            ProductDataAccess pda = new ProductDataAccess();
            pda.InsertData(connectionString);
        }
    }
}
