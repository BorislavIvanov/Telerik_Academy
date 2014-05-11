//Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubtractionAndMultiplication
{
    static int GetThePositionAndCoeficient(string[] firstPolynomial)
    {
        int pos = 0;

        string[] coeficient = firstPolynomial[0].Split('x');
        string[] position = new string[2];
        if (coeficient.Length == 2 && coeficient[1] != "")
        {
            position = coeficient[1].Split('^');
            if (Convert.ToInt32(position[1]) > pos)
            {
                pos = Convert.ToInt32(position[1]);
            }
        }
        else if (coeficient[coeficient.Length - 1] == "")
        {
            pos = 1;
        }
        return pos;
    }
    //Proverka koi to dwata polinoma e ot po-visoka stepen 
    static int getHighestDegradient(string a, string b)
    {
        char[] charSeparators = new char[] { '-', '+' };
        string[] firstPolynomial = a.Split(charSeparators, StringSplitOptions.None);
        string[] secondPolynomial = b.Split(charSeparators, StringSplitOptions.None);
        return Math.Max(GetThePositionAndCoeficient(firstPolynomial), GetThePositionAndCoeficient(secondPolynomial));
    }
    //Predstawqne waw wid na masiw na polinom
    static int[] Representation(string a, int degradient)
    {
        char[] charSeparators = new char[] { '-', '+' };
        string[] firstPolynomial = a.Split(charSeparators, StringSplitOptions.None);
        int pos = 0;
        int coef = 0;
        int lastPos;
        string[] coeficient = firstPolynomial[0].Split('x');
        string[] position = new string[2];
        int[] polynom1Coef = new int[degradient + 1];

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            lastPos = pos;
            pos = 0;
            coef = 0;
            coeficient = firstPolynomial[i].Split('x');
            if (coeficient.Length == 1)
            {
                pos = 0;
                if (coeficient[0] != "")
                {
                    coef = Convert.ToInt32(coeficient[0]);
                }
                else
                {
                    coef = 1;

                }
            }
            else if (coeficient.Length == 2 && coeficient[1] != "")
            {
                position = coeficient[1].Split('^');
                pos = Convert.ToInt32(position[1]);
                if (coeficient[0] != "")
                {
                    coef = Convert.ToInt32(coeficient[0]);

                }
                else
                {
                    coef = 1;
                }
            }
            else if (coeficient[1] == "")
            {
                pos = 1;
                if (coeficient[0] != "")
                {
                    coef = Convert.ToInt32(coeficient[0]);
                }
                else
                {
                    coef = 1;
                }
            }
            if (i > 0 && pos != lastPos - 1)
            {
                polynom1Coef[pos] = coef;
                pos++;
                while (pos < polynom1Coef.Length && pos != lastPos - 1)
                {
                    polynom1Coef[pos] = 0;
                    pos++;
                }

            }
            else if (i == 0)
            {
                polynom1Coef[pos] = coef;
            }
            else
            {
                polynom1Coef[pos] = coef;
            }
        }
        NormalizingMinuses(a, polynom1Coef, firstPolynomial);
        return polynom1Coef;
    }
    static void NormalizingMinuses(string a, int[] polynom1Coef, string[] firstPolynomial)
    {
        int br = polynom1Coef.Length;
        if (a.Substring(0, 1) == "-")
        {
            while (polynom1Coef[br - 1] == 0)
            {
                br--;
            }
            polynom1Coef[br - 1] *= -1;
        }
        br = firstPolynomial.Length;
        for (int i = 1; i < a.Length; i++)
        {
            if (a.Substring(i, 1) == "-")
            {
                if (polynom1Coef[firstPolynomial.Length - br] == 0)
                {
                    while (polynom1Coef[firstPolynomial.Length - br] == 0)
                    {
                        br--;
                    }
                }
                else
                {
                    polynom1Coef[firstPolynomial.Length - br + firstPolynomial.Length % 2] *= -1;
                }

            }
            else if (a.Substring(i, 1) == "+")
            {
                br--;
            }
            if (br == 0)
            {
                break;
            }
        }
    }
    static void Print(int[] result)
    {
        Console.WriteLine();
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == result.Length - 1 && result[i] > 0)
            {
                Console.Write("{0}x^{1}", result[i], i);
            }
            else if (i == 0 && result[i] > 0)
            {
                Console.Write("+{0}", result[i], i);
            }
            else if (i == 0 && result[i] < 0)
            {
                Console.Write("{0}", result[i], i);
            }
            else if (result[i] > 0)
            {
                Console.Write("+{0}x^{1}", result[i], i);
            }
            else if (result[i] < 0)
            {
                Console.Write("{0}x^{1}", result[i], i);
            }
        }
    }
    static void Sum(int[] polynom1, int[] polynom2)
    {
        int[] result = new int[polynom1.Length + 1];
        for (int i = 0; i < polynom1.Length; i++)
        {
            result[i] = polynom1[i] + polynom2[i];
        }
        Print(result);
    }
    static void Substracting(int[] polynom1, int[] polynom2)
    {
        int[] result = new int[polynom1.Length + 1];
        for (int i = 0; i < polynom1.Length; i++)
        {
            result[i] = polynom1[i] - polynom2[i];
        }
        Print(result);
    }
    static void Multiplying(int[] polynom1, int[] polynom2)
    {
        int[] resultOfMultiplying = new int[polynom1.Length * 2 + 1];
        for (int i = 0; i < polynom1.Length; i++)
        {
            for (int j = 0; j < polynom1.Length; j++)
            {
                resultOfMultiplying[i + j] += polynom1[i] * polynom2[j];
            }
        }
        Print(resultOfMultiplying);
    }
    static void AddingTwoPolynnomials(string a, string b)
    {
        int deg = getHighestDegradient(a, b);
        int[] polynom1 = new int[deg + 1];
        int[] polynom2 = new int[deg + 1];
        polynom1 = Representation(a, deg);
        polynom2 = Representation(b, deg);
        //sabirane na dvata spisaka
        Sum(polynom1, polynom2);
        Substracting(polynom1, polynom2);
        Multiplying(polynom1, polynom2);
    }
    static void Main()
    {
        string str = Console.ReadLine();
        string str1 = Console.ReadLine();
        AddingTwoPolynnomials(str, str1);
    }
}

