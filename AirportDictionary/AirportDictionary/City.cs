namespace CityDetails
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class City
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("geonameid")]
        public long GeoNameID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subcountry")]
        public string Subcountry { get; set; }
    }

    public partial class City
    {
        public static City[] FromJson(string json) => JsonConvert.DeserializeObject<City[]>(json, CityDetails.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this City[] self) => JsonConvert.SerializeObject(self, CityDetails.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}