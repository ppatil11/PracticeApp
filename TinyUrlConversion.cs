using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.PracticeApp
{
    public class TinyUrlConversion
    {
        public static String IdToShortUrl(int n)
        {
            char[] map = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

            String shorturl = "";

            while (n > 0)
            {
                // use above map to store actual character 
                // in short url 
                int m = n % 62;
                shorturl += (map[n % 62]);
                n = n / 62;
            }

            // Reverse shortURL to complete base conversion 
            return reverse(shorturl);
        }

        static String reverse(String input)
        {
            char[] a = input.ToCharArray();
            int l, r = a.Length - 1;
            for (l = 0; l < r; l++, r--)
            {
                char temp = a[l];
                a[l] = a[r];
                a[r] = temp;
            }
            return String.Join("", a);
        }

        // Function to get integer ID back from a short url 
        public static int shortURLtoID(String shortURL)
        {
            int id = 0; // initialize result 

            // A simple base conversion logic 
            for (int i = 0; i < shortURL.Length; i++)
            {
                if ('a' <= shortURL[i] &&
                           shortURL[i] <= 'z')
                    id = id * 62 + shortURL[i] - 'a';
                if ('A' <= shortURL[i] &&
                           shortURL[i] <= 'Z')
                    id = id * 62 + shortURL[i] - 'A' + 26;
                if ('0' <= shortURL[i] &&
                           shortURL[i] <= '9')
                    id = id * 62 + shortURL[i] - '0' + 52;
            }
            return id;
        }
    }
}
