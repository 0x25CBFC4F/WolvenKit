using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JukeboxControllerPS : ScriptableDeviceComponentPS
	{
		private JukeboxSetup _jukeboxSetup;
		private CArray<RadioStationsMap> _stations;
		private CInt32 _activeStation;
		private CBool _isPlaying;

		[Ordinal(104)] 
		[RED("jukeboxSetup")] 
		public JukeboxSetup JukeboxSetup
		{
			get => GetProperty(ref _jukeboxSetup);
			set => SetProperty(ref _jukeboxSetup, value);
		}

		[Ordinal(105)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetProperty(ref _stations);
			set => SetProperty(ref _stations, value);
		}

		[Ordinal(106)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get => GetProperty(ref _activeStation);
			set => SetProperty(ref _activeStation, value);
		}

		[Ordinal(107)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetProperty(ref _isPlaying);
			set => SetProperty(ref _isPlaying, value);
		}

		public JukeboxControllerPS()
		{
			_isPlaying = true;
		}
	}
}
