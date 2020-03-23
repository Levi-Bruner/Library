using System;
using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    //Properties
    public string Location { get; set; }
    public string Name { get; set; }
    private List<Book> Books { get; set; }
    public List<Book> CheckedOut { get; set; }
    //Methods
    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }
    public void Checkout(string selection)
    {
      Book selectedBook = ValidateBook(selection, Books);
      {
        if (selectedBook == null)
        {
          Console.Clear();
          System.Console.WriteLine(@"Invalid Selection");
          return;
        }
        selectedBook.Available = false;
        CheckedOut.Add(selectedBook);
        Books.Remove(selectedBook);
        Console.WriteLine("Successfully checked out.");
      }
    }
    public void ReturnBook(string selection)
    {
      Book selectedBook = ValidateBook(selection, CheckedOut);
      {
        if (selectedBook == null)
        {
          Console.Clear();
          System.Console.WriteLine(@"Invalid Selection");
          return;
        }
        selectedBook.Available = true;
        CheckedOut.Remove(selectedBook);
        Books.Add(selectedBook);
        Console.Clear();
        Console.WriteLine("Successfully returned a book!");
      }
    }
    private Book ValidateBook(string selection, List<Book> booklist)
    {
      int bookIndex = 0;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 1 || bookIndex > booklist.Count)
      {
        return null;
      }
      return booklist[bookIndex - 1];
    }
    //Constructor
    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book>();
      CheckedOut = new List<Book>();
    }

  }
}