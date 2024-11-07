using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningfromHackerRank.ProblemSolving
{
    public class PlusMinus
    {
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            PlusMinus.plusMinus(arr);
        }

        public static void plusMinus(List<int> arr)
        {
            int totalCount = arr.Count;
            int positiveCount = arr.Count(num => num > 0);
            int negativeCount = arr.Count(num => num < 0);
            int zeroCount = arr.Count(num => num == 0);

            Console.WriteLine((positiveCount / (double)totalCount).ToString("F6"));
            Console.WriteLine((negativeCount / (double)totalCount).ToString("F6"));
            Console.WriteLine((zeroCount / (double)totalCount).ToString("F6"));
        }
    }
}
