using System.Collections.Generic;
using System;
using MySqlConnector;

namespace AnimalShelter.Models
{
  public class Types
  {
    public int TypesId { get; set; }
    public string Description { get; set; }
    // public int AnimalId { get; set; }
    // public string Name { get; set;}
    // public string Breed { get; set; }
    // public string Date { get; set; }

    // public Types(string description, int id)
    // {
    //   Description = description;
    //   TypesId = id;
    // }

//     public static List<Types> GetAll()
//     {
//       List<Types> allTypes = new List<Types> { };
      
//       MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
//       conn.Open();

//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = "SELECT * From types;";

//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       while (rdr.Read())
//       {
//         int typesId = rdr.GetInt32(0);
//         string typesDescription = rdr.GetString(1);
//         Types newTypes = new Types(typesDescription, typesId);
//         allTypes.Add(newTypes);
//       }
//       conn.Close();
//       if (conn != null)
//       {
//         conn.Dispose();
//       }
//       return allTypes;
//     }

  }
}