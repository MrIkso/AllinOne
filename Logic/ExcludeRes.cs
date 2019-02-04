using System;

namespace AllInOne.Logic
{
    [Serializable]
    public class ExcludeRes
    {
        public string[] langList
        {
            get
            {
                return langs.Split(new string[] { "," },StringSplitOptions.RemoveEmptyEntries);
            }
        }
        public string[] qualList
        {
            get
            {
                return quals.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        public string[] libList
        {
            get
            {
                return libs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        public string langs;
        public string quals;
        public string libs;
        public string basis;
        public bool animator;
        public bool anim;
        public bool color;
        public bool font;
        public bool drawable;
        public bool mipmap;
        public bool layout;
        public bool lib;
        public bool menu;
        public bool raw;
        public bool values;
        public bool xml;

    }
}
