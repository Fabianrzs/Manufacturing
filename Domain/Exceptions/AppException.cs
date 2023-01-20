using System.Runtime.Serialization;

namespace Domain.Exception
{
    [System.Serializable]
    public class AppException : System.Exception
    {
        public AppException() { }
        public AppException(string message) : base(message) { }
        public AppException(string message, System.Exception inner) : base(message, inner) { }
        protected AppException(SerializationInfo info,StreamingContext context) : base(info, context) { }
    }
}
