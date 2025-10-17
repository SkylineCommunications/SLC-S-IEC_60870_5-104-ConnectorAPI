namespace Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.Models
{
	/// <summary>
	/// Represents a device and its associated metadata.
	/// </summary>
	public class MetaDataRow
	{
		/// <summary>
		/// Gets or sets the unique key identifying the device.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Gets or sets the device family.
		/// </summary>
		public string Family { get; set; }

		/// <summary>
		/// Gets or sets the sub-family of the device.
		/// </summary>
		public string SubFamily { get; set; }

		/// <summary>
		/// Gets or sets the main object or functional group the device belongs to.
		/// </summary>
		public string Object { get; set; }

		/// <summary>
		/// Gets or sets the sub-object or subgroup within the main object.
		/// </summary>
		public string SubObject { get; set; }

		/// <summary>
		/// Gets or sets the service name or functional service associated with the device.
		/// </summary>
		public string Service { get; set; }

		/// <summary>
		/// Gets or sets the UCA (Unified Control Architecture) identifier related to the device.
		/// </summary>
		public string Uca { get; set; }

		/// <summary>
		/// Gets or sets the physical or logical position of the device.
		/// </summary>
		public string Position { get; set; }

		/// <summary>
		/// Gets or sets the operational status of the device (enabled or disabled).
		/// </summary>
		public DeviceStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the IP address assigned to the device.
		/// </summary>
		public string Ip { get; set; }

		/// <summary>
		/// Gets or sets the type of device (analog/digital input or output).
		/// </summary>
		public DeviceType Type { get; set; }

		/// <summary>
		/// Gets or sets the SIMET (simulation/metering) identifier of the device.
		/// </summary>
		public double? IdSimet { get; set; }

		/// <summary>
		/// Gets or sets the SIMET parameter name related to the device.
		/// </summary>
		public string ParameterSimet { get; set; }

		/// <summary>
		/// Gets or sets the INGRID identification reference for the device.
		/// </summary>
		public string IdenIngrid { get; set; }

		/// <summary>
		/// Gets or sets the display name of the device.
		/// </summary>
		public string DeviceName { get; set; }

		/// <summary>
		/// Gets or sets a description of the signal or measurement provided by the device.
		/// </summary>
		public string SignalDescription { get; set; }

		/// <summary>
		/// Gets or sets the discrete values or states associated with the device’s signal.
		/// </summary>
		public string Discreets { get; set; }

		/// <summary>
		/// Gets or sets the factor applied to the parameter.
		/// </summary>
		public object Factor { get; set; }

		/// <summary>
		/// Gets or sets the CA (Common Address) value of the device.
		/// </summary>
		public double? Ca { get; set; }

		/// <summary>
		/// Gets or sets the IOA (Information Object Address) associated with the device.
		/// </summary>
		public double? Ioa { get; set; }

		/// <summary>
		/// Gets or sets the unit of measurement for the parameter.
		/// </summary>
		public string Units { get; set; }

		/// <summary>
		/// Gets or sets the writable IOA value if applicable.
		/// </summary>
		public object IoaWr { get; set; }

		/// <summary>
		/// Gets or sets the name or location of the site where the device is installed.
		/// </summary>
		public string Site { get; set; }
	}

}