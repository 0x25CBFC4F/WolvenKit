using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetItemTags_NodeTypeParams : RedBaseClass
	{
		private CHandle<questUniversalRef> _objectRef;
		private TweakDBID _itemId;
		private CBool _addTags;
		private CEnum<gameEItemDynamicTags> _tags;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(2)] 
		[RED("addTags")] 
		public CBool AddTags
		{
			get => GetProperty(ref _addTags);
			set => SetProperty(ref _addTags, value);
		}

		[Ordinal(3)] 
		[RED("tags")] 
		public CEnum<gameEItemDynamicTags> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		public questSetItemTags_NodeTypeParams()
		{
			_addTags = true;
			_tags = new() { Value = Enums.gameEItemDynamicTags.Quest };
		}
	}
}
