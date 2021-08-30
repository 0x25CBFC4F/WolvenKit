using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUIElement_ConditionType : questIUIConditionType
	{
		private TweakDBID _element;
		private CEnum<gamedataUICondition> _condition;
		private CBool _value;

		[Ordinal(0)] 
		[RED("element")] 
		public TweakDBID Element
		{
			get => GetProperty(ref _element);
			set => SetProperty(ref _element, value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CEnum<gamedataUICondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public questUIElement_ConditionType()
		{
			_condition = new() { Value = Enums.gamedataUICondition.Visible };
			_value = true;
		}
	}
}
