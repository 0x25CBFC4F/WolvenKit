using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VignetteAreaSettings : IAreaSettings
	{
		private CBool _vignetteEnabled;
		private CFloat _vignetteRadius;
		private CFloat _vignetteExp;
		private CColor _vignetteColor;

		[Ordinal(2)] 
		[RED("vignetteEnabled")] 
		public CBool VignetteEnabled
		{
			get => GetProperty(ref _vignetteEnabled);
			set => SetProperty(ref _vignetteEnabled, value);
		}

		[Ordinal(3)] 
		[RED("vignetteRadius")] 
		public CFloat VignetteRadius
		{
			get => GetProperty(ref _vignetteRadius);
			set => SetProperty(ref _vignetteRadius, value);
		}

		[Ordinal(4)] 
		[RED("vignetteExp")] 
		public CFloat VignetteExp
		{
			get => GetProperty(ref _vignetteExp);
			set => SetProperty(ref _vignetteExp, value);
		}

		[Ordinal(5)] 
		[RED("vignetteColor")] 
		public CColor VignetteColor
		{
			get => GetProperty(ref _vignetteColor);
			set => SetProperty(ref _vignetteColor, value);
		}

		public VignetteAreaSettings()
		{
			_vignetteRadius = 0.500000F;
			_vignetteExp = 2.000000F;
		}
	}
}
