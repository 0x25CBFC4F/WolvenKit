using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entColliderComponentCapsule : entColliderComponentShape
	{
		private CFloat _radius;
		private CFloat _height;

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		public entColliderComponentCapsule()
		{
			_radius = 1.000000F;
			_height = 1.000000F;
		}
	}
}
