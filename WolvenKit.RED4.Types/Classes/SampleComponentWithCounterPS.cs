using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleComponentWithCounterPS : gameComponentPS
	{
		private CInt32 _counter;

		[Ordinal(0)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		public SampleComponentWithCounterPS()
		{
			_counter = 1000;
		}
	}
}
