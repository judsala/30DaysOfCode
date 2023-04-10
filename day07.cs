/*Task:

Given an array, A, of N integers, print A's elements in reverse order as a single line 
of space-separated numbers.

Example:
A = [1, 2, 3, 4] 

Print 4 3 2 1. Each integer is separated by one space.*/

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        int len = arr.Count;
            
        for(int i = len - 1; i >= 0; i--)
        {                   
            Console.Write(arr[i] + " ");
        }          
    }              
}
