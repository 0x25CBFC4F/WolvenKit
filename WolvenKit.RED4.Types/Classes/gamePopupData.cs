using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePopupData : RedBaseClass
	{
		private CString _title;
		private CString _message;
		private TweakDBID _iconID;
		private CBool _isModal;
		private CEnum<gameVideoType> _videoType;
		private CResourceAsyncReference<Bink> _video;

		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(1)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(2)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		[Ordinal(3)] 
		[RED("isModal")] 
		public CBool IsModal
		{
			get => GetProperty(ref _isModal);
			set => SetProperty(ref _isModal, value);
		}

		[Ordinal(4)] 
		[RED("videoType")] 
		public CEnum<gameVideoType> VideoType
		{
			get => GetProperty(ref _videoType);
			set => SetProperty(ref _videoType, value);
		}

		[Ordinal(5)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		public gamePopupData()
		{
			_videoType = new() { Value = Enums.gameVideoType.Unknown };
		}
	}
}
