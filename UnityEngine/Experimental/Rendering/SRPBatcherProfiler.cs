using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.Profiling;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000989 RID: 2441
	public class SRPBatcherProfiler : MonoBehaviour
	{
		// Token: 0x0600CE45 RID: 52805 RVA: 0x00334984 File Offset: 0x00332B84
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE46 RID: 52806 RVA: 0x003349C8 File Offset: 0x00332BC8
		[CallerCount(0)]
		public unsafe void RazCounters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_RazCounters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE47 RID: 52807 RVA: 0x00334A0C File Offset: 0x00332C0C
		[CallerCount(0)]
		public unsafe void ResetStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_ResetStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE48 RID: 52808 RVA: 0x00334A50 File Offset: 0x00332C50
		[CallerCount(0)]
		public unsafe void ToggleStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_ToggleStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE49 RID: 52809 RVA: 0x00334A94 File Offset: 0x00332C94
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE4A RID: 52810 RVA: 0x00334AD8 File Offset: 0x00332CD8
		[CallerCount(0)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE4B RID: 52811 RVA: 0x00334B1C File Offset: 0x00332D1C
		[CallerCount(0)]
		public unsafe SRPBatcherProfiler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE4C RID: 52812 RVA: 0x00334B68 File Offset: 0x00332D68
		// Note: this type is marked as 'beforefieldinit'.
		static SRPBatcherProfiler()
		{
			Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.Experimental.Rendering", "SRPBatcherProfiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr);
			SRPBatcherProfiler.NativeFieldInfoPtr_m_Enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "m_Enable");
			SRPBatcherProfiler.NativeFieldInfoPtr_kAverageStatDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "kAverageStatDuration");
			SRPBatcherProfiler.NativeFieldInfoPtr_m_frameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "m_frameCount");
			SRPBatcherProfiler.NativeFieldInfoPtr_m_AccDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "m_AccDeltaTime");
			SRPBatcherProfiler.NativeFieldInfoPtr_m_statsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "m_statsLabel");
			SRPBatcherProfiler.NativeFieldInfoPtr_m_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "m_style");
			SRPBatcherProfiler.NativeFieldInfoPtr_m_oldBatcherEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "m_oldBatcherEnable");
			SRPBatcherProfiler.NativeFieldInfoPtr_recordersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "recordersList");
			SRPBatcherProfiler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100679187);
			SRPBatcherProfiler.NativeMethodInfoPtr_RazCounters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100679188);
			SRPBatcherProfiler.NativeMethodInfoPtr_ResetStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100679189);
			SRPBatcherProfiler.NativeMethodInfoPtr_ToggleStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100679190);
			SRPBatcherProfiler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100679191);
			SRPBatcherProfiler.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100679192);
			SRPBatcherProfiler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, 100679193);
		}

		// Token: 0x0600CE4D RID: 52813 RVA: 0x0000210C File Offset: 0x0000030C
		public SRPBatcherProfiler(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x0600CE4E RID: 52814 RVA: 0x00334CC4 File Offset: 0x00332EC4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr));
			}
		}

		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x0600CE4F RID: 52815 RVA: 0x00334CD8 File Offset: 0x00332ED8
		// (set) Token: 0x0600CE50 RID: 52816 RVA: 0x00334D00 File Offset: 0x00332F00
		public unsafe bool m_Enable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_Enable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_Enable)) = value;
			}
		}

		// Token: 0x17004B1F RID: 19231
		// (get) Token: 0x0600CE51 RID: 52817 RVA: 0x00334D24 File Offset: 0x00332F24
		// (set) Token: 0x0600CE52 RID: 52818 RVA: 0x00334D42 File Offset: 0x00332F42
		public unsafe static float kAverageStatDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SRPBatcherProfiler.NativeFieldInfoPtr_kAverageStatDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SRPBatcherProfiler.NativeFieldInfoPtr_kAverageStatDuration, (void*)(&value));
			}
		}

		// Token: 0x17004B20 RID: 19232
		// (get) Token: 0x0600CE53 RID: 52819 RVA: 0x00334D54 File Offset: 0x00332F54
		// (set) Token: 0x0600CE54 RID: 52820 RVA: 0x00334D7C File Offset: 0x00332F7C
		public unsafe int m_frameCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_frameCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_frameCount)) = value;
			}
		}

		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x0600CE55 RID: 52821 RVA: 0x00334DA0 File Offset: 0x00332FA0
		// (set) Token: 0x0600CE56 RID: 52822 RVA: 0x00334DC8 File Offset: 0x00332FC8
		public unsafe float m_AccDeltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_AccDeltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_AccDeltaTime)) = value;
			}
		}

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x0600CE57 RID: 52823 RVA: 0x00334DEC File Offset: 0x00332FEC
		// (set) Token: 0x0600CE58 RID: 52824 RVA: 0x00334E15 File Offset: 0x00333015
		public unsafe string m_statsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_statsLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_statsLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x0600CE59 RID: 52825 RVA: 0x00334E3C File Offset: 0x0033303C
		// (set) Token: 0x0600CE5A RID: 52826 RVA: 0x00334E70 File Offset: 0x00333070
		public unsafe GUIStyle m_style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GUIStyle(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x0600CE5B RID: 52827 RVA: 0x00334E98 File Offset: 0x00333098
		// (set) Token: 0x0600CE5C RID: 52828 RVA: 0x00334EC0 File Offset: 0x003330C0
		public unsafe bool m_oldBatcherEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_oldBatcherEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_m_oldBatcherEnable)) = value;
			}
		}

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x0600CE5D RID: 52829 RVA: 0x00334EE4 File Offset: 0x003330E4
		// (set) Token: 0x0600CE5E RID: 52830 RVA: 0x00334F18 File Offset: 0x00333118
		public unsafe Il2CppReferenceArray<SRPBatcherProfiler.RecorderEntry> recordersList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_recordersList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<SRPBatcherProfiler.RecorderEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.NativeFieldInfoPtr_recordersList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008269 RID: 33385
		private static readonly IntPtr NativeFieldInfoPtr_m_Enable;

		// Token: 0x0400826A RID: 33386
		private static readonly IntPtr NativeFieldInfoPtr_kAverageStatDuration;

		// Token: 0x0400826B RID: 33387
		private static readonly IntPtr NativeFieldInfoPtr_m_frameCount;

		// Token: 0x0400826C RID: 33388
		private static readonly IntPtr NativeFieldInfoPtr_m_AccDeltaTime;

		// Token: 0x0400826D RID: 33389
		private static readonly IntPtr NativeFieldInfoPtr_m_statsLabel;

		// Token: 0x0400826E RID: 33390
		private static readonly IntPtr NativeFieldInfoPtr_m_style;

		// Token: 0x0400826F RID: 33391
		private static readonly IntPtr NativeFieldInfoPtr_m_oldBatcherEnable;

		// Token: 0x04008270 RID: 33392
		private static readonly IntPtr NativeFieldInfoPtr_recordersList;

		// Token: 0x04008271 RID: 33393
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008272 RID: 33394
		private static readonly IntPtr NativeMethodInfoPtr_RazCounters_Private_Void_0;

		// Token: 0x04008273 RID: 33395
		private static readonly IntPtr NativeMethodInfoPtr_ResetStats_Private_Void_0;

		// Token: 0x04008274 RID: 33396
		private static readonly IntPtr NativeMethodInfoPtr_ToggleStats_Private_Void_0;

		// Token: 0x04008275 RID: 33397
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04008276 RID: 33398
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04008277 RID: 33399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200098A RID: 2442
		public class RecorderEntry : Object
		{
			// Token: 0x0600CE5F RID: 52831 RVA: 0x00334F40 File Offset: 0x00333140
			[CallerCount(0)]
			public unsafe RecorderEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPBatcherProfiler.RecorderEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE60 RID: 52832 RVA: 0x00334F8C File Offset: 0x0033318C
			// Note: this type is marked as 'beforefieldinit'.
			static RecorderEntry()
			{
				Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SRPBatcherProfiler>.NativeClassPtr, "RecorderEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr);
				SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, "name");
				SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, "oldName");
				SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_callCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, "callCount");
				SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_accTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, "accTime");
				SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_recorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, "recorder");
				SRPBatcherProfiler.RecorderEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr, 100679194);
			}

			// Token: 0x0600CE61 RID: 52833 RVA: 0x00002988 File Offset: 0x00000B88
			public RecorderEntry(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17004B26 RID: 19238
			// (get) Token: 0x0600CE62 RID: 52834 RVA: 0x0033502F File Offset: 0x0033322F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SRPBatcherProfiler.RecorderEntry>.NativeClassPtr));
				}
			}

			// Token: 0x17004B27 RID: 19239
			// (get) Token: 0x0600CE63 RID: 52835 RVA: 0x00335040 File Offset: 0x00333240
			// (set) Token: 0x0600CE64 RID: 52836 RVA: 0x00335069 File Offset: 0x00333269
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B28 RID: 19240
			// (get) Token: 0x0600CE65 RID: 52837 RVA: 0x00335090 File Offset: 0x00333290
			// (set) Token: 0x0600CE66 RID: 52838 RVA: 0x003350B9 File Offset: 0x003332B9
			public unsafe string oldName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_oldName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_oldName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B29 RID: 19241
			// (get) Token: 0x0600CE67 RID: 52839 RVA: 0x003350E0 File Offset: 0x003332E0
			// (set) Token: 0x0600CE68 RID: 52840 RVA: 0x00335108 File Offset: 0x00333308
			public unsafe int callCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_callCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_callCount)) = value;
				}
			}

			// Token: 0x17004B2A RID: 19242
			// (get) Token: 0x0600CE69 RID: 52841 RVA: 0x0033512C File Offset: 0x0033332C
			// (set) Token: 0x0600CE6A RID: 52842 RVA: 0x00335154 File Offset: 0x00333354
			public unsafe float accTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_accTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_accTime)) = value;
				}
			}

			// Token: 0x17004B2B RID: 19243
			// (get) Token: 0x0600CE6B RID: 52843 RVA: 0x00335178 File Offset: 0x00333378
			// (set) Token: 0x0600CE6C RID: 52844 RVA: 0x003351AC File Offset: 0x003333AC
			public unsafe Recorder recorder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_recorder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Recorder(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SRPBatcherProfiler.RecorderEntry.NativeFieldInfoPtr_recorder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008278 RID: 33400
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008279 RID: 33401
			private static readonly IntPtr NativeFieldInfoPtr_oldName;

			// Token: 0x0400827A RID: 33402
			private static readonly IntPtr NativeFieldInfoPtr_callCount;

			// Token: 0x0400827B RID: 33403
			private static readonly IntPtr NativeFieldInfoPtr_accTime;

			// Token: 0x0400827C RID: 33404
			private static readonly IntPtr NativeFieldInfoPtr_recorder;

			// Token: 0x0400827D RID: 33405
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200098B RID: 2443
		public enum SRPBMarkers
		{
			// Token: 0x0400827F RID: 33407
			kStdRenderDraw,
			// Token: 0x04008280 RID: 33408
			kStdShadowDraw,
			// Token: 0x04008281 RID: 33409
			kSRPBRenderDraw,
			// Token: 0x04008282 RID: 33410
			kSRPBShadowDraw,
			// Token: 0x04008283 RID: 33411
			kRenderThreadIdle,
			// Token: 0x04008284 RID: 33412
			kStdRenderApplyShader,
			// Token: 0x04008285 RID: 33413
			kStdShadowApplyShader,
			// Token: 0x04008286 RID: 33414
			kSRPBRenderApplyShader,
			// Token: 0x04008287 RID: 33415
			kSRPBShadowApplyShader,
			// Token: 0x04008288 RID: 33416
			kPrepareBatchRendererGroupNodes
		}
	}
}
