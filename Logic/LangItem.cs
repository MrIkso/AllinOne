using System;
using System.Xml.Serialization;

namespace AllInOne.Logic
{
	[Serializable]
	public class LangItem
	{
		[XmlAttribute]
		public string name;

		[XmlText]
		public string value;
	}
}
