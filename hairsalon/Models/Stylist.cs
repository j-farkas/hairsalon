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
    private int _level;
    private int _hair;
    private int _scissors;
    private string _scissorsName;

    public Stylist()
    {

    }

    public Stylist(string name, string description)
    {
      _name = name;
      _description = description;
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

    public int GetLevel()
    {
      return _level;
    }

    public void SetLevel(int level)
    {
      _level = level;
    }

    public int GetScissors()
    {
      return _scissors;
    }

    public void SetScissors(int scissors)
    {
      _scissors = scissors;
    }

    public void SetScissorsName(string scissorsName)
    {
      _scissorsName = scissorsName;
    }

    public void SetHair(int hair)
    {
      _hair = hair;
    }

    public int GetHair()
    {
      return _hair;
    }

    public string GetScissorsName()
    {
      return _scissorsName;
    }
    public int GetNextLevel()
    {
      return _level*_level*10;
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

        ret.SetName(rdr.GetString(1));
        ret.SetId(rdr.GetInt32(0));
        ret.SetDescription(rdr.GetString(2));
        ret.SetLevel(rdr.GetInt32(3));
        ret.SetHair(rdr.GetInt32(4));
        ret.SetScissors(rdr.GetInt32(5));
        ret.SetScissorsName(rdr.GetString(6));
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
        newItem.SetLevel(rdr.GetInt32(3));
        newItem.SetHair(rdr.GetInt32(4));
        newItem.SetScissors(rdr.GetInt32(5));
        newItem.SetScissorsName(rdr.GetString(6));
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

    public void Update(string field, string change)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"UPDATE `stylists` SET `"+field+"` = '"+change+"' WHERE `stylists`.`id` = "+_id+";";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
    
    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO `stylists` (`name`, `description`,`level`,`hair`,`scissors`,`scissors_name`) VALUES ('"+_name+"','"+_description+"',"+_level+","+_hair+","+_scissors+",'"+_scissorsName+"');";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
  }
}
