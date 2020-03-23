using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Book endersGame = new Book("Ender's Game", "Orson S. Card");
      Library Levi = new Library("303 W Pennwood", "Levi's Public Library");
      Levi.AddBook(endersGame);
      Levi.AddBook(new Book("Can't Hurt Me", "David Goggins"));
      Levi.AddBook(new Book("Times of Contempt", "Andrzej Aapkowski"));
      Console.WriteLine($"Welcome to {Levi.Name} located at {Levi.Location}.\n Available Books: ");
      Levi.PrintBooks();
      Console.WriteLine("Please select a book number to checkout, (Q)uit, or (R)eturn a book");
      string selection = Console.ReadLine();
      Levi.Checkout(selection);
    }
  }
}
