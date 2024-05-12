using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Fps
{
	// Token: 0x020008EA RID: 2282
	public class G_FpsManager : MonoBehaviour
	{
		// Token: 0x0600B9EF RID: 47599 RVA: 0x002F9348 File Offset: 0x002F7548
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x002F938C File Offset: 0x002F758C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x002F93D0 File Offset: 0x002F75D0
		[CallerCount(0)]
		public unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newModulePosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x002F9424 File Offset: 0x002F7624
		[CallerCount(0)]
		public unsafe void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silentUpdate;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x002F948C File Offset: 0x002F768C
		[CallerCount(0)]
		public unsafe void RestorePreviousState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x002F94D0 File Offset: 0x002F76D0
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x002F9514 File Offset: 0x002F7714
		[CallerCount(0)]
		public unsafe void RefreshParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x002F9558 File Offset: 0x002F7758
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F7 RID: 47607 RVA: 0x002F959C File Offset: 0x002F779C
		[CallerCount(0)]
		public unsafe void SetGraphActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x002F95F0 File Offset: 0x002F77F0
		[CallerCount(0)]
		public unsafe G_FpsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x002F963C File Offset: 0x002F783C
		// Note: this type is marked as 'beforefieldinit'.
		static G_FpsManager()
		{
			Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Fps", "G_FpsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr);
			G_FpsManager.NativeFieldInfoPtr_m_fpsGraphGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_fpsGraphGameObject");
			G_FpsManager.NativeFieldInfoPtr_m_nonBasicTextGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_nonBasicTextGameObjects");
			G_FpsManager.NativeFieldInfoPtr_m_backgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_backgroundImages");
			G_FpsManager.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_graphyManager");
			G_FpsManager.NativeFieldInfoPtr_m_fpsGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_fpsGraph");
			G_FpsManager.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_fpsMonitor");
			G_FpsManager.NativeFieldInfoPtr_m_fpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_fpsText");
			G_FpsManager.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_rectTransform");
			G_FpsManager.NativeFieldInfoPtr_m_childrenGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_childrenGameObjects");
			G_FpsManager.NativeFieldInfoPtr_m_previousModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_previousModuleState");
			G_FpsManager.NativeFieldInfoPtr_m_currentModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, "m_currentModuleState");
			G_FpsManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678444);
			G_FpsManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678445);
			G_FpsManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678446);
			G_FpsManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678447);
			G_FpsManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678448);
			G_FpsManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678449);
			G_FpsManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678450);
			G_FpsManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678451);
			G_FpsManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678452);
			G_FpsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr, 100678453);
		}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x0000210C File Offset: 0x0000030C
		public G_FpsManager(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x0600B9FB RID: 47611 RVA: 0x002F9810 File Offset: 0x002F7A10
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_FpsManager>.NativeClassPtr));
			}
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x0600B9FC RID: 47612 RVA: 0x002F9824 File Offset: 0x002F7A24
		// (set) Token: 0x0600B9FD RID: 47613 RVA: 0x002F9858 File Offset: 0x002F7A58
		public unsafe GameObject m_fpsGraphGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsGraphGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsGraphGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x0600B9FE RID: 47614 RVA: 0x002F9880 File Offset: 0x002F7A80
		// (set) Token: 0x0600B9FF RID: 47615 RVA: 0x002F98B4 File Offset: 0x002F7AB4
		public unsafe List<GameObject> m_nonBasicTextGameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_nonBasicTextGameObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_nonBasicTextGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x0600BA00 RID: 47616 RVA: 0x002F98DC File Offset: 0x002F7ADC
		// (set) Token: 0x0600BA01 RID: 47617 RVA: 0x002F9910 File Offset: 0x002F7B10
		public unsafe List<Image> m_backgroundImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_backgroundImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_backgroundImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x0600BA02 RID: 47618 RVA: 0x002F9938 File Offset: 0x002F7B38
		// (set) Token: 0x0600BA03 RID: 47619 RVA: 0x002F996C File Offset: 0x002F7B6C
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x0600BA04 RID: 47620 RVA: 0x002F9994 File Offset: 0x002F7B94
		// (set) Token: 0x0600BA05 RID: 47621 RVA: 0x002F99C8 File Offset: 0x002F7BC8
		public unsafe G_FpsGraph m_fpsGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_FpsGraph(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x0600BA06 RID: 47622 RVA: 0x002F99F0 File Offset: 0x002F7BF0
		// (set) Token: 0x0600BA07 RID: 47623 RVA: 0x002F9A24 File Offset: 0x002F7C24
		public unsafe G_FpsMonitor m_fpsMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_FpsMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x0600BA08 RID: 47624 RVA: 0x002F9A4C File Offset: 0x002F7C4C
		// (set) Token: 0x0600BA09 RID: 47625 RVA: 0x002F9A80 File Offset: 0x002F7C80
		public unsafe G_FpsText m_fpsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_FpsText(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_fpsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x0600BA0A RID: 47626 RVA: 0x002F9AA8 File Offset: 0x002F7CA8
		// (set) Token: 0x0600BA0B RID: 47627 RVA: 0x002F9ADC File Offset: 0x002F7CDC
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x0600BA0C RID: 47628 RVA: 0x002F9B04 File Offset: 0x002F7D04
		// (set) Token: 0x0600BA0D RID: 47629 RVA: 0x002F9B38 File Offset: 0x002F7D38
		public unsafe List<GameObject> m_childrenGameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_childrenGameObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_childrenGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x0600BA0E RID: 47630 RVA: 0x002F9B60 File Offset: 0x002F7D60
		// (set) Token: 0x0600BA0F RID: 47631 RVA: 0x002F9B88 File Offset: 0x002F7D88
		public unsafe GraphyManager.ModuleState m_previousModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_previousModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_previousModuleState)) = value;
			}
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x0600BA10 RID: 47632 RVA: 0x002F9BAC File Offset: 0x002F7DAC
		// (set) Token: 0x0600BA11 RID: 47633 RVA: 0x002F9BD4 File Offset: 0x002F7DD4
		public unsafe GraphyManager.ModuleState m_currentModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_currentModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsManager.NativeFieldInfoPtr_m_currentModuleState)) = value;
			}
		}

		// Token: 0x04007754 RID: 30548
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsGraphGameObject;

		// Token: 0x04007755 RID: 30549
		private static readonly IntPtr NativeFieldInfoPtr_m_nonBasicTextGameObjects;

		// Token: 0x04007756 RID: 30550
		private static readonly IntPtr NativeFieldInfoPtr_m_backgroundImages;

		// Token: 0x04007757 RID: 30551
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x04007758 RID: 30552
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsGraph;

		// Token: 0x04007759 RID: 30553
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsMonitor;

		// Token: 0x0400775A RID: 30554
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsText;

		// Token: 0x0400775B RID: 30555
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x0400775C RID: 30556
		private static readonly IntPtr NativeFieldInfoPtr_m_childrenGameObjects;

		// Token: 0x0400775D RID: 30557
		private static readonly IntPtr NativeFieldInfoPtr_m_previousModuleState;

		// Token: 0x0400775E RID: 30558
		private static readonly IntPtr NativeFieldInfoPtr_m_currentModuleState;

		// Token: 0x0400775F RID: 30559
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007760 RID: 30560
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007761 RID: 30561
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0;

		// Token: 0x04007762 RID: 30562
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0;

		// Token: 0x04007763 RID: 30563
		private static readonly IntPtr NativeMethodInfoPtr_RestorePreviousState_Public_Void_0;

		// Token: 0x04007764 RID: 30564
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x04007765 RID: 30565
		private static readonly IntPtr NativeMethodInfoPtr_RefreshParameters_Public_Void_0;

		// Token: 0x04007766 RID: 30566
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007767 RID: 30567
		private static readonly IntPtr NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0;

		// Token: 0x04007768 RID: 30568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
