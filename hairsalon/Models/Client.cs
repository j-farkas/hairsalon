using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    private string _name;
    private int _id;
    private int _stylist;

    public Client()
    {

    }

    public Client(string name, int stylist)
    {
      _name = name;
      _stylist = stylist;
    }

    public int GetId()
    {
      return _id;
    }

    public void SetId(int id)
    {
      _id = id;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public void SetStylist(int stylist)
    {
      _stylist = stylist;
    }

    public int GetStylist()
    {
      return _stylist;
    }

    public static Client Find(int check)
    {
      Client ret = new Client();
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM clients where id = "+check+";";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      rdr.Read();
      if(rdr.IsDBNull(0) == false)
      {
        ret.SetId(rdr.GetInt32(0));
        ret.SetName(rdr.GetString(1));
        ret.SetStylist(rdr.GetInt32(2));
      }

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return ret;
    }

    public static List<Client> GetAll()
    {
      List<Client> allItems = new List<Client> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM clients;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        Client newItem = new Client();
        newItem.SetName(rdr.GetString(1));
        newItem.SetId(rdr.GetInt32(0));
        newItem.SetStylist(rdr.GetInt32(2));
        allItems.Add(newItem);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allItems;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM clients;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
       conn.Dispose();
      }
    }

    public static List<Client> GetClients(int num)
    {

      List<Client> allItems = new List<Client> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM `clients` WHERE `stylist` = "+num+";";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        Client newClient = new Client();
        newClient.SetName(rdr.GetString(1));
        newClient.SetId(rdr.GetInt32(0));
        newClient.SetStylist(rdr.GetInt32(2));
        allItems.Add(newClient);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allItems;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO `clients` (`name`, `stylist`) VALUES ('"+_name+"','"+_stylist+"');";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public void Update(string field, string change)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"UPDATE `clients` SET `"+field+"` = '"+change+"' WHERE `clients`.`id` = "+_id+";";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
  }
}
