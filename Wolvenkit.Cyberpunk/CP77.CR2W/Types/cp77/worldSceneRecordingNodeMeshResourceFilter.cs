using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingNodeMeshResourceFilter : CVariable
	{
		[Ordinal(0)]  [RED("forceFilterIgnore")] public CArray<raRef<CMesh>> ForceFilterIgnore { get; set; }
		[Ordinal(1)]  [RED("forceFilterMatch")] public CArray<raRef<CMesh>> ForceFilterMatch { get; set; }

		public worldSceneRecordingNodeMeshResourceFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
