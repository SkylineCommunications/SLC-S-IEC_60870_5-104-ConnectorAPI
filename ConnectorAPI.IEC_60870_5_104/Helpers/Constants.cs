namespace Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.Helpers
{
	/// <summary>
	/// Contains constant values used in the ConnectorAPI.
	/// </summary>
	internal static class Constants
	{
		/// <summary>
		/// The protocol name of the IEC 60870 5-104.
		/// </summary>
		internal const string ProtocolName = "IEC 60870 5-104";

		/// <summary>
		/// The ID of the parameter that will receive the InterApp Messages
		/// </summary>
		internal const int InterAppReceiverPID = 9000000;

		/// <summary>
		/// The ID of the parameter that will hold the responses for the InterApp Messages
		/// </summary>
		internal const int InterAppResponsePID = 9000001;
	}
}