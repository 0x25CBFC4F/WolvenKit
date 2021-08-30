using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtPreset_EyesHead : animLookAtPreset
	{
		private CFloat _suppressHeadAnimation;
		private CFloat _headMobility;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("suppressHeadAnimation")] 
		public CFloat SuppressHeadAnimation
		{
			get => GetProperty(ref _suppressHeadAnimation);
			set => SetProperty(ref _suppressHeadAnimation, value);
		}

		[Ordinal(1)] 
		[RED("headMobility")] 
		public CFloat HeadMobility
		{
			get => GetProperty(ref _headMobility);
			set => SetProperty(ref _headMobility, value);
		}

		[Ordinal(2)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetProperty(ref _softLimitAngle);
			set => SetProperty(ref _softLimitAngle, value);
		}

		public animLookAtPreset_EyesHead()
		{
			_headMobility = 0.950000F;
			_softLimitAngle = 360.000000F;
		}
	}
}
