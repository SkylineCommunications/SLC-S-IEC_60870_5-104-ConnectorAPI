namespace Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp.Messages.Responses
{
	using System;

	using Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp.Messages.Requests;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Represents the response returned after processing an <see cref="ImportMetaDataRequest"/>.
	/// </summary>
	public class ImportMetaDataResponse : IInterAppResponse
	{
		/// <inheritdoc/>
		public bool SuccessStatus { get; set; }

		/// <inheritdoc/>
		public string StatusMessage { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier from import request.
		/// </summary>
		public Guid? RequestGuid { get; set; }

		/// <inheritdoc/>
		public Message ToMessage()
		{
			return new GenericInterAppMessage<ImportMetaDataResponse>(this);
		}
	}
}