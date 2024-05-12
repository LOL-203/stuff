using System;

namespace VLB
{
	// Token: 0x020005D4 RID: 1492
	public enum RenderQueue
	{
		// Token: 0x04004DF6 RID: 19958
		Custom,
		// Token: 0x04004DF7 RID: 19959
		Background = 1000,
		// Token: 0x04004DF8 RID: 19960
		Geometry = 2000,
		// Token: 0x04004DF9 RID: 19961
		AlphaTest = 2450,
		// Token: 0x04004DFA RID: 19962
		GeometryLast = 2500,
		// Token: 0x04004DFB RID: 19963
		Transparent = 3000,
		// Token: 0x04004DFC RID: 19964
		Overlay = 4000
	}
}
