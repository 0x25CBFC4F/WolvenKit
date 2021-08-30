using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnPlaySkAnimEventData : RedBaseClass
	{
		private CName _animName;
		private CFloat _blendIn;
		private CFloat _blendOut;
		private CFloat _clipFront;
		private CFloat _stretch;
		private CFloat _weight;
		private CName _bodyPartMask;

		[Ordinal(0)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(1)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get => GetProperty(ref _blendIn);
			set => SetProperty(ref _blendIn, value);
		}

		[Ordinal(2)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get => GetProperty(ref _blendOut);
			set => SetProperty(ref _blendOut, value);
		}

		[Ordinal(3)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get => GetProperty(ref _clipFront);
			set => SetProperty(ref _clipFront, value);
		}

		[Ordinal(4)] 
		[RED("stretch")] 
		public CFloat Stretch
		{
			get => GetProperty(ref _stretch);
			set => SetProperty(ref _stretch, value);
		}

		[Ordinal(5)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(6)] 
		[RED("bodyPartMask")] 
		public CName BodyPartMask
		{
			get => GetProperty(ref _bodyPartMask);
			set => SetProperty(ref _bodyPartMask, value);
		}

		public scnPlaySkAnimEventData()
		{
			_stretch = 1.000000F;
			_weight = 1.000000F;
		}
	}
}
