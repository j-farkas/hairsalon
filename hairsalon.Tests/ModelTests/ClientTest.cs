using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest : IDisposable
  {

    public void Dispose()
    {
      Client.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=jared_farkas_test;";
    }

  [TestMethod]
   public void GetAll_CategoriesEmptyAtFirst_List()
   {
     //Arrange, Act
     int result = Stylist.GetAll().Count;

     //Assert
     Assert.AreEqual(0, result);
   }

   [TestMethod]
    public void GetAll_CategoriesNotEmpty_List()
    {
      //Arrange, Act
      Client test = new Client("Test",1);
      test.Save();
      int result = Client.GetAll().Count;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}
