using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PointerController : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _connectors;
		private inkWidgetReference _pointer;
		private inkWidgetReference _centerButtonSlot;
		private CWeakHandle<inkWidget> _centerButton;
		private CInt32 _currentIndex;

		[Ordinal(1)] 
		[RED("connectors")] 
		public CArray<inkWidgetReference> Connectors
		{
			get => GetProperty(ref _connectors);
			set => SetProperty(ref _connectors, value);
		}

		[Ordinal(2)] 
		[RED("pointer")] 
		public inkWidgetReference Pointer
		{
			get => GetProperty(ref _pointer);
			set => SetProperty(ref _pointer, value);
		}

		[Ordinal(3)] 
		[RED("centerButtonSlot")] 
		public inkWidgetReference CenterButtonSlot
		{
			get => GetProperty(ref _centerButtonSlot);
			set => SetProperty(ref _centerButtonSlot, value);
		}

		[Ordinal(4)] 
		[RED("centerButton")] 
		public CWeakHandle<inkWidget> CenterButton
		{
			get => GetProperty(ref _centerButton);
			set => SetProperty(ref _centerButton, value);
		}

		[Ordinal(5)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetProperty(ref _currentIndex);
			set => SetProperty(ref _currentIndex, value);
		}

		public PointerController()
		{
			_currentIndex = -1;
		}
	}
}
