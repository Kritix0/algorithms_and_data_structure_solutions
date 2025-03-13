using System;

namespace Tasks
{
    class Program
    {
        public static int MaxAS(int[] nums, int k)
        {
            int sumtmp = 0;
            for (int left = 0; left < k; left++) sumtmp += nums[left];
            int ans = sumtmp;
            for (int left = k; left < nums.Length; left++)
            {
                sumtmp += nums[left] - nums[left - k];
                ans = Math.Max(ans, sumtmp);
            }
            return ans / k;
        }
        public static char[] ReverseMassive(char[] s)
        {
            char[] t = new char[s.Length];
            int left = 0;
            int right = s.Length - 1;
            while (right != 0)
            {
                t[left] = s[right];
                left++;
                right--;
            }
            if (right == 0) t[left] = s[right];
            return t;
        }
        public static int MaxLengthSubarrayZeroOne(int[] nums, int k)
        {
            int left = 0, right = 0;
            int zeroc = 0;
            int maxLength = 0;

            while (right < nums.Length)
            {
                if (nums[right] == 0) zeroc++;
                while (zeroc > k)
                {
                    if (nums[left] == 0) zeroc--;
                    left++;
                }
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }

            return maxLength;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 0, 0, 0,0,0,0, 1, 1 };
            int k = 5;
            char[] nums = {'h','e','l','l','o'};
            Console.WriteLine("My numbers: " + String.Join(", ", ReverseMassive(nums)));
            Console.WriteLine(MaxLengthSubarrayZeroOne(nums1,k));
        }
    }
}

