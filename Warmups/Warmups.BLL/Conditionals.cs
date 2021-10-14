using System;
using System.Linq;

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return aSmile == bSmile;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            return !isWeekday || isVacation;
        }

        public int SumDouble(int a, int b)
        {
            return a == b ? 2 * (a + b) : (a + b);
        }

        public int Diff21(int n)
        {
            throw new NotImplementedException();
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            return isTalking && hour == 6;
        }

        public bool Makes10(int a, int b)
        {
            return a + b == 10 || (a == 10 || b == 10);
        }

        public bool NearHundred(int n)
        {
            return Enumerable.Range(90, 110).Contains(n);
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            throw new NotImplementedException();
        }

        public string NotString(string s)
        {
            return "not " + s;
        }

        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        public string FrontBack(string str)
        {
            throw new NotImplementedException();
        }

        public string Front3(string str)
        {
            if (str.Length < 3)
                return string.Concat(Enumerable.Repeat(str, 3));
            return string.Concat(Enumerable.Repeat(str.Remove(3), 3));
        }

        public string BackAround(string str)
        {
            throw new NotImplementedException();
        }

        public bool Multiple3or5(int number)
        {
            return number % 3 == 0 || number % 5 == 0;
        }

        public bool StartHi(string str)
        {
            throw new NotImplementedException();
        }

        public bool IcyHot(int temp1, int temp2)
        {
            throw new NotImplementedException();
        }

        public bool Between10and20(int a, int b)
        {
            return a >= 10 && a <= 20 || b >= 10 && b <= 20;
        }

        public bool HasTeen(int a, int b, int c)
        {
            return a >= 13 && a <= 19 ||
                b >= 13 && b <= 19 ||
                c >= 13 && c <= 19;
        }

        public bool SoAlone(int a, int b)
        {
            throw new NotImplementedException();
        }

        public string RemoveDel(string str)
        {
            return str.Replace("del", "");
        }

        public bool IxStart(string str)
        {
            return str.Contains("ix");
        }

        public string StartOz(string str)
        {
            throw new NotImplementedException();
        }

        public int Max(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        public int Closer(int a, int b)
        {
            throw new NotImplementedException();
        }

        public bool GotE(string str)
        {
            return str.Count(i => i == 'e') % 2 != 0;
        }

        public string EndUp(string str)
        {
            return str.Length < 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
        }

        public string EveryNth(string str, int n)
        {
            throw new NotImplementedException();
        }
    }
}
