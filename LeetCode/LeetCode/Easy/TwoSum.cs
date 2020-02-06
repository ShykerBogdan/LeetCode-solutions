using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
  public class TwoSum
    {
        public List<Stack<int>> CombinationSum(int[] candidates, int target)
        {
            List<Stack<int>> listOfCollections = new List<Stack<int>>();


            for (int i = 0; i < candidates.Length; i++)
            {
                Stack<int> numbers = new Stack<int>();
                List<int> bannedIndexes = new List<int>();

                int sum = 0;

                if (candidates[i] < target)
                {
                    sum = candidates[i];
                    numbers.Push(i);
                }
                if (candidates[i] == target)
                {
                    numbers.Push(i);
                    listOfCollections.Add(numbers);
                    numbers = new Stack<int>();
                    continue;
                }
                if (candidates[i] > target)
                {
                    continue;
                }

                for (int j = i + 1; j < candidates.Length; j++)
                {
                    if (checkIfNotBanned(j, bannedIndexes))
                    {
                        sum += candidates[j];
                        if (sum == target)
                        {
                            numbers.Push(j);
                            listOfCollections.Add(numbers);
                            numbers = new Stack<int>();
                            numbers.Push(candidates[i]);
                        }
                        if (sum > target)
                        {
                            if (j == (candidates.Length) - 1)
                            {
                                bannedIndexes.Add(numbers.Peek());
                                sum -= candidates[numbers.Pop()];
                                j = numbers.Peek() + 1;

                            }
                            else
                            {
                                sum -= candidates[j];
                                continue;
                            }
                        }

                        if (sum < target)
                            numbers.Push(j);

                    }
                    else
                        continue;
                }

            }
            return listOfCollections;
        }

        public bool checkIfNotBanned(int target, List<int> searchList)
        {
            foreach (var item in searchList)
            {
                if (target == item)
                    return false;
            }
            return true;
        }
    }
}
