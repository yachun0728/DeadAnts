using System;

namespace DeadAnts
{
    public class Kata
    {
        public static int DeadAntCount(string ants)
        {
            int deadAntCount = 0;


            if (string.IsNullOrEmpty(ants))
                return deadAntCount;
            if (ants.Substring(0, 1) != "a")
                deadAntCount++;

            var eachAnts = ants.Split('a');

            foreach (var ant in eachAnts)
            {
                deadAntCount = CheckAntCount(ant, deadAntCount);
            }
            return deadAntCount - 1;
        }

        private static int CheckAntCount(string ant, int deadAntCount)
        {
            if (ant.Length == 0 || ant.Length < 2)
            {
                deadAntCount++;
            }
            else
            {
                var first = ant.Substring(0, 1);
                var second = ant.Substring(1, 1);
                if (first != "n" || first+second != "nt")
                {
                    deadAntCount++;
                }
            }
            return deadAntCount;
        }
    }
}