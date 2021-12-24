using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    
    public static void First(int[] nums, int target)
    {

        int n = nums.Length;
        int firstpos = -1,lastpos = -1;
        for (int i = 0 ; i <= n; i ++)
        {
            if(target != nums[i])
            {
                continue;
            }if(firstpos == -1)
            {
                firstpos = i;
                lastpos = i;
            }
            if(firstpos != -1)
            {
                Console.WriteLine("First"+"Occurence:"+firstpos /n );
                                Console.WriteLine("Last"+"Occurence:"+lastpos /n );

            }
          else
           {
               Console.WriteLine("[-1,-1]");
           } 
        }
        //Q2
         
    }
    public void LongestPalindromicSubstring(string word)
    {// {
    //     for(int i = 0; i <= word.Length; i++)
    //     {

    //     }
    for(int i =1; i<word.Length; i++)
    {
         
        for( int c= 0; c < word.Length -i; i++)
        {
            string reverse = string .Empty;
            string substring = word.Substring(c,i);
            Console.WriteLine($"All possible substring in string{word} are: {substring}");
            for (int d = substring.Length; d > 0 ; d--)
            {
                reverse += substring;
                if(substring == reverse && substring.Length ==substring.Length-1)
                {
                    Console.WriteLine("The longest substring is"+substring);
                }
            }
        }
    }
    }
    }
}
