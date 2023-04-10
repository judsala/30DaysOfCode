/*Task:

Given a Book class and a Solution class, write a MyBook class that does the following:

- Inherits from Book
- Has a parameterized constructor taking these 3 parameters:
1. string title
2. string author
3. int price
- Implements the Book class' abstract display() method so it prints these 3 lines:
1. Title:, a space, and then the current instance's title.
2. Author:, a space, and then the current instance's author.
3. Price: , a space, and then the current instance's price.
*/

using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    private int price;
    
    public MyBook(string title, string author, int myPrice) :base(title, author)
    {
        price = myPrice;
    }
    
    public override void display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}