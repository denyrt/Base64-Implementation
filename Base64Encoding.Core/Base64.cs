using System;
using System.Collections.Generic;

namespace Base64Encoding.Core
{
    public static class Base64
    {
        private static readonly string base64Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        private static readonly Dictionary<char, int> base64Dictionary = new Dictionary<char, int>()
        {
            {'A', 0 },{'B', 1 },{'C', 2 },{'D', 3 },{'E', 4 },{'F', 5 },{'G', 6 },{'H', 7 },{'I', 8 },{'J', 9 },{'K', 10 },{'L', 11 },{'M', 12 },{'N', 13 },{'O', 14 },{'P', 15 },{'Q', 16 },{'R', 17 },{'S', 18 },{'T', 19 },{'U', 20 },{'V', 21 },{'W', 22 },{'X', 23 },{'Y', 24 },{'Z', 25 },{'a', 26 },{'b', 27 },{'c', 28 },{'d', 29 },{'e', 30 },{'f', 31 },{'g', 32 },{'h', 33 },{'i', 34 },{'j', 35 },{'k', 36 },{'l', 37 },{'m', 38 },{'n', 39 },{'o', 40 },{'p', 41 },{'q', 42 },{'r', 43 },{'s', 44 },{'t', 45 },{'u', 46 },{'v', 47 },{'w', 48 },{'x', 49 },{'y', 50 },{'z', 51 },{'0', 52 },{'1', 53 },{'2', 54 },{'3', 55 },{'4', 56 },{'5', 57 },{'6', 58 },{'7', 59 },{'8', 60 },{'9', 61 },{'+', 62 },{'/', 63 },{'=', -1 }
        };

        public unsafe static string Encode(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes), "");
           
            var appendSize = bytes.Length % 3 == 2 ? 1 : bytes.Length % 3 == 1 ? 2 : 0;
            var length = (bytes.Length * 8 + (appendSize * 2)) / 6 + appendSize;
            
            var result = new string('=', length);
            var clearLenth = (bytes.Length / 3) * 3;
           
            var nextValue = 0; 

            fixed (char* resPointer = result)
            {
                char* c = resPointer;
                
                for (int i = 0; i < clearLenth; i += 3)
                {
                    fixed (byte* next = &bytes[i])
                    {                        
                        nextValue = *next >> 2;
                        *(c++) = base64Alphabet[nextValue];
                        nextValue = (*next & 0b00000011) << 4;


                        nextValue |= *(next + 1) >> 4;
                        *(c++) = base64Alphabet[nextValue];
                        nextValue = (*(next + 1) & 0b00001111) << 2;


                        nextValue |= (*(next + 2) & 0b11000000) >> 6;
                        *(c++) = base64Alphabet[nextValue];

                        nextValue = *(next + 2) & 0b00111111;
                        *(c++) = base64Alphabet[nextValue];
                        nextValue = 0;
                    }
                }

                if (appendSize != 0)
                {
                    fixed (byte* next = &bytes[clearLenth])
                    {
                        nextValue = *next >> 2;
                        *(c++) = base64Alphabet[nextValue];
                        nextValue = (*next & 0b00000011) << 4;

                        if (appendSize == 1)
                        {
                            nextValue |= *(next + 1) >> 4;
                            *(c++) = base64Alphabet[nextValue];
                            nextValue = (*(next + 1) & 0b00001111) << 2;
                        }
                    }
                }

                *c = base64Alphabet[nextValue];
            }

            return result;
        }
        
        public unsafe static byte[] Decode(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str), "");

            var length = str.Length;
            var countOfEquals = str.EndsWith("==") ? 2 : str.EndsWith("=") ? 1 : 0;
            var arraySize = (length - countOfEquals) * 6 / 8;

            var result = new byte[arraySize];
            var loopLength = (length / 4) * 4;

            var arrayPosition = 0;
            var stringPosition = 0;
            fixed (char* c = str)
            {
                fixed (byte* element = result)
                {
                    for (int i = 0; i < loopLength; i += 4)
                    {

                        var next = base64Dictionary[*(c + stringPosition++)];
                        var buf = base64Dictionary[*(c + stringPosition++)];
                        next = next << 2;
                        next |= (buf >> 4);
                        *(element + arrayPosition++) = (byte)next;

                        next = (buf & 0b001111) << 4;
                        buf = base64Dictionary[*(c + stringPosition++)];
                        next |= (buf >> 2);
                        *(element + arrayPosition++) = (byte)next;


                        next = (buf & 0b000011) << 6;
                        buf = base64Dictionary[*(c + stringPosition++)];
                        next |= buf;
                        *(element + arrayPosition++) = (byte)next;
                    }
                    if (countOfEquals != 0)
                    {
                        var cur = loopLength;

                        if (stringPosition < str.Length)
                        {
                            var next = base64Dictionary[*(c + stringPosition++)] << 2;

                            var buf = base64Dictionary[*(c + stringPosition++)];
                            next |= buf >> 4;
                            *(element + arrayPosition++) = (byte)next;
                            if (countOfEquals == 1)
                            {
                                next = (buf & 0b001111) << 4;
                                buf = base64Dictionary[*(c + stringPosition++)];
                                next |= (buf >> 2);
                                *(element + arrayPosition) = (byte)next;
                            }
                            if (countOfEquals == 2)
                            {
                                next = (buf & 0b001111) << 4;
                                buf = base64Dictionary[*(c + stringPosition++)];
                                next |= (buf >> 2);
                                *(element + arrayPosition) = (byte)next;
                            }
                        }
                    }
                }
            }
            return result;
        }    
    }
}