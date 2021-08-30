using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectDefinition : ISerializable
	{
		private CResourceReference<gameSmartObjectResource> _resource;
		private CArray<CName> _actions;
		private CResourceReference<animActionAnimDatabase> _motionActionDatabase;
		private CBool _enabled;
		private CBool _overrideGeneratedParameters;

		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceReference<gameSmartObjectResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(1)] 
		[RED("actions")] 
		public CArray<CName> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}

		[Ordinal(2)] 
		[RED("motionActionDatabase")] 
		public CResourceReference<animActionAnimDatabase> MotionActionDatabase
		{
			get => GetProperty(ref _motionActionDatabase);
			set => SetProperty(ref _motionActionDatabase, value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(4)] 
		[RED("overrideGeneratedParameters")] 
		public CBool OverrideGeneratedParameters
		{
			get => GetProperty(ref _overrideGeneratedParameters);
			set => SetProperty(ref _overrideGeneratedParameters, value);
		}

		public gameSmartObjectDefinition()
		{
			_enabled = true;
		}
	}
}
