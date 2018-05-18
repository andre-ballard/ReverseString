using System;
using System.Collections.Generic;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abgd";
            string s2 = "s fr  u o";
            string s3 = "s d, srs, dr,a,";

            Reverse r = new Reverse();
            
            Console.WriteLine(r.ReverseString(s1));
            Console.WriteLine(r.ReverseString(s2));
            Console.WriteLine(r.ReverseString(s3));
            Console.ReadLine();

        }
    }


    class Reverse
    {
        public string ReverseString(string s)
        {
            RemoveSpaces rs = new RemoveSpaces();
            RemoveCommas rc = new RemoveCommas();
            string ns = rc.Commas(rs.Spaces(s));
            
            List<char> rstring = new List<char>();

            for (int i = ns.Length - 1; i != 0; i--)
            {
                rstring.Add(ns[i]);
            }

            rstring.Add(ns[0]);

            return string.Join("", rstring);

        }

    }

    class RemoveSpaces
    {
        public string Spaces(string s)
        {
            List<char> rstring = new List<char>();

            for (int i = 0, j = s.Length; i < j; i++)
            {
                if (s[i] != ' ')
                {
                    rstring.Add(s[i]);
                }
            }

            return string.Join("", rstring);
        }
    }

    class RemoveCommas
    {
        public string Commas(string s)
        {
            List<char> rstring = new List<char>();

            for (int i = 0, j = s.Length; i < j; i++)
            {
                if (s[i] != ',')
                {
                    rstring.Add(s[i]);
                }
            }

            return string.Join("", rstring);
        }
    }
}
