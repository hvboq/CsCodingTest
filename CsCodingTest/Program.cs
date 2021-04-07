using System;

namespace CsCodingTest
{
    class Program
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = n;

            List<int> lostList = new List<int>(lost);
            List<int> reserveList = new List<int>(reserve);

            //먼저 여벌이 있는데 도난당한 경우를 뺀다.
            foreach (int lostNum in lostList)
            {
                foreach (int reserveNum in reserveList)
                {
                    if (lostNum == reserveNum)
                    {
                        lostList.Remove(lostNum);
                        reserveList.Remove(lostNum);
                    }
                }
            }

            //빌려줄수 있는가 찾기
            foreach (int lostNum in lostList)
            {
                if (reserveList.Contains(lostNum + 1))
                {
                    reserveList.Remove(lostNum + 1);
                    lostList.Remove(lostNum);
                }
                else if (reserveList.Contains(lostNum - 1))
                {
                    reserveList.Remove(lostNum - 1);
                    lostList.Remove(lostNum);
                }
                return answer - lostList.Count;
            }
            static void Main(string[] args){
                Console.WriteLine("Hello World!");
}