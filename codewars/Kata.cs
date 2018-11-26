using System;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		//Code here...
    Array.Sort(numbers);
    
    return Convert.ToInt32(numbers[0] + numbers[1]);
	}
}