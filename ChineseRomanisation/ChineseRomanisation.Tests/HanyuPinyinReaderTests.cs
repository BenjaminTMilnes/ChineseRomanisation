﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseRomanisation.Tests
{
    public class HanyuPinyinReaderTests
    {
        /// <summary>
        /// Tests that a single syllable can be read and then output in different romanisations. A number of the syllables given in the tests are either rare or never occur in Chinese; however, since the system works just as well whether or not such syllables are explicitly blocked / ignored, they might as well be tested.
        /// </summary>
        /// <param name="input">The Hanyu Pinyin to read</param>
        /// <param name="output1">The syllable outputted as Hanyu Pinyin</param>
        /// <param name="output2">The syllable outputted as Wade-Giles</param>
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
        [InlineData("mui", "mui", "mui")]
        [InlineData("nui", "nui", "nui")]
        [InlineData("bui", "bui", "pui")]
        [InlineData("dui", "dui", "tui")]
        [InlineData("gui", "gui", "kuei")]
        [InlineData("pui", "pui", "p'ui")]
        [InlineData("tui", "tui", "t'ui")]
        [InlineData("kui", "kui", "k'uei")]
        [InlineData("zui", "zui", "tsui")]
        [InlineData("zhui", "zhui", "chui")]
        [InlineData("jui", "jui", "chui")]
        [InlineData("cui", "cui", "ts'ui")]
        [InlineData("chui", "chui", "ch'ui")]
        [InlineData("qui", "qui", "ch'ui")]
        [InlineData("fui", "fui", "fui")]
        [InlineData("sui", "sui", "sui")]
        [InlineData("shui", "shui", "shui")]
        [InlineData("xui", "xui", "hsui")]
        [InlineData("hui", "hui", "hui")]
        [InlineData("lui", "lui", "lui")]
        [InlineData("rui", "rui", "jui")]
        public void ReadWriteTest1(string input, string output1, string output2)
        {
            var syllables = HanyuPinyinReader.ReadHanyuPinyin(input);

            Assert.Equal(output1, string.Join("", syllables.Select(s => s.ToString("HP"))));
            Assert.Equal(output2, string.Join("", syllables.Select(s => s.ToString("WG"))));
        }
    }
}
