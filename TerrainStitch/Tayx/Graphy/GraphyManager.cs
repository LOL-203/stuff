using System;
using Il2CppSystem;
using Tayx.Graphy.Advanced;
using Tayx.Graphy.Audio;
using Tayx.Graphy.Fps;
using Tayx.Graphy.Ram;
using Tayx.Graphy.Utils;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Tayx.Graphy
{
	// Token: 0x020008D6 RID: 2262
	public class GraphyManager : G_Singleton<GraphyManager>
	{
		// Token: 0x0600B82B RID: 47147 RVA: 0x002F21E4 File Offset: 0x002F03E4
		[CallerCount(0)]
		public unsafe GraphyManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x0600B82C RID: 47148 RVA: 0x002F2230 File Offset: 0x002F0430
		// (set) Token: 0x0600B82D RID: 47149 RVA: 0x002F2280 File Offset: 0x002F0480
		public unsafe GraphyManager.Mode GraphyMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_GraphyMode_Public_get_Mode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_GraphyMode_Public_set_Void_Mode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x0600B82E RID: 47150 RVA: 0x002F22D4 File Offset: 0x002F04D4
		public unsafe bool EnableOnStartup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_EnableOnStartup_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x0600B82F RID: 47151 RVA: 0x002F2324 File Offset: 0x002F0524
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x0600B830 RID: 47152 RVA: 0x002F2374 File Offset: 0x002F0574
		// (set) Token: 0x0600B831 RID: 47153 RVA: 0x002F23C4 File Offset: 0x002F05C4
		public unsafe bool Background
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_Background_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_Background_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x0600B832 RID: 47154 RVA: 0x002F2418 File Offset: 0x002F0618
		// (set) Token: 0x0600B833 RID: 47155 RVA: 0x002F2468 File Offset: 0x002F0668
		public unsafe Color BackgroundColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_BackgroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_BackgroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x0600B834 RID: 47156 RVA: 0x002F24BC File Offset: 0x002F06BC
		// (set) Token: 0x0600B835 RID: 47157 RVA: 0x002F250C File Offset: 0x002F070C
		public unsafe GraphyManager.ModulePosition GraphModulePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_GraphModulePosition_Public_get_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_GraphModulePosition_Public_set_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x0600B836 RID: 47158 RVA: 0x002F2560 File Offset: 0x002F0760
		// (set) Token: 0x0600B837 RID: 47159 RVA: 0x002F25B0 File Offset: 0x002F07B0
		public unsafe GraphyManager.ModuleState FpsModuleState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FpsModuleState_Public_get_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FpsModuleState_Public_set_Void_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x0600B838 RID: 47160 RVA: 0x002F2604 File Offset: 0x002F0804
		// (set) Token: 0x0600B839 RID: 47161 RVA: 0x002F2654 File Offset: 0x002F0854
		public unsafe int TimeToResetMinMaxFps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_TimeToResetMinMaxFps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_TimeToResetMinMaxFps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x0600B83A RID: 47162 RVA: 0x002F26A8 File Offset: 0x002F08A8
		// (set) Token: 0x0600B83B RID: 47163 RVA: 0x002F26F8 File Offset: 0x002F08F8
		public unsafe Color GoodFPSColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_GoodFPSColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_GoodFPSColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x0600B83C RID: 47164 RVA: 0x002F274C File Offset: 0x002F094C
		// (set) Token: 0x0600B83D RID: 47165 RVA: 0x002F279C File Offset: 0x002F099C
		public unsafe Color CautionFPSColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_CautionFPSColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_CautionFPSColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x0600B83E RID: 47166 RVA: 0x002F27F0 File Offset: 0x002F09F0
		// (set) Token: 0x0600B83F RID: 47167 RVA: 0x002F2840 File Offset: 0x002F0A40
		public unsafe Color CriticalFPSColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_CriticalFPSColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_CriticalFPSColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x0600B840 RID: 47168 RVA: 0x002F2894 File Offset: 0x002F0A94
		// (set) Token: 0x0600B841 RID: 47169 RVA: 0x002F28E4 File Offset: 0x002F0AE4
		public unsafe int GoodFPSThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_GoodFPSThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_GoodFPSThreshold_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x0600B842 RID: 47170 RVA: 0x002F2938 File Offset: 0x002F0B38
		// (set) Token: 0x0600B843 RID: 47171 RVA: 0x002F2988 File Offset: 0x002F0B88
		public unsafe int CautionFPSThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_CautionFPSThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_CautionFPSThreshold_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x0600B844 RID: 47172 RVA: 0x002F29DC File Offset: 0x002F0BDC
		// (set) Token: 0x0600B845 RID: 47173 RVA: 0x002F2A2C File Offset: 0x002F0C2C
		public unsafe int FpsGraphResolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FpsGraphResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FpsGraphResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x0600B846 RID: 47174 RVA: 0x002F2A80 File Offset: 0x002F0C80
		// (set) Token: 0x0600B847 RID: 47175 RVA: 0x002F2AD0 File Offset: 0x002F0CD0
		public unsafe int FpsTextUpdateRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FpsTextUpdateRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FpsTextUpdateRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x0600B848 RID: 47176 RVA: 0x002F2B24 File Offset: 0x002F0D24
		public unsafe float CurrentFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x0600B849 RID: 47177 RVA: 0x002F2B74 File Offset: 0x002F0D74
		public unsafe float AverageFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x0600B84A RID: 47178 RVA: 0x002F2BC4 File Offset: 0x002F0DC4
		public unsafe float MinFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x0600B84B RID: 47179 RVA: 0x002F2C14 File Offset: 0x002F0E14
		public unsafe float MaxFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x0600B84C RID: 47180 RVA: 0x002F2C64 File Offset: 0x002F0E64
		// (set) Token: 0x0600B84D RID: 47181 RVA: 0x002F2CB4 File Offset: 0x002F0EB4
		public unsafe GraphyManager.ModuleState RamModuleState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_RamModuleState_Public_get_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_RamModuleState_Public_set_Void_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x0600B84E RID: 47182 RVA: 0x002F2D08 File Offset: 0x002F0F08
		// (set) Token: 0x0600B84F RID: 47183 RVA: 0x002F2D58 File Offset: 0x002F0F58
		public unsafe Color AllocatedRamColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AllocatedRamColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AllocatedRamColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x0600B850 RID: 47184 RVA: 0x002F2DAC File Offset: 0x002F0FAC
		// (set) Token: 0x0600B851 RID: 47185 RVA: 0x002F2DFC File Offset: 0x002F0FFC
		public unsafe Color ReservedRamColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_ReservedRamColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_ReservedRamColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x0600B852 RID: 47186 RVA: 0x002F2E50 File Offset: 0x002F1050
		// (set) Token: 0x0600B853 RID: 47187 RVA: 0x002F2EA0 File Offset: 0x002F10A0
		public unsafe Color MonoRamColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MonoRamColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_MonoRamColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x0600B854 RID: 47188 RVA: 0x002F2EF4 File Offset: 0x002F10F4
		// (set) Token: 0x0600B855 RID: 47189 RVA: 0x002F2F44 File Offset: 0x002F1144
		public unsafe int RamGraphResolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_RamGraphResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_RamGraphResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x0600B856 RID: 47190 RVA: 0x002F2F98 File Offset: 0x002F1198
		// (set) Token: 0x0600B857 RID: 47191 RVA: 0x002F2FE8 File Offset: 0x002F11E8
		public unsafe int RamTextUpdateRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_RamTextUpdateRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_RamTextUpdateRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x0600B858 RID: 47192 RVA: 0x002F303C File Offset: 0x002F123C
		public unsafe float AllocatedRam
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x0600B859 RID: 47193 RVA: 0x002F308C File Offset: 0x002F128C
		public unsafe float ReservedRam
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x0600B85A RID: 47194 RVA: 0x002F30DC File Offset: 0x002F12DC
		public unsafe float MonoRam
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x0600B85B RID: 47195 RVA: 0x002F312C File Offset: 0x002F132C
		// (set) Token: 0x0600B85C RID: 47196 RVA: 0x002F317C File Offset: 0x002F137C
		public unsafe GraphyManager.ModuleState AudioModuleState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioModuleState_Public_get_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioModuleState_Public_set_Void_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x0600B85D RID: 47197 RVA: 0x002F31D0 File Offset: 0x002F13D0
		// (set) Token: 0x0600B85E RID: 47198 RVA: 0x002F3228 File Offset: 0x002F1428
		public unsafe AudioListener AudioListener
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioListener_Public_get_AudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new AudioListener(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioListener_Public_set_Void_AudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x0600B85F RID: 47199 RVA: 0x002F3284 File Offset: 0x002F1484
		// (set) Token: 0x0600B860 RID: 47200 RVA: 0x002F32D4 File Offset: 0x002F14D4
		public unsafe GraphyManager.LookForAudioListener FindAudioListenerInCameraIfNull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FindAudioListenerInCameraIfNull_Public_get_LookForAudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FindAudioListenerInCameraIfNull_Public_set_Void_LookForAudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x0600B861 RID: 47201 RVA: 0x002F3328 File Offset: 0x002F1528
		// (set) Token: 0x0600B862 RID: 47202 RVA: 0x002F3378 File Offset: 0x002F1578
		public unsafe Color AudioGraphColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioGraphColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioGraphColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x0600B863 RID: 47203 RVA: 0x002F33CC File Offset: 0x002F15CC
		// (set) Token: 0x0600B864 RID: 47204 RVA: 0x002F341C File Offset: 0x002F161C
		public unsafe int AudioGraphResolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioGraphResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioGraphResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x0600B865 RID: 47205 RVA: 0x002F3470 File Offset: 0x002F1670
		// (set) Token: 0x0600B866 RID: 47206 RVA: 0x002F34C0 File Offset: 0x002F16C0
		public unsafe int AudioTextUpdateRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AudioTextUpdateRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AudioTextUpdateRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x0600B867 RID: 47207 RVA: 0x002F3514 File Offset: 0x002F1714
		// (set) Token: 0x0600B868 RID: 47208 RVA: 0x002F3564 File Offset: 0x002F1764
		public unsafe FFTWindow FftWindow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_FftWindow_Public_get_FFTWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_FftWindow_Public_set_Void_FFTWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x0600B869 RID: 47209 RVA: 0x002F35B8 File Offset: 0x002F17B8
		// (set) Token: 0x0600B86A RID: 47210 RVA: 0x002F3608 File Offset: 0x002F1808
		public unsafe int SpectrumSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_SpectrumSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_SpectrumSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x0600B86B RID: 47211 RVA: 0x002F365C File Offset: 0x002F185C
		public unsafe Il2CppStructArray<float> Spectrum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_Spectrum_Public_get_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
		}

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x0600B86C RID: 47212 RVA: 0x002F36B4 File Offset: 0x002F18B4
		public unsafe float MaxDB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x0600B86D RID: 47213 RVA: 0x002F3704 File Offset: 0x002F1904
		// (set) Token: 0x0600B86E RID: 47214 RVA: 0x002F3754 File Offset: 0x002F1954
		public unsafe GraphyManager.ModuleState AdvancedModuleState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AdvancedModuleState_Public_get_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AdvancedModuleState_Public_set_Void_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x0600B86F RID: 47215 RVA: 0x002F37A8 File Offset: 0x002F19A8
		// (set) Token: 0x0600B870 RID: 47216 RVA: 0x002F37F8 File Offset: 0x002F19F8
		public unsafe GraphyManager.ModulePosition AdvancedModulePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_get_AdvancedModulePosition_Public_get_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_set_AdvancedModulePosition_Public_set_Void_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B871 RID: 47217 RVA: 0x002F384C File Offset: 0x002F1A4C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B872 RID: 47218 RVA: 0x002F3890 File Offset: 0x002F1A90
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B873 RID: 47219 RVA: 0x002F38D4 File Offset: 0x002F1AD4
		[CallerCount(0)]
		public unsafe void OnApplicationFocus(bool isFocused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isFocused;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B874 RID: 47220 RVA: 0x002F3928 File Offset: 0x002F1B28
		[CallerCount(0)]
		public unsafe void SetModulePosition(GraphyManager.ModuleType moduleType, GraphyManager.ModulePosition modulePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modulePosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_SetModulePosition_Public_Void_ModuleType_ModulePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B875 RID: 47221 RVA: 0x002F3990 File Offset: 0x002F1B90
		[CallerCount(0)]
		public unsafe void SetModuleMode(GraphyManager.ModuleType moduleType, GraphyManager.ModuleState moduleState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moduleState;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_SetModuleMode_Public_Void_ModuleType_ModuleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B876 RID: 47222 RVA: 0x002F39F8 File Offset: 0x002F1BF8
		[CallerCount(0)]
		public unsafe void ToggleModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_ToggleModes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x002F3A3C File Offset: 0x002F1C3C
		[CallerCount(0)]
		public unsafe void SetPreset(GraphyManager.ModulePreset modulePreset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref modulePreset;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_SetPreset_Public_Void_ModulePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B878 RID: 47224 RVA: 0x002F3A90 File Offset: 0x002F1C90
		[CallerCount(0)]
		public unsafe void ToggleActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_ToggleActive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B879 RID: 47225 RVA: 0x002F3AD4 File Offset: 0x002F1CD4
		[CallerCount(0)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x002F3B18 File Offset: 0x002F1D18
		[CallerCount(0)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x002F3B5C File Offset: 0x002F1D5C
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x002F3BA0 File Offset: 0x002F1DA0
		[CallerCount(0)]
		public unsafe void CheckForHotkeyPresses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_CheckForHotkeyPresses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x002F3BE4 File Offset: 0x002F1DE4
		[CallerCount(0)]
		public unsafe bool CheckFor1KeyPress(KeyCode key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_CheckFor1KeyPress_Private_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x002F3C48 File Offset: 0x002F1E48
		[CallerCount(0)]
		public unsafe bool CheckFor2KeyPress(KeyCode key1, KeyCode key2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key2;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_CheckFor2KeyPress_Private_Boolean_KeyCode_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x002F3CC0 File Offset: 0x002F1EC0
		[CallerCount(0)]
		public unsafe bool CheckFor3KeyPress(KeyCode key1, KeyCode key2, KeyCode key3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key3;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_CheckFor3KeyPress_Private_Boolean_KeyCode_KeyCode_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x002F3D48 File Offset: 0x002F1F48
		[CallerCount(0)]
		public unsafe void UpdateAllParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_UpdateAllParameters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B881 RID: 47233 RVA: 0x002F3D8C File Offset: 0x002F1F8C
		[CallerCount(0)]
		public unsafe void RefreshAllParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyManager.NativeMethodInfoPtr_RefreshAllParameters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B882 RID: 47234 RVA: 0x002F3DD0 File Offset: 0x002F1FD0
		// Note: this type is marked as 'beforefieldinit'.
		static GraphyManager()
		{
			Il2CppClassPointerStore<GraphyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy", "GraphyManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr);
			GraphyManager.NativeFieldInfoPtr_m_graphyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_graphyMode");
			GraphyManager.NativeFieldInfoPtr_m_enableOnStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_enableOnStartup");
			GraphyManager.NativeFieldInfoPtr_m_keepAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_keepAlive");
			GraphyManager.NativeFieldInfoPtr_m_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_background");
			GraphyManager.NativeFieldInfoPtr_m_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_backgroundColor");
			GraphyManager.NativeFieldInfoPtr_m_enableHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_enableHotkeys");
			GraphyManager.NativeFieldInfoPtr_m_toggleModeKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_toggleModeKeyCode");
			GraphyManager.NativeFieldInfoPtr_m_toggleModeCtrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_toggleModeCtrl");
			GraphyManager.NativeFieldInfoPtr_m_toggleModeAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_toggleModeAlt");
			GraphyManager.NativeFieldInfoPtr_m_toggleActiveKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_toggleActiveKeyCode");
			GraphyManager.NativeFieldInfoPtr_m_toggleActiveCtrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_toggleActiveCtrl");
			GraphyManager.NativeFieldInfoPtr_m_toggleActiveAlt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_toggleActiveAlt");
			GraphyManager.NativeFieldInfoPtr_m_graphModulePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_graphModulePosition");
			GraphyManager.NativeFieldInfoPtr_m_fpsModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_fpsModuleState");
			GraphyManager.NativeFieldInfoPtr_m_timeToResetMinMaxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_timeToResetMinMaxFps");
			GraphyManager.NativeFieldInfoPtr_m_goodFpsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_goodFpsColor");
			GraphyManager.NativeFieldInfoPtr_m_goodFpsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_goodFpsThreshold");
			GraphyManager.NativeFieldInfoPtr_m_cautionFpsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_cautionFpsColor");
			GraphyManager.NativeFieldInfoPtr_m_cautionFpsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_cautionFpsThreshold");
			GraphyManager.NativeFieldInfoPtr_m_criticalFpsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_criticalFpsColor");
			GraphyManager.NativeFieldInfoPtr_m_fpsGraphResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_fpsGraphResolution");
			GraphyManager.NativeFieldInfoPtr_m_fpsTextUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_fpsTextUpdateRate");
			GraphyManager.NativeFieldInfoPtr_m_ramModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_ramModuleState");
			GraphyManager.NativeFieldInfoPtr_m_allocatedRamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_allocatedRamColor");
			GraphyManager.NativeFieldInfoPtr_m_reservedRamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_reservedRamColor");
			GraphyManager.NativeFieldInfoPtr_m_monoRamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_monoRamColor");
			GraphyManager.NativeFieldInfoPtr_m_ramGraphResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_ramGraphResolution");
			GraphyManager.NativeFieldInfoPtr_m_ramTextUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_ramTextUpdateRate");
			GraphyManager.NativeFieldInfoPtr_m_audioModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_audioModuleState");
			GraphyManager.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_findAudioListenerInCameraIfNull");
			GraphyManager.NativeFieldInfoPtr_m_audioListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_audioListener");
			GraphyManager.NativeFieldInfoPtr_m_audioGraphColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_audioGraphColor");
			GraphyManager.NativeFieldInfoPtr_m_audioGraphResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_audioGraphResolution");
			GraphyManager.NativeFieldInfoPtr_m_audioTextUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_audioTextUpdateRate");
			GraphyManager.NativeFieldInfoPtr_m_FFTWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_FFTWindow");
			GraphyManager.NativeFieldInfoPtr_m_spectrumSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_spectrumSize");
			GraphyManager.NativeFieldInfoPtr_m_advancedModulePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_advancedModulePosition");
			GraphyManager.NativeFieldInfoPtr_m_advancedModuleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_advancedModuleState");
			GraphyManager.NativeFieldInfoPtr_m_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_initialized");
			GraphyManager.NativeFieldInfoPtr_m_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_active");
			GraphyManager.NativeFieldInfoPtr_m_focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_focused");
			GraphyManager.NativeFieldInfoPtr_m_fpsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_fpsManager");
			GraphyManager.NativeFieldInfoPtr_m_ramManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_ramManager");
			GraphyManager.NativeFieldInfoPtr_m_audioManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_audioManager");
			GraphyManager.NativeFieldInfoPtr_m_advancedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_advancedData");
			GraphyManager.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_fpsMonitor");
			GraphyManager.NativeFieldInfoPtr_m_ramMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_ramMonitor");
			GraphyManager.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_audioMonitor");
			GraphyManager.NativeFieldInfoPtr_m_modulePresetState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, "m_modulePresetState");
			GraphyManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678285);
			GraphyManager.NativeMethodInfoPtr_get_GraphyMode_Public_get_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678286);
			GraphyManager.NativeMethodInfoPtr_set_GraphyMode_Public_set_Void_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678287);
			GraphyManager.NativeMethodInfoPtr_get_EnableOnStartup_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678288);
			GraphyManager.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678289);
			GraphyManager.NativeMethodInfoPtr_get_Background_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678290);
			GraphyManager.NativeMethodInfoPtr_set_Background_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678291);
			GraphyManager.NativeMethodInfoPtr_get_BackgroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678292);
			GraphyManager.NativeMethodInfoPtr_set_BackgroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678293);
			GraphyManager.NativeMethodInfoPtr_get_GraphModulePosition_Public_get_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678294);
			GraphyManager.NativeMethodInfoPtr_set_GraphModulePosition_Public_set_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678295);
			GraphyManager.NativeMethodInfoPtr_get_FpsModuleState_Public_get_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678296);
			GraphyManager.NativeMethodInfoPtr_set_FpsModuleState_Public_set_Void_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678297);
			GraphyManager.NativeMethodInfoPtr_get_TimeToResetMinMaxFps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678298);
			GraphyManager.NativeMethodInfoPtr_set_TimeToResetMinMaxFps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678299);
			GraphyManager.NativeMethodInfoPtr_get_GoodFPSColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678300);
			GraphyManager.NativeMethodInfoPtr_set_GoodFPSColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678301);
			GraphyManager.NativeMethodInfoPtr_get_CautionFPSColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678302);
			GraphyManager.NativeMethodInfoPtr_set_CautionFPSColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678303);
			GraphyManager.NativeMethodInfoPtr_get_CriticalFPSColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678304);
			GraphyManager.NativeMethodInfoPtr_set_CriticalFPSColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678305);
			GraphyManager.NativeMethodInfoPtr_get_GoodFPSThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678306);
			GraphyManager.NativeMethodInfoPtr_set_GoodFPSThreshold_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678307);
			GraphyManager.NativeMethodInfoPtr_get_CautionFPSThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678308);
			GraphyManager.NativeMethodInfoPtr_set_CautionFPSThreshold_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678309);
			GraphyManager.NativeMethodInfoPtr_get_FpsGraphResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678310);
			GraphyManager.NativeMethodInfoPtr_set_FpsGraphResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678311);
			GraphyManager.NativeMethodInfoPtr_get_FpsTextUpdateRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678312);
			GraphyManager.NativeMethodInfoPtr_set_FpsTextUpdateRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678313);
			GraphyManager.NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678314);
			GraphyManager.NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678315);
			GraphyManager.NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678316);
			GraphyManager.NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678317);
			GraphyManager.NativeMethodInfoPtr_get_RamModuleState_Public_get_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678318);
			GraphyManager.NativeMethodInfoPtr_set_RamModuleState_Public_set_Void_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678319);
			GraphyManager.NativeMethodInfoPtr_get_AllocatedRamColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678320);
			GraphyManager.NativeMethodInfoPtr_set_AllocatedRamColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678321);
			GraphyManager.NativeMethodInfoPtr_get_ReservedRamColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678322);
			GraphyManager.NativeMethodInfoPtr_set_ReservedRamColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678323);
			GraphyManager.NativeMethodInfoPtr_get_MonoRamColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678324);
			GraphyManager.NativeMethodInfoPtr_set_MonoRamColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678325);
			GraphyManager.NativeMethodInfoPtr_get_RamGraphResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678326);
			GraphyManager.NativeMethodInfoPtr_set_RamGraphResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678327);
			GraphyManager.NativeMethodInfoPtr_get_RamTextUpdateRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678328);
			GraphyManager.NativeMethodInfoPtr_set_RamTextUpdateRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678329);
			GraphyManager.NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678330);
			GraphyManager.NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678331);
			GraphyManager.NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678332);
			GraphyManager.NativeMethodInfoPtr_get_AudioModuleState_Public_get_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678333);
			GraphyManager.NativeMethodInfoPtr_set_AudioModuleState_Public_set_Void_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678334);
			GraphyManager.NativeMethodInfoPtr_get_AudioListener_Public_get_AudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678335);
			GraphyManager.NativeMethodInfoPtr_set_AudioListener_Public_set_Void_AudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678336);
			GraphyManager.NativeMethodInfoPtr_get_FindAudioListenerInCameraIfNull_Public_get_LookForAudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678337);
			GraphyManager.NativeMethodInfoPtr_set_FindAudioListenerInCameraIfNull_Public_set_Void_LookForAudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678338);
			GraphyManager.NativeMethodInfoPtr_get_AudioGraphColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678339);
			GraphyManager.NativeMethodInfoPtr_set_AudioGraphColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678340);
			GraphyManager.NativeMethodInfoPtr_get_AudioGraphResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678341);
			GraphyManager.NativeMethodInfoPtr_set_AudioGraphResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678342);
			GraphyManager.NativeMethodInfoPtr_get_AudioTextUpdateRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678343);
			GraphyManager.NativeMethodInfoPtr_set_AudioTextUpdateRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678344);
			GraphyManager.NativeMethodInfoPtr_get_FftWindow_Public_get_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678345);
			GraphyManager.NativeMethodInfoPtr_set_FftWindow_Public_set_Void_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678346);
			GraphyManager.NativeMethodInfoPtr_get_SpectrumSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678347);
			GraphyManager.NativeMethodInfoPtr_set_SpectrumSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678348);
			GraphyManager.NativeMethodInfoPtr_get_Spectrum_Public_get_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678349);
			GraphyManager.NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678350);
			GraphyManager.NativeMethodInfoPtr_get_AdvancedModuleState_Public_get_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678351);
			GraphyManager.NativeMethodInfoPtr_set_AdvancedModuleState_Public_set_Void_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678352);
			GraphyManager.NativeMethodInfoPtr_get_AdvancedModulePosition_Public_get_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678353);
			GraphyManager.NativeMethodInfoPtr_set_AdvancedModulePosition_Public_set_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678354);
			GraphyManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678355);
			GraphyManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678356);
			GraphyManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678357);
			GraphyManager.NativeMethodInfoPtr_SetModulePosition_Public_Void_ModuleType_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678358);
			GraphyManager.NativeMethodInfoPtr_SetModuleMode_Public_Void_ModuleType_ModuleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678359);
			GraphyManager.NativeMethodInfoPtr_ToggleModes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678360);
			GraphyManager.NativeMethodInfoPtr_SetPreset_Public_Void_ModulePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678361);
			GraphyManager.NativeMethodInfoPtr_ToggleActive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678362);
			GraphyManager.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678363);
			GraphyManager.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678364);
			GraphyManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678365);
			GraphyManager.NativeMethodInfoPtr_CheckForHotkeyPresses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678366);
			GraphyManager.NativeMethodInfoPtr_CheckFor1KeyPress_Private_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678367);
			GraphyManager.NativeMethodInfoPtr_CheckFor2KeyPress_Private_Boolean_KeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678368);
			GraphyManager.NativeMethodInfoPtr_CheckFor3KeyPress_Private_Boolean_KeyCode_KeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678369);
			GraphyManager.NativeMethodInfoPtr_UpdateAllParameters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678370);
			GraphyManager.NativeMethodInfoPtr_RefreshAllParameters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr, 100678371);
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x002F48A0 File Offset: 0x002F2AA0
		public GraphyManager(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x0600B884 RID: 47236 RVA: 0x002F48A9 File Offset: 0x002F2AA9
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphyManager>.NativeClassPtr));
			}
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x0600B885 RID: 47237 RVA: 0x002F48BC File Offset: 0x002F2ABC
		// (set) Token: 0x0600B886 RID: 47238 RVA: 0x002F48E4 File Offset: 0x002F2AE4
		public unsafe GraphyManager.Mode m_graphyMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_graphyMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_graphyMode)) = value;
			}
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x0600B887 RID: 47239 RVA: 0x002F4908 File Offset: 0x002F2B08
		// (set) Token: 0x0600B888 RID: 47240 RVA: 0x002F4930 File Offset: 0x002F2B30
		public unsafe bool m_enableOnStartup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_enableOnStartup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_enableOnStartup)) = value;
			}
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x0600B889 RID: 47241 RVA: 0x002F4954 File Offset: 0x002F2B54
		// (set) Token: 0x0600B88A RID: 47242 RVA: 0x002F497C File Offset: 0x002F2B7C
		public unsafe bool m_keepAlive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_keepAlive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_keepAlive)) = value;
			}
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x0600B88B RID: 47243 RVA: 0x002F49A0 File Offset: 0x002F2BA0
		// (set) Token: 0x0600B88C RID: 47244 RVA: 0x002F49C8 File Offset: 0x002F2BC8
		public unsafe bool m_background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_background);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_background)) = value;
			}
		}

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x0600B88D RID: 47245 RVA: 0x002F49EC File Offset: 0x002F2BEC
		// (set) Token: 0x0600B88E RID: 47246 RVA: 0x002F4A14 File Offset: 0x002F2C14
		public unsafe Color m_backgroundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_backgroundColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_backgroundColor)) = value;
			}
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x0600B88F RID: 47247 RVA: 0x002F4A38 File Offset: 0x002F2C38
		// (set) Token: 0x0600B890 RID: 47248 RVA: 0x002F4A60 File Offset: 0x002F2C60
		public unsafe bool m_enableHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_enableHotkeys);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_enableHotkeys)) = value;
			}
		}

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x0600B891 RID: 47249 RVA: 0x002F4A84 File Offset: 0x002F2C84
		// (set) Token: 0x0600B892 RID: 47250 RVA: 0x002F4AAC File Offset: 0x002F2CAC
		public unsafe KeyCode m_toggleModeKeyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeKeyCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeKeyCode)) = value;
			}
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x0600B893 RID: 47251 RVA: 0x002F4AD0 File Offset: 0x002F2CD0
		// (set) Token: 0x0600B894 RID: 47252 RVA: 0x002F4AF8 File Offset: 0x002F2CF8
		public unsafe bool m_toggleModeCtrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeCtrl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeCtrl)) = value;
			}
		}

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x0600B895 RID: 47253 RVA: 0x002F4B1C File Offset: 0x002F2D1C
		// (set) Token: 0x0600B896 RID: 47254 RVA: 0x002F4B44 File Offset: 0x002F2D44
		public unsafe bool m_toggleModeAlt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeAlt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleModeAlt)) = value;
			}
		}

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x0600B897 RID: 47255 RVA: 0x002F4B68 File Offset: 0x002F2D68
		// (set) Token: 0x0600B898 RID: 47256 RVA: 0x002F4B90 File Offset: 0x002F2D90
		public unsafe KeyCode m_toggleActiveKeyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveKeyCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveKeyCode)) = value;
			}
		}

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x0600B899 RID: 47257 RVA: 0x002F4BB4 File Offset: 0x002F2DB4
		// (set) Token: 0x0600B89A RID: 47258 RVA: 0x002F4BDC File Offset: 0x002F2DDC
		public unsafe bool m_toggleActiveCtrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveCtrl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveCtrl)) = value;
			}
		}

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x0600B89B RID: 47259 RVA: 0x002F4C00 File Offset: 0x002F2E00
		// (set) Token: 0x0600B89C RID: 47260 RVA: 0x002F4C28 File Offset: 0x002F2E28
		public unsafe bool m_toggleActiveAlt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveAlt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_toggleActiveAlt)) = value;
			}
		}

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x0600B89D RID: 47261 RVA: 0x002F4C4C File Offset: 0x002F2E4C
		// (set) Token: 0x0600B89E RID: 47262 RVA: 0x002F4C74 File Offset: 0x002F2E74
		public unsafe GraphyManager.ModulePosition m_graphModulePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_graphModulePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_graphModulePosition)) = value;
			}
		}

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x0600B89F RID: 47263 RVA: 0x002F4C98 File Offset: 0x002F2E98
		// (set) Token: 0x0600B8A0 RID: 47264 RVA: 0x002F4CC0 File Offset: 0x002F2EC0
		public unsafe GraphyManager.ModuleState m_fpsModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsModuleState)) = value;
			}
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x0600B8A1 RID: 47265 RVA: 0x002F4CE4 File Offset: 0x002F2EE4
		// (set) Token: 0x0600B8A2 RID: 47266 RVA: 0x002F4D0C File Offset: 0x002F2F0C
		public unsafe int m_timeToResetMinMaxFps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_timeToResetMinMaxFps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_timeToResetMinMaxFps)) = value;
			}
		}

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x0600B8A3 RID: 47267 RVA: 0x002F4D30 File Offset: 0x002F2F30
		// (set) Token: 0x0600B8A4 RID: 47268 RVA: 0x002F4D58 File Offset: 0x002F2F58
		public unsafe Color m_goodFpsColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_goodFpsColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_goodFpsColor)) = value;
			}
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x002F4D7C File Offset: 0x002F2F7C
		// (set) Token: 0x0600B8A6 RID: 47270 RVA: 0x002F4DA4 File Offset: 0x002F2FA4
		public unsafe int m_goodFpsThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_goodFpsThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_goodFpsThreshold)) = value;
			}
		}

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x002F4DC8 File Offset: 0x002F2FC8
		// (set) Token: 0x0600B8A8 RID: 47272 RVA: 0x002F4DF0 File Offset: 0x002F2FF0
		public unsafe Color m_cautionFpsColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_cautionFpsColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_cautionFpsColor)) = value;
			}
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x0600B8A9 RID: 47273 RVA: 0x002F4E14 File Offset: 0x002F3014
		// (set) Token: 0x0600B8AA RID: 47274 RVA: 0x002F4E3C File Offset: 0x002F303C
		public unsafe int m_cautionFpsThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_cautionFpsThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_cautionFpsThreshold)) = value;
			}
		}

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x0600B8AB RID: 47275 RVA: 0x002F4E60 File Offset: 0x002F3060
		// (set) Token: 0x0600B8AC RID: 47276 RVA: 0x002F4E88 File Offset: 0x002F3088
		public unsafe Color m_criticalFpsColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_criticalFpsColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_criticalFpsColor)) = value;
			}
		}

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x0600B8AD RID: 47277 RVA: 0x002F4EAC File Offset: 0x002F30AC
		// (set) Token: 0x0600B8AE RID: 47278 RVA: 0x002F4ED4 File Offset: 0x002F30D4
		public unsafe int m_fpsGraphResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsGraphResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsGraphResolution)) = value;
			}
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x0600B8AF RID: 47279 RVA: 0x002F4EF8 File Offset: 0x002F30F8
		// (set) Token: 0x0600B8B0 RID: 47280 RVA: 0x002F4F20 File Offset: 0x002F3120
		public unsafe int m_fpsTextUpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsTextUpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsTextUpdateRate)) = value;
			}
		}

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x0600B8B1 RID: 47281 RVA: 0x002F4F44 File Offset: 0x002F3144
		// (set) Token: 0x0600B8B2 RID: 47282 RVA: 0x002F4F6C File Offset: 0x002F316C
		public unsafe GraphyManager.ModuleState m_ramModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramModuleState)) = value;
			}
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x0600B8B3 RID: 47283 RVA: 0x002F4F90 File Offset: 0x002F3190
		// (set) Token: 0x0600B8B4 RID: 47284 RVA: 0x002F4FB8 File Offset: 0x002F31B8
		public unsafe Color m_allocatedRamColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_allocatedRamColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_allocatedRamColor)) = value;
			}
		}

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x0600B8B5 RID: 47285 RVA: 0x002F4FDC File Offset: 0x002F31DC
		// (set) Token: 0x0600B8B6 RID: 47286 RVA: 0x002F5004 File Offset: 0x002F3204
		public unsafe Color m_reservedRamColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_reservedRamColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_reservedRamColor)) = value;
			}
		}

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x0600B8B7 RID: 47287 RVA: 0x002F5028 File Offset: 0x002F3228
		// (set) Token: 0x0600B8B8 RID: 47288 RVA: 0x002F5050 File Offset: 0x002F3250
		public unsafe Color m_monoRamColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_monoRamColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_monoRamColor)) = value;
			}
		}

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x0600B8B9 RID: 47289 RVA: 0x002F5074 File Offset: 0x002F3274
		// (set) Token: 0x0600B8BA RID: 47290 RVA: 0x002F509C File Offset: 0x002F329C
		public unsafe int m_ramGraphResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramGraphResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramGraphResolution)) = value;
			}
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x0600B8BB RID: 47291 RVA: 0x002F50C0 File Offset: 0x002F32C0
		// (set) Token: 0x0600B8BC RID: 47292 RVA: 0x002F50E8 File Offset: 0x002F32E8
		public unsafe int m_ramTextUpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramTextUpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramTextUpdateRate)) = value;
			}
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x0600B8BD RID: 47293 RVA: 0x002F510C File Offset: 0x002F330C
		// (set) Token: 0x0600B8BE RID: 47294 RVA: 0x002F5134 File Offset: 0x002F3334
		public unsafe GraphyManager.ModuleState m_audioModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioModuleState)) = value;
			}
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x0600B8BF RID: 47295 RVA: 0x002F5158 File Offset: 0x002F3358
		// (set) Token: 0x0600B8C0 RID: 47296 RVA: 0x002F5180 File Offset: 0x002F3380
		public unsafe GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull)) = value;
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x0600B8C1 RID: 47297 RVA: 0x002F51A4 File Offset: 0x002F33A4
		// (set) Token: 0x0600B8C2 RID: 47298 RVA: 0x002F51D8 File Offset: 0x002F33D8
		public unsafe AudioListener m_audioListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioListener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AudioListener(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioListener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x0600B8C3 RID: 47299 RVA: 0x002F5200 File Offset: 0x002F3400
		// (set) Token: 0x0600B8C4 RID: 47300 RVA: 0x002F5228 File Offset: 0x002F3428
		public unsafe Color m_audioGraphColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioGraphColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioGraphColor)) = value;
			}
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x0600B8C5 RID: 47301 RVA: 0x002F524C File Offset: 0x002F344C
		// (set) Token: 0x0600B8C6 RID: 47302 RVA: 0x002F5274 File Offset: 0x002F3474
		public unsafe int m_audioGraphResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioGraphResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioGraphResolution)) = value;
			}
		}

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x0600B8C7 RID: 47303 RVA: 0x002F5298 File Offset: 0x002F3498
		// (set) Token: 0x0600B8C8 RID: 47304 RVA: 0x002F52C0 File Offset: 0x002F34C0
		public unsafe int m_audioTextUpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioTextUpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioTextUpdateRate)) = value;
			}
		}

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x0600B8C9 RID: 47305 RVA: 0x002F52E4 File Offset: 0x002F34E4
		// (set) Token: 0x0600B8CA RID: 47306 RVA: 0x002F530C File Offset: 0x002F350C
		public unsafe FFTWindow m_FFTWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_FFTWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_FFTWindow)) = value;
			}
		}

		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x0600B8CB RID: 47307 RVA: 0x002F5330 File Offset: 0x002F3530
		// (set) Token: 0x0600B8CC RID: 47308 RVA: 0x002F5358 File Offset: 0x002F3558
		public unsafe int m_spectrumSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_spectrumSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_spectrumSize)) = value;
			}
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x0600B8CD RID: 47309 RVA: 0x002F537C File Offset: 0x002F357C
		// (set) Token: 0x0600B8CE RID: 47310 RVA: 0x002F53A4 File Offset: 0x002F35A4
		public unsafe GraphyManager.ModulePosition m_advancedModulePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedModulePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedModulePosition)) = value;
			}
		}

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x0600B8CF RID: 47311 RVA: 0x002F53C8 File Offset: 0x002F35C8
		// (set) Token: 0x0600B8D0 RID: 47312 RVA: 0x002F53F0 File Offset: 0x002F35F0
		public unsafe GraphyManager.ModuleState m_advancedModuleState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedModuleState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedModuleState)) = value;
			}
		}

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x0600B8D1 RID: 47313 RVA: 0x002F5414 File Offset: 0x002F3614
		// (set) Token: 0x0600B8D2 RID: 47314 RVA: 0x002F543C File Offset: 0x002F363C
		public unsafe bool m_initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_initialized)) = value;
			}
		}

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x0600B8D3 RID: 47315 RVA: 0x002F5460 File Offset: 0x002F3660
		// (set) Token: 0x0600B8D4 RID: 47316 RVA: 0x002F5488 File Offset: 0x002F3688
		public unsafe bool m_active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_active)) = value;
			}
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x0600B8D5 RID: 47317 RVA: 0x002F54AC File Offset: 0x002F36AC
		// (set) Token: 0x0600B8D6 RID: 47318 RVA: 0x002F54D4 File Offset: 0x002F36D4
		public unsafe bool m_focused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_focused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_focused)) = value;
			}
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x0600B8D7 RID: 47319 RVA: 0x002F54F8 File Offset: 0x002F36F8
		// (set) Token: 0x0600B8D8 RID: 47320 RVA: 0x002F552C File Offset: 0x002F372C
		public unsafe G_FpsManager m_fpsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_FpsManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x0600B8D9 RID: 47321 RVA: 0x002F5554 File Offset: 0x002F3754
		// (set) Token: 0x0600B8DA RID: 47322 RVA: 0x002F5588 File Offset: 0x002F3788
		public unsafe G_RamManager m_ramManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_RamManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x0600B8DB RID: 47323 RVA: 0x002F55B0 File Offset: 0x002F37B0
		// (set) Token: 0x0600B8DC RID: 47324 RVA: 0x002F55E4 File Offset: 0x002F37E4
		public unsafe G_AudioManager m_audioManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AudioManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x0600B8DD RID: 47325 RVA: 0x002F560C File Offset: 0x002F380C
		// (set) Token: 0x0600B8DE RID: 47326 RVA: 0x002F5640 File Offset: 0x002F3840
		public unsafe G_AdvancedData m_advancedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AdvancedData(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_advancedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x0600B8DF RID: 47327 RVA: 0x002F5668 File Offset: 0x002F3868
		// (set) Token: 0x0600B8E0 RID: 47328 RVA: 0x002F569C File Offset: 0x002F389C
		public unsafe G_FpsMonitor m_fpsMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_FpsMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x0600B8E1 RID: 47329 RVA: 0x002F56C4 File Offset: 0x002F38C4
		// (set) Token: 0x0600B8E2 RID: 47330 RVA: 0x002F56F8 File Offset: 0x002F38F8
		public unsafe G_RamMonitor m_ramMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_RamMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_ramMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x0600B8E3 RID: 47331 RVA: 0x002F5720 File Offset: 0x002F3920
		// (set) Token: 0x0600B8E4 RID: 47332 RVA: 0x002F5754 File Offset: 0x002F3954
		public unsafe G_AudioMonitor m_audioMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AudioMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x0600B8E5 RID: 47333 RVA: 0x002F577C File Offset: 0x002F397C
		// (set) Token: 0x0600B8E6 RID: 47334 RVA: 0x002F57A4 File Offset: 0x002F39A4
		public unsafe GraphyManager.ModulePreset m_modulePresetState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_modulePresetState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyManager.NativeFieldInfoPtr_m_modulePresetState)) = value;
			}
		}

		// Token: 0x0400761A RID: 30234
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyMode;

		// Token: 0x0400761B RID: 30235
		private static readonly IntPtr NativeFieldInfoPtr_m_enableOnStartup;

		// Token: 0x0400761C RID: 30236
		private static readonly IntPtr NativeFieldInfoPtr_m_keepAlive;

		// Token: 0x0400761D RID: 30237
		private static readonly IntPtr NativeFieldInfoPtr_m_background;

		// Token: 0x0400761E RID: 30238
		private static readonly IntPtr NativeFieldInfoPtr_m_backgroundColor;

		// Token: 0x0400761F RID: 30239
		private static readonly IntPtr NativeFieldInfoPtr_m_enableHotkeys;

		// Token: 0x04007620 RID: 30240
		private static readonly IntPtr NativeFieldInfoPtr_m_toggleModeKeyCode;

		// Token: 0x04007621 RID: 30241
		private static readonly IntPtr NativeFieldInfoPtr_m_toggleModeCtrl;

		// Token: 0x04007622 RID: 30242
		private static readonly IntPtr NativeFieldInfoPtr_m_toggleModeAlt;

		// Token: 0x04007623 RID: 30243
		private static readonly IntPtr NativeFieldInfoPtr_m_toggleActiveKeyCode;

		// Token: 0x04007624 RID: 30244
		private static readonly IntPtr NativeFieldInfoPtr_m_toggleActiveCtrl;

		// Token: 0x04007625 RID: 30245
		private static readonly IntPtr NativeFieldInfoPtr_m_toggleActiveAlt;

		// Token: 0x04007626 RID: 30246
		private static readonly IntPtr NativeFieldInfoPtr_m_graphModulePosition;

		// Token: 0x04007627 RID: 30247
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsModuleState;

		// Token: 0x04007628 RID: 30248
		private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMinMaxFps;

		// Token: 0x04007629 RID: 30249
		private static readonly IntPtr NativeFieldInfoPtr_m_goodFpsColor;

		// Token: 0x0400762A RID: 30250
		private static readonly IntPtr NativeFieldInfoPtr_m_goodFpsThreshold;

		// Token: 0x0400762B RID: 30251
		private static readonly IntPtr NativeFieldInfoPtr_m_cautionFpsColor;

		// Token: 0x0400762C RID: 30252
		private static readonly IntPtr NativeFieldInfoPtr_m_cautionFpsThreshold;

		// Token: 0x0400762D RID: 30253
		private static readonly IntPtr NativeFieldInfoPtr_m_criticalFpsColor;

		// Token: 0x0400762E RID: 30254
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsGraphResolution;

		// Token: 0x0400762F RID: 30255
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsTextUpdateRate;

		// Token: 0x04007630 RID: 30256
		private static readonly IntPtr NativeFieldInfoPtr_m_ramModuleState;

		// Token: 0x04007631 RID: 30257
		private static readonly IntPtr NativeFieldInfoPtr_m_allocatedRamColor;

		// Token: 0x04007632 RID: 30258
		private static readonly IntPtr NativeFieldInfoPtr_m_reservedRamColor;

		// Token: 0x04007633 RID: 30259
		private static readonly IntPtr NativeFieldInfoPtr_m_monoRamColor;

		// Token: 0x04007634 RID: 30260
		private static readonly IntPtr NativeFieldInfoPtr_m_ramGraphResolution;

		// Token: 0x04007635 RID: 30261
		private static readonly IntPtr NativeFieldInfoPtr_m_ramTextUpdateRate;

		// Token: 0x04007636 RID: 30262
		private static readonly IntPtr NativeFieldInfoPtr_m_audioModuleState;

		// Token: 0x04007637 RID: 30263
		private static readonly IntPtr NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull;

		// Token: 0x04007638 RID: 30264
		private static readonly IntPtr NativeFieldInfoPtr_m_audioListener;

		// Token: 0x04007639 RID: 30265
		private static readonly IntPtr NativeFieldInfoPtr_m_audioGraphColor;

		// Token: 0x0400763A RID: 30266
		private static readonly IntPtr NativeFieldInfoPtr_m_audioGraphResolution;

		// Token: 0x0400763B RID: 30267
		private static readonly IntPtr NativeFieldInfoPtr_m_audioTextUpdateRate;

		// Token: 0x0400763C RID: 30268
		private static readonly IntPtr NativeFieldInfoPtr_m_FFTWindow;

		// Token: 0x0400763D RID: 30269
		private static readonly IntPtr NativeFieldInfoPtr_m_spectrumSize;

		// Token: 0x0400763E RID: 30270
		private static readonly IntPtr NativeFieldInfoPtr_m_advancedModulePosition;

		// Token: 0x0400763F RID: 30271
		private static readonly IntPtr NativeFieldInfoPtr_m_advancedModuleState;

		// Token: 0x04007640 RID: 30272
		private static readonly IntPtr NativeFieldInfoPtr_m_initialized;

		// Token: 0x04007641 RID: 30273
		private static readonly IntPtr NativeFieldInfoPtr_m_active;

		// Token: 0x04007642 RID: 30274
		private static readonly IntPtr NativeFieldInfoPtr_m_focused;

		// Token: 0x04007643 RID: 30275
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsManager;

		// Token: 0x04007644 RID: 30276
		private static readonly IntPtr NativeFieldInfoPtr_m_ramManager;

		// Token: 0x04007645 RID: 30277
		private static readonly IntPtr NativeFieldInfoPtr_m_audioManager;

		// Token: 0x04007646 RID: 30278
		private static readonly IntPtr NativeFieldInfoPtr_m_advancedData;

		// Token: 0x04007647 RID: 30279
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsMonitor;

		// Token: 0x04007648 RID: 30280
		private static readonly IntPtr NativeFieldInfoPtr_m_ramMonitor;

		// Token: 0x04007649 RID: 30281
		private static readonly IntPtr NativeFieldInfoPtr_m_audioMonitor;

		// Token: 0x0400764A RID: 30282
		private static readonly IntPtr NativeFieldInfoPtr_m_modulePresetState;

		// Token: 0x0400764B RID: 30283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400764C RID: 30284
		private static readonly IntPtr NativeMethodInfoPtr_get_GraphyMode_Public_get_Mode_0;

		// Token: 0x0400764D RID: 30285
		private static readonly IntPtr NativeMethodInfoPtr_set_GraphyMode_Public_set_Void_Mode_0;

		// Token: 0x0400764E RID: 30286
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableOnStartup_Public_get_Boolean_0;

		// Token: 0x0400764F RID: 30287
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04007650 RID: 30288
		private static readonly IntPtr NativeMethodInfoPtr_get_Background_Public_get_Boolean_0;

		// Token: 0x04007651 RID: 30289
		private static readonly IntPtr NativeMethodInfoPtr_set_Background_Public_set_Void_Boolean_0;

		// Token: 0x04007652 RID: 30290
		private static readonly IntPtr NativeMethodInfoPtr_get_BackgroundColor_Public_get_Color_0;

		// Token: 0x04007653 RID: 30291
		private static readonly IntPtr NativeMethodInfoPtr_set_BackgroundColor_Public_set_Void_Color_0;

		// Token: 0x04007654 RID: 30292
		private static readonly IntPtr NativeMethodInfoPtr_get_GraphModulePosition_Public_get_ModulePosition_0;

		// Token: 0x04007655 RID: 30293
		private static readonly IntPtr NativeMethodInfoPtr_set_GraphModulePosition_Public_set_Void_ModulePosition_0;

		// Token: 0x04007656 RID: 30294
		private static readonly IntPtr NativeMethodInfoPtr_get_FpsModuleState_Public_get_ModuleState_0;

		// Token: 0x04007657 RID: 30295
		private static readonly IntPtr NativeMethodInfoPtr_set_FpsModuleState_Public_set_Void_ModuleState_0;

		// Token: 0x04007658 RID: 30296
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeToResetMinMaxFps_Public_get_Int32_0;

		// Token: 0x04007659 RID: 30297
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeToResetMinMaxFps_Public_set_Void_Int32_0;

		// Token: 0x0400765A RID: 30298
		private static readonly IntPtr NativeMethodInfoPtr_get_GoodFPSColor_Public_get_Color_0;

		// Token: 0x0400765B RID: 30299
		private static readonly IntPtr NativeMethodInfoPtr_set_GoodFPSColor_Public_set_Void_Color_0;

		// Token: 0x0400765C RID: 30300
		private static readonly IntPtr NativeMethodInfoPtr_get_CautionFPSColor_Public_get_Color_0;

		// Token: 0x0400765D RID: 30301
		private static readonly IntPtr NativeMethodInfoPtr_set_CautionFPSColor_Public_set_Void_Color_0;

		// Token: 0x0400765E RID: 30302
		private static readonly IntPtr NativeMethodInfoPtr_get_CriticalFPSColor_Public_get_Color_0;

		// Token: 0x0400765F RID: 30303
		private static readonly IntPtr NativeMethodInfoPtr_set_CriticalFPSColor_Public_set_Void_Color_0;

		// Token: 0x04007660 RID: 30304
		private static readonly IntPtr NativeMethodInfoPtr_get_GoodFPSThreshold_Public_get_Int32_0;

		// Token: 0x04007661 RID: 30305
		private static readonly IntPtr NativeMethodInfoPtr_set_GoodFPSThreshold_Public_set_Void_Int32_0;

		// Token: 0x04007662 RID: 30306
		private static readonly IntPtr NativeMethodInfoPtr_get_CautionFPSThreshold_Public_get_Int32_0;

		// Token: 0x04007663 RID: 30307
		private static readonly IntPtr NativeMethodInfoPtr_set_CautionFPSThreshold_Public_set_Void_Int32_0;

		// Token: 0x04007664 RID: 30308
		private static readonly IntPtr NativeMethodInfoPtr_get_FpsGraphResolution_Public_get_Int32_0;

		// Token: 0x04007665 RID: 30309
		private static readonly IntPtr NativeMethodInfoPtr_set_FpsGraphResolution_Public_set_Void_Int32_0;

		// Token: 0x04007666 RID: 30310
		private static readonly IntPtr NativeMethodInfoPtr_get_FpsTextUpdateRate_Public_get_Int32_0;

		// Token: 0x04007667 RID: 30311
		private static readonly IntPtr NativeMethodInfoPtr_set_FpsTextUpdateRate_Public_set_Void_Int32_0;

		// Token: 0x04007668 RID: 30312
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0;

		// Token: 0x04007669 RID: 30313
		private static readonly IntPtr NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0;

		// Token: 0x0400766A RID: 30314
		private static readonly IntPtr NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0;

		// Token: 0x0400766B RID: 30315
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0;

		// Token: 0x0400766C RID: 30316
		private static readonly IntPtr NativeMethodInfoPtr_get_RamModuleState_Public_get_ModuleState_0;

		// Token: 0x0400766D RID: 30317
		private static readonly IntPtr NativeMethodInfoPtr_set_RamModuleState_Public_set_Void_ModuleState_0;

		// Token: 0x0400766E RID: 30318
		private static readonly IntPtr NativeMethodInfoPtr_get_AllocatedRamColor_Public_get_Color_0;

		// Token: 0x0400766F RID: 30319
		private static readonly IntPtr NativeMethodInfoPtr_set_AllocatedRamColor_Public_set_Void_Color_0;

		// Token: 0x04007670 RID: 30320
		private static readonly IntPtr NativeMethodInfoPtr_get_ReservedRamColor_Public_get_Color_0;

		// Token: 0x04007671 RID: 30321
		private static readonly IntPtr NativeMethodInfoPtr_set_ReservedRamColor_Public_set_Void_Color_0;

		// Token: 0x04007672 RID: 30322
		private static readonly IntPtr NativeMethodInfoPtr_get_MonoRamColor_Public_get_Color_0;

		// Token: 0x04007673 RID: 30323
		private static readonly IntPtr NativeMethodInfoPtr_set_MonoRamColor_Public_set_Void_Color_0;

		// Token: 0x04007674 RID: 30324
		private static readonly IntPtr NativeMethodInfoPtr_get_RamGraphResolution_Public_get_Int32_0;

		// Token: 0x04007675 RID: 30325
		private static readonly IntPtr NativeMethodInfoPtr_set_RamGraphResolution_Public_set_Void_Int32_0;

		// Token: 0x04007676 RID: 30326
		private static readonly IntPtr NativeMethodInfoPtr_get_RamTextUpdateRate_Public_get_Int32_0;

		// Token: 0x04007677 RID: 30327
		private static readonly IntPtr NativeMethodInfoPtr_set_RamTextUpdateRate_Public_set_Void_Int32_0;

		// Token: 0x04007678 RID: 30328
		private static readonly IntPtr NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0;

		// Token: 0x04007679 RID: 30329
		private static readonly IntPtr NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0;

		// Token: 0x0400767A RID: 30330
		private static readonly IntPtr NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0;

		// Token: 0x0400767B RID: 30331
		private static readonly IntPtr NativeMethodInfoPtr_get_AudioModuleState_Public_get_ModuleState_0;

		// Token: 0x0400767C RID: 30332
		private static readonly IntPtr NativeMethodInfoPtr_set_AudioModuleState_Public_set_Void_ModuleState_0;

		// Token: 0x0400767D RID: 30333
		private static readonly IntPtr NativeMethodInfoPtr_get_AudioListener_Public_get_AudioListener_0;

		// Token: 0x0400767E RID: 30334
		private static readonly IntPtr NativeMethodInfoPtr_set_AudioListener_Public_set_Void_AudioListener_0;

		// Token: 0x0400767F RID: 30335
		private static readonly IntPtr NativeMethodInfoPtr_get_FindAudioListenerInCameraIfNull_Public_get_LookForAudioListener_0;

		// Token: 0x04007680 RID: 30336
		private static readonly IntPtr NativeMethodInfoPtr_set_FindAudioListenerInCameraIfNull_Public_set_Void_LookForAudioListener_0;

		// Token: 0x04007681 RID: 30337
		private static readonly IntPtr NativeMethodInfoPtr_get_AudioGraphColor_Public_get_Color_0;

		// Token: 0x04007682 RID: 30338
		private static readonly IntPtr NativeMethodInfoPtr_set_AudioGraphColor_Public_set_Void_Color_0;

		// Token: 0x04007683 RID: 30339
		private static readonly IntPtr NativeMethodInfoPtr_get_AudioGraphResolution_Public_get_Int32_0;

		// Token: 0x04007684 RID: 30340
		private static readonly IntPtr NativeMethodInfoPtr_set_AudioGraphResolution_Public_set_Void_Int32_0;

		// Token: 0x04007685 RID: 30341
		private static readonly IntPtr NativeMethodInfoPtr_get_AudioTextUpdateRate_Public_get_Int32_0;

		// Token: 0x04007686 RID: 30342
		private static readonly IntPtr NativeMethodInfoPtr_set_AudioTextUpdateRate_Public_set_Void_Int32_0;

		// Token: 0x04007687 RID: 30343
		private static readonly IntPtr NativeMethodInfoPtr_get_FftWindow_Public_get_FFTWindow_0;

		// Token: 0x04007688 RID: 30344
		private static readonly IntPtr NativeMethodInfoPtr_set_FftWindow_Public_set_Void_FFTWindow_0;

		// Token: 0x04007689 RID: 30345
		private static readonly IntPtr NativeMethodInfoPtr_get_SpectrumSize_Public_get_Int32_0;

		// Token: 0x0400768A RID: 30346
		private static readonly IntPtr NativeMethodInfoPtr_set_SpectrumSize_Public_set_Void_Int32_0;

		// Token: 0x0400768B RID: 30347
		private static readonly IntPtr NativeMethodInfoPtr_get_Spectrum_Public_get_ArrayOf_Single_0;

		// Token: 0x0400768C RID: 30348
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0;

		// Token: 0x0400768D RID: 30349
		private static readonly IntPtr NativeMethodInfoPtr_get_AdvancedModuleState_Public_get_ModuleState_0;

		// Token: 0x0400768E RID: 30350
		private static readonly IntPtr NativeMethodInfoPtr_set_AdvancedModuleState_Public_set_Void_ModuleState_0;

		// Token: 0x0400768F RID: 30351
		private static readonly IntPtr NativeMethodInfoPtr_get_AdvancedModulePosition_Public_get_ModulePosition_0;

		// Token: 0x04007690 RID: 30352
		private static readonly IntPtr NativeMethodInfoPtr_set_AdvancedModulePosition_Public_set_Void_ModulePosition_0;

		// Token: 0x04007691 RID: 30353
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007692 RID: 30354
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007693 RID: 30355
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x04007694 RID: 30356
		private static readonly IntPtr NativeMethodInfoPtr_SetModulePosition_Public_Void_ModuleType_ModulePosition_0;

		// Token: 0x04007695 RID: 30357
		private static readonly IntPtr NativeMethodInfoPtr_SetModuleMode_Public_Void_ModuleType_ModuleState_0;

		// Token: 0x04007696 RID: 30358
		private static readonly IntPtr NativeMethodInfoPtr_ToggleModes_Public_Void_0;

		// Token: 0x04007697 RID: 30359
		private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Public_Void_ModulePreset_0;

		// Token: 0x04007698 RID: 30360
		private static readonly IntPtr NativeMethodInfoPtr_ToggleActive_Public_Void_0;

		// Token: 0x04007699 RID: 30361
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x0400769A RID: 30362
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x0400769B RID: 30363
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x0400769C RID: 30364
		private static readonly IntPtr NativeMethodInfoPtr_CheckForHotkeyPresses_Private_Void_0;

		// Token: 0x0400769D RID: 30365
		private static readonly IntPtr NativeMethodInfoPtr_CheckFor1KeyPress_Private_Boolean_KeyCode_0;

		// Token: 0x0400769E RID: 30366
		private static readonly IntPtr NativeMethodInfoPtr_CheckFor2KeyPress_Private_Boolean_KeyCode_KeyCode_0;

		// Token: 0x0400769F RID: 30367
		private static readonly IntPtr NativeMethodInfoPtr_CheckFor3KeyPress_Private_Boolean_KeyCode_KeyCode_KeyCode_0;

		// Token: 0x040076A0 RID: 30368
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllParameters_Private_Void_0;

		// Token: 0x040076A1 RID: 30369
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAllParameters_Private_Void_0;

		// Token: 0x020008D7 RID: 2263
		public enum Mode
		{
			// Token: 0x040076A3 RID: 30371
			FULL,
			// Token: 0x040076A4 RID: 30372
			LIGHT
		}

		// Token: 0x020008D8 RID: 2264
		public enum ModuleType
		{
			// Token: 0x040076A6 RID: 30374
			FPS,
			// Token: 0x040076A7 RID: 30375
			RAM,
			// Token: 0x040076A8 RID: 30376
			AUDIO,
			// Token: 0x040076A9 RID: 30377
			ADVANCED
		}

		// Token: 0x020008D9 RID: 2265
		public enum ModuleState
		{
			// Token: 0x040076AB RID: 30379
			FULL,
			// Token: 0x040076AC RID: 30380
			TEXT,
			// Token: 0x040076AD RID: 30381
			BASIC,
			// Token: 0x040076AE RID: 30382
			BACKGROUND,
			// Token: 0x040076AF RID: 30383
			OFF
		}

		// Token: 0x020008DA RID: 2266
		public enum ModulePosition
		{
			// Token: 0x040076B1 RID: 30385
			TOP_RIGHT,
			// Token: 0x040076B2 RID: 30386
			TOP_LEFT,
			// Token: 0x040076B3 RID: 30387
			BOTTOM_RIGHT,
			// Token: 0x040076B4 RID: 30388
			BOTTOM_LEFT,
			// Token: 0x040076B5 RID: 30389
			FREE
		}

		// Token: 0x020008DB RID: 2267
		public enum LookForAudioListener
		{
			// Token: 0x040076B7 RID: 30391
			ALWAYS,
			// Token: 0x040076B8 RID: 30392
			ON_SCENE_LOAD,
			// Token: 0x040076B9 RID: 30393
			NEVER
		}

		// Token: 0x020008DC RID: 2268
		public enum ModulePreset
		{
			// Token: 0x040076BB RID: 30395
			FPS_BASIC,
			// Token: 0x040076BC RID: 30396
			FPS_TEXT,
			// Token: 0x040076BD RID: 30397
			FPS_FULL,
			// Token: 0x040076BE RID: 30398
			FPS_TEXT_RAM_TEXT,
			// Token: 0x040076BF RID: 30399
			FPS_FULL_RAM_TEXT,
			// Token: 0x040076C0 RID: 30400
			FPS_FULL_RAM_FULL,
			// Token: 0x040076C1 RID: 30401
			FPS_TEXT_RAM_TEXT_AUDIO_TEXT,
			// Token: 0x040076C2 RID: 30402
			FPS_FULL_RAM_TEXT_AUDIO_TEXT,
			// Token: 0x040076C3 RID: 30403
			FPS_FULL_RAM_FULL_AUDIO_TEXT,
			// Token: 0x040076C4 RID: 30404
			FPS_FULL_RAM_FULL_AUDIO_FULL,
			// Token: 0x040076C5 RID: 30405
			FPS_FULL_RAM_FULL_AUDIO_FULL_ADVANCED_FULL,
			// Token: 0x040076C6 RID: 30406
			FPS_BASIC_ADVANCED_FULL
		}
	}
}
