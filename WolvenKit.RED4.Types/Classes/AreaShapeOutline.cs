using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AreaShapeOutline : ISerializable
	{
		private CArray<Vector3> _points;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("points")] 
		public CArray<Vector3> Points
		{
			get => GetProperty(ref _points);
			set => SetProperty(ref _points, value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		public AreaShapeOutline()
		{
			_height = 2.000000F;
		}
	}
}
