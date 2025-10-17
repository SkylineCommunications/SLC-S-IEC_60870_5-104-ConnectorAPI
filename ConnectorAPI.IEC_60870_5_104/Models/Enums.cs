namespace Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.Models
{
	/// <summary>
	/// Defines the operational state of a device.
	/// </summary>
	public enum DeviceStatus
	{
		/// <summary>
		/// The device is disabled.
		/// </summary>
		Disable,

		/// <summary>
		/// The device is enabled.
		/// </summary>
		Enable,
	}

	/// <summary>
	/// Specifies the type of a device.
	/// </summary>
	public enum DeviceType
	{
		/// <summary>
		/// Represents an analog input device.
		/// </summary>
		AnalogInput,

		/// <summary>
		/// Represents an analog output device.
		/// </summary>
		AnalogOutput,

		/// <summary>
		/// Represents a digital input device.
		/// </summary>
		DigitalInput,

		/// <summary>
		/// Represents a digital output device.
		/// </summary>
		DigitalOutput,
	}
}
