using System;
using System.Runtime.Serialization;

namespace VNVon.Service.CustomException
{
    [Serializable()]
    public class ServiceException : Exception, ISerializable
    {
        public int Id { get; set; }
        public int ErrorCode { get; set; }
        public ServiceException() : base() { }
        public ServiceException(string message) : base(message) { }
        public ServiceException(string message, System.Exception inner) : base(message, inner) { }
        public ServiceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public ServiceException(string message, int Id, int ErrorCode)
            : base(message)
        {
            this.Id = Id;
            this.ErrorCode = ErrorCode;
        }

        public ServiceException(string message, int ErrorCode)
            : base(message)
        {
            this.ErrorCode = ErrorCode;
        }

        public object GetObjectMessage()
        {
            return new { ErrorCode, Message };
        }
    }
}
