
namespace ImplicateX.TinyCLR.Components.Web
{
	public sealed partial class ICY
	{
		public sealed class Information
		{
			public string Name { get; init; }
			public string Description { get; init; }
			public string Genre { get; init; }
			public string Url { get; init; }

			public int Bitrate { get; init; }
			public int SampleRate { get; init; }
			public int Channels { get; init; }
		}
	}
}
