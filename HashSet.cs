using Code.PracticeApp.Interfaces;
using System.Text;


namespace Code.PracticeApp
{
    /*
    In C#, HashSet is an unordered collection of unique elements. This collection is introduced in .NET 3.5. 
    It supports the implementation of sets and uses the hash table for storage. This collection is of the generic 
    type collection and it is defined under System.Collections.Generic namespace. It is generally used when we want 
    to prevent duplicate elements from being placed in the collection. The performance of the HashSet is much better 
    in comparison to the list. 
    
    Important Points:
    The HashSet class implements the ICollection, IEnumerable, IReadOnlyCollection, ISet, IEnumerable, IDeserializationCallback, and ISerializable interfaces.
    In HashSet, the order of the element is not defined. You cannot sort the elements of HashSet.
    In HashSet, the elements must be unique.
    In HashSet, duplicate elements are not allowed.
    Is provides many mathematical set operations, such as intersection, union, and difference.
    The capacity of a HashSet is the number of elements it can hold.
    A HashSet is a dynamic collection means the size of the HashSet is automatically increased when the new elements are added.
    In HashSet, you can only store the same type of elements.
    */
    public class HashSet : IHashSet
    {
        public HashSet()
        {

        }

        public HashSet<string> Get()
        {
            HashSet<string> newHashSet = new HashSet<string>();

            newHashSet.Add("C#");
            newHashSet.Add("Java");
            newHashSet.Add("JS");
            newHashSet.Add("Python");
//            newHashSet.Add(1);

            return newHashSet;
        }

        public void ReadAll(HashSet<string> hs)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string value in hs)
            {
                sb.AppendLine($"Value : {value}, Length : {value.Length}");                
            }
            Console.WriteLine(sb);
        }
       
        public void Read(HashSet<string> hs, string value)
        {
            var response = hs.TryGetValue(value, out string? result) ? $"Match found for : {result}" : $"No match found for : {value}";

            Console.WriteLine(response);
        }

        public HashSet<string> Delete(HashSet<string> hs, string value)
        {
            hs.Remove(value);

            return hs;
        }

        public HashSet<string> DeleteAll(HashSet<string> hs)
        {
            hs.Clear();

            return hs;
        }
    }
}
