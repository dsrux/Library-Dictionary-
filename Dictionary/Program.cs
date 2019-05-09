using System;
using Dictionary.Models;

namespace Dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Library");
      Library myLibrary = new Library("Darren's Reading Place!", "People of Boise", "Boise");
      System.Console.WriteLine(myLibrary.Name);
      Book hp = new Book("Harry Potter", "JKR");
      Book lotr = new Book("The Hobbit", "Tolken");
      Book narnia = new Book("Narnia", "CS Lewis", false);
      myLibrary.AddBook(hp);
      myLibrary.AddBook(lotr);
      myLibrary.AddBook(narnia);

      bool inLibrary = true;
      myLibrary.Greeting();
      while (inLibrary)
      {
        Console.ReadLine();
        Console.Clear();
        bool stayInLibrary = myLibrary.PrintDirectory();
        if (!stayInLibrary)
        {
          inLibrary = false;
          System.Console.WriteLine("Goodbye");
        }

      }







    }
  }
}
