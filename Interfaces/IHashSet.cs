using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.PracticeApp.Interfaces
{
    public interface IHashSet : IBaseCollection
    {
        public HashSet<string> Get();

        public void ReadAll(HashSet<string> hs);
    }
}
