using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
  public class Stylist
  {
    private string _name;
    private int _id;
    private string _description;

    public Stylist()
    {

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

    public void SetDescription(string description)
    {
      _description = description;
    }

    public string GetDescription()
    {
      return _description;
    }

    public static Stylist Find(int check)
    {
      Stylist ret = new Stylist();
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM stylists where id = "+check+";";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      rdr.Read();
      if(rdr.IsDBNull(0) == false)
      {
        ret.SetId(rdr.GetInt32(0));
        ret.SetName(rdr.GetString(1));
        ret.SetDescription(rdr.GetString(2));
      }

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return ret;
    }

    public static List<Stylist> GetAll()
    {
      List<Stylist> allItems = new List<Stylist> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM stylists;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        Stylist newItem = new Stylist();
        newItem.SetName(rdr.GetString(1));
        newItem.SetId(rdr.GetInt32(0));
        newItem.SetDescription(rdr.GetString(2));
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
      cmd.CommandText = @"DELETE FROM stylists;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
       conn.Dispose();
      }
    }

    // public static List<Client> GetClients(int check)
    // {
    //
    //   int num = int.Parse(cuisine);
    //   List<Client> allItems = new List<Client> {};
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM `restaurant` WHERE `primarycuisine` = "+num+" or `secondarycuisine` = "+num+";";
    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   while(rdr.Read())
    //   {
    //     Client newItem = new Client();
    //     newItem.SetName(rdr.GetString(1));
    //     newItem.SetId(rdr.GetInt32(0));
    //     newItem.SetDescription(rdr.GetString(2));
    //     newItem.SetPrimaryKey(rdr.GetInt32(3));
    //     if(rdr.IsDBNull(4) == false)
    //     {
    //       newItem.SetSecondaryKey(rdr.GetInt32(4));
    //     }
    //       allItems.Add(newItem);
    //   }
    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    //   return allItems;
    // }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO `stylists` (`name`, `description`) VALUES ('"+_name+"','"+_description+"');";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
  }
}
