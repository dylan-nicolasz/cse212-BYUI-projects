public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //We already have a list to store the data, call the list and give a it name
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)  //for loop to iterate over the list, will start at 0 until the length of the list.
        {
            multiples[i] = number * (i + 1); // It will take the number and se if it's a multiple of, if it is it wil store in the 'multiples' list and continue with the next number
        }



        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // we need to tell the program to find the start position from the list will rotate
        // we take the whole list and substract the amount the user will provide and the result of that will be the index for the list to rotate.
        int rotateIndex = data.Count - amount;
        List<int> rotateList = new List<int>();


        //For loop to find the starting index and to keep going until the end of the list.
        for (int i = rotateIndex; rotateIndex < data.Count; i++)
        {
            rotateList.Add(data[i]); //this will take the values and sotore in the new List, and will put the last values first.
        }

        data.Clear(); // clear the original list

        data.AddRange(rotateList); // copy all the values that were rotated already into the original list.
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
