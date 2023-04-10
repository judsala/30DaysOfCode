/*Task:

Given a base-10 integer, n, convert it to binary (base-2). Then find and print the base-10
 integer denoting the maximum number of consecutive 1's in n's binary representation. 
 When working with different bases, it is common to show the base as a subscript.*/

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
        int reminder = 0;
        int count = 0;
        int max = 0;
        
        while(n > 0)
        {
            reminder = n % 2;
            n /= 2;
            if (reminder == 1)
            {
                count++;
                max = Math.Max(max, count);
            }
            else
            {
                count = 0;   
            }
        }
        Console.WriteLine(max);
    }
}