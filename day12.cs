/*Task:
You are given two classes, Person and Student, where Person is the base class and Student 
is the derived class. Completed code for Person and a declaration for Student are provided 
for you in the editor. Observe that Student inherits all the properties of Person.

Complete the Student class by writing the following:

A Student class constructor, which has  parameters:
A string, firstName.
A string, lastName.
An integer, idNumber.
An integer array (or vector) of test scores, scores.
A char calculate() method that calculates a Student object's average and returns the grade 
character representative of their calculated average:

Letter  Average(a)
  O     90 <= a <= 100  
  E     80 <= a < 90
  A     70 <= a < 80
  P     55 <= a < 70
  D     40 <= a < 55
  T     a < 40

*/

using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
    
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string fn, string ln, int i, int[] sc) 
    {
        firstName = fn;
        lastName = ln;
        id = i;
        testScores = sc;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate()
    {
        var sum = 0;
        
        foreach(var score in testScores)
        {
            sum += score;
        }
        
        var average = sum / testScores.Length;
        
        if (average >= 90)
        {
            return 'O';
        }
        else if (average >= 80)
        {
            return 'E';
        }
        else if (average >= 70)
        {
            return 'A';
        }
        else if(average >= 55)
        {
            return 'P';
        }
        else if(average >= 40)
        {
            return 'D';
        }
        else
        {
            return 'T';
        }
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}