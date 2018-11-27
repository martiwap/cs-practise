using System;
using System.Collections.Generic;
using System.Linq;

public class NumericArraysKata
{
    //return an array with count of positives and sum of negatives
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (IsNullOrEmpty(input))
        {
            return new int[] {};
        }
        
        int[] result = new int[] {CountPositives(input), SumNegatives(input)};

        return result;
    }
    
    public static int SumNegatives(int[] input)
    {
        int negSum = 0;
        foreach(int num in input)
        {
            if(num < 0)
            {
                negSum += num;
            }
        }
        return negSum;
    }
    
    public static int CountPositives(int[] input)
    {
        int count = 0;
        foreach(int num in input)
        {
            if(num > 0)
            {
                count++;
            }  
        }
        return count;
    }
    
    public static bool IsNullOrEmpty(Array array)
    {
        return (array == null || array.Length == 0);
    }
}
