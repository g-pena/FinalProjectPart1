using System;

class Program {
  public static void Main (string[] args) {
    
  //Authors
  Author a1 = new Author();
  a1.FirstName = "Dwight";
  a1.LastName = "Schrute";
  a1.Email = "DwightSchrute@dundermifflin.net";
  
  Author a2 = new Author();
  a2.FirstName = "Jim";
  a2.LastName = "Halpert";
  a2.Email = "JimHalpert@dundermifflin.net";

  //Books
  Book b1 = new Book();
  b1.ISBN = "1111";
  b1.Title = "Dwight's Book of Bears 1";
  b1.AuthorInfo = a1;
  
  Book b2 = new Book();
  b2.ISBN = "2222";
  b2.Title = "Dwight's Book of Bears 2";
  b2.AuthorInfo = a2;

  Book b3 = new Book();
  b3.ISBN = "3333";
  b3.Title = "Dwight's Book of Bears 3";
  b3.AuthorInfo = a1;
  
  Book b4 = new Book();
  b4.ISBN = "4444";
  b4.Title = "Dwight's Book of Bears 4";
  b4.AuthorInfo = a2;
  b4.PublishedOn = Convert.ToDateTime("12/04/2021");
  b4.PublishedBy = "TheOfficePublications";

  Book b5 = new Book();
  b5.ISBN = "5555";
  b5.Title = "Dwight's Book of Bears 5";
  b5.AuthorInfo = a1;
  b5.PublishedOn = Convert.ToDateTime("12/05/2021");
  b5.PublishedBy = "TheOfficePublications";

  Book b6 = new Book();
  b6.ISBN = "6666";
  b6.Title = "Dwight's Book of Bears 6";
  b6.AuthorInfo = a2;
  b6.PublishedOn = Convert.ToDateTime("12/06/2021");
  b6.PublishedBy = "TheOfficePublications";

  //Tests
  a1.DisplayInfo();
  a2.DisplayInfo();

  a1.AddBook(b1);
  a1.AddBook(b3);
  a1.AddBook(b5);

  a2.AddBook(b2);
  a2.AddBook(b4);
  a2.AddBook(b6);

  a1.RemoveBook(1111);

  a1.DisplayBooks();
  
  }
}