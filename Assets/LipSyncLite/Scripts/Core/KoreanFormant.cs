namespace LipSyncLite
{
    public struct KoreanFormant
    {
        public char character;
        public char[] formant;

        public override string ToString()
        {
            if (formant != null)
            {
                if (formant[2] > 0)
                {
                    return $"{formant[0]}{formant[1]}{formant[2]}";
                } else if (formant[1] > 0)
                {
                    return $"{formant[0]}{formant[1]}";
                } else
                {
                    return formant[0].ToString();
                }
            } else
            {
                return character.ToString();
            }
        }
    }
}