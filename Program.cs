using Microsoft.Data.SqlClient;
using MyFirstApp.Core;
using MyFirstApp.Data;
using System;
using System.Data;
using Dapper;
using System.Linq;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=AmazingDb; Integrated Security=True;";

            //Console.WriteLine("Enter schema name: ");
            //var schema = Console.ReadLine();
            //Console.WriteLine("Enter stored procedure name: ");
            //var procName = Console.ReadLine();

            var repository = new Repository(connectionString, "fs", "usp_AccessTypesGet");



            var parameters = repository.ParametersNamesGet();

            //foreach (string param in parameters)
            //{
            //    Console.WriteLine(param);
            //}

            repository.ParametersDataGet(parameters);




            //Test methods
            //IDbConnection db = new SqlConnection(connectionString);
            //var data = db.Query("select * from fs.AccessTypes").ToList();

            //var parametersNames = repository.ParametersNamesGet();
            //var parametersData = repository.ParametersDataGet(parametersNames);

            //var query = new StoredProcQuery(procName, parametersNames, parametersData);

            //Console.WriteLine(query);
        }

    }
}
