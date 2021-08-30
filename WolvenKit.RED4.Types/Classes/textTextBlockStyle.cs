using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class textTextBlockStyle : RedBaseClass
	{
		private HDRColor _tintColor;
		private Vector2 _shadowOffset;
		private HDRColor _shadowColor;
		private textTextBlockFontStyle _fontStyle;
		private CUInt16 _fontSize;

		[Ordinal(0)] 
		[RED("tintColor")] 
		public HDRColor TintColor
		{
			get => GetProperty(ref _tintColor);
			set => SetProperty(ref _tintColor, value);
		}

		[Ordinal(1)] 
		[RED("shadowOffset")] 
		public Vector2 ShadowOffset
		{
			get => GetProperty(ref _shadowOffset);
			set => SetProperty(ref _shadowOffset, value);
		}

		[Ordinal(2)] 
		[RED("shadowColor")] 
		public HDRColor ShadowColor
		{
			get => GetProperty(ref _shadowColor);
			set => SetProperty(ref _shadowColor, value);
		}

		[Ordinal(3)] 
		[RED("fontStyle")] 
		public textTextBlockFontStyle FontStyle
		{
			get => GetProperty(ref _fontStyle);
			set => SetProperty(ref _fontStyle, value);
		}

		[Ordinal(4)] 
		[RED("fontSize")] 
		public CUInt16 FontSize
		{
			get => GetProperty(ref _fontSize);
			set => SetProperty(ref _fontSize, value);
		}

		public textTextBlockStyle()
		{
			_fontSize = 22;
		}
	}
}
