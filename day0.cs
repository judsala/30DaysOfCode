/*Task:

To complete this challenge, you must save a line of input from stdin to a variable, 
print 'Hello, World.' on a single line, and finally print the value of your variable on a 
second line.

You've got this!*/

using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
        String inputString; 
        
        inputString = Console.ReadLine(); 
        
        Console.WriteLine("Hello, World.");
        
        Console.Write(inputString);
    }
}
