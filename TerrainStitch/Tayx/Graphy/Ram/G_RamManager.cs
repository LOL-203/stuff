using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Ram
{
	// Token: 0x020008E5 RID: 2277
	public class G_RamManager : MonoBehaviour
	{
		// Token: 0x0600B988 RID: 47496 RVA: 0x002F7AD0 File Offset: 0x002F5CD0
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x002F7B14 File Offset: 0x002F5D14
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x002F7B58 File Offset: 0x002F5D58
		[CallerCount(0)]
		public unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newModulePosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x002F7BAC File Offset: 0x002F5DAC
		[CallerCount(0)]
		public unsafe void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silentUpdate;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98C RID: 47500 RVA: 0x002F7C14 File Offset: 0x002F5E14
		[CallerCount(0)]
		public unsafe void RestorePreviousState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x002F7C58 File Offset: 0x002F5E58
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x002F7C9C File Offset: 0x002F5E9C
		[CallerCount(0)]
		public unsafe void RefreshParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x002F7CE0 File Offset: 0x002F5EE0
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x002F7D24 File Offset: 0x002F5F24
		[CallerCount(0)]
		public unsafe void SetGraphActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x002F7D78 File Offset: 0x002F5F78
		[CallerCount(0)]
		public unsafe G_RamManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x002F7DC4 File Offset: 0x002F5FC4
		// Note: this type is marked as 'beforefieldinit'.
		static G_RamManager()
		{
			Il2CppClassPointerStore<G_RamManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Ram", "G_RamManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr);
			G_RamManager.NativeFieldInfoPtr_m_ramGraphGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_ramGraphGameObject");
			G_RamManager.NativeFieldInfoPtr_m_backgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_backgroundImages");
			G_RamManager.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_graphyManager");
			G_RamManager.NativeFieldInfoPtr_m_ramGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_ramGraph");
			G_RamManager.NativeFieldInfoPtr_m_ramText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_ramText");
			G_RamManager.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_rectTransform");
			G_RamManager.NativeFieldInfoPtr_m_childrenGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_childrenGameObjects");
			G_RamManager.NativeFieldInfoPtr_m_previousModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_previousModuleState");
			G_RamManager.NativeFieldInfoPtr_m_currentModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, "m_currentModuleState");
			G_RamManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678414);
			G_RamManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678415);
			G_RamManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678416);
			G_RamManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678417);
			G_RamManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678418);
			G_RamManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678419);
			G_RamManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678420);
			G_RamManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678421);
			G_RamManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678422);
			G_RamManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr, 100678423);
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x0000210C File Offset: 0x0000030C
		public G_RamManager(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x0600B994 RID: 47508 RVA: 0x002F7F70 File Offset: 0x002F6170
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_RamManager>.NativeClassPtr));
			}
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x0600B995 RID: 47509 RVA: 0x002F7F84 File Offset: 0x002F6184
		// (set) Token: 0x0600B996 RID: 47510 RVA: 0x002F7FB8 File Offset: 0x002F61B8
		public unsafe GameObject m_ramGraphGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramGraphGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramGraphGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x0600B997 RID: 47511 RVA: 0x002F7FE0 File Offset: 0x002F61E0
		// (set) Token: 0x0600B998 RID: 47512 RVA: 0x002F8014 File Offset: 0x002F6214
		public unsafe List<Image> m_backgroundImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_backgroundImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_backgroundImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x0600B999 RID: 47513 RVA: 0x002F803C File Offset: 0x002F623C
		// (set) Token: 0x0600B99A RID: 47514 RVA: 0x002F8070 File Offset: 0x002F6270
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x0600B99B RID: 47515 RVA: 0x002F8098 File Offset: 0x002F6298
		// (set) Token: 0x0600B99C RID: 47516 RVA: 0x002F80CC File Offset: 0x002F62CC
		public unsafe G_RamGraph m_ramGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_RamGraph(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x0600B99D RID: 47517 RVA: 0x002F80F4 File Offset: 0x002F62F4
		// (set) Token: 0x0600B99E RID: 47518 RVA: 0x002F8128 File Offset: 0x002F6328
		public unsafe G_RamText m_ramText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_RamText(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_ramText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x0600B99F RID: 47519 RVA: 0x002F8150 File Offset: 0x002F6350
		// (set) Token: 0x0600B9A0 RID: 47520 RVA: 0x002F8184 File Offset: 0x002F6384
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x0600B9A1 RID: 47521 RVA: 0x002F81AC File Offset: 0x002F63AC
		// (set) Token: 0x0600B9A2 RID: 47522 RVA: 0x002F81E0 File Offset: 0x002F63E0
		public unsafe List<GameObject> m_childrenGameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_childrenGameObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_childrenGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x0600B9A3 RID: 47523 RVA: 0x002F8208 File Offset: 0x002F6408
		// (set) Token: 0x0600B9A4 RID: 47524 RVA: 0x002F8230 File Offset: 0x002F6430
		public unsafe GraphyManager.ModuleState m_previousModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_previousModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_previousModuleState)) = value;
			}
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x0600B9A5 RID: 47525 RVA: 0x002F8254 File Offset: 0x002F6454
		// (set) Token: 0x0600B9A6 RID: 47526 RVA: 0x002F827C File Offset: 0x002F647C
		public unsafe GraphyManager.ModuleState m_currentModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_currentModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamManager.NativeFieldInfoPtr_m_currentModuleState)) = value;
			}
		}

		// Token: 0x04007719 RID: 30489
		private static readonly IntPtr NativeFieldInfoPtr_m_ramGraphGameObject;

		// Token: 0x0400771A RID: 30490
		private static readonly IntPtr NativeFieldInfoPtr_m_backgroundImages;

		// Token: 0x0400771B RID: 30491
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x0400771C RID: 30492
		private static readonly IntPtr NativeFieldInfoPtr_m_ramGraph;

		// Token: 0x0400771D RID: 30493
		private static readonly IntPtr NativeFieldInfoPtr_m_ramText;

		// Token: 0x0400771E RID: 30494
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x0400771F RID: 30495
		private static readonly IntPtr NativeFieldInfoPtr_m_childrenGameObjects;

		// Token: 0x04007720 RID: 30496
		private static readonly IntPtr NativeFieldInfoPtr_m_previousModuleState;

		// Token: 0x04007721 RID: 30497
		private static readonly IntPtr NativeFieldInfoPtr_m_currentModuleState;

		// Token: 0x04007722 RID: 30498
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007723 RID: 30499
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007724 RID: 30500
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0;

		// Token: 0x04007725 RID: 30501
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0;

		// Token: 0x04007726 RID: 30502
		private static readonly IntPtr NativeMethodInfoPtr_RestorePreviousState_Public_Void_0;

		// Token: 0x04007727 RID: 30503
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x04007728 RID: 30504
		private static readonly IntPtr NativeMethodInfoPtr_RefreshParameters_Public_Void_0;

		// Token: 0x04007729 RID: 30505
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x0400772A RID: 30506
		private static readonly IntPtr NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0;

		// Token: 0x0400772B RID: 30507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
