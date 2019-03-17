using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AllInOne.Logic.Util
{
    public static class Utils
    {
        public static object locker = new object();

        public static string getJavaPath()
        {
            try
            {
                return Directory.GetFiles(Program.pathToBatchapktool + "\\bin", "java.exe", SearchOption.AllDirectories)[0];
            }
            catch (Exception e)
            {
                WriteLog("getJavaPath\n" + e.Message + "\n" + e.ToString());
                return "java.exe";
            }
        }

        public static void WriteLog(string str)
        {
            lock (locker) { File.AppendAllText(Program.pathToBatchapktool + "\\AllInOne_log.txt", DateTime.Now.ToString("HH:mm:ss") + " :\n" + str); }
        }

        public static void WriteDebugLog(string str)
        {
            lock (locker) { File.AppendAllText(Program.pathToBatchapktool + "\\AllInOne_DEBUG.txt", str); }
        }

        public static void DelDebugLogFile()
        {
            lock (locker)
            {
                File.Delete(Program.pathToBatchapktool + "\\AllInOne_DEBUG.txt");
            }
        }
        public static byte[] stringToBytes(string str)//"FF FF"
        {
            string[] strSplit = str.Split(' ');
            byte[] result = new byte[strSplit.Length];

            for (int i = 0; i < strSplit.Length; i++)
            {
                result[i] = Convert.ToByte(strSplit[i], 16);
            }
            return result;
        }

        public static string stringToHex(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Encoding.UTF8.GetBytes(str))
            {
                sb.Append(b.ToString("X2"));
                sb.Append(" ");
            }
            return sb.ToString().TrimEnd();
        }

        public static string convertUnicodeToText(string text)
        {
            string result = "";
            try
            {
                UTF8Encoding utf = new UTF8Encoding();
                UnicodeEncoding unicode = new UnicodeEncoding();
                foreach (Match m in Regex.Matches(text, @"\\u([0-9a-fA-F]+)"))
                {
                    text = text.Replace(m.Value, ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString());
                }
                result = utf.GetString(Encoding.Convert(unicode, utf, unicode.GetBytes(text))).Replace("\r", "").Replace("\n", "");
            }
            catch (Exception e)
            {
                return "";
            }
            return result;
        }

        public static string convertBase64ToText(string text)
        {
            UTF8Encoding utf = new UTF8Encoding();
            UnicodeEncoding unicode = new UnicodeEncoding();
            string result = "";
            byte[] resultBytes;

            try
            {
                if (text.Length % 4 == 0 && text.Length >= 4)
                {
                    if (text.Length == 4 && text.IndexOf("=") == -1) { return ""; }

                    resultBytes = Convert.FromBase64String(text);

                    result = utf.GetString(resultBytes).Replace("\r", "").Replace("\n", "");
                    foreach (char c in result)
                    {
                        if (Char.GetUnicodeCategory(c) == UnicodeCategory.OtherLetter || Char.GetUnicodeCategory(c) == UnicodeCategory.OtherSymbol || Char.GetUnicodeCategory(c) == UnicodeCategory.Control)
                        {
                            result = "";
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return "";
            }
            return result;
        }

        public static string convertArrayDataToString(string text)
        {
            try
            {
                string result = "";
                List<string> replaced = new List<string>();
                string[] letters = new string[] { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", ".", ",", "\'", "\"", "%", "\\", "@", ":", ";", "(", ")", "*", "&", "[", "]", "/", "_", "-", "+", "=", "?", "{", "}", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", " " };
                string[] lettersHex = new string[] { "-0x30t-0x70t", "-0x30t-0x6ft", "-0x30t-0x6et", "-0x30t-0x6dt", "-0x30t-0x6ct", "-0x30t-0x6bt", "-0x30t-0x7ft", "-0x30t-0x6at", "-0x30t-0x69t", "-0x30t-0x68t", "-0x30t-0x67t", "-0x30t-0x66t", "-0x30t-0x65t", "-0x30t-0x64t", "-0x30t-0x63t", "-0x30t-0x62t", "-0x30t-0x61t", "-0x30t-0x60t", "-0x30t-0x5ft", "-0x30t-0x5et", "-0x30t-0x5dt", "-0x30t-0x5ct", "-0x30t-0x5bt", "-0x30t-0x5at", "-0x30t-0x59t", "-0x30t-0x58t", "-0x30t-0x57t", "-0x30t-0x56t", "-0x30t-0x55t", "-0x30t-0x54t", "-0x30t-0x53t", "-0x30t-0x52t", "-0x30t-0x51t", "-0x30t-0x50t", "-0x30t-0x4ft", "-0x30t-0x4et", "-0x30t-0x4dt", "-0x30t-0x4ct", "-0x30t-0x4bt", "-0x2ft-0x6ft", "-0x30t-0x4at", "-0x30t-0x49t", "-0x30t-0x48t", "-0x30t-0x47t", "-0x30t-0x46t", "-0x30t-0x45t", "-0x30t-0x44t", "-0x30t-0x43t", "-0x30t-0x42t", "-0x30t-0x41t", "-0x2ft-0x80t", "-0x2ft-0x7ft", "-0x2ft-0x7et", "-0x2ft-0x7dt", "-0x2ft-0x7ct", "-0x2ft-0x7bt", "-0x2ft-0x7at", "-0x2ft-0x79t", "-0x2ft-0x78t", "-0x2ft-0x77t", "-0x2ft-0x76t", "-0x2ft-0x75t", "-0x2ft-0x74t", "-0x2ft-0x73t", "-0x2ft-0x72t", "-0x2ft-0x71t", "0x41t", "0x42t", "0x43t", "0x44t", "0x45t", "0x46t", "0x47t", "0x48t", "0x49t", "0x4at", "0x4bt", "0x4ct", "0x4dt", "0x4et", "0x4ft", "0x50t", "0x51t", "0x52t", "0x53t", "0x54t", "0x55t", "0x56t", "0x57t", "0x58t", "0x59t", "0x5at", "0x61t", "0x62t", "0x63t", "0x64t", "0x65t", "0x66t", "0x67t", "0x68t", "0x69t", "0x6at", "0x6bt", "0x6ct", "0x6dt", "0x6et", "0x6ft", "0x70t", "0x71t", "0x72t", "0x73t", "0x74t", "0x75t", "0x76t", "0x77t", "0x78t", "0x79t", "0x7at", "0x2et", "0x2ct", "0x27t", "0x22t", "0x25t", "0x5ct", "0x40t", "0x3at", "0x3bt", "0x28t", "0x29t", "0x2at", "0x26t", "0x5bt", "0x5dt", "0x2ft", "0x5ft", "0x2dt", "0x2bt", "0x3dt", "0x3ft", "0x7bt", "0x7dt", "0x31t", "0x32t", "0x33t", "0x34t", "0x35t", "0x36t", "0x37t", "0x38t", "0x39t", "0x30t", "0x20t" };
                UTF8Encoding utf = new UTF8Encoding();
                ASCIIEncoding asci = new ASCIIEncoding();
                UnicodeEncoding unicode = new UnicodeEncoding();

                text = text.Replace("\r\n", "");
                text = text.Replace(" ", "");

                for (int i = 0; i < letters.Length; i++)
                {
                    if (replaced.Contains(letters[i])) { continue; }

                    text = text.Replace(lettersHex[i], letters[i]);
                    replaced.Add(letters[i]);
                }
                if (Regex.Matches(text, @"-?0x[a-fA-F0-9]+t").Count != 0) { return ""; }

                replaced.Clear();
                result = utf.GetString(Encoding.Convert(unicode, utf, unicode.GetBytes(text))).Replace("\r", "").Replace("\n", "");

                return result;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static string getCurrentTime()
        {
            long result = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            return "0x" + result.ToString("X") + "L";
        }

        public static string parseDateTime(string dateTime, string path)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(dateTime);
                long result = (long)(dt - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                return "0x" + result.ToString("X") + "L";
            }
            catch (Exception e)
            {
                MessageBox.Show(Language.errorMsg, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteLog("Error in parseDateTime\nError message:" + e.Message + "\n" + e.ToString());
                return "";
            }
        }
        public static string ReadRSA(string path)
        {
            if (!File.Exists(path + "\\original\\META-INF\\CERT.RSA"))
            {
                MessageBox.Show(path + Language.errorMsgRsa, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            FileStream fs = new FileStream(path + "\\original\\META-INF\\CERT.RSA", FileMode.Open);
            int hexIn;
            String hex = "";

            for (int i = 0; (hexIn = fs.ReadByte()) != -1; i++)
            {
                hex = hex + string.Format("{0:X2}", hexIn);
            }
            return hex;
        }
    }
}
