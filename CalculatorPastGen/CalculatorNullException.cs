using System.Runtime.Serialization;

namespace CalculatorPastGen
{
    [Serializable]
    /// <summary>
    /// Represents an exception that is thrown when a calculator instance is null.
    /// </summary>
    public class CalculatorNullException : Exception, ISerializable
    {
        /// <summary>
        /// Initializes a new instance of the CalculatorNullException class.
        /// </summary>
        public CalculatorNullException() : base() { }

        /// <summary>
        /// Initializes a new instance of the CalculatorNullException class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public CalculatorNullException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the CalculatorNullException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception.</param>
        public CalculatorNullException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Initializes a new instance of the CalculatorNullException class with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected CalculatorNullException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        /// <summary>
        /// Sets the SerializationInfo with information about the exception.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
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
