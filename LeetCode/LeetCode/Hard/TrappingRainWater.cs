using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hard
{
    //https://leetcode.com/problems/trapping-rain-water/
    // Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.

    class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int totalWeight = 0;
            int leftFlag = 0;
            int rightFlag = height.Length - 1;

            int leftMaximum = height[leftFlag];
            int rightMaximum = height[rightFlag];

            while (leftFlag <= rightFlag)
            {

                if (leftMaximum < rightMaximum)
                {

                    if (leftMaximum > height[leftFlag])
                        totalWeight += leftMaximum - height[leftFlag];
                    else
                        leftMaximum = height[leftFlag];
                    ++leftFlag;
                }
                else
                {
                    if (rightMaximum > height[rightFlag])
                        totalWeight += rightMaximum - height[rightFlag];
                    else
                        rightMaximum = height[rightFlag];
                    --rightFlag;

                }
            }

            return totalWeight;
        }

        public void Test()
        {
            int[] poolStructureArrray = new int[] { 2, 0, 0, 1, 0, 0, 1 };
            Trap(poolStructureArrray);
        }
    }
}
