﻿using System.Web.Script.Serialization;

namespace PusherServer
{
    /// <summary>
    /// Default implmentation for deserializing an object
    /// </summary>
    public class DefaultDeserializer : IDeserializeJsonStrings
    {
        /// <inheritDoc/>
        public T Deserialize<T>(string stringToDeserialize)
        {
            return new JavaScriptSerializer().Deserialize<T>(stringToDeserialize);
        }
    }
}