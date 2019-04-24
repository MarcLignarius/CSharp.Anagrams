using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {

    public void Dispose()
    {
      //Act
      Word.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      //Arrange
      Word newItem = new Word("test");


      //Assert
      Assert.AreEqual(true, Word.IsAnagram("boo","boot"));
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Items()
    {
      //Arrange
      Word newItem = new Word("test");

      //Assert
      Assert.AreEqual(false, Word.IsAnagram("boo","ilhafd"));
    }

    [TestMethod]
    public void ItemConstructor_NotCreatesInstanceOfItem_Items()
    {
      //Arrange
      Word newItem = new Word("test");

      //Assert
      Assert.AreEqual(false, Word.IsAnagram("boot","bottle"));
    }

    [TestMethod]
    public void ItemConstructor_NotCreatesInssatanceOfItem_Items()
    {
      //Arrange
      Word newItem = new Word("test");

      //Assert
      Assert.AreEqual(true, Word.IsAnagram("boot","toob"));
    }

  }
}
