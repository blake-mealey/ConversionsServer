using System;

namespace Chimerical.Conversions.Dal
{
    public class DataNotFoundException : Exception
    {
        public DataNotFoundException()
        {
        }

        public DataNotFoundException(string message, Exception innerException = null) : base("", innerException)
        {
        }

        public DataNotFoundException(string type, string id, Exception innerException = null) : base($"{type} object with ID {id} could not be found.", innerException)
        {
        }
    }
}
