using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftSetup : RedBaseClass
	{
		private CInt32 _startingFloorTerminal;
		private CFloat _liftSpeed;
		private CFloat _liftStartingDelay;
		private CFloat _liftTravelTimeOverride;
		private CBool _isLiftTravelTimeOverride;
		private CFloat _emptyLiftSpeedMultiplier;
		private CInt32 _radioStationNumer;
		private CName _speakerDestroyedQuestFact;
		private CName _speakerDestroyedVFX;
		private CString _authorizationTextOverride;

		[Ordinal(0)] 
		[RED("startingFloorTerminal")] 
		public CInt32 StartingFloorTerminal
		{
			get => GetProperty(ref _startingFloorTerminal);
			set => SetProperty(ref _startingFloorTerminal, value);
		}

		[Ordinal(1)] 
		[RED("liftSpeed")] 
		public CFloat LiftSpeed
		{
			get => GetProperty(ref _liftSpeed);
			set => SetProperty(ref _liftSpeed, value);
		}

		[Ordinal(2)] 
		[RED("liftStartingDelay")] 
		public CFloat LiftStartingDelay
		{
			get => GetProperty(ref _liftStartingDelay);
			set => SetProperty(ref _liftStartingDelay, value);
		}

		[Ordinal(3)] 
		[RED("liftTravelTimeOverride")] 
		public CFloat LiftTravelTimeOverride
		{
			get => GetProperty(ref _liftTravelTimeOverride);
			set => SetProperty(ref _liftTravelTimeOverride, value);
		}

		[Ordinal(4)] 
		[RED("isLiftTravelTimeOverride")] 
		public CBool IsLiftTravelTimeOverride
		{
			get => GetProperty(ref _isLiftTravelTimeOverride);
			set => SetProperty(ref _isLiftTravelTimeOverride, value);
		}

		[Ordinal(5)] 
		[RED("emptyLiftSpeedMultiplier")] 
		public CFloat EmptyLiftSpeedMultiplier
		{
			get => GetProperty(ref _emptyLiftSpeedMultiplier);
			set => SetProperty(ref _emptyLiftSpeedMultiplier, value);
		}

		[Ordinal(6)] 
		[RED("radioStationNumer")] 
		public CInt32 RadioStationNumer
		{
			get => GetProperty(ref _radioStationNumer);
			set => SetProperty(ref _radioStationNumer, value);
		}

		[Ordinal(7)] 
		[RED("speakerDestroyedQuestFact")] 
		public CName SpeakerDestroyedQuestFact
		{
			get => GetProperty(ref _speakerDestroyedQuestFact);
			set => SetProperty(ref _speakerDestroyedQuestFact, value);
		}

		[Ordinal(8)] 
		[RED("speakerDestroyedVFX")] 
		public CName SpeakerDestroyedVFX
		{
			get => GetProperty(ref _speakerDestroyedVFX);
			set => SetProperty(ref _speakerDestroyedVFX, value);
		}

		[Ordinal(9)] 
		[RED("authorizationTextOverride")] 
		public CString AuthorizationTextOverride
		{
			get => GetProperty(ref _authorizationTextOverride);
			set => SetProperty(ref _authorizationTextOverride, value);
		}

		public LiftSetup()
		{
			_liftSpeed = 2.500000F;
			_liftStartingDelay = 1.000000F;
			_liftTravelTimeOverride = 4.000000F;
			_emptyLiftSpeedMultiplier = 2.000000F;
			_radioStationNumer = -1;
		}
	}
}
