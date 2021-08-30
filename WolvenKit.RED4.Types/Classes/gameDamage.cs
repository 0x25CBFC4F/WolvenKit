using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDamage : IScriptable
	{
		private CEnum<gamedataDamageType> _damageType;
		private CFloat _value;

		[Ordinal(0)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public gameDamage()
		{
			_damageType = new() { Value = Enums.gamedataDamageType.Physical };
		}
	}
}
