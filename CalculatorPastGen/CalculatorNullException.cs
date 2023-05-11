using System.Runtime.Serialization;

namespace CalculatorPastGen
{
    [Serializable]
    public class CalculatorNullException : Exception, ISerializable
    {
        public CalculatorNullException() : base() { }
        public CalculatorNullException(string message) : base(message) { }
        public CalculatorNullException(string message, Exception inner) : base(message, inner) { }
        protected CalculatorNullException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            base.GetObjectData(info, context);
        }
    }
}
