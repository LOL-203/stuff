using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Audio
{
	// Token: 0x020008F0 RID: 2288
	public class G_AudioText : MonoBehaviour
	{
		// Token: 0x0600BAC9 RID: 47817 RVA: 0x002FC7A8 File Offset: 0x002FA9A8
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BACA RID: 47818 RVA: 0x002FC7EC File Offset: 0x002FA9EC
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BACB RID: 47819 RVA: 0x002FC830 File Offset: 0x002FAA30
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BACC RID: 47820 RVA: 0x002FC874 File Offset: 0x002FAA74
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioText.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BACD RID: 47821 RVA: 0x002FC8B8 File Offset: 0x002FAAB8
		[CallerCount(0)]
		public unsafe G_AudioText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BACE RID: 47822 RVA: 0x002FC904 File Offset: 0x002FAB04
		// Note: this type is marked as 'beforefieldinit'.
		static G_AudioText()
		{
			Il2CppClassPointerStore<G_AudioText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Audio", "G_AudioText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr);
			G_AudioText.NativeFieldInfoPtr_m_DBText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, "m_DBText");
			G_AudioText.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, "m_graphyManager");
			G_AudioText.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, "m_audioMonitor");
			G_AudioText.NativeFieldInfoPtr_m_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, "m_updateRate");
			G_AudioText.NativeFieldInfoPtr_m_deltaTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, "m_deltaTimeOffset");
			G_AudioText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, 100678502);
			G_AudioText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, 100678503);
			G_AudioText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, 100678504);
			G_AudioText.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, 100678505);
			G_AudioText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr, 100678506);
		}

		// Token: 0x0600BACF RID: 47823 RVA: 0x0000210C File Offset: 0x0000030C
		public G_AudioText(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x002FC9FC File Offset: 0x002FABFC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_AudioText>.NativeClassPtr));
			}
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x0600BAD1 RID: 47825 RVA: 0x002FCA10 File Offset: 0x002FAC10
		// (set) Token: 0x0600BAD2 RID: 47826 RVA: 0x002FCA44 File Offset: 0x002FAC44
		public unsafe Text m_DBText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_DBText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_DBText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x0600BAD3 RID: 47827 RVA: 0x002FCA6C File Offset: 0x002FAC6C
		// (set) Token: 0x0600BAD4 RID: 47828 RVA: 0x002FCAA0 File Offset: 0x002FACA0
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x0600BAD5 RID: 47829 RVA: 0x002FCAC8 File Offset: 0x002FACC8
		// (set) Token: 0x0600BAD6 RID: 47830 RVA: 0x002FCAFC File Offset: 0x002FACFC
		public unsafe G_AudioMonitor m_audioMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_audioMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AudioMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x0600BAD7 RID: 47831 RVA: 0x002FCB24 File Offset: 0x002FAD24
		// (set) Token: 0x0600BAD8 RID: 47832 RVA: 0x002FCB4C File Offset: 0x002FAD4C
		public unsafe int m_updateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_updateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_updateRate)) = value;
			}
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x0600BAD9 RID: 47833 RVA: 0x002FCB70 File Offset: 0x002FAD70
		// (set) Token: 0x0600BADA RID: 47834 RVA: 0x002FCB98 File Offset: 0x002FAD98
		public unsafe float m_deltaTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_deltaTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioText.NativeFieldInfoPtr_m_deltaTimeOffset)) = value;
			}
		}

		// Token: 0x040077D5 RID: 30677
		private static readonly IntPtr NativeFieldInfoPtr_m_DBText;

		// Token: 0x040077D6 RID: 30678
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x040077D7 RID: 30679
		private static readonly IntPtr NativeFieldInfoPtr_m_audioMonitor;

		// Token: 0x040077D8 RID: 30680
		private static readonly IntPtr NativeFieldInfoPtr_m_updateRate;

		// Token: 0x040077D9 RID: 30681
		private static readonly IntPtr NativeFieldInfoPtr_m_deltaTimeOffset;

		// Token: 0x040077DA RID: 30682
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040077DB RID: 30683
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040077DC RID: 30684
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x040077DD RID: 30685
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040077DE RID: 30686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
