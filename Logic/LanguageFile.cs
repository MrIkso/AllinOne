using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AllInOne.Logic
{
	[Serializable]
	public class LanguageFile
	{
		[XmlEnum]
		public List<string[]> strings;
	}
}
