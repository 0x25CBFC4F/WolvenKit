using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalPhoneMessage : gameJournalEntry
	{
		private CEnum<gameMessageSender> _sender;
		private LocalizationString _text;
		private TweakDBID _imageId;
		private CFloat _delay;
		private CHandle<gameJournalPath> _attachment;

		[Ordinal(1)] 
		[RED("sender")] 
		public CEnum<gameMessageSender> Sender
		{
			get => GetProperty(ref _sender);
			set => SetProperty(ref _sender, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(3)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetProperty(ref _imageId);
			set => SetProperty(ref _imageId, value);
		}

		[Ordinal(4)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(5)] 
		[RED("attachment")] 
		public CHandle<gameJournalPath> Attachment
		{
			get => GetProperty(ref _attachment);
			set => SetProperty(ref _attachment, value);
		}

		public gameJournalPhoneMessage()
		{
			_delay = 3.000000F;
		}
	}
}
