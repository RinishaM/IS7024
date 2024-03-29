﻿namespace AirportDetails
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Airport
    {
        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("elevation_ft")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ElevationFeet { get; set; }

        [JsonProperty("gps_code")]
        public string GpsCode { get; set; }

        [JsonProperty("iata_code")]
        public object IataCode { get; set; }

        [JsonProperty("ident")]
        public string Ident { get; set; }

        [JsonProperty("iso_country")]
        public string IsoCountry { get; set; }

        [JsonProperty("iso_region")]
        public string IsoRegion { get; set; }

        [JsonProperty("local_code")]
        public string LocalCode { get; set; }

        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Airport
    {
        public static Airport[] FromJson(string json) => JsonConvert.DeserializeObject<Airport[]>(json, AirportDetails.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Airport[] self) => JsonConvert.SerializeObject(self, AirportDetails.Converter.Settings);
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

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}