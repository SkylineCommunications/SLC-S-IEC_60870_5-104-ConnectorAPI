namespace Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp.Messages
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Represents an InterApp Message that a IEC 60870 5-104 element can receive.
	/// </summary>
	public interface IInterAppMessage
	{
	}

	/// <summary>
	/// Represents a generic inter-application message that contains data of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the data contained in the message, which must implement <see cref="IInterAppMessage"/>.</typeparam>
	public class GenericInterAppMessage<T> : Message
			where T : IInterAppMessage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GenericInterAppMessage{T}"/> class with the specified data.
		/// </summary>
		/// <param name="data">The data contained in the message.</param>
		public GenericInterAppMessage(T data)
		{
			Data = data;
		}

		/// <summary>
		/// Gets the data contained in the message.
		/// </summary>
		public T Data { get; }
	}

	/// <summary>
	/// Base class that hold default properties that every request has.
	/// </summary>
	public interface IInterAppRequest : IInterAppMessage
	{
		
	}

	/// <summary>
	/// Base class that hold default properties that every response has.
	/// </summary>
	public interface IInterAppResponse : IInterAppMessage
	{
		/// <summary>
		/// Gets or sets the status if the request was parsed and received OK.
		/// </summary>
		bool SuccessStatus { get; set; }

		/// <summary>
		/// Gets or sets the additional status information about the response.
		/// </summary>
		string StatusMessage { get; set; }

		/// <summary>
		/// Generates the <see cref="Message"/> to be sent back via InterApp.
		/// </summary>
		/// <returns><see cref="Message"/> with the response from the request.</returns>
		Message ToMessage();
	}
}