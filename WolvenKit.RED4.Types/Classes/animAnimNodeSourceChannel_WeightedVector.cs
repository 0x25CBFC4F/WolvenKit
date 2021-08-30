using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNodeSourceChannel_WeightedVector : ISerializable
	{
		private CHandle<animIAnimNodeSourceChannel_Vector> _channel;
		private CFloat _weight;
		private animFloatLink _weightLink;
		private animNamedTrackIndex _weightFloatTrack;

		[Ordinal(0)] 
		[RED("channel")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> Channel
		{
			get => GetProperty(ref _channel);
			set => SetProperty(ref _channel, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(2)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetProperty(ref _weightLink);
			set => SetProperty(ref _weightLink, value);
		}

		[Ordinal(3)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetProperty(ref _weightFloatTrack);
			set => SetProperty(ref _weightFloatTrack, value);
		}

		public animAnimNodeSourceChannel_WeightedVector()
		{
			_weight = 1.000000F;
		}
	}
}
