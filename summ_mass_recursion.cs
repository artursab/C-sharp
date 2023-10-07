using System.Xml.Serialization;

class Program
{

    static int Sum(int[] myArray, int i = 0)
    {
        if (i >= myArray.Length) 
            return 0;

        return myArray[i] + Sum(myArray, i + 1);
    }


    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5 };

        int result = Sum(myArray);
    }
}
