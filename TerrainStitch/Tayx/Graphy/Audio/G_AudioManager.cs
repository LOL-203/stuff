using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Audio
{
	// Token: 0x020008EE RID: 2286
	public class G_AudioManager : MonoBehaviour
	{
		// Token: 0x0600BA83 RID: 47747 RVA: 0x002FB5A0 File Offset: 0x002F97A0
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x002FB5E4 File Offset: 0x002F97E4
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x002FB628 File Offset: 0x002F9828
		[CallerCount(0)]
		public unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newModulePosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x002FB67C File Offset: 0x002F987C
		[CallerCount(0)]
		public unsafe void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silentUpdate;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x002FB6E4 File Offset: 0x002F98E4
		[CallerCount(0)]
		public unsafe void RestorePreviousState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x002FB728 File Offset: 0x002F9928
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA89 RID: 47753 RVA: 0x002FB76C File Offset: 0x002F996C
		[CallerCount(0)]
		public unsafe void RefreshParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA8A RID: 47754 RVA: 0x002FB7B0 File Offset: 0x002F99B0
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA8B RID: 47755 RVA: 0x002FB7F4 File Offset: 0x002F99F4
		[CallerCount(0)]
		public unsafe void SetGraphActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA8C RID: 47756 RVA: 0x002FB848 File Offset: 0x002F9A48
		[CallerCount(0)]
		public unsafe G_AudioManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x002FB894 File Offset: 0x002F9A94
		// Note: this type is marked as 'beforefieldinit'.
		static G_AudioManager()
		{
			Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Audio", "G_AudioManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr);
			G_AudioManager.NativeFieldInfoPtr_m_audioGraphGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_audioGraphGameObject");
			G_AudioManager.NativeFieldInfoPtr_m_audioDbText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_audioDbText");
			G_AudioManager.NativeFieldInfoPtr_m_backgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_backgroundImages");
			G_AudioManager.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_graphyManager");
			G_AudioManager.NativeFieldInfoPtr_m_audioGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_audioGraph");
			G_AudioManager.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_audioMonitor");
			G_AudioManager.NativeFieldInfoPtr_m_audioText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_audioText");
			G_AudioManager.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_rectTransform");
			G_AudioManager.NativeFieldInfoPtr_m_childrenGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_childrenGameObjects");
			G_AudioManager.NativeFieldInfoPtr_m_previousModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_previousModuleState");
			G_AudioManager.NativeFieldInfoPtr_m_currentModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, "m_currentModuleState");
			G_AudioManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678478);
			G_AudioManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678479);
			G_AudioManager.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678480);
			G_AudioManager.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678481);
			G_AudioManager.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678482);
			G_AudioManager.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678483);
			G_AudioManager.NativeMethodInfoPtr_RefreshParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678484);
			G_AudioManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678485);
			G_AudioManager.NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678486);
			G_AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr, 100678487);
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x0000210C File Offset: 0x0000030C
		public G_AudioManager(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x0600BA8F RID: 47759 RVA: 0x002FBA68 File Offset: 0x002F9C68
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_AudioManager>.NativeClassPtr));
			}
		}

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x0600BA90 RID: 47760 RVA: 0x002FBA7C File Offset: 0x002F9C7C
		// (set) Token: 0x0600BA91 RID: 47761 RVA: 0x002FBAB0 File Offset: 0x002F9CB0
		public unsafe GameObject m_audioGraphGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioGraphGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioGraphGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x0600BA92 RID: 47762 RVA: 0x002FBAD8 File Offset: 0x002F9CD8
		// (set) Token: 0x0600BA93 RID: 47763 RVA: 0x002FBB0C File Offset: 0x002F9D0C
		public unsafe Text m_audioDbText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioDbText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioDbText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x0600BA94 RID: 47764 RVA: 0x002FBB34 File Offset: 0x002F9D34
		// (set) Token: 0x0600BA95 RID: 47765 RVA: 0x002FBB68 File Offset: 0x002F9D68
		public unsafe List<Image> m_backgroundImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_backgroundImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_backgroundImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x0600BA96 RID: 47766 RVA: 0x002FBB90 File Offset: 0x002F9D90
		// (set) Token: 0x0600BA97 RID: 47767 RVA: 0x002FBBC4 File Offset: 0x002F9DC4
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x002FBBEC File Offset: 0x002F9DEC
		// (set) Token: 0x0600BA99 RID: 47769 RVA: 0x002FBC20 File Offset: 0x002F9E20
		public unsafe G_AudioGraph m_audioGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AudioGraph(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x0600BA9A RID: 47770 RVA: 0x002FBC48 File Offset: 0x002F9E48
		// (set) Token: 0x0600BA9B RID: 47771 RVA: 0x002FBC7C File Offset: 0x002F9E7C
		public unsafe G_AudioMonitor m_audioMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AudioMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x0600BA9C RID: 47772 RVA: 0x002FBCA4 File Offset: 0x002F9EA4
		// (set) Token: 0x0600BA9D RID: 47773 RVA: 0x002FBCD8 File Offset: 0x002F9ED8
		public unsafe G_AudioText m_audioText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AudioText(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_audioText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x0600BA9E RID: 47774 RVA: 0x002FBD00 File Offset: 0x002F9F00
		// (set) Token: 0x0600BA9F RID: 47775 RVA: 0x002FBD34 File Offset: 0x002F9F34
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x0600BAA0 RID: 47776 RVA: 0x002FBD5C File Offset: 0x002F9F5C
		// (set) Token: 0x0600BAA1 RID: 47777 RVA: 0x002FBD90 File Offset: 0x002F9F90
		public unsafe List<GameObject> m_childrenGameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_childrenGameObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_childrenGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x0600BAA2 RID: 47778 RVA: 0x002FBDB8 File Offset: 0x002F9FB8
		// (set) Token: 0x0600BAA3 RID: 47779 RVA: 0x002FBDE0 File Offset: 0x002F9FE0
		public unsafe GraphyManager.ModuleState m_previousModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_previousModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_previousModuleState)) = value;
			}
		}

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x0600BAA4 RID: 47780 RVA: 0x002FBE04 File Offset: 0x002FA004
		// (set) Token: 0x0600BAA5 RID: 47781 RVA: 0x002FBE2C File Offset: 0x002FA02C
		public unsafe GraphyManager.ModuleState m_currentModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_currentModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioManager.NativeFieldInfoPtr_m_currentModuleState)) = value;
			}
		}

		// Token: 0x040077A9 RID: 30633
		private static readonly IntPtr NativeFieldInfoPtr_m_audioGraphGameObject;

		// Token: 0x040077AA RID: 30634
		private static readonly IntPtr NativeFieldInfoPtr_m_audioDbText;

		// Token: 0x040077AB RID: 30635
		private static readonly IntPtr NativeFieldInfoPtr_m_backgroundImages;

		// Token: 0x040077AC RID: 30636
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x040077AD RID: 30637
		private static readonly IntPtr NativeFieldInfoPtr_m_audioGraph;

		// Token: 0x040077AE RID: 30638
		private static readonly IntPtr NativeFieldInfoPtr_m_audioMonitor;

		// Token: 0x040077AF RID: 30639
		private static readonly IntPtr NativeFieldInfoPtr_m_audioText;

		// Token: 0x040077B0 RID: 30640
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x040077B1 RID: 30641
		private static readonly IntPtr NativeFieldInfoPtr_m_childrenGameObjects;

		// Token: 0x040077B2 RID: 30642
		private static readonly IntPtr NativeFieldInfoPtr_m_previousModuleState;

		// Token: 0x040077B3 RID: 30643
		private static readonly IntPtr NativeFieldInfoPtr_m_currentModuleState;

		// Token: 0x040077B4 RID: 30644
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040077B5 RID: 30645
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040077B6 RID: 30646
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0;

		// Token: 0x040077B7 RID: 30647
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0;

		// Token: 0x040077B8 RID: 30648
		private static readonly IntPtr NativeMethodInfoPtr_RestorePreviousState_Public_Void_0;

		// Token: 0x040077B9 RID: 30649
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x040077BA RID: 30650
		private static readonly IntPtr NativeMethodInfoPtr_RefreshParameters_Public_Void_0;

		// Token: 0x040077BB RID: 30651
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040077BC RID: 30652
		private static readonly IntPtr NativeMethodInfoPtr_SetGraphActive_Private_Void_Boolean_0;

		// Token: 0x040077BD RID: 30653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
