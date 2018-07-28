using Newtonsoft.Json;

namespace SamsWebsite.Models.GitHub
{
	public class License
	{
		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("spdx_id")]
		public string SpdxId { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}
}