﻿using System;
using System.Xml.Serialization;
using SevenDigital.Api.Schema.Attributes;

namespace SevenDigital.Api.Schema
{
	[Serializable]
	[ApiEndpoint("status")]
	[XmlRoot("serviceStatus")]
	public class Status
	{
		[XmlElement("serverTime")]
		public DateTime ServerTime { get; set; }
	}
}