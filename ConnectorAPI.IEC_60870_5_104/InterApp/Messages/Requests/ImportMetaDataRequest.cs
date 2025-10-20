namespace Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.InterApp.Messages.Requests
{
	using System;
	using System.Collections.Generic;

	using Skyline.DataMiner.ConnectorAPI.IEC_60870_5_104.Models;

	/// <summary>
	/// Represents a request to import metadata rows through an InterApp communication message.
	/// </summary>
	public class ImportMetaDataRequest : IInterAppRequest
	{
		/// <summary>
		/// Gets or sets the collection of metadata rows to be imported.
		/// </summary>
		public List<MetaDataRow> MetaDataRows { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for this import request, allowing correlation with the import script execution from the element.
		/// </summary>
		public Guid? RequestGuid { get; set; }
	}
}