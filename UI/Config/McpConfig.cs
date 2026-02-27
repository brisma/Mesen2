using ReactiveUI.Fody.Helpers;
using System;

namespace Mesen.Config
{
	public class McpConfig : BaseConfig<McpConfig>
	{
		[Reactive] public bool Enabled { get; set; } = false;
		[Reactive] [MinMax(1, 65535)] public UInt32 Port { get; set; } = 9100;

		public McpConfig()
		{
		}
	}
}
