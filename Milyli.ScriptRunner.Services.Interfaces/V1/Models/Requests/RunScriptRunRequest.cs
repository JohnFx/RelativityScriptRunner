﻿namespace Milyli.ScriptRunner.Services.Interfaces.V1.Models.Requests
{
	/// <summary>
	/// Request definition to run a single script run.
	/// </summary>
	public class RunScriptRunRequest
	{
		/// <summary>
		/// Script Run to execute.
		/// </summary>
		public int ScriptRunId { get; set; }
	}
}
