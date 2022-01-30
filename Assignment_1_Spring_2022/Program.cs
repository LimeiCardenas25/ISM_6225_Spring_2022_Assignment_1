/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}",final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[]{"Marshall", "Student","Center"};
            string[] bulls_string2 = new string[]{"MarshallStudent", "Center"};
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch ='c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // create an array c that contains all the vowels
                var c = new string[] { "a", "i", "o","e","u" };
                 //decalre a empty string variable for the new string
                String final_string = "";
                //check the constraints of 0<=s.length<=10000
                if (s.Length >= 0 && s.Length <= 10000)
                {
                // loop through c, replace the elelments of s with empty character if any element of c is found 
                    foreach (var i in c)
                    {
                        final_string = s.Replace(i, string.Empty);
                    }
                    //return the new string 
                    return final_string;
                }

                
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                //var bulls_string1 = new string[] { "Marshall", "Student", "Center" };
                //var bulls_string2 = new string[] { "MarshallStudent", "Center" };
                // using string join method to join bulls_string1 & 2 together as two separete string separeted by ,
                var t1 = string.Join("", bulls_string1);
                var t2 = string.Join("", bulls_string2);
                // using string compare to method to compare these two strings 
                if (t1.CompareTo(t2) == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
               // var b = new int[] { 1, 2, 3, 4, 5 };
                var a = new List<int>();
                var sum = 0;
                //loop through bull_bucks,find duplicate elements and remove it from the array
                for (var i = 0; i < bull_bucks.Length; i++)
                {
                    for (var m = i + 1; m < bull_bucks.Length; m++)
                        if (bull_bucks[i] == bull_bucks[m])
                        { bull_bucks = bull_bucks.Where(e => e != bull_bucks[i]).ToArray(); }
                }
                //sum up all the elements 
                foreach (var n in bull_bucks)
                { sum += n; }
                return sum;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
               // var mat = new int[,] { { 5 } };
                var p = 0;
                var s = 0;
                var ps = 0;
                //get the sum of the primary diagonal
                //get the sum of the secondary diagonal
                for (var i = 0; i < bulls_grid.GetLength(0); i++)
                {

                    p += bulls_grid[i, i];
                    s += bulls_grid[i, bulls_grid.GetLength(0) - i - 1];
                }
                // if the length of first element of Bulls_grid is odd, need to deduct the element that we counted twice 
                if (bulls_grid.Length % 2 != 0)
                {
                    p -= bulls_grid[(int)(bulls_grid.GetLength(0) / 2), (int)(bulls_grid.GetLength(0) / 2)];
                }
                return (p+s);
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
               // var s = "aaiougrt";
                //var a = new int[] { 4, 0, 2, 6, 7, 3, 1, 5 };
                //check if indices has a same length of bulls_String
                if (indices.Length == bulls_string.Length)
                {
                    //create a empty array with a same length of bulls_string to store
                    //bulls_string's element which are replaced according to the indice position
                    var tmp = new char[bulls_string.Length];
                    for (var i = 0; i < bulls_string.Length; i++)
                    {
                        var m = indices[i];
                        tmp[m] = bulls_string[i];
                    }
                    //Console.WriteLine(string.Join("", tmp));
                    //join tmp element together after being re-positioned 
                    return string.Join("", tmp);
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                //var s = "mumacollegeofbusiness";
                // var ch = 'c';
                //create a empty string to store the final string 
                String prefix_string = "";
                //check if inpute string contains ch
                if (bulls_string6.Contains(ch))
                {
                    //if the inpute string contains ch,return the index position 
                    var i = bulls_string6.IndexOf(ch);
                    Console.WriteLine(i);
                    // store the substring of index(0,i+1)
                    var sc1 = bulls_string6.Substring(0, i + 1);
                    //store the substring of the rest of the input string
                    var sc2 = bulls_string6.Substring(i + 2);
                    //use a stringbuilder to reverse the first substring
                    var c = new StringBuilder();
                    for (var m = i; m >= 0; m--)
                    {
                        c.Append(sc1[m]);
                    }
                    //convert the stringbuilder to a string 
                    var sc3 = c.ToString();
                    //concanitate the reversed string 
                    prefix_string = sc3 + sc2;
                    return prefix_string;
                }
                else
                {
                   return bulls_string6;
                }

                
                
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
