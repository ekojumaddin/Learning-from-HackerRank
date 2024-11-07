using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningfromHackerRank.ProblemSolving
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public class DiagonalDifference
    {
        public void Main(string[] args)
        {
            TextWriter textWriter = Console.Out;

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference.diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int n = arr.Count;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += arr[i][i];
                secondaryDiagonalSum += arr[i][n - i - 1];
            }

            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }
    }
}
