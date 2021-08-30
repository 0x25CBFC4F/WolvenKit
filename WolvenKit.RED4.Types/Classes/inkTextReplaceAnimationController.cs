using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTextReplaceAnimationController : inkTextAnimationController
	{
		private CFloat _timeToSkip;
		private CEnum<inkTextReplaceAnimationControllerWidgetTextUsage> _widgetTextUsage;
		private LocalizationString _baseTextLocalized;
		private CString _targetText;
		private LocalizationString _targetTextLocalized;

		[Ordinal(8)] 
		[RED("timeToSkip")] 
		public CFloat TimeToSkip
		{
			get => GetProperty(ref _timeToSkip);
			set => SetProperty(ref _timeToSkip, value);
		}

		[Ordinal(9)] 
		[RED("widgetTextUsage")] 
		public CEnum<inkTextReplaceAnimationControllerWidgetTextUsage> WidgetTextUsage
		{
			get => GetProperty(ref _widgetTextUsage);
			set => SetProperty(ref _widgetTextUsage, value);
		}

		[Ordinal(10)] 
		[RED("baseTextLocalized")] 
		public LocalizationString BaseTextLocalized
		{
			get => GetProperty(ref _baseTextLocalized);
			set => SetProperty(ref _baseTextLocalized, value);
		}

		[Ordinal(11)] 
		[RED("targetText")] 
		public CString TargetText
		{
			get => GetProperty(ref _targetText);
			set => SetProperty(ref _targetText, value);
		}

		[Ordinal(12)] 
		[RED("targetTextLocalized")] 
		public LocalizationString TargetTextLocalized
		{
			get => GetProperty(ref _targetTextLocalized);
			set => SetProperty(ref _targetTextLocalized, value);
		}

		public inkTextReplaceAnimationController()
		{
			_timeToSkip = 0.050000F;
		}
	}
}
