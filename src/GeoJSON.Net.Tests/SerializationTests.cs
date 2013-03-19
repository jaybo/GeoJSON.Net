using System.Globalization;
using GeoJSON.Net.CoordinateReferenceSystem;
using GeoJSON.Net.Geometry;
using NUnit.Framework;
using Newtonsoft.Json;

namespace GeoJSON.Net.Tests
{
    [TestFixture]
    public class SerializationTests
    {
        [Test]
        public void Should_serialize_Enumeration_to_simplified_json()
        {
            var point = new Point(new GeographicPosition(1, 2))
            {
                CRS = new NamedCRS(26912.ToString(CultureInfo.InvariantCulture))
            };

            Assert.That(point.Type, Is.EqualTo(GeoJSONObjectType.Point));

            string json = JsonConvert.SerializeObject(point);
            Assert.AreEqual(@"{""coordinates"":[2.0,1.0],""bbox"":null,""type"":""Point"",""crs"":{""type"":""Name"",""properties"":{""name"":""26912""}}}", json);
        }
    }
}
