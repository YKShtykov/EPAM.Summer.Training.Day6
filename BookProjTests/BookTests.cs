using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookProj;
using System.Diagnostics;

namespace BookProjTests
{
  [TestClass]
  public class BookTests
  {
    public Book[] arr;
    public Book[] sortedByCostArr;
    public Book[] sortedByTitleArr;
    public Book[] sortedByPageCountArr;

    [TestInitialize]
    public void Init()
    {
      Book warAndPeace = new Book();
      Book goldenBook = new Book("Midas", "Golden Book", 500, 1000000);
      arr = new Book[] { goldenBook, warAndPeace };
      sortedByTitleArr = new Book[] { goldenBook, warAndPeace };
      sortedByCostArr = new Book[] { warAndPeace, goldenBook };
      sortedByPageCountArr = new Book[] { goldenBook, warAndPeace };
    }

    [TestMethod]
    public void InterfaceSort()
    {
      //Arrange 
      foreach (var item in arr)
      {
        Debug.WriteLine(item.ToString());
      }
      //Act
      Array.Sort(arr);

      foreach (var item in arr)
      {
        Debug.WriteLine(item.ToString());
      }

      //Assert
      CollectionAssert.AreEqual(arr, sortedByCostArr);
    }

    [TestMethod]
    public void SortTest()
    {
      //Arrange 
      PageCountComparer comparer = new PageCountComparer();
      foreach (var item in arr)
      {
        Debug.WriteLine(item.ToString());
      }
      //Act
      Array.Sort(arr, comparer);

      foreach (var item in arr)
      {
        Debug.WriteLine(item.ToString());
      }

      //Assert
      CollectionAssert.AreEqual(arr, sortedByPageCountArr);
    }

    [TestMethod]
    public void TitleSortTest()
    {
      //Arrange 
      TitleComparer comparer = new TitleComparer();
      foreach (var item in arr)
      {
        Debug.WriteLine(item.ToString());
      }
      //Act
      Array.Sort(arr, comparer);

      foreach (var item in arr)
      {
        Debug.WriteLine(item.ToString());
      }

      //Assert
      CollectionAssert.AreEqual(arr, sortedByTitleArr);
    }
  }
}




