// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
int n = Convert.ToInt32(Console.ReadLine().Trim());
List<List<int>> arr = new List<List<int>>();
for (int i = 0; i < n; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());

}
int result = Result.DiagonalDifference(arr);
textWriter.WriteLine(result);

textWriter.Flush();
textWriter.Close();

class Result
{
    public static int DiagonalDifference(List<List<int>> arr)
    {
        int n = arr.Count;
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += arr[i][i];
            secondaryDiagonalSum += arr[i][n - 1 - i];
        }
        return Math.Abs(primaryDiagonalSum + secondaryDiagonalSum);
    }
}
