namespace ImplicateX.TinyCLR.Components.Web
{
	/// <summary>
	/// Contains descriptive and technical information about an ICY<br/>
	/// (Internet Content Yield, originally "I Can Yell") stream.
	/// </summary>
	public sealed partial class ICY
	{
		/// <summary>
		/// Describes the station and audio format advertised by an ICY stream.
		/// </summary>
		public sealed class Information
		{
			/// <summary>
			/// Gets the station or stream name.
			/// </summary>
			public string Name { get; init; }

			/// <summary>
			/// Gets the station or stream description.
			/// </summary>
			public string Description { get; init; }

			/// <summary>
			/// Gets the genre of the station or stream.
			/// </summary>
			public string Genre { get; init; }

			/// <summary>
			/// Gets the URL associated with the station or stream.
			/// </summary>
			public string Url { get; init; }

			/// <summary>
			/// Gets the advertised audio bitrate, in kilobits per second.
			/// </summary>
			public int Bitrate { get; init; }

			/// <summary>
			/// Gets the audio sample rate, in samples per second.
			/// </summary>
			public int SampleRate { get; init; }

			/// <summary>
			/// Gets the number of audio channels.
			/// </summary>
			public int Channels { get; init; }
		}
	}
}