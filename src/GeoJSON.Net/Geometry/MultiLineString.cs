// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MultiLineString.cs" company="Jörg Battermann">
//   Copyright © Jörg Battermann 2011
// </copyright>
// <summary>
//   Defines the <see cref="http://geojson.org/geojson-spec.html#multilinestring">MultiLineString</see> type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeoJSON.Net.Geometry
{
    /// <summary>
    ///     Defines the <see cref="http://geojson.org/geojson-spec.html#multilinestring">MultiLineString</see> type.
    /// </summary>
    public class MultiLineString : GeoJSONObject, IGeometryObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MultiLineString" /> class.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        public MultiLineString(List<LineString> coordinates)
        {
            Coordinates = coordinates ?? new List<LineString>();
            Type = GeoJSONObjectType.MultiLineString;
        }

        /// <summary>
        ///     Gets the Coordinates.
        /// </summary>
        /// <value>The Coordinates.</value>
        [JsonProperty(PropertyName = "coordinates", Required = Required.Always)]
        public List<LineString> Coordinates { get; private set; }
    }
}