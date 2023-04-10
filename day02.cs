/*Task:

Given the meal price (base cost of a meal), tip percent (the percentage of the meal price
 being added as tip), and tax percent (the percentage of the meal price being added as 
 tax) for a meal, find and print the meal's total cost. Round the result to the nearest 
 integer.*/

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

class Result
{
     double meal_cost;
     int tip_percent;
     int tax_percent;

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tip;
        double tax;
        tip = meal_cost * tip_percent / 100;
        tax = meal_cost * tax_percent / 100;
        double total_cost = meal_cost + tip + tax;
        Console.Write(Math.Round(total_cost));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}
