using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProj
{
  public class Book : IEquatable<Book>, IComparable<Book>
  {
    public string Author { get; set; }
    public string Title { get; set; }
    public int PageCount { get; set; }
    public int Cost { get; set; }

    public Book(string author = "Leo Tolstoy", string title = "War and peace", int pageCount = 1274, int cost = 40)
    {
      Author = author;
      Title = title;
      PageCount = pageCount;
      Cost = cost;
    }

    public int CompareTo(Book other)
    {
      return Cost.CompareTo(other.Cost);
    }

    public int CompareTo(Book other, IComparer<Book> comparer)
    {
      return comparer.Compare(this, other);
    }

    public bool Equals(Book other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;

      return (Author == other.Author && Title == other.Title && PageCount == other.PageCount);
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;

      if (obj.GetType() == typeof(Book)) return Equals((Book)obj);
      return false;
    }

    public override int GetHashCode()
    {
      return 555 * Author.GetHashCode() + 55 * Title.GetHashCode() + 5 * PageCount + Cost;
    }

    public override string ToString()
    {
      return string.Format("Book: {0}; Author: {1}; {2} pages; Cost {3:c}", Title, Author, PageCount, Cost);
    }
  }

  public class AuthorComparer : IComparer<Book>
  {
    public int Compare(Book x, Book y)
    {
      return x.Author.CompareTo(y.Author);
    }
  }

  public class TitleComparer : IComparer<Book>
  {
    public int Compare(Book x, Book y)
    {
      return x.Title.CompareTo(y.Title);
    }
  }

  public class PageCountComparer : IComparer<Book>
  {
    public int Compare(Book x, Book y)
    {
      return x.PageCount.CompareTo(y.PageCount);
    }
  }
}
