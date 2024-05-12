using System;

namespace VLB
{
	// Token: 0x020005D7 RID: 1495
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		// Token: 0x04004E04 RID: 19972
		Never = 1,
		// Token: 0x04004E05 RID: 19973
		OnEnable = 2,
		// Token: 0x04004E06 RID: 19974
		OnBeamMove = 4,
		// Token: 0x04004E07 RID: 19975
		EveryXFrames = 8,
		// Token: 0x04004E08 RID: 19976
		OnBeamMoveAndEveryXFrames = 12
	}
}
