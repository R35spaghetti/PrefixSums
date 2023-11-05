PrefixSums test = new PrefixSums();
int[] arr1 = { 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0 };
var result = test.PassingCars(arr1);
Console.WriteLine(result);

var result1 = test.CountDiv(6, 11, 2);
Console.WriteLine(result1);

class PrefixSums
{
    public int PassingCars(int[] A)
    {
        int westCars = 0;
        int passingCars = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == 0)
            {
                westCars++;
            }
            else
            {
                passingCars += westCars;
            }

            if (passingCars > 1000000000)
            {
                return -1;
            }
        }

        return passingCars;
    }
    //i:A<= i mod K = 0
    public int CountDiv(int A, int B, int K)
    {
        if (A % K == 0)
            return (B / K) - (A / K) + 1; //add 1 to the result to include A itself in the count.
        else
            return (B / K) - (A / K);
    }
}