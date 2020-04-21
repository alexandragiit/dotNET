using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace team1
{
    public class Class1
    {
        public List<string> res = new List<string>();
        public int get_prime1(int a)
        {
            for(var i = a-1; i>2; i--)
            {
                if (isPrime(i))
                {
                    return i;
                }
            }
            return 2;
        }

        public int get_prime2(int a)
        {
            int prime = 2;
            for (var i = 2; i < a; i++)
            {
                if (isPrime(i))
                {
                    prime = i;
                }
            }
            return prime;
        }

        public bool isPrime(int a)
        {
            for(var i = 2; i<=a/2; i++)
            {
                if(a%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

  
}
