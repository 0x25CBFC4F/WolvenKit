using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtAdditionalPreset_FullControl : animLookAtAdditionalPreset
	{
		private CBool _useRightHand;
		private CBool _attachHandToOtherOne;
		private animLookAtLimits _limits;
		private CFloat _suppress;
		private CInt32 _mode;

		[Ordinal(0)] 
		[RED("useRightHand")] 
		public CBool UseRightHand
		{
			get => GetProperty(ref _useRightHand);
			set => SetProperty(ref _useRightHand, value);
		}

		[Ordinal(1)] 
		[RED("attachHandToOtherOne")] 
		public CBool AttachHandToOtherOne
		{
			get => GetProperty(ref _attachHandToOtherOne);
			set => SetProperty(ref _attachHandToOtherOne, value);
		}

		[Ordinal(2)] 
		[RED("limits")] 
		public animLookAtLimits Limits
		{
			get => GetProperty(ref _limits);
			set => SetProperty(ref _limits, value);
		}

		[Ordinal(3)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get => GetProperty(ref _suppress);
			set => SetProperty(ref _suppress, value);
		}

		[Ordinal(4)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public animLookAtAdditionalPreset_FullControl()
		{
			_useRightHand = true;
			_suppress = 1.000000F;
		}
	}
}
