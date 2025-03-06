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

        public static ChinesePhoneme None => new ChinesePhoneme();

        public static ChinesePhoneme M => new ChinesePhoneme(ChinesePhonemeType.Initial, "m", "m", "ㄇ");
        public static ChinesePhoneme N => new ChinesePhoneme(ChinesePhonemeType.Initial, "n", "n", "ㄋ");

        public static ChinesePhoneme B => new ChinesePhoneme(ChinesePhonemeType.Initial, "b", "p", "ㄅ");
        public static ChinesePhoneme D => new ChinesePhoneme(ChinesePhonemeType.Initial, "d", "t", "ㄉ");
        public static ChinesePhoneme G => new ChinesePhoneme(ChinesePhonemeType.Initial, "g", "k", "ㄍ");

        public static ChinesePhoneme P => new ChinesePhoneme(ChinesePhonemeType.Initial, "p", "p'", "ㄆ");
        public static ChinesePhoneme T => new ChinesePhoneme(ChinesePhonemeType.Initial, "t", "t'", "ㄊ");
        public static ChinesePhoneme K => new ChinesePhoneme(ChinesePhonemeType.Initial, "k", "k'", "ㄎ");

        public static ChinesePhoneme Z => new ChinesePhoneme(ChinesePhonemeType.Initial, "z", "ts", "ㄗ");
        public static ChinesePhoneme Zh => new ChinesePhoneme(ChinesePhonemeType.Initial, "zh", "ch", "ㄓ");
        public static ChinesePhoneme J => new ChinesePhoneme(ChinesePhonemeType.Initial, "j", "ch", "ㄐ");

        public static ChinesePhoneme C => new ChinesePhoneme(ChinesePhonemeType.Initial, "c", "ts'", "ㄘ");
        public static ChinesePhoneme Ch => new ChinesePhoneme(ChinesePhonemeType.Initial, "ch", "ch'", "ㄔ");
        public static ChinesePhoneme Q => new ChinesePhoneme(ChinesePhonemeType.Initial, "q", "ch'", "ㄑ");

        public static ChinesePhoneme F => new ChinesePhoneme(ChinesePhonemeType.Initial, "f", "f", "ㄈ");
        public static ChinesePhoneme S => new ChinesePhoneme(ChinesePhonemeType.Initial, "s", "s", "ㄙ");
        public static ChinesePhoneme Sh => new ChinesePhoneme(ChinesePhonemeType.Initial, "sh", "sh", "ㄕ");
        public static ChinesePhoneme X => new ChinesePhoneme(ChinesePhonemeType.Initial, "x", "hs", "ㄒ");
        public static ChinesePhoneme H => new ChinesePhoneme(ChinesePhonemeType.Initial, "h", "h", "ㄏ");

        public static ChinesePhoneme L => new ChinesePhoneme(ChinesePhonemeType.Initial, "l", "l", "ㄌ");
        public static ChinesePhoneme R => new ChinesePhoneme(ChinesePhonemeType.Initial, "r", "j", "ㄖ");

        public static ChinesePhoneme _I => new ChinesePhoneme(ChinesePhonemeType.Final, "-i", "ih", "ㄭ");
        public static ChinesePhoneme E => new ChinesePhoneme(ChinesePhonemeType.Final, "e", "ê", "ㄜ");
        public static ChinesePhoneme A => new ChinesePhoneme(ChinesePhonemeType.Final, "a", "a", "ㄚ");
        public static ChinesePhoneme Ei => new ChinesePhoneme(ChinesePhonemeType.Final, "ei", "ei", "ㄟ");
        public static ChinesePhoneme Ai => new ChinesePhoneme(ChinesePhonemeType.Final, "ai", "ai", "ㄞ");
        public static ChinesePhoneme Ou => new ChinesePhoneme(ChinesePhonemeType.Final, "ou", "ou", "ㄡ");
        public static ChinesePhoneme Ao => new ChinesePhoneme(ChinesePhonemeType.Final, "ao", "ao", "ㄠ");
        public static ChinesePhoneme En => new ChinesePhoneme(ChinesePhonemeType.Final, "en", "ên", "ㄣ");
        public static ChinesePhoneme An => new ChinesePhoneme(ChinesePhonemeType.Final, "an", "an", "ㄢ");
        public static ChinesePhoneme Ong => new ChinesePhoneme(ChinesePhonemeType.Final, "ong", "ung", "ㄨㄥ");
        public static ChinesePhoneme Eng => new ChinesePhoneme(ChinesePhonemeType.Final, "eng", "êng", "ㄥ");
        public static ChinesePhoneme Ang => new ChinesePhoneme(ChinesePhonemeType.Final, "ang", "ang", "ㄤ");
        public static ChinesePhoneme Er => new ChinesePhoneme(ChinesePhonemeType.Final, "er", "êrh", "ㄦ");

        public static ChinesePhoneme I => new ChinesePhoneme(ChinesePhonemeType.Final, "i", "i", "ㄧ");
        public static ChinesePhoneme Ie => new ChinesePhoneme(ChinesePhonemeType.Final, "ie", "ieh", "ㄧㄝ");
        public static ChinesePhoneme Ia => new ChinesePhoneme(ChinesePhonemeType.Final, "ia", "ia", "ㄧㄚ");
        public static ChinesePhoneme Iu => new ChinesePhoneme(ChinesePhonemeType.Final, "iu", "iu", "ㄧㄡ");
        public static ChinesePhoneme Iao => new ChinesePhoneme(ChinesePhonemeType.Final, "iao", "iao", "ㄧㄠ");
        public static ChinesePhoneme In => new ChinesePhoneme(ChinesePhonemeType.Final, "in", "in", "ㄧㄣ");
        public static ChinesePhoneme Ian => new ChinesePhoneme(ChinesePhonemeType.Final, "ian", "ien", "ㄧㄢ");
        public static ChinesePhoneme Iong => new ChinesePhoneme(ChinesePhonemeType.Final, "iong", "iung", "ㄩㄥ");
        public static ChinesePhoneme Ing => new ChinesePhoneme(ChinesePhonemeType.Final, "ing", "ing", "ㄧㄥ");
        public static ChinesePhoneme Iang => new ChinesePhoneme(ChinesePhonemeType.Final, "iang", "iang", "ㄧㄤ");

        public static ChinesePhoneme U => new ChinesePhoneme(ChinesePhonemeType.Final, "u", "u", "ㄨ");
        public static ChinesePhoneme Uo => new ChinesePhoneme(ChinesePhonemeType.Final, "uo", "uo", "ㄨㄛ");
        public static ChinesePhoneme Ua => new ChinesePhoneme(ChinesePhonemeType.Final, "ua", "ua", "ㄨㄚ");
        public static ChinesePhoneme Ui => new ChinesePhoneme(ChinesePhonemeType.Final, "ui", "uei", "ㄨㄟ");
        public static ChinesePhoneme Uai => new ChinesePhoneme(ChinesePhonemeType.Final, "uai", "uai", "ㄨㄞ");
        public static ChinesePhoneme Un => new ChinesePhoneme(ChinesePhonemeType.Final, "un", "un", "ㄨㄣ");
        public static ChinesePhoneme Uan => new ChinesePhoneme(ChinesePhonemeType.Final, "uan", "uan", "ㄨㄢ");
        public static ChinesePhoneme Uang => new ChinesePhoneme(ChinesePhonemeType.Final, "uang", "uang", "ㄨㄤ");

        public static ChinesePhoneme Uu => new ChinesePhoneme(ChinesePhonemeType.Final, "ü", "ü", "ㄩ");
        public static ChinesePhoneme Uue => new ChinesePhoneme(ChinesePhonemeType.Final, "üe", "üeh", "ㄩㄝ");
        public static ChinesePhoneme Uun => new ChinesePhoneme(ChinesePhonemeType.Final, "ün", "ün", "ㄩㄣ");
        public static ChinesePhoneme Uuan => new ChinesePhoneme(ChinesePhonemeType.Final, "üan", "üan", "ㄩㄢ");
    }
}
