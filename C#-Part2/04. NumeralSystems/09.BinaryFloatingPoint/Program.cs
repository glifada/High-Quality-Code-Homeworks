using System;
using System.Collections;

class BinaryFloatingPoint
{
    static void Main()
    {
        Console.WriteLine("Enter float value");
        float value = float.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of float number {0} is {1} ", value, ConvertFloatToBinaryString(value));
    }

    static string ConvertFloatToBinaryString(float input)
    {
        const int fractionSize = 23;

        float value;
        int sign;
        long exponent;
        int lead;
        int[] fraction;

        value = input;

        sign = 1;
        lead = 0;
        exponent = 0;
        fraction = new int[fractionSize];

        int i;
        for (i = 0; i < fractionSize; i++)
        {
            fraction[i] = 0;
        }

        if (value == 0.0f)
        {
            sign = 1;
        }
        else if (value == -0.0f)
        {
            sign = -1;
            value = -1.0f * value;
        }
        else if (value < 0.0f)
        {
            sign = -1;
            value = -1.0f * value;
        }

        if (value > 0.0f)
        {
            while (value >= 2.0f)
            {
                exponent++;
                value = value / 2.0f;
            }
            while (value < 1.0f && exponent > -127)
            {
                exponent--;
                value = value * 2.0f;
            }

            if (value >= 1.0f)
            {
                value = value - 1.0f;
                value = value * 2.0f;
                lead = 1;
            }
            else
            {
                lead = 0;
            }

            for (i = 0; i < fractionSize; i++)
            {
                if (value >= 1.0f)
                {
                    fraction[i] = 1;
                    value = value - 1.0f;
                }
                else
                {
                    fraction[i] = 0;
                }
                value = value * 2.0f;
            }
        }

        string str = string.Empty;
        string strExponent = string.Empty;

        if (sign < 0)
        {
            str = str + "1";
        }
        else
        {
            str = str + "0";
        }

        strExponent = Convert.ToString(exponent - 1, 2);
        strExponent = strExponent.PadLeft(7, '0');

        str += lead;

        str += strExponent;

        for (i = 0; i < fractionSize; i++)
        {
            str = str + fraction[i];
        }

        return str;
    }
}