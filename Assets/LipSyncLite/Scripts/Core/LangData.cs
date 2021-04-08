namespace LipSyncLite
{
    public class LangData
    {
        public string[] vowels { get; private set; }
        public string[] vowelsByFormant { get; private set; }
        public float[] vowelFormantFloor { get; private set; }
        public float[] vowelFormantCeil { get; private set; }

        public static LangData JP = new LangData
        {
            vowels = new [] { "a", "i", "u", "e", "o" },
            vowelsByFormant = new[] { "i", "u", "e", "o", "a" },
            vowelFormantFloor = new[] { 0.0f, 250.0f, 300.0f, 450.0f, 600.0f },
            vowelFormantCeil = new[] { 0.0f, 250.0f, 300.0f, 450.0f, 600.0f }
        };

        public static LangData CN = new LangData
        {
            vowels = new[] { "a", "e", "i", "o", "u", "v" },
            vowelsByFormant = new[] { "i", "v", "u", "e", "o", "a" },
            vowelFormantFloor = new[] { 0.0f, 100.0f, 250.0f, 300.0f, 450.0f, 600.0f },
            vowelFormantCeil = new[] { 0.0f, 100.0f, 250.0f, 300.0f, 450.0f, 600.0f }
        };

        public static LangData KR = new LangData
        {
            vowels = new[] { "ㅏ", "ㅑ", "ㅓ", "ㅕ", "ㅗ", "ㅛ", "ㅜ", "ㅠ", "ㅡ", "ㅣ", "ㅔ", "ㅐ" },
            vowelsByFormant = new[] { "ㅏ", "ㅑ", "ㅓ", "ㅕ", "ㅗ", "ㅛ", "ㅜ", "ㅠ", "ㅡ", "ㅣ", "ㅔ", "ㅐ"},
            vowelFormantFloor = new[] { 0.0f, 100.0f, 250.0f, 300.0f, 450.0f, 600.0f, 700.0f, 800.0f, 950.0f, 1000.0f, 1150.0f, 1200.0f },
            vowelFormantCeil = new[] { 0.0f, 100.0f, 250.0f, 300.0f, 450.0f, 600.0f, 700.0f, 800.0f, 950.0f, 1000.0f, 1150.0f, 1200.0f }
        };
    }
}