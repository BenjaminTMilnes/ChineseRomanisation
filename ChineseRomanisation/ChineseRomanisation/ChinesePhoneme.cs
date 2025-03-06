using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseRomanisation
{
    public class ChinesePhoneme
    {
        public ChinesePhonemeType Type { get; set; }
        public string HanyuPinyin { get; set; }
        public string WadeGiles { get; set; }
        public string ZhuyinFuhao { get; set; }

        public ChinesePhoneme()
        {
            Type = ChinesePhonemeType.None;
            HanyuPinyin = "";
            WadeGiles = "";
            ZhuyinFuhao = "";
        }

        public ChinesePhoneme(ChinesePhonemeType type, string hanyuPinyin = "", string wadeGiles = "", string zhuyinFuhao = "")
        {
            Type = type;
            HanyuPinyin = hanyuPinyin;
            WadeGiles = wadeGiles;
            ZhuyinFuhao = zhuyinFuhao;
        }

        public static ChinesePhoneme M => new ChinesePhoneme(ChinesePhonemeType.Initial, "m", "m", "ㄇ");
        public static ChinesePhoneme N => new ChinesePhoneme(ChinesePhonemeType.Initial, "n", "n", "ㄋ");

        public static ChinesePhoneme B => new ChinesePhoneme(ChinesePhonemeType.Initial, "b", "p", "ㄅ");
        public static ChinesePhoneme D => new ChinesePhoneme(ChinesePhonemeType.Initial, "d", "t", "ㄉ");
        public static ChinesePhoneme G => new ChinesePhoneme(ChinesePhonemeType.Initial, "g", "k", "ㄍ");

        public static ChinesePhoneme P => new ChinesePhoneme(ChinesePhonemeType.Initial, "p", "p'", "ㄆ");
        public static ChinesePhoneme T => new ChinesePhoneme(ChinesePhonemeType.Initial, "t", "t'", "ㄊ");
        public static ChinesePhoneme K => new ChinesePhoneme(ChinesePhonemeType.Initial, "k", "k'", "ㄎ");
    }
}
