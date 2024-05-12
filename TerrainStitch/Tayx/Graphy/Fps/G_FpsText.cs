using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Fps
{
	// Token: 0x020008EC RID: 2284
	public class G_FpsText : MonoBehaviour
	{
		// Token: 0x0600BA3E RID: 47678 RVA: 0x002FA62C File Offset: 0x002F882C
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA3F RID: 47679 RVA: 0x002FA670 File Offset: 0x002F8870
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA40 RID: 47680 RVA: 0x002FA6B4 File Offset: 0x002F88B4
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA41 RID: 47681 RVA: 0x002FA6F8 File Offset: 0x002F88F8
		[CallerCount(0)]
		public unsafe void SetFpsRelatedTextColor(Text text, float fps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fps;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_SetFpsRelatedTextColor_Private_Void_Text_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x002FA764 File Offset: 0x002F8964
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA43 RID: 47683 RVA: 0x002FA7A8 File Offset: 0x002F89A8
		[CallerCount(0)]
		public unsafe G_FpsText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA44 RID: 47684 RVA: 0x002FA7F4 File Offset: 0x002F89F4
		// Note: this type is marked as 'beforefieldinit'.
		static G_FpsText()
		{
			Il2CppClassPointerStore<G_FpsText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Fps", "G_FpsText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr);
			G_FpsText.NativeFieldInfoPtr_m_fpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_fpsText");
			G_FpsText.NativeFieldInfoPtr_m_msText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_msText");
			G_FpsText.NativeFieldInfoPtr_m_avgFpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_avgFpsText");
			G_FpsText.NativeFieldInfoPtr_m_minFpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_minFpsText");
			G_FpsText.NativeFieldInfoPtr_m_maxFpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_maxFpsText");
			G_FpsText.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_graphyManager");
			G_FpsText.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_fpsMonitor");
			G_FpsText.NativeFieldInfoPtr_m_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_updateRate");
			G_FpsText.NativeFieldInfoPtr_m_frameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_frameCount");
			G_FpsText.NativeFieldInfoPtr_m_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_deltaTime");
			G_FpsText.NativeFieldInfoPtr_m_fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_fps");
			G_FpsText.NativeFieldInfoPtr_m_minFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_minFps");
			G_FpsText.NativeFieldInfoPtr_m_maxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_maxFps");
			G_FpsText.NativeFieldInfoPtr_m_msStringFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, "m_msStringFormat");
			G_FpsText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100678465);
			G_FpsText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100678466);
			G_FpsText.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100678467);
			G_FpsText.NativeMethodInfoPtr_SetFpsRelatedTextColor_Private_Void_Text_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100678468);
			G_FpsText.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100678469);
			G_FpsText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr, 100678470);
		}

		// Token: 0x0600BA45 RID: 47685 RVA: 0x0000210C File Offset: 0x0000030C
		public G_FpsText(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x0600BA46 RID: 47686 RVA: 0x002FA9B4 File Offset: 0x002F8BB4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_FpsText>.NativeClassPtr));
			}
		}

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x0600BA47 RID: 47687 RVA: 0x002FA9C8 File Offset: 0x002F8BC8
		// (set) Token: 0x0600BA48 RID: 47688 RVA: 0x002FA9FC File Offset: 0x002F8BFC
		public unsafe Text m_fpsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fpsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fpsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x0600BA49 RID: 47689 RVA: 0x002FAA24 File Offset: 0x002F8C24
		// (set) Token: 0x0600BA4A RID: 47690 RVA: 0x002FAA58 File Offset: 0x002F8C58
		public unsafe Text m_msText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_msText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_msText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x0600BA4B RID: 47691 RVA: 0x002FAA80 File Offset: 0x002F8C80
		// (set) Token: 0x0600BA4C RID: 47692 RVA: 0x002FAAB4 File Offset: 0x002F8CB4
		public unsafe Text m_avgFpsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_avgFpsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_avgFpsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x0600BA4D RID: 47693 RVA: 0x002FAADC File Offset: 0x002F8CDC
		// (set) Token: 0x0600BA4E RID: 47694 RVA: 0x002FAB10 File Offset: 0x002F8D10
		public unsafe Text m_minFpsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_minFpsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_minFpsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x0600BA4F RID: 47695 RVA: 0x002FAB38 File Offset: 0x002F8D38
		// (set) Token: 0x0600BA50 RID: 47696 RVA: 0x002FAB6C File Offset: 0x002F8D6C
		public unsafe Text m_maxFpsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_maxFpsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_maxFpsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x0600BA51 RID: 47697 RVA: 0x002FAB94 File Offset: 0x002F8D94
		// (set) Token: 0x0600BA52 RID: 47698 RVA: 0x002FABC8 File Offset: 0x002F8DC8
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x0600BA53 RID: 47699 RVA: 0x002FABF0 File Offset: 0x002F8DF0
		// (set) Token: 0x0600BA54 RID: 47700 RVA: 0x002FAC24 File Offset: 0x002F8E24
		public unsafe G_FpsMonitor m_fpsMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fpsMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_FpsMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x0600BA55 RID: 47701 RVA: 0x002FAC4C File Offset: 0x002F8E4C
		// (set) Token: 0x0600BA56 RID: 47702 RVA: 0x002FAC74 File Offset: 0x002F8E74
		public unsafe int m_updateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_updateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_updateRate)) = value;
			}
		}

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x0600BA57 RID: 47703 RVA: 0x002FAC98 File Offset: 0x002F8E98
		// (set) Token: 0x0600BA58 RID: 47704 RVA: 0x002FACC0 File Offset: 0x002F8EC0
		public unsafe int m_frameCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_frameCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_frameCount)) = value;
			}
		}

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x0600BA59 RID: 47705 RVA: 0x002FACE4 File Offset: 0x002F8EE4
		// (set) Token: 0x0600BA5A RID: 47706 RVA: 0x002FAD0C File Offset: 0x002F8F0C
		public unsafe float m_deltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_deltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_deltaTime)) = value;
			}
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x0600BA5B RID: 47707 RVA: 0x002FAD30 File Offset: 0x002F8F30
		// (set) Token: 0x0600BA5C RID: 47708 RVA: 0x002FAD58 File Offset: 0x002F8F58
		public unsafe float m_fps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsText.NativeFieldInfoPtr_m_fps)) = value;
			}
		}

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x0600BA5D RID: 47709 RVA: 0x002FAD7C File Offset: 0x002F8F7C
		// (set) Token: 0x0600BA5E RID: 47710 RVA: 0x002FAD9A File Offset: 0x002F8F9A
		public unsafe static int m_minFps
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(G_FpsText.NativeFieldInfoPtr_m_minFps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_FpsText.NativeFieldInfoPtr_m_minFps, (void*)(&value));
			}
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x0600BA5F RID: 47711 RVA: 0x002FADAC File Offset: 0x002F8FAC
		// (set) Token: 0x0600BA60 RID: 47712 RVA: 0x002FADCA File Offset: 0x002F8FCA
		public unsafe static int m_maxFps
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(G_FpsText.NativeFieldInfoPtr_m_maxFps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_FpsText.NativeFieldInfoPtr_m_maxFps, (void*)(&value));
			}
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x0600BA61 RID: 47713 RVA: 0x002FADDC File Offset: 0x002F8FDC
		// (set) Token: 0x0600BA62 RID: 47714 RVA: 0x002FADFC File Offset: 0x002F8FFC
		public unsafe static string m_msStringFormat
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(G_FpsText.NativeFieldInfoPtr_m_msStringFormat, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_FpsText.NativeFieldInfoPtr_m_msStringFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04007783 RID: 30595
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsText;

		// Token: 0x04007784 RID: 30596
		private static readonly IntPtr NativeFieldInfoPtr_m_msText;

		// Token: 0x04007785 RID: 30597
		private static readonly IntPtr NativeFieldInfoPtr_m_avgFpsText;

		// Token: 0x04007786 RID: 30598
		private static readonly IntPtr NativeFieldInfoPtr_m_minFpsText;

		// Token: 0x04007787 RID: 30599
		private static readonly IntPtr NativeFieldInfoPtr_m_maxFpsText;

		// Token: 0x04007788 RID: 30600
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x04007789 RID: 30601
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsMonitor;

		// Token: 0x0400778A RID: 30602
		private static readonly IntPtr NativeFieldInfoPtr_m_updateRate;

		// Token: 0x0400778B RID: 30603
		private static readonly IntPtr NativeFieldInfoPtr_m_frameCount;

		// Token: 0x0400778C RID: 30604
		private static readonly IntPtr NativeFieldInfoPtr_m_deltaTime;

		// Token: 0x0400778D RID: 30605
		private static readonly IntPtr NativeFieldInfoPtr_m_fps;

		// Token: 0x0400778E RID: 30606
		private static readonly IntPtr NativeFieldInfoPtr_m_minFps;

		// Token: 0x0400778F RID: 30607
		private static readonly IntPtr NativeFieldInfoPtr_m_maxFps;

		// Token: 0x04007790 RID: 30608
		private static readonly IntPtr NativeFieldInfoPtr_m_msStringFormat;

		// Token: 0x04007791 RID: 30609
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007792 RID: 30610
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007793 RID: 30611
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x04007794 RID: 30612
		private static readonly IntPtr NativeMethodInfoPtr_SetFpsRelatedTextColor_Private_Void_Text_Single_0;

		// Token: 0x04007795 RID: 30613
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007796 RID: 30614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
