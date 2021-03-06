﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MultiPoint.cs" company="Jörg Battermann">
//   Copyright © Jörg Battermann 2011
// </copyright>
// <summary>
//   Defines the MultiPoint type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeoJSON.Net.Geometry
{
    /// <summary>
    ///     Contains an array of <see cref="Point" />s.
    /// </summary>
    /// <seealso cref="http://geojson.org/geojson-spec.html#multipoint" />
    public class MultiPoint : GeoJSONObject, IGeometryObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MultiPoint" /> class.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        public MultiPoint(List<Point> coordinates = null)
        {
            Coordinates = coordinates ?? new List<Point>();
            Type = GeoJSONObjectType.MultiPoint;
        }

        /// <summary>
        ///     Gets the Coordinates.
        /// </summary>
        /// <value>The Coordinates.</value>
        [JsonProperty(PropertyName = "coordinates", Required = Required.Always)]
        public List<Point> Coordinates { get; private set; }
    }
}