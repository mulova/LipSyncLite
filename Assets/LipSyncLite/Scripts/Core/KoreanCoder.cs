using System;
using System.Collections.Generic;

namespace LipSyncLite
{
    public sealed class KoreanCoder
    {
        public static readonly string firstFormants = "ㄱㄲㄴㄷㄸㄹㅁㅂㅃㅅㅆㅇㅈㅉㅊㅋㅌㅍㅎ";
        public static readonly string middleFormants = "ㅏㅐㅑㅒㅓㅔㅕㅖㅗㅘㅙㅚㅛㅜㅝㅞㅟㅠㅡㅢㅣ";
        public static readonly string lastFormants = " ㄱㄲㄳㄴㄵㄶㄷㄹㄺㄻㄼㄽㄾㄿㅀㅁㅂㅄㅅㅆㅇㅈㅊㅋㅌㅍㅎ";
        private static readonly ushort unicodeStart = 0xAC00;
        private static readonly ushort unicodeEnd = 0xD79F;

        public KoreanCoder() { }

        public static char Combine(string leading, string middle, string trailing)
        {
            var i1 = firstFormants.IndexOf(leading);
            var i2 = middleFormants.IndexOf(middle);
            var i3 = lastFormants.IndexOf(trailing);
            var unicode = unicodeStart + (i1 * 21 + i2) * 28 + i3;

            return Convert.ToChar(unicode);
        }

        public static KoreanFormant Split(char input)
        {
            ushort unicode = 0x0000;
            KoreanFormant result = new KoreanFormant();
            result.character = input;

            unicode = Convert.ToUInt16(input);

            if (unicode >= unicodeStart && unicode <= unicodeEnd)
            {
                var code = unicode - unicodeStart;
                var first = code / (21 * 28);
                code = code % (21 * 28);
                var middle = code / 28;
                code = code % 28;
                var last = code;
                result.formant = new char[] { firstFormants[first], middleFormants[middle], lastFormants[last] };
            }

            return result;
        }

        public static void Split(string input, List<KoreanFormant> output)
        {
            output.Clear();
            for (int i = 0; i < input.Length; ++i)
            {
                output.Add(Split(input[i]));
            }
        }
    }
}