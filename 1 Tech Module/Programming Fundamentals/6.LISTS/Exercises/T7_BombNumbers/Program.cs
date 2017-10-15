using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> bombNumAndbombPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bombNum = bombNumAndbombPower[0];
            int bombPower = bombNumAndbombPower[1];

           

            for(int i = 0; i < nums.Count; i++)
            {
                if(nums[i] == bombNum)
                {
                    Bomb(i, bombPower, nums);
                    i = -1;

                }
            }

            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);

        }

        static void Bomb(int bombNumPosition,int bombPower,List<int> nums)
        {
            int leftmostPositionToRemove = 0;
            int allreadyBombedOnLeft = 0;

            if (bombNumPosition - bombPower < 0)
            {
                allreadyBombedOnLeft = bombPower - bombNumPosition;
                leftmostPositionToRemove = 0;
            }
            else
            {
                leftmostPositionToRemove = bombNumPosition - bombPower;
            }

            int allreadyBombedOnRight = 0;

            if(bombNumPosition + bombPower >= nums.Count)
            {
                allreadyBombedOnRight = (bombNumPosition+ bombPower) - (nums.Count-1);
            }

            int bombingSteps = (bombPower*2)+1 -(allreadyBombedOnLeft + allreadyBombedOnRight);

            for(int i = 0; i < bombingSteps;i++)
            {
                nums.RemoveAt(leftmostPositionToRemove);
            }


        }
    }
}
