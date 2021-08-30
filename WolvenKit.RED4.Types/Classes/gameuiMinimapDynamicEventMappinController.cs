using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinimapDynamicEventMappinController : gameuiBaseMinimapMappinController
	{
		private CBool _pulseEnabled;
		private inkWidgetReference _pulseWidget;
		private CFloat _hideAtDistance;
		private CBool _hideInCombat;
		private CHandle<inkanimProxy> _pulseAnim;

		[Ordinal(14)] 
		[RED("pulseEnabled")] 
		public CBool PulseEnabled
		{
			get => GetProperty(ref _pulseEnabled);
			set => SetProperty(ref _pulseEnabled, value);
		}

		[Ordinal(15)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetProperty(ref _pulseWidget);
			set => SetProperty(ref _pulseWidget, value);
		}

		[Ordinal(16)] 
		[RED("hideAtDistance")] 
		public CFloat HideAtDistance
		{
			get => GetProperty(ref _hideAtDistance);
			set => SetProperty(ref _hideAtDistance, value);
		}

		[Ordinal(17)] 
		[RED("hideInCombat")] 
		public CBool HideInCombat
		{
			get => GetProperty(ref _hideInCombat);
			set => SetProperty(ref _hideInCombat, value);
		}

		[Ordinal(18)] 
		[RED("pulseAnim")] 
		public CHandle<inkanimProxy> PulseAnim
		{
			get => GetProperty(ref _pulseAnim);
			set => SetProperty(ref _pulseAnim, value);
		}

		public gameuiMinimapDynamicEventMappinController()
		{
			_hideAtDistance = 25.000000F;
			_hideInCombat = true;
		}
	}
}
