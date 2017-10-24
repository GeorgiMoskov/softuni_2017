using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] strStartDay = Console.ReadLine().Split('-').Select(int.Parse).ToArray() ;
            int[] strEndDay = Console.ReadLine().Split('-').Select(int.Parse).ToArray();

            DateTime startDate = new DateTime(strStartDay[2], strStartDay[1], strStartDay[0]);
            DateTime endDate = new DateTime(strEndDay[2], strEndDay[1], strEndDay[0]);

            List<DateTime> holidayList = new List<DateTime>();

            holidayList.Add(new DateTime(1,1,1));
            holidayList.Add(new DateTime(1, 3, 3));
            holidayList.Add(new DateTime(1, 5, 1));
            holidayList.Add(new DateTime(1, 5, 6));
            holidayList.Add(new DateTime(1, 5, 24));
            holidayList.Add(new DateTime(1, 9, 6));
            holidayList.Add(new DateTime(1, 9, 22));
            holidayList.Add(new DateTime(1, 11, 1));
            holidayList.Add(new DateTime(1, 12, 24));
            holidayList.Add(new DateTime(1, 12, 25));
            holidayList.Add(new DateTime(1, 12, 26));

            int workingDaysCounter = 0;

            for (startDate = startDate; startDate <= endDate; startDate =startDate.AddDays(1))
            {
                bool log = true;

                foreach (var holDate in holidayList)
                {
                    if((startDate.Day == holDate.Day && startDate.Month == holDate.Month) || (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday))
                    {
                        log = false;
                        break;
                    }
                }

                if(log == true)
                {
                    workingDaysCounter++;
                }
            }

            Console.WriteLine(workingDaysCounter);





        }
    }
}
