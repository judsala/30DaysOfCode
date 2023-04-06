/*Task:

Given a string, S, of length N that is indexed from 0 to N - 1, print its even-indexed 
and odd-indexed characters as 2 space-separated strings on a single line 
(see the Sample below for more detail).

Note: 0 is considered to be an even index.

Example

S = adbecf

Print abc def*/

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        
        int N = int.Parse(Console.ReadLine());
                
        for (int i = 0; i < N; i++)
        {
            string S = Console.ReadLine();
            for (int j = 0; j < S.Length; j++)
            {
                if (j % 2 == 0)
                Console.Write(S[j]);                 
            }
            Console.Write(" ");
            for (int k = 1; k < S.Length; k++)
            {
                if (k % 2 != 0)
                Console.Write(S[k]);
            }
            Console.WriteLine();
        }
    }
}