using System;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using Dapper;
using Program.Models;


namespace HelloWorld
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

      IDbConnection dbConnection = new SqlConnection(connectionString);

      string SqlCommand = "SELECT GETDATE()";

      DateTime rightNow = dbConnection.QuerySingle<DateTime>(SqlCommand);

      var test = "God natt";

      Console.WriteLine(rightNow + " Great work buddy!!!!!" +"   " +test);

    }

  }
}