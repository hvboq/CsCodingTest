using System;
using System.Collections.Generic;

namespace CsCodingTest
{
    class Program
    {
        public static void Main()
        {
            int n = 3;
            Console.WriteLine(n);
            int answer = solution(5, new int[] {2,4 }, new int[] { 1,3,5});
            Console.WriteLine(answer);
        }
        public static int solution(int n, int[] lost, int[] reserve)
        {
            int answer = n;

            List<int> lostList = new List<int>(lost);
            List<int> reserveList = new List<int>(reserve);

            //먼저 여벌이 있는데 도난당한 경우를 뺀다
            foreach (int lostNum in new List<int>(lostList))
            {
                foreach (int reserveNum in new List<int>(reserveList))
                {
                    if (lostNum == reserveNum)
                    {
                        lostList.Remove(lostNum);
                        reserveList.Remove(lostNum);
                    }
                }
            }

            //빌려줄수 있는가 찾기
            foreach (int lostNum in new List<int>(lostList))
            {
                if (reserveList.Contains(lostNum + 1))
                {
                    lostList.Remove(lostNum);
                }
                else if (reserveList.Contains(lostNum - 1))
                {
                    lostList.Remove(lostNum);
                }
            }
            return answer - lostList.Count;
        }
    }
}