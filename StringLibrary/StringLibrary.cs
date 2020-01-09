using System;

namespace StringLibrary
{
    public static class StringLibrary
    {

        public static bool StartWithUpper(this string s)
        {
            if (String.IsNullOrWhiteSpace(s))
                return false;

            return Char.IsUpper(s[0]);
        }

        public static bool StartWithLower(this string s)
        {
            if (String.IsNullOrWhiteSpace(s))
                return false;

            return Char.IsLower(s[0]);
        }

        public static bool HasEmbeddedSpace(this string s)
        {
            foreach(Char ch in s.Trim())
            {
                if (Char.IsWhiteSpace(ch))
                {
                    return true;
                }
            }
            return false;
        } 

    }
}
