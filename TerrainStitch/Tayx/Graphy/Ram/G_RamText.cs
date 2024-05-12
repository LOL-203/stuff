using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Ram
{
	// Token: 0x020008E7 RID: 2279
	public class G_RamText : MonoBehaviour
	{
		// Token: 0x0600B9B5 RID: 47541 RVA: 0x002F85E8 File Offset: 0x002F67E8
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x002F862C File Offset: 0x002F682C
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9B7 RID: 47543 RVA: 0x002F8670 File Offset: 0x002F6870
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9B8 RID: 47544 RVA: 0x002F86B4 File Offset: 0x002F68B4
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9B9 RID: 47545 RVA: 0x002F86F8 File Offset: 0x002F68F8
		[CallerCount(0)]
		public unsafe G_RamText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_RamText>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9BA RID: 47546 RVA: 0x002F8744 File Offset: 0x002F6944
		// Note: this type is marked as 'beforefieldinit'.
		static G_RamText()
		{
			Il2CppClassPointerStore<G_RamText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Ram", "G_RamText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_RamText>.NativeClassPtr);
			G_RamText.NativeFieldInfoPtr_m_allocatedSystemMemorySizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, "m_allocatedSystemMemorySizeText");
			G_RamText.NativeFieldInfoPtr_m_reservedSystemMemorySizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, "m_reservedSystemMemorySizeText");
			G_RamText.NativeFieldInfoPtr_m_monoSystemMemorySizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, "m_monoSystemMemorySizeText");
			G_RamText.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, "m_graphyManager");
			G_RamText.NativeFieldInfoPtr_m_ramMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, "m_ramMonitor");
			G_RamText.NativeFieldInfoPtr_m_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, "m_updateRate");
			G_RamText.NativeFieldInfoPtr_m_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, "m_deltaTime");
			G_RamText.NativeFieldInfoPtr_m_memoryStringFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, "m_memoryStringFormat");
			G_RamText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100678429);
			G_RamText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100678430);
			G_RamText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100678431);
			G_RamText.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100678432);
			G_RamText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamText>.NativeClassPtr, 100678433);
		}

		// Token: 0x0600B9BB RID: 47547 RVA: 0x0000210C File Offset: 0x0000030C
		public G_RamText(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x0600B9BC RID: 47548 RVA: 0x002F8878 File Offset: 0x002F6A78
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_RamText>.NativeClassPtr));
			}
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x0600B9BD RID: 47549 RVA: 0x002F888C File Offset: 0x002F6A8C
		// (set) Token: 0x0600B9BE RID: 47550 RVA: 0x002F88C0 File Offset: 0x002F6AC0
		public unsafe Text m_allocatedSystemMemorySizeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_allocatedSystemMemorySizeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_allocatedSystemMemorySizeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x0600B9BF RID: 47551 RVA: 0x002F88E8 File Offset: 0x002F6AE8
		// (set) Token: 0x0600B9C0 RID: 47552 RVA: 0x002F891C File Offset: 0x002F6B1C
		public unsafe Text m_reservedSystemMemorySizeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_reservedSystemMemorySizeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_reservedSystemMemorySizeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x0600B9C1 RID: 47553 RVA: 0x002F8944 File Offset: 0x002F6B44
		// (set) Token: 0x0600B9C2 RID: 47554 RVA: 0x002F8978 File Offset: 0x002F6B78
		public unsafe Text m_monoSystemMemorySizeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_monoSystemMemorySizeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_monoSystemMemorySizeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x0600B9C3 RID: 47555 RVA: 0x002F89A0 File Offset: 0x002F6BA0
		// (set) Token: 0x0600B9C4 RID: 47556 RVA: 0x002F89D4 File Offset: 0x002F6BD4
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x0600B9C5 RID: 47557 RVA: 0x002F89FC File Offset: 0x002F6BFC
		// (set) Token: 0x0600B9C6 RID: 47558 RVA: 0x002F8A30 File Offset: 0x002F6C30
		public unsafe G_RamMonitor m_ramMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_ramMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_RamMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_ramMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x0600B9C7 RID: 47559 RVA: 0x002F8A58 File Offset: 0x002F6C58
		// (set) Token: 0x0600B9C8 RID: 47560 RVA: 0x002F8A80 File Offset: 0x002F6C80
		public unsafe float m_updateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_updateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_updateRate)) = value;
			}
		}

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x0600B9C9 RID: 47561 RVA: 0x002F8AA4 File Offset: 0x002F6CA4
		// (set) Token: 0x0600B9CA RID: 47562 RVA: 0x002F8ACC File Offset: 0x002F6CCC
		public unsafe float m_deltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_deltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_deltaTime)) = value;
			}
		}

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x0600B9CB RID: 47563 RVA: 0x002F8AF0 File Offset: 0x002F6CF0
		// (set) Token: 0x0600B9CC RID: 47564 RVA: 0x002F8B19 File Offset: 0x002F6D19
		public unsafe string m_memoryStringFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_memoryStringFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamText.NativeFieldInfoPtr_m_memoryStringFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04007734 RID: 30516
		private static readonly IntPtr NativeFieldInfoPtr_m_allocatedSystemMemorySizeText;

		// Token: 0x04007735 RID: 30517
		private static readonly IntPtr NativeFieldInfoPtr_m_reservedSystemMemorySizeText;

		// Token: 0x04007736 RID: 30518
		private static readonly IntPtr NativeFieldInfoPtr_m_monoSystemMemorySizeText;

		// Token: 0x04007737 RID: 30519
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x04007738 RID: 30520
		private static readonly IntPtr NativeFieldInfoPtr_m_ramMonitor;

		// Token: 0x04007739 RID: 30521
		private static readonly IntPtr NativeFieldInfoPtr_m_updateRate;

		// Token: 0x0400773A RID: 30522
		private static readonly IntPtr NativeFieldInfoPtr_m_deltaTime;

		// Token: 0x0400773B RID: 30523
		private static readonly IntPtr NativeFieldInfoPtr_m_memoryStringFormat;

		// Token: 0x0400773C RID: 30524
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400773D RID: 30525
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400773E RID: 30526
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x0400773F RID: 30527
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007740 RID: 30528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
