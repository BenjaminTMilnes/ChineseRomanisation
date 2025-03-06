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
        public void ReadWriteTest1(string input, string output1, string output2)
        {
            var syllables = HanyuPinyinReader.ReadHanyuPinyin(input);

            Assert.Equal(output1, string.Join("", syllables.Select(s => s.ToString("HP"))));
            Assert.Equal(output2, string.Join("", syllables.Select(s => s.ToString("WG"))));
        }
    }
}
