/*Task: 

Complete the code in the editor below. The variables i, d, and s are already 
declared and initialized for you. You must:

1 - Declare 3 variables: one of type int, one of type double, and one of type String.
2 - Read 3 lines of input from stdin (according to the sequence given in the Input Format 
section below) and initialize your  variables.
3 - Use the + operator to perform the following operations:
  1 - Print the sum of i plus your int variable on a new line.
  2 - Print the sum of d plus your double variable to a scale of one decimal place on a new line.
  3 - Concatenate s with the string you read as input and print the result on a new line.*/

using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int j = int.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        
        double sum = d + e;
        
        Console.WriteLine(i + j);
        Console.WriteLine(sum.ToString("F1"));
        Console.WriteLine(s + str);
    }
}
