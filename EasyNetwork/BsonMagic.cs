//-----------------------------------------------------------------------------
// BsonMagic.cs Copyright(c) 2015 Jacob Christensen and Bryan Hansen
//
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.
//-----------------------------------------------------------------------------

namespace EasyNetwork
{
    using System.IO;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Bson;

    /// <summary>
    /// Class which serializes and deserializes objects to/from Binary JSON
    /// </summary>
    public static class BsonMagic
    {
        /// <summary>
        /// Serialize an object into Binary JSON
        /// </summary>
        /// <typeparam name="T">Type of the object being serialized</typeparam>
        /// <param name="objectToSerialize">The object to be serialized</param>
        /// <returns>An array of bytes containing the serialized object</returns>
        public static byte[] SerializeObject<T>(T objectToSerialize)
        {
            byte[] data;

            using (MemoryStream ms = new MemoryStream())
            {
                using (BsonWriter writer = new BsonWriter(ms))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, objectToSerialize);
                    data = ms.ToArray();
                }
            }

            return data;
        }

        /// <summary>
        /// Deserializes an object from Binary JSON
        /// </summary>
        /// <typeparam name="T">Type of the object to deserialize</typeparam>
        /// <param name="binaryData">Byte array containing the previously serialized object</param>
        /// <returns>The deserialized object</returns>
        public static T DeserializeObject<T>(byte[] binaryData)
        {
            T deserialziedObject;

            using (MemoryStream ms = new MemoryStream(binaryData))
            {
                using (BsonReader reader = new BsonReader(ms))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    deserialziedObject = serializer.Deserialize<T>(reader);
                }
            }

            return deserialziedObject;
        }
    }
}
