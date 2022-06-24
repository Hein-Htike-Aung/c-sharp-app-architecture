using ArchitectureLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using ArchitectureLibrary.Configuration;
using System.Data;
using ArchitectureLibrary.Enumeration;

namespace ArchitectureLibrary.Service.Implementation
{
    public class PersonServiceImpl : PersonService
    {
        public Person Create(Person person)
        {

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(GlobalConfig.ConnectionStringName)))
            {
                var dp = new DynamicParameters();
                dp.Add("@Person_Name", person.Name);
                dp.Add("@Phone", person.Phone);
                dp.Add("@Email", person.Email);
                dp.Add("@GPA", person.GPA);
                dp.Add("@Asset", person.Asset);
                dp.Add("@Active", person.Active);
                dp.Add("@DOB", person.DOB);
                dp.Add("@Gender", person.Gender.ToString());
                dp.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPerson_Insert", dp, commandType: CommandType.StoredProcedure);

                person.Id = dp.Get<int>("@Id");
            }

            return person;
        }
    }
}
