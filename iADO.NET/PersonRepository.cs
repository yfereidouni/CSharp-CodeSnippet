using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    public class PersonRepository
    {
        private readonly SqlConnection _connection = new SqlConnection("Server=.;Database=ISBN;Integrated Security=True;");

        public PersonRepository()
        {

        }

        public int CreatePerson(string firstname, string lastname, DateTime birthdate, string shsh)
        {
            _connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Person] SELECT @FirstName, @LastName, @BirthDate, @ShSh", _connection);
            SqlParameter firstnameparam = new SqlParameter("@FirstName", firstname);
            SqlParameter lastnameparam = new SqlParameter("@LastName", lastname);
            SqlParameter birthdateparam = new SqlParameter("@BirthDate", birthdate);
            SqlParameter shshparam = new SqlParameter("@ShSh", shsh);

            command.Parameters.Add(firstnameparam);
            command.Parameters.Add(lastnameparam);
            command.Parameters.Add(birthdateparam);
            command.Parameters.Add(shshparam);

            int count = command.ExecuteNonQuery();

            _connection.Close();

            return count;
        }

        public List<Person> ReadAllPersons()
        {
            List<Person> InnerList = new List<Person>();

            _connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Person]", _connection);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Person pr = new Person
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Name = reader["Name"].ToString(),
                    Family = reader["Family"].ToString(),
                    BirthDate = DateTime.Parse(reader["BirthDate"].ToString()),
                    ShSh = reader["BirthDate"].ToString(),
                };
                InnerList.Add(pr);
            }


            _connection.Close();
            return InnerList;
        }
    }

}
