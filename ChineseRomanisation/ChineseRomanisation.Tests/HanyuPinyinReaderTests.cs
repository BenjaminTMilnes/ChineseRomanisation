using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseRomanisation.Tests
{
    public class HanyuPinyinReaderTests
    {
        [Theory]
        [InlineData("ma", "ma", "ma")]
        [InlineData("na", "na", "na")]
        [InlineData("ba", "ba", "pa")]
        [InlineData("da", "da", "ta")]
        [InlineData("ga", "ga", "ka")]
        [InlineData("pa", "pa", "p'a")]
        [InlineData("ta", "ta", "t'a")]
        [InlineData("ka", "ka", "k'a")]
        [InlineData("za", "za", "tsa")]
        [InlineData("zha", "zha", "cha")]
        [InlineData("ja", "ja", "cha")]
        [InlineData("ca", "ca", "ts'a")]
        [InlineData("cha", "cha", "ch'a")]
        [InlineData("qa", "qa", "ch'a")]
        [InlineData("fa", "fa", "fa")]
        [InlineData("sa", "sa", "sa")]
        [InlineData("sha", "sha", "sha")]
        [InlineData("xa", "xa", "hsa")]
        [InlineData("ha", "ha", "ha")]
        [InlineData("la", "la", "la")]
        [InlineData("ra", "ra", "ja")]
        [InlineData("mei", "mei", "mei")]
        [InlineData("nei", "nei", "nei")]
        [InlineData("bei", "bei", "pei")]
        [InlineData("dei", "dei", "tei")]
        [InlineData("gei", "gei", "kei")]
        [InlineData("pei", "pei", "p'ei")]
        [InlineData("tei", "tei", "t'ei")]
        [InlineData("kei", "kei", "k'ei")]
        [InlineData("zei", "zei", "tsei")]
        [InlineData("zhei", "zhei", "chei")]
        [InlineData("jei", "jei", "chei")]
        [InlineData("cei", "cei", "ts'ei")]
        [InlineData("chei", "chei", "ch'ei")]
        [InlineData("qei", "qei", "ch'ei")]
        [InlineData("fei", "fei", "fei")]
        [InlineData("sei", "sei", "sei")]
        [InlineData("shei", "shei", "shei")]
        [InlineData("xei", "xei", "hsei")]
        [InlineData("hei", "hei", "hei")]
        [InlineData("lei", "lei", "lei")]
        [InlineData("rei", "rei", "jei")]
        [InlineData("men", "men", "mên")]
        [InlineData("nen", "nen", "nên")]
        [InlineData("ben", "ben", "pên")]
        [InlineData("den", "den", "tên")]
        [InlineData("gen", "gen", "kên")]
        [InlineData("pen", "pen", "p'ên")]
        [InlineData("ten", "ten", "t'ên")]
        [InlineData("ken", "ken", "k'ên")]
        [InlineData("zen", "zen", "tsên")]
        [InlineData("zhen", "zhen", "chên")]
        [InlineData("jen", "jen", "chên")]
        [InlineData("cen", "cen", "ts'ên")]
        [InlineData("chen", "chen", "ch'ên")]
        [InlineData("qen", "qen", "ch'ên")]
        [InlineData("fen", "fen", "fên")]
        [InlineData("sen", "sen", "sên")]
        [InlineData("shen", "shen", "shên")]
        [InlineData("xen", "xen", "hsên")]
        [InlineData("hen", "hen", "hên")]
        [InlineData("len", "len", "lên")]
        [InlineData("ren", "ren", "jên")]
        public void ReadWriteTest1(string input, string output1, string output2)
        {
            var syllables = HanyuPinyinReader.ReadHanyuPinyin(input);

            Assert.Equal(output1, string.Join("", syllables.Select(s => s.ToString("HP"))));
            Assert.Equal(output2, string.Join("", syllables.Select(s => s.ToString("WG"))));
        }
    }
}
