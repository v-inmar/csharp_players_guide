using System;

namespace C2_The_Variable_Shop_Returns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine("Variable 1.");
            char aCharacter = 'a';
            Console.WriteLine("The variable: 'aCharacter' is of type " + aCharacter.GetTypeCode() + " and its value is: " + aCharacter);
            aCharacter = 'A';
            Console.WriteLine("The variable: 'aCharacter' is of type " + aCharacter.GetTypeCode() + " and its UPDATED value is: " + aCharacter);

            // 2.
            Console.WriteLine("Variable 2.");
            string aString = "a string";
            Console.WriteLine("The variable: 'aString' is of type " + aString.GetTypeCode() + " and its value is: " + aString);
            aString = "some string";
            Console.WriteLine("The variable: 'aString' is of type " + aString.GetTypeCode() + " and its UPDATED value is: " + aString);

            // 3.
            Console.WriteLine("Variable 3.");
            bool aBoolTrue = true;
            Console.WriteLine("The variable: 'aBoolTrue' is of type " + aBoolTrue.GetTypeCode() + " and its value is: " + aBoolTrue);
            bool aBoolFalse = false;
            Console.WriteLine("The variable: 'aBoolFalse' is of type " + aBoolFalse.GetTypeCode() + " and its value is: " + aBoolFalse);
            aBoolFalse = true;
            Console.WriteLine("The variable: 'aBoolFalse' is of type " + aBoolFalse.GetTypeCode() + " and its UPDATED value is: " + aBoolFalse);

            // 4.
            Console.WriteLine("Variable 4.");
            byte aMinByte = 0;
            Console.WriteLine("The variable: 'aMinByte' is of type " + aMinByte.GetTypeCode() + " and its value is: " + aMinByte);
            byte aMaxByte = 255;
            Console.WriteLine("The variable: 'aMaxByte' is of type " + aMaxByte.GetTypeCode() + " and its value is: " + aMaxByte);
            aMaxByte = 200;
            Console.WriteLine("The variable: 'aMaxByte' is of type " + aMaxByte.GetTypeCode() + " and its UPDATED value is: " + aMaxByte);

            // 5.
            Console.WriteLine("Variable 5.");
            sbyte aMinSByte = -128;
            Console.WriteLine("The variable: 'aMinSByte' is of type " + aMinSByte.GetTypeCode() + " and its value is: " + aMinSByte);
            sbyte aMaxSByte = 127;
            Console.WriteLine("The variable: 'aMaxSByte' is of type " + aMaxSByte.GetTypeCode() + " and its value is: " + aMaxSByte);
            aMaxSByte = 100;
            Console.WriteLine("The variable: 'aMaxSByte' is of type " + aMaxSByte.GetTypeCode() + " and its UPDATED value is: " + aMaxSByte);

            // 6.
            Console.WriteLine("Variable 6.");
            short aMinShort = -32_768;
            Console.WriteLine("The variable: 'aMinShort' is of type " + aMinShort.GetTypeCode() + " and its value is: " + aMinShort);
            short aMaxShort = 32_676;
            Console.WriteLine("The variable: 'aMaxShort' is of type " + aMaxShort.GetTypeCode() + " and its value is: " + aMaxShort);
            aMaxShort = 32_000;
            Console.WriteLine("The variable: 'aMaxShort' is of type " + aMaxShort.GetTypeCode() + " and its UPDATED value is: " + aMaxShort);

            // 7.
            Console.WriteLine("Variable 7.");
            ushort aMinUShort = 0;
            Console.WriteLine("The variable: 'aMinUShort' is of type " + aMinUShort.GetTypeCode() + " and its value is: " + aMinUShort);
            ushort aMaxUShort = 65_535;
            Console.WriteLine("The variable: 'aMaxUShort' is of type " + aMaxUShort.GetTypeCode() + " and its value is: " + aMaxUShort);
            aMaxUShort = 65_000;
            Console.WriteLine("The variable: 'aMaxUShort' is of type " + aMaxUShort.GetTypeCode() + " and its UPDATED value is: " + aMaxUShort);

            // 8.
            Console.WriteLine("Variable 8.");
            int aMinInt = -2_147_483_648;
            Console.WriteLine("The variable: 'aMinInt' is of type " + aMinInt.GetTypeCode() + " and its value is: " + aMinInt);
            int aMaxInt = 2_147_483_647;
            Console.WriteLine("The variable: 'aMaxInt' is of type " + aMaxInt.GetTypeCode() + " and its value is: " + aMaxInt);
            aMaxInt = 2_000_000_000;
            Console.WriteLine("The variable: 'aMaxInt' is of type " + aMaxInt.GetTypeCode() + " and its UPDATED value is: " + aMaxInt);

            // 9.
            Console.WriteLine("Variable 9.");
            uint aMinUInt = 0;
            Console.WriteLine("The variable: 'aMinUInt' is of type " + aMinUInt.GetTypeCode() + " and its value is: " + aMinUInt);
            uint aMaxUInt = 4_294_967_295;
            Console.WriteLine("The variable: 'aMaxUInt' is of type " + aMaxUInt.GetTypeCode() + " and its value is: " + aMaxUInt);
            aMaxUInt = 4_000_000_000;
            Console.WriteLine("The variable: 'aMaxUInt' is of type " + aMaxUInt.GetTypeCode() + " and its UPDATED value is: " + aMaxUInt);

            // 10.
            Console.WriteLine("Variable 10.");
            long aMinLong = -9_223_372_036_854_775_808;
            Console.WriteLine("The variable: 'aMinLong' is of type " + aMinLong.GetTypeCode() + " and its value is: " + aMinLong);
            long aMaxLong = 9_223_372_036_854_775_807;
            Console.WriteLine("The variable: 'aMaxLong' is of type " + aMaxLong.GetTypeCode() + " and its value is: " + aMaxLong);
            aMaxLong = 9_000_000_000_000_000_000;
            Console.WriteLine("The variable: 'aMaxLong' is of type " + aMaxLong.GetTypeCode() + " and its UPDATED value is: " + aMaxLong);

            // 11.
            Console.WriteLine("Variable 11.");
            ulong aMinULong = 0;
            Console.WriteLine("The variable: 'aMinULong' is of type " + aMinULong.GetTypeCode() + " and its value is: " + aMinULong);
            ulong aMaxULong = 18_446_744_073_709_551_615;
            Console.WriteLine("The variable: 'aMaxULong' is of type " + aMaxULong.GetTypeCode() + " and its value is: " + aMaxULong);
            aMaxULong = 18_000_000_000_000_000_000;
            Console.WriteLine("The variable: 'aMaxULong' is of type " + aMaxULong.GetTypeCode() + " and its UPDATED value is: " + aMaxULong);

            // 12.
            Console.WriteLine("Variable 12.");
            float aFloat = 3.5623f;
            Console.WriteLine("The variable: 'aFloat' is of type " + aFloat.GetTypeCode() + " and its value is: " + aFloat);
            aFloat = 3.5001f;
            Console.WriteLine("The variable: 'aFloat' is of type " + aFloat.GetTypeCode() + " and its UPDATED value is: " + aFloat);

            // 13.
            Console.WriteLine("Variable 13.");
            double aDouble = 3.5623;
            Console.WriteLine("The variable: 'aDouble' is of type " + aDouble.GetTypeCode() + " and its value is: " + aDouble);
            aDouble = 3.5002;
            Console.WriteLine("The variable: 'aDouble' is of type " + aDouble.GetTypeCode() + " and its UPDATED value is: " + aDouble);

            // 14.
            Console.WriteLine("Variable 14.");
            decimal aDecimal = 3.5623m;
            Console.WriteLine("The variable: 'aDecimal' is of type " + aDecimal.GetTypeCode() + " and its value is: " + aDecimal);
            aDecimal = 3.5003m;
            Console.WriteLine("The variable: 'aDecimal' is of type " + aDecimal.GetTypeCode() + " and its UPDATED value is: " + aDecimal);
        }
    }
}