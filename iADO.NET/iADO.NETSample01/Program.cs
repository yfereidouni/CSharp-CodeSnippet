using iADO.NETSample01;
using Microsoft.Data.SqlClient;
using System.Data;

SQLSample sqlSample = new SQLSample();

//sqlSample.FirstSample();

//sqlSample.WorkingWithConnection();

//sqlSample.ConnectionBuilder();

//sqlSample.TestCommand();

//sqlSample.TestReader();

//sqlSample.TestReaderMultiple();

//sqlSample.AddProduct(1, "Motorolla", 120);

//sqlSample.AddProductWithParameters(1, "Noki K10", 150);

//sqlSample.AddTransactional("NewCategory".PadLeft(100,'-'), 1, "Samsong NOTE 20", 100);

//sqlSample.BulkInsert();

sqlSample.SqlBulkCopy();

