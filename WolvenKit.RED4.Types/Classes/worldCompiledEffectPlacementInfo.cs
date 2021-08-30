using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCompiledEffectPlacementInfo : RedBaseClass
	{
		private CUInt8 _placementTagIndex;
		private CUInt8 _relativePositionIndex;
		private CUInt8 _relativeRotationIndex;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("placementTagIndex")] 
		public CUInt8 PlacementTagIndex
		{
			get => GetProperty(ref _placementTagIndex);
			set => SetProperty(ref _placementTagIndex, value);
		}

		[Ordinal(1)] 
		[RED("relativePositionIndex")] 
		public CUInt8 RelativePositionIndex
		{
			get => GetProperty(ref _relativePositionIndex);
			set => SetProperty(ref _relativePositionIndex, value);
		}

		[Ordinal(2)] 
		[RED("relativeRotationIndex")] 
		public CUInt8 RelativeRotationIndex
		{
			get => GetProperty(ref _relativeRotationIndex);
			set => SetProperty(ref _relativeRotationIndex, value);
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public worldCompiledEffectPlacementInfo()
		{
			_placementTagIndex = 255;
			_relativePositionIndex = 255;
			_relativeRotationIndex = 255;
		}
	}
}
