using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SamsWebsite.Models.GitHub
{
	public static class Converter
	{
		private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
		{
			MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
			DateParseHandling = DateParseHandling.None,
			Converters = {
				new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
			},
		};

		public static Repository[] FromJson(string json) => JsonConvert.DeserializeObject<Repository[]>(json, Settings);

		public static string ToJson(this Repository[] self) => JsonConvert.SerializeObject(self, Settings);
	}
}