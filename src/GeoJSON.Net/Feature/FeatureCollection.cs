// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureCollection.cs" company="Jörg Battermann">
//   Copyright © Jörg Battermann 2011
// </copyright>
// <summary>
//   Defines the FeatureCollection type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GeoJSON.Net.Feature
{
    /// <summary>
    ///     Defines the FeatureCollection type.
    /// </summary>
    public class FeatureCollection : GeoJSONObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FeatureCollection" /> class.
        /// </summary>
        /// <param name="features">The features.</param>
        public FeatureCollection(List<Feature> features)
        {
            Features = features;

            Type = GeoJSONObjectType.FeatureCollection;
        }

        /// <summary>
        ///     Gets the features.
        /// </summary>
        /// <value>The features.</value>
        [JsonProperty(PropertyName = "features", Required = Required.Always)]
        public List<Feature> Features { get; private set; }

        [JsonProperty(PropertyName = "type", Required = Required.Always, Order = 0, ItemConverterType = typeof(StringEnumConverter))]
        public GeoJSONObjectType Type { get; internal set; }
    }
}