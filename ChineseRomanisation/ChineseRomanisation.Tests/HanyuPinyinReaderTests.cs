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
        public void ReadWriteTest1(string input, string output1, string output2)
        {
            var syllables = HanyuPinyinReader.ReadHanyuPinyin(input);

            Assert.Equal(output1, string.Join("", syllables.Select(s => s.ToString("HP"))));
            Assert.Equal(output2, string.Join("", syllables.Select(s => s.ToString("WG"))));
        }
    }
}
