﻿namespace Milyli.ScriptRunner.Services.Interfaces.V1.Models
{
	/// <summary>
	/// Defines a relativity script associated with a script run.
	/// </summary>
	public class Script
	{
		/// <summary>
		/// Script identifier.
		/// </summary>
		public int RelativityScriptId { get; set; }

		/// <summary>
		/// Identifier of the workspace the script belongs to.
		/// </summary>
		public int WorkspaceId { get; set; }

		/// <summary>
		/// Name of the workspace the script belongs to.
		/// </summary>
		public string WorkspaceName { get; set; }

		/// <summary>
		/// Name of the script.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Script description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Script timeout.
		/// </summary>
		public int ScriptTimeout { get; set; }
	}
}
