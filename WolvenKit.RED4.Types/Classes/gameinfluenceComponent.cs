using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinfluenceComponent : entIPlacedComponent
	{
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public gameinfluenceComponent()
		{
			_isEnabled = true;
		}
	}
}
