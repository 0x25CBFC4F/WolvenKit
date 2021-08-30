using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterCombat_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CBool _isPlayer;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		public questCharacterCombat_ConditionType()
		{
			_isPlayer = true;
		}
	}
}
