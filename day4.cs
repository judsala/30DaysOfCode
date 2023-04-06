/*Task:

Write a Person class with an instance variable, age, and a constructor that takes an 
integer, initialAge, as a parameter. The constructor must assign initialAge to age after 
confirming the argument passed as initialAge is not negative; if a negative argument is 
passed as initialAge, the constructor should set age to 0 and print "Age is not valid, 
setting age to 0.". In addition, you must write the following instance methods:
  1 - yearPasses() should increase the age instance variable by 1.
  2 - amIOld() should perform the following conditional actions:
    -- If age < 13, print You are young..
    -- If age >= 13 and age < 18, print "You are a teenager.".
  Otherwise, print "You are old.".*/

using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
	public Person(int initialAge) {
        
        if (initialAge < 0) 
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            age = 0;
        }
        else{
            age = initialAge;
        }
     }
     public void amIOld() {
        if (age < 13 ) 
        {
            Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else if (age >= 18)
        {
            Console.WriteLine("You are old.");
        }         
     }

     public void yearPasses() {
             age++;         
    }

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}