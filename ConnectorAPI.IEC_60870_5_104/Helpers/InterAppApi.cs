namespace Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.Helpers
{
	using System.Collections.Generic;
	using System;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
	using Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp.Messages.Requests;
	using Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp.Messages.Responses;
	using Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp.Messages;

	/// <summary>
	/// InterApp API that contains all the generic information.
	/// </summary>
	public static class InterAppApi
	{
		private static readonly List<Type> knownTypesValue = new List<Type>
		{
			typeof(GenericInterAppMessage<ImportMetaDataRequest>),
			typeof(GenericInterAppMessage<ImportMetaDataResponse>),
		};

		/// <summary>
		///  A list of all the possible Message classes, necessary for the default background serializer.
		/// </summary>
		public static List<Type> KnownTypes { get => knownTypesValue; }

		/// <summary>
		/// Converts an <see cref="IInterAppRequest"/> message to a <see cref="Message"/> object.
		/// </summary>
		/// <param name="message">The <see cref="IInterAppRequest"/> message to be converted.</param>
		/// <returns>
		/// A <see cref="Message"/> object that represents the specified <see cref="IInterAppRequest"/> message.
		/// </returns>
		/// <exception cref="InvalidOperationException">Thrown when the message type is unknown.</exception>
		internal static Message ToMessage(IInterAppRequest message)
		{
			switch (message)
			{
				case ImportMetaDataRequest requestData:
					return new GenericInterAppMessage<ImportMetaDataRequest>(requestData);

				default:
					throw new InvalidOperationException("Unknown message type");
			}
		}

		/// <summary>
		/// Converts a <see cref="Message"/> object to an <see cref="IInterAppResponse"/>.
		/// </summary>
		/// <param name="message">The <see cref="Message"/> to be converted.</param>
		/// <returns>
		/// An <see cref="IInterAppResponse"/> object that represents the data from the specified <see cref="Message"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">Thrown when the message type is unknown.</exception>
		internal static IInterAppResponse FromMessage(Message message)
		{
			switch (message)
			{
				case GenericInterAppMessage<ImportMetaDataResponse> requestResult:
					return requestResult.Data;

				default:
					throw new InvalidOperationException("Unknown message type");
			}
		}
	}
}