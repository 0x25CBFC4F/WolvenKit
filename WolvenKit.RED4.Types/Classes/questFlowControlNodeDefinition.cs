using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFlowControlNodeDefinition : questDisableableNodeDefinition
	{
		private CBool _isOpen;
		private CUInt16 _opensAt;
		private CUInt16 _closesAt;

		[Ordinal(2)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(3)] 
		[RED("opensAt")] 
		public CUInt16 OpensAt
		{
			get => GetProperty(ref _opensAt);
			set => SetProperty(ref _opensAt, value);
		}

		[Ordinal(4)] 
		[RED("closesAt")] 
		public CUInt16 ClosesAt
		{
			get => GetProperty(ref _closesAt);
			set => SetProperty(ref _closesAt, value);
		}

		public questFlowControlNodeDefinition()
		{
			_isOpen = true;
		}
	}
}
