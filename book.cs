using System;

class Book
{
  //Auto-Implemented Properties
  public string ISBN {get; set;}
  public string Title {get; set;}
  public DateTime PublishedOn {get; set;}
  public string PublishedBy {get; set;}

  
  public Author AuthorInfo {get; set;}

  public Book ()
  {
    AuthorInfo = new Author();
  }

  //Constructors
  public Book (string isbn, string title, Author AuthorInfo) : this (isbn, title, AuthorInfo, DateTime.Today, "Unknown")
  {
  }

  public Book (string isbn, string title, Author AuthorInfo, DateTime publishedon, string publishedby)
  {
    ISBN = isbn;
    Title = title;
    AuthorInfo = new Author();
    PublishedOn = publishedon;
    PublishedBy = publishedby;
  }

  //methods
  public void Display()
  {
    Console.WriteLine("Book '"+Title+ "' was written by "+AuthorInfo+" and was published on "+PublishedOn);
  }



  
}