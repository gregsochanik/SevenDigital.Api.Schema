using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SevenDigital.Api.Schema.Packages
{
	[Serializable]
	public class PackageList
	{
		[XmlArray("packages")]
		[XmlArrayItem("package")]
		public List<Package> Packages { get; set; }
	}
}