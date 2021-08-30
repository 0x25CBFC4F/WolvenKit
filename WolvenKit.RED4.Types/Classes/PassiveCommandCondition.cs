using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveCommandCondition : AIbehaviorexpressionScript
	{
		private CName _commandName;
		private CBool _useInheritance;
		private CUInt32 _cmdCbId;

		[Ordinal(0)] 
		[RED("commandName")] 
		public CName CommandName
		{
			get => GetProperty(ref _commandName);
			set => SetProperty(ref _commandName, value);
		}

		[Ordinal(1)] 
		[RED("useInheritance")] 
		public CBool UseInheritance
		{
			get => GetProperty(ref _useInheritance);
			set => SetProperty(ref _useInheritance, value);
		}

		[Ordinal(2)] 
		[RED("cmdCbId")] 
		public CUInt32 CmdCbId
		{
			get => GetProperty(ref _cmdCbId);
			set => SetProperty(ref _cmdCbId, value);
		}

		public PassiveCommandCondition()
		{
			_useInheritance = true;
		}
	}
}
