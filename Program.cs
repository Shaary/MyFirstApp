using MyFirstApp.Core;
using MyFirstApp.Data;
using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter schema name: ");
            var schema = Console.ReadLine();
            Console.WriteLine("Enter stored procedure name: ");
            var procName = Console.ReadLine();

            var repository = new Repository(schema, procName);

            var parametersNames = repository.ParametersNamesGet();
            var parametersData = repository.ParametersDataGet(parametersNames);

            var query = new StoredProcQuery(procName, parametersNames, parametersData);

            Console.WriteLine(query);
        }

    }
}
