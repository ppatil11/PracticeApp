using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public static class ObjectClonning
{	
    public static T CreateDeepCopy<T>(T input)
    {
      // Console.WriteLine(input);
      //  Dictionary<string, string> xyz = new Dictionary<string, string>();
      // xyz.Add("ticket", input);       
      // Console.ReadLine();

        using (var ms = new MemoryStream())
        {
            BinaryFormatter binaryFormatter = new();

            try
            {
                binaryFormatter.Serialize(ms, input);

                ms.Seek(0, SeekOrigin.Begin);

                return (T)binaryFormatter.Deserialize(ms);

            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Error" + ex.Message);
                throw;
            }
            finally
            {
                ms.Close();
            }
        }

    }
}
