using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Advanced
{
	// Token: 0x020008F1 RID: 2289
	public class G_AdvancedData : MonoBehaviour
	{
		// Token: 0x0600BADB RID: 47835 RVA: 0x002FCBBC File Offset: 0x002FADBC
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BADC RID: 47836 RVA: 0x002FCC00 File Offset: 0x002FAE00
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BADD RID: 47837 RVA: 0x002FCC44 File Offset: 0x002FAE44
		[CallerCount(0)]
		public unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newModulePosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BADE RID: 47838 RVA: 0x002FCC98 File Offset: 0x002FAE98
		[CallerCount(0)]
		public unsafe void SetState(GraphyManager.ModuleState state, bool silentUpdate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silentUpdate;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BADF RID: 47839 RVA: 0x002FCD00 File Offset: 0x002FAF00
		[CallerCount(0)]
		public unsafe void RestorePreviousState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAE0 RID: 47840 RVA: 0x002FCD44 File Offset: 0x002FAF44
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAE1 RID: 47841 RVA: 0x002FCD88 File Offset: 0x002FAF88
		[CallerCount(0)]
		public unsafe void RefreshParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_RefreshParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAE2 RID: 47842 RVA: 0x002FCDCC File Offset: 0x002FAFCC
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x002FCE10 File Offset: 0x002FB010
		[CallerCount(0)]
		public unsafe G_AdvancedData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AdvancedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x002FCE5C File Offset: 0x002FB05C
		// Note: this type is marked as 'beforefieldinit'.
		static G_AdvancedData()
		{
			Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Advanced", "G_AdvancedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr);
			G_AdvancedData.NativeFieldInfoPtr_m_backgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_backgroundImages");
			G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceVersionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_graphicsDeviceVersionText");
			G_AdvancedData.NativeFieldInfoPtr_m_processorTypeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_processorTypeText");
			G_AdvancedData.NativeFieldInfoPtr_m_operatingSystemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_operatingSystemText");
			G_AdvancedData.NativeFieldInfoPtr_m_systemMemoryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_systemMemoryText");
			G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_graphicsDeviceNameText");
			G_AdvancedData.NativeFieldInfoPtr_m_graphicsMemorySizeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_graphicsMemorySizeText");
			G_AdvancedData.NativeFieldInfoPtr_m_screenResolutionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_screenResolutionText");
			G_AdvancedData.NativeFieldInfoPtr_m_gameWindowResolutionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_gameWindowResolutionText");
			G_AdvancedData.NativeFieldInfoPtr_m_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_updateRate");
			G_AdvancedData.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_graphyManager");
			G_AdvancedData.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_rectTransform");
			G_AdvancedData.NativeFieldInfoPtr_m_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_deltaTime");
			G_AdvancedData.NativeFieldInfoPtr_m_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_sb");
			G_AdvancedData.NativeFieldInfoPtr_m_previousModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_previousModuleState");
			G_AdvancedData.NativeFieldInfoPtr_m_currentModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_currentModuleState");
			G_AdvancedData.NativeFieldInfoPtr_m_windowStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, "m_windowStrings");
			G_AdvancedData.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678507);
			G_AdvancedData.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678508);
			G_AdvancedData.NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678509);
			G_AdvancedData.NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678510);
			G_AdvancedData.NativeMethodInfoPtr_RestorePreviousState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678511);
			G_AdvancedData.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678512);
			G_AdvancedData.NativeMethodInfoPtr_RefreshParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678513);
			G_AdvancedData.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678514);
			G_AdvancedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr, 100678515);
		}

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x0000210C File Offset: 0x0000030C
		public G_AdvancedData(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x0600BAE6 RID: 47846 RVA: 0x002FD094 File Offset: 0x002FB294
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_AdvancedData>.NativeClassPtr));
			}
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x0600BAE7 RID: 47847 RVA: 0x002FD0A8 File Offset: 0x002FB2A8
		// (set) Token: 0x0600BAE8 RID: 47848 RVA: 0x002FD0DC File Offset: 0x002FB2DC
		public unsafe List<Image> m_backgroundImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_backgroundImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_backgroundImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x0600BAE9 RID: 47849 RVA: 0x002FD104 File Offset: 0x002FB304
		// (set) Token: 0x0600BAEA RID: 47850 RVA: 0x002FD138 File Offset: 0x002FB338
		public unsafe Text m_graphicsDeviceVersionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceVersionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceVersionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x0600BAEB RID: 47851 RVA: 0x002FD160 File Offset: 0x002FB360
		// (set) Token: 0x0600BAEC RID: 47852 RVA: 0x002FD194 File Offset: 0x002FB394
		public unsafe Text m_processorTypeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_processorTypeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_processorTypeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x0600BAED RID: 47853 RVA: 0x002FD1BC File Offset: 0x002FB3BC
		// (set) Token: 0x0600BAEE RID: 47854 RVA: 0x002FD1F0 File Offset: 0x002FB3F0
		public unsafe Text m_operatingSystemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_operatingSystemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_operatingSystemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x0600BAEF RID: 47855 RVA: 0x002FD218 File Offset: 0x002FB418
		// (set) Token: 0x0600BAF0 RID: 47856 RVA: 0x002FD24C File Offset: 0x002FB44C
		public unsafe Text m_systemMemoryText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_systemMemoryText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_systemMemoryText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x0600BAF1 RID: 47857 RVA: 0x002FD274 File Offset: 0x002FB474
		// (set) Token: 0x0600BAF2 RID: 47858 RVA: 0x002FD2A8 File Offset: 0x002FB4A8
		public unsafe Text m_graphicsDeviceNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsDeviceNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x0600BAF3 RID: 47859 RVA: 0x002FD2D0 File Offset: 0x002FB4D0
		// (set) Token: 0x0600BAF4 RID: 47860 RVA: 0x002FD304 File Offset: 0x002FB504
		public unsafe Text m_graphicsMemorySizeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsMemorySizeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphicsMemorySizeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x0600BAF5 RID: 47861 RVA: 0x002FD32C File Offset: 0x002FB52C
		// (set) Token: 0x0600BAF6 RID: 47862 RVA: 0x002FD360 File Offset: 0x002FB560
		public unsafe Text m_screenResolutionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_screenResolutionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_screenResolutionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x0600BAF7 RID: 47863 RVA: 0x002FD388 File Offset: 0x002FB588
		// (set) Token: 0x0600BAF8 RID: 47864 RVA: 0x002FD3BC File Offset: 0x002FB5BC
		public unsafe Text m_gameWindowResolutionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_gameWindowResolutionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_gameWindowResolutionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x0600BAF9 RID: 47865 RVA: 0x002FD3E4 File Offset: 0x002FB5E4
		// (set) Token: 0x0600BAFA RID: 47866 RVA: 0x002FD40C File Offset: 0x002FB60C
		public unsafe float m_updateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_updateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_updateRate)) = value;
			}
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x0600BAFB RID: 47867 RVA: 0x002FD430 File Offset: 0x002FB630
		// (set) Token: 0x0600BAFC RID: 47868 RVA: 0x002FD464 File Offset: 0x002FB664
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042C0 RID: 17088
		// (get) Token: 0x0600BAFD RID: 47869 RVA: 0x002FD48C File Offset: 0x002FB68C
		// (set) Token: 0x0600BAFE RID: 47870 RVA: 0x002FD4C0 File Offset: 0x002FB6C0
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042C1 RID: 17089
		// (get) Token: 0x0600BAFF RID: 47871 RVA: 0x002FD4E8 File Offset: 0x002FB6E8
		// (set) Token: 0x0600BB00 RID: 47872 RVA: 0x002FD510 File Offset: 0x002FB710
		public unsafe float m_deltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_deltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_deltaTime)) = value;
			}
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x0600BB01 RID: 47873 RVA: 0x002FD534 File Offset: 0x002FB734
		// (set) Token: 0x0600BB02 RID: 47874 RVA: 0x002FD568 File Offset: 0x002FB768
		public unsafe StringBuilder m_sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new StringBuilder(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x0600BB03 RID: 47875 RVA: 0x002FD590 File Offset: 0x002FB790
		// (set) Token: 0x0600BB04 RID: 47876 RVA: 0x002FD5B8 File Offset: 0x002FB7B8
		public unsafe GraphyManager.ModuleState m_previousModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_previousModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_previousModuleState)) = value;
			}
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x0600BB05 RID: 47877 RVA: 0x002FD5DC File Offset: 0x002FB7DC
		// (set) Token: 0x0600BB06 RID: 47878 RVA: 0x002FD604 File Offset: 0x002FB804
		public unsafe GraphyManager.ModuleState m_currentModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_currentModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_currentModuleState)) = value;
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x0600BB07 RID: 47879 RVA: 0x002FD628 File Offset: 0x002FB828
		// (set) Token: 0x0600BB08 RID: 47880 RVA: 0x002FD65C File Offset: 0x002FB85C
		public unsafe Il2CppStringArray m_windowStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_windowStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AdvancedData.NativeFieldInfoPtr_m_windowStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040077DF RID: 30687
		private static readonly IntPtr NativeFieldInfoPtr_m_backgroundImages;

		// Token: 0x040077E0 RID: 30688
		private static readonly IntPtr NativeFieldInfoPtr_m_graphicsDeviceVersionText;

		// Token: 0x040077E1 RID: 30689
		private static readonly IntPtr NativeFieldInfoPtr_m_processorTypeText;

		// Token: 0x040077E2 RID: 30690
		private static readonly IntPtr NativeFieldInfoPtr_m_operatingSystemText;

		// Token: 0x040077E3 RID: 30691
		private static readonly IntPtr NativeFieldInfoPtr_m_systemMemoryText;

		// Token: 0x040077E4 RID: 30692
		private static readonly IntPtr NativeFieldInfoPtr_m_graphicsDeviceNameText;

		// Token: 0x040077E5 RID: 30693
		private static readonly IntPtr NativeFieldInfoPtr_m_graphicsMemorySizeText;

		// Token: 0x040077E6 RID: 30694
		private static readonly IntPtr NativeFieldInfoPtr_m_screenResolutionText;

		// Token: 0x040077E7 RID: 30695
		private static readonly IntPtr NativeFieldInfoPtr_m_gameWindowResolutionText;

		// Token: 0x040077E8 RID: 30696
		private static readonly IntPtr NativeFieldInfoPtr_m_updateRate;

		// Token: 0x040077E9 RID: 30697
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x040077EA RID: 30698
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x040077EB RID: 30699
		private static readonly IntPtr NativeFieldInfoPtr_m_deltaTime;

		// Token: 0x040077EC RID: 30700
		private static readonly IntPtr NativeFieldInfoPtr_m_sb;

		// Token: 0x040077ED RID: 30701
		private static readonly IntPtr NativeFieldInfoPtr_m_previousModuleState;

		// Token: 0x040077EE RID: 30702
		private static readonly IntPtr NativeFieldInfoPtr_m_currentModuleState;

		// Token: 0x040077EF RID: 30703
		private static readonly IntPtr NativeFieldInfoPtr_m_windowStrings;

		// Token: 0x040077F0 RID: 30704
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040077F1 RID: 30705
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040077F2 RID: 30706
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Virtual_Final_New_Void_ModulePosition_0;

		// Token: 0x040077F3 RID: 30707
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Final_New_Void_ModuleState_Boolean_0;

		// Token: 0x040077F4 RID: 30708
		private static readonly IntPtr NativeMethodInfoPtr_RestorePreviousState_Public_Void_0;

		// Token: 0x040077F5 RID: 30709
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x040077F6 RID: 30710
		private static readonly IntPtr NativeMethodInfoPtr_RefreshParameters_Public_Void_0;

		// Token: 0x040077F7 RID: 30711
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040077F8 RID: 30712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
