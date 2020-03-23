using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      bool inLibrary = true;
      Book endersGame = new Book("Ender's Game", "Orson S. Card");
      Library Levi = new Library("303 W Pennwood", "Levi's Public Library");
      Levi.AddBook(endersGame);
      Levi.AddBook(new Book("Can't Hurt Me", "David Goggins"));
      Levi.AddBook(new Book("Times of Contempt", "Andrzej Aapkowski"));
      Console.WriteLine($"Welcome to {Levi.Name} located at {Levi.Location}.\n Available Books: ");
      while (inLibrary)
      {
        Levi.PrintBooks();
        Console.WriteLine("Please select a book number to checkout, (Q)uit, or (R)eturn a book");
        string selection = Console.ReadLine().ToLower();
        if (selection == "q")
        {
          inLibrary = false;
        }
        else if (selection == "r")
        {
          Levi.ReturnBook(selection);
        }
        else
          Levi.Checkout(selection);
      }
    }
  }
}
