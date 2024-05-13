using System;

namespace DPI.Networking.Transport
{
	// Token: 0x02001269 RID: 4713
	public enum NetworkTransportEventType
	{
		// Token: 0x0400DBBD RID: 56253
		Nothing,
		// Token: 0x0400DBBE RID: 56254
		KeepPolling,
		// Token: 0x0400DBBF RID: 56255
		Connected,
		// Token: 0x0400DBC0 RID: 56256
		Disconnected,
		// Token: 0x0400DBC1 RID: 56257
		DataAvailable,
		// Token: 0x0400DBC2 RID: 56258
		Timeout
	}
}
