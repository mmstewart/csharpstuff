using System;
using System.Linq;

namespace Warmups.BLL
{
    public class Strings
    {

        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }

        public string InsertWord(string container, string word)
        {
            return container.Substring(0, 2) + word + container.Substring(2);
        }

        public string MultipleEndings(string str)
        {
            return string.Concat(Enumerable.Repeat((str.Substring(str.Length - 2)), 3));
        }

        public string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }

        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

        public string LongInMiddle(string a, string b)
        {
            return a.Length > b.Length ? b + a + b : a + b + a;
        }

        public string RotateLeft2(string str)
        {
            if (str.Length < 3)
                return str;

            return str.Substring(2) + str.Substring(0, 2);
        }

        public string RotateRight2(string str)
        {
            if (str.Length < 3)
                return str;

            return str.Substring(str.Length - 2, 2) + str.Substring(0, str.Length - 2);
        }

        public string TakeOne(string str, bool fromFront)
        {
            //if (str. == fromFront)
            //    return str.Substring(0, 1);
            //return str.Substring(str.Length - 1, 1);
            throw new NotImplementedException();
        }

        public string MiddleTwo(string str)
        {
            var offset = str.Length % 2 == 0 ? 1 : 0;
            return str.Substring(str.Length / 2 - offset, offset + 1);
        }

        public bool EndsWithLy(string str)
        {
            return str.Contains("ly") ? true : false;
        }

        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n);
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            return n == 2 ? str.Substring(2) : str.Substring(0, 2);
        }

        public bool HasBad(string str)
        {
            if (str.EndsWith("xx"))
                if (!str.StartsWith("xx"))
                    return true;

            return false;
        }

        public string AtFirst(string str)
        {
            throw new NotImplementedException();
        }

        public string LastChars(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string ConCat(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string SwapLast(string str)
        {
            if (str.Length < 2)
                return str;

            return str.Substring(0, str.Length - 2) + str.Substring(str.Length - 1) + str.Substring(str.Length - 2, 1);
        }

        public bool FrontAgain(string str)
        {
            if (str.StartsWith("ed"))
            {
                if (str.EndsWith("ed"))
                {
                    return true;
                }
            }

            return false;
        }

        public string MinCat(string a, string b)
        {
            throw new NotImplementedException();
        }

        public string TweakFront(string str)
        {
            throw new NotImplementedException();
        }

        public string StripX(string str)
        {
            if (str.Equals("x"))
                return String.Empty;

            if (str.StartsWith("x") && str.EndsWith("x"))
            {
                return str.Substring(1, str.Length - 2);
            }
            else if (str.StartsWith("x"))
            {
                return str.Substring(1, str.Length - 1);
            }
            else if (str.EndsWith("x"))
            {
                return str.Substring(0, str.Length - 1);
            }

            return str;
        }
    }
}
