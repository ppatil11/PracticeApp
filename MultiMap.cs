using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.PracticeApp
{
    public class MultiMap<TKey, TValue> : Dictionary<TKey, HashSet<TValue>>
    {
      
        public MultiMap<TKey, TValue> Clone()
        {
            try
            {
                return MemberwiseClone() as MultiMap<TKey, TValue>;
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
        }

        //Add
        //AddMany
        //Read
        //Remove
        //Merge
        //Get

        //Add sepcified value under specified key
        public void Add(TKey key, TValue value)
        {
            if(key == null)
            {
                throw new Exception("Key cant be null");                
            }

            HashSet<TValue> container;

            if(this.TryGetValue(key, out container))
            {
                container.Add(value);
            }
            else
            {
                container = new HashSet<TValue>();
                container.Add(value);
                this[key] = container;
            }
            
        }

    }

    public interface IMultiValueDict<K, V> : IEnumerable<KeyValuePair<K, V>>
    {

        //bool Add(K, V)
        //Get
    }

    public class MultiValueDict<K, V> : IMultiValueDict<K, V>
    {
        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
