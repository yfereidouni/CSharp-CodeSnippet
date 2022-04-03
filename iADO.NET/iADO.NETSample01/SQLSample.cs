using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iADO.NETSample01
{
    public class SQLSample
    {
        private SqlConnection connection;

        public SQLSample()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = "iADO.NETSample01";
            builder.DataSource = ".";
            builder.IntegratedSecurity = true;
            builder.Encrypt = false;
            //builder.UserID = "";
            //builder.Password = "";
            builder.CommandTimeout = 200;
            builder.ConnectTimeout = 100;

            connection = new(builder.ConnectionString);
        }

        public void FirstSample()
        {
            string ConnectionString = "Server=.;Initial catalog=iADO.NETSample01; Integrated Security=true;Encrypt=false;";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            Console.WriteLine(sqlConnection.State);

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Categories";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine($"Id: {reader.GetInt32(0)} | Name: {reader.GetString(1)}");
                Console.WriteLine($"Id: {reader["Id"]} | Name: {reader["CategoryName"]}");
            }

            sqlConnection.Close();
            Console.WriteLine(sqlConnection.State);
            Console.ReadKey();
        }

        public void WorkingWithConnection()
        {
            string ConnectionString = "Server=.;Initial catalog=iADO.NETSample01; Integrated Security=true;Encrypt=false;";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            Console.WriteLine($"Database: {sqlConnection.Database}");
            Console.WriteLine($"DataSource: {sqlConnection.DataSource}");
            Console.WriteLine($"CommandTimeout: {sqlConnection.CommandTimeout}");
            Console.WriteLine($"ConnectionTimeout: {sqlConnection.ConnectionTimeout}");

        }

        public void ConnectionBuilder()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = "iADO.NETSample01";
            builder.DataSource = ".";
            builder.IntegratedSecurity = true;
            builder.Encrypt = false;
            //builder.UserID = "";
            //builder.Password = "";
            builder.CommandTimeout = 200;
            builder.ConnectTimeout = 100;

            SqlConnection sqlConnection = new(builder.ConnectionString);

            Console.WriteLine($"Database: {sqlConnection.Database}");
            Console.WriteLine($"DataSource: {sqlConnection.DataSource}");
            Console.WriteLine($"CommandTimeout: {sqlConnection.CommandTimeout}");
            Console.WriteLine($"ConnectionTimeout: {sqlConnection.ConnectionTimeout}");
            Console.WriteLine($"Connection State: {sqlConnection.State}");
        }

        public void TestCommand()
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Categories"
            };

            connection.Open();

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine($"Id: {reader.GetInt32(0)} | Name: {reader.GetString(1)}");
                Console.WriteLine($"Id: {reader["Id"]} | Name: {reader["CategoryName"]}");
            }

            connection.Close();
        }

        public void TestReader()
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Categories"
            };

            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i));
                    Console.Write(" : ");
                    Console.Write(reader.GetValue(i));
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            connection.Close();
        }

        public void TestReaderMultiple()
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Categories; SELECT * FROM Products"
            };

            connection.Open();

            var reader = command.ExecuteReader();

            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i));
                        Console.Write(" : ");
                        Console.Write(reader.GetValue(i));
                        Console.Write("\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("".PadLeft(100, '-'));
            } while (reader.NextResult()); // With calling reader.NextResult(); automatically cursor indicate to next result-set

            connection.Close();
        }

        public void AddProduct(int categoryId, string productName, int price)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = $"INSERT INTO Products (CategoryId,ProductName,Price) Values({categoryId},'{productName}',{price})",
            };

            connection.Open();
            int result = command.ExecuteNonQuery();

            Console.WriteLine($"Affected row(s) is: {result}");
        }

        public void AddProductWithParameters(int categoryId, string productName, int price)
        {
            SqlParameter categoryIdParam = new SqlParameter()
            {
                ParameterName = "@CategoryId",
                DbType = DbType.Int32,
                Direction = ParameterDirection.Input,
                Value = categoryId
            };
            SqlParameter productNameParam = new SqlParameter()
            {
                ParameterName = "@ProductName",
                DbType = DbType.String,
                Direction = ParameterDirection.Input,
                Value = productName
            };
            SqlParameter priceParam = new SqlParameter()
            {
                ParameterName = "@Price",
                DbType = DbType.Int32,
                Direction = ParameterDirection.Input,
                Value = price
            };

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = $"INSERT INTO Products (CategoryId,ProductName,Price) Values(@CategoryId,@ProductName,@Price)",
            };
            command.Parameters.Add(categoryIdParam);
            command.Parameters.Add(productNameParam);
            command.Parameters.Add(priceParam);

            connection.Open();
            int result = command.ExecuteNonQuery();

            Console.WriteLine($"Affected row(s) is: {result}");
        }

        public void AddTransactional(string categoryName, int categoryId, string productName, int price)
        {
            SqlTransaction transaction = null;

            SqlCommand addCategory = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = $"INSERT INTO Categories (CategoryName) Values('{categoryName}')",
            };

            SqlCommand addProduct = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = $"INSERT INTO Products (CategoryId,ProductName,Price) Values({categoryId},'{productName}',{price})",
            };
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                int result = addCategory.ExecuteNonQuery();
                result += addProduct.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine($"Affected row(s) is: {result}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                transaction.Rollback();
            }

        }

        public void BulkInsert()
        {
            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
            };
            connection.Open();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                command.CommandText = $"INSERT INTO BulkTable (Name, [Desc]) Values ('Name {i}', 'Desc {i}')";
                command.ExecuteNonQuery();
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        public void SqlBulkCopy()
        {
            
            SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(connection);
            sqlBulkCopy.DestinationTableName = "BulkTable";
            connection.Open();
            Stopwatch stopwatch = Stopwatch.StartNew();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Desc"));
            for (int i = 0; i < 1000; i++)
            {
                dt.Rows.Add(new object[] { $"Name {i}, Desc {i}" });
            }
            sqlBulkCopy.WriteToServer(dt);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
