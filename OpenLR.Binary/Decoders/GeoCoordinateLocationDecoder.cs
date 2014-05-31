﻿using OpenLR.Binary.Data;
using OpenLR.Locations;

namespace OpenLR.Binary.Decoders
{
    /// <summary>
    /// A decoder that decodes binary data into a geo coordinate.
    /// </summary>
    public class GeoCoordinateLocationDecoder : BinaryLocationDecoder<GeoCoordinateLocation>
    {
        /// <summary>
        /// Decodes the given data into a location reference.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected override GeoCoordinateLocation Decode(byte[] data)
        {
            var geoCoordinate = new GeoCoordinateLocation();
            geoCoordinate.Coordinate = CoordinateConverter.Decode(data, 1);
            return geoCoordinate;
        }

        /// <summary>
        /// Returns true if the given data can be decoded by this decoder.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected override bool CanDecode(byte[] data)
        {
            return data != null && data.Length == 7;
        }
    }
}