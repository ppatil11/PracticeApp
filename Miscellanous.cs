using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.PracticeApp
{
    public class Miscellanous<TFirst, TSecond>
    {
        public TFirst? First { get; }
        public TSecond? Second { get; }

        public Miscellanous(TFirst? first, TSecond? second)
        {
            First = first;
            Second = second;
        }
    }

    public class RunMiscellanous
    {
        public void RunMisc()
        {
            Miscellanous<int, string> misc = new Miscellanous<int, string>(1, "Prashant");
            int i = misc.First;
            string s = misc.Second;

        }
    }
}
