using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
    }

    public StylistTest()
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

  //  [TestMethod]
  //   public void GetAll_CategoriesNotEmptyAt_List()
  //   {
  //     //Arrange, Act
  //     int result = Category.GetAll().Count;
  //
  //     //Assert
  //     Assert.AreEqual(0, result);
  //   }
  // }


}
