using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighlightEditableData : IScriptable
	{
		private CEnum<EFocusForcedHighlightType> _highlightType;
		private CEnum<EFocusOutlineType> _outlineType;
		private CEnum<EPriority> _priority;
		private CFloat _inTransitionTime;
		private CFloat _outTransitionTime;
		private CBool _isRevealed;
		private CEnum<gameVisionModePatternType> _patternType;

		[Ordinal(0)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetProperty(ref _highlightType);
			set => SetProperty(ref _highlightType, value);
		}

		[Ordinal(1)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get => GetProperty(ref _outlineType);
			set => SetProperty(ref _outlineType, value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(3)] 
		[RED("inTransitionTime")] 
		public CFloat InTransitionTime
		{
			get => GetProperty(ref _inTransitionTime);
			set => SetProperty(ref _inTransitionTime, value);
		}

		[Ordinal(4)] 
		[RED("outTransitionTime")] 
		public CFloat OutTransitionTime
		{
			get => GetProperty(ref _outTransitionTime);
			set => SetProperty(ref _outTransitionTime, value);
		}

		[Ordinal(5)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetProperty(ref _isRevealed);
			set => SetProperty(ref _isRevealed, value);
		}

		[Ordinal(6)] 
		[RED("patternType")] 
		public CEnum<gameVisionModePatternType> PatternType
		{
			get => GetProperty(ref _patternType);
			set => SetProperty(ref _patternType, value);
		}

		public HighlightEditableData()
		{
			_outlineType = new() { Value = Enums.EFocusOutlineType.INVALID };
			_inTransitionTime = 0.500000F;
			_outTransitionTime = 0.500000F;
		}
	}
}
