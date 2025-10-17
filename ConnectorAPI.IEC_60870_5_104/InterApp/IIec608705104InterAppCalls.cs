namespace Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp
{
	using System;
	using System.Collections.Generic;

	using Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp.Messages;
	using Skyline.DataMiner.Net;

	/// <summary>
	/// Defines the methods for inter-application communication.
	/// </summary>
	public interface IIec608705104InterAppCalls
	{
		/// <summary>
		/// The SLNet Connection to use.
		/// </summary>
		IConnection SLNetConnection { get; set; }

		/// <summary>
		/// The id of the DataMiner that is hosting the element.
		/// </summary>
		int AgentId { get; }

		/// <summary>
		/// The id of the element in DataMiner.
		/// </summary>
		int ElementId { get; }

		/// <summary>
		/// Sends the specified messages to the element using InterApp and do not wait for a response.
		/// </summary>
		/// <param name="messages">The messages that need to be send.</param>
		void SendMessageNoResponse(params IInterAppRequest[] messages);

		/// <summary>
		/// Sends the specified messages to the element using InterApp and wait for the responses.
		/// </summary>
		/// <param name="messages">The messages that need to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the element</returns>
		IEnumerable<IInterAppResponse> SendMessages(IInterAppRequest[] messages, TimeSpan timeout = default);

		/// <summary>
		/// Sends the specified message to the element using InterApp and wait for the responses.
		/// </summary>
		/// <param name="message">The message that needs to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the element</returns>
		IInterAppResponse SendSingleResponseMessage(IInterAppRequest message, TimeSpan timeout = default);

		/// <summary>
		/// Sends the specified message to the element using InterApp and wait for the responses.
		/// </summary>
		/// <param name="message">The message that needs to be send.</param>
		/// <param name="timeout">The time the method needs to wait for a response.</param>
		/// <returns>The response coming from the device</returns>
		/// <typeparam name="T">The type of the expected response, which must implement <see cref="IInterAppResponse"/>.</typeparam>
		T SendSingleResponseMessage<T>(IInterAppRequest message, TimeSpan timeout = default) where T : IInterAppResponse;
	}
}
