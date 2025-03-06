using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseRomanisation
{
    public class HanyuPinyinReader
    {
        public static List<ChineseSyllable> ReadHanyuPinyin(string text)
        {
            var syllables = new List<ChineseSyllable>();

            var initials = ChinesePhoneme.Initials.OrderBy(i => i.HanyuPinyin.Length).Reverse();
            var finals = ChinesePhoneme.Finals.OrderBy(f => f.HanyuPinyin.Length).Reverse();

            var n = 0;

            while (n < text.Length)
            {
                var initial = ChinesePhoneme.None;
                var final = ChinesePhoneme.None;

                foreach (var i in initials)
                {
                    if (text.Substring(n, i.HanyuPinyin.Length) == i.HanyuPinyin)
                    {
                        initial = i;

                        n += i.HanyuPinyin.Length;

                        break;
                    }
                }

                foreach (var f in finals)
                {
                    if (n + f.HanyuPinyin.Length <= text.Length && text.Substring(n, f.HanyuPinyin.Length) == f.HanyuPinyin)
                    {
                        final = f;

                        n += f.HanyuPinyin.Length;

                        break;
                    }
                }

                if (final.Equals(ChinesePhoneme.None))
                {
                    break;
                }

                var syllable = new ChineseSyllable(initial, final);

                syllables.Add(syllable);
            }

            return syllables;
        }
    }
}
