using System;
using System.Text;

namespace _01.SubstringMethod
{
    public static class SubstringMethod
    {
        public static StringBuilder SubString(this StringBuilder input, int index)
        {
            StringBuilder str = new StringBuilder();
            
            if (index >= input.Length || index <= 0)
            {
                throw new ArgumentException("The index is out of range!!!");
            }
            else
            {
                for (int i = index; i < input.Length; i++)
                {
                    str.Append(input[i]);
                }
            }

            return str;
        }

        public static StringBuilder SubString(this StringBuilder input, int index, int count)
        {
            StringBuilder str = new StringBuilder();

            if (index >= input.Length || index < 0)
            {
                throw new ArgumentException("The index is out of range!!!");
            }
            else if (index + count >= input.Length || count < 1)
            {
                throw new ArgumentException("Count Error!!!");
            }
            else
            {
                for (int i = index; i < index + count; i++)
                {
                    str.Append(input[i]);
                }
            }

            return str;
        }
    }
}
