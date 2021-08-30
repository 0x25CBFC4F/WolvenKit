using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleGlassTint : ActionBool
	{
		private CString _trueRecord;
		private CString _falseRecord;

		[Ordinal(25)] 
		[RED("TrueRecord")] 
		public CString TrueRecord
		{
			get => GetProperty(ref _trueRecord);
			set => SetProperty(ref _trueRecord, value);
		}

		[Ordinal(26)] 
		[RED("FalseRecord")] 
		public CString FalseRecord
		{
			get => GetProperty(ref _falseRecord);
			set => SetProperty(ref _falseRecord, value);
		}

		public ToggleGlassTint()
		{
			_trueRecord = new() { Text = "TintGlass" };
			_falseRecord = new() { Text = "ClearGlass" };
		}
	}
}
