using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GlobalLightingTrajectoryOverride : RedBaseClass
	{
		private CFloat _overrideScale;
		private CFloat _latitude;
		private CFloat _sunRotationOffset;
		private CFloat _moonRotationOffset;
		private CEnum<ETimeOfYearSeason> _timeOfYearSeason;

		[Ordinal(0)] 
		[RED("overrideScale")] 
		public CFloat OverrideScale
		{
			get => GetProperty(ref _overrideScale);
			set => SetProperty(ref _overrideScale, value);
		}

		[Ordinal(1)] 
		[RED("latitude")] 
		public CFloat Latitude
		{
			get => GetProperty(ref _latitude);
			set => SetProperty(ref _latitude, value);
		}

		[Ordinal(2)] 
		[RED("sunRotationOffset")] 
		public CFloat SunRotationOffset
		{
			get => GetProperty(ref _sunRotationOffset);
			set => SetProperty(ref _sunRotationOffset, value);
		}

		[Ordinal(3)] 
		[RED("moonRotationOffset")] 
		public CFloat MoonRotationOffset
		{
			get => GetProperty(ref _moonRotationOffset);
			set => SetProperty(ref _moonRotationOffset, value);
		}

		[Ordinal(4)] 
		[RED("timeOfYearSeason")] 
		public CEnum<ETimeOfYearSeason> TimeOfYearSeason
		{
			get => GetProperty(ref _timeOfYearSeason);
			set => SetProperty(ref _timeOfYearSeason, value);
		}

		public GlobalLightingTrajectoryOverride()
		{
			_timeOfYearSeason = new() { Value = Enums.ETimeOfYearSeason.ETOYS_Summer };
		}
	}
}
