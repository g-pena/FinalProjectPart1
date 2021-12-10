using System;
using System.Collections.Generic;


class Author : Person
{
  //Properties
  private List<Book> BookList = new List<Book>();
  

  //Constructors
  public Author() : base()
  {
   PermanentAddress = new Address();
   Console.WriteLine("Author constructor");
  }

  public Author(string fname, string lname) : base (fname, lname)
  {
    FirstName = fname;
    LastName = lname;
    PermanentAddress = new Address();
    //Console.WriteLine("Author constructor");
  }
  

  //Methods
  public void DisplayInfo()
  {
    Console.WriteLine("First Name: "+FirstName);
    Console.WriteLine("Last Name: "+LastName);
    Console.WriteLine("Email: "+Email);
  }

  public void DisplayBooks()
  {
    foreach(Book n in BookList)
    {
      Console.WriteLine("List of books {0} {1} {2}", n.Title);
    }
  }

 public void AddBook(Book b) 
  {
    Book n = new Book(b);
    BookList.Add(n);
    Console.WriteLine("Book was added successfully.");
  }
  
  public void RemoveBook(Book b)
  {
    Book n = BookList.Find(o=>o.ISBN == b.ISBN);
    BookList.Remove(b);
  }



} 