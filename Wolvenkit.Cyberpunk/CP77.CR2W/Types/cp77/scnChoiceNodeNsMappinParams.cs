using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsMappinParams : ISerializable
	{
		[Ordinal(0)]  [RED("locationType")] public CEnum<scnChoiceNodeNsMappinLocation> LocationType { get; set; }
		[Ordinal(1)]  [RED("mappinSettings")] public TweakDBID MappinSettings { get; set; }

		public scnChoiceNodeNsMappinParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
