using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Tayx.Graphy.Fps
{
	// Token: 0x020008EB RID: 2283
	public class G_FpsMonitor : MonoBehaviour
	{
		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x0600BA12 RID: 47634 RVA: 0x002F9BF8 File Offset: 0x002F7DF8
		public unsafe float CurrentFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x0600BA13 RID: 47635 RVA: 0x002F9C48 File Offset: 0x002F7E48
		public unsafe float AverageFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x0600BA14 RID: 47636 RVA: 0x002F9C98 File Offset: 0x002F7E98
		public unsafe float MinFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x0600BA15 RID: 47637 RVA: 0x002F9CE8 File Offset: 0x002F7EE8
		public unsafe float MaxFPS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x002F9D38 File Offset: 0x002F7F38
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x002F9D7C File Offset: 0x002F7F7C
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA18 RID: 47640 RVA: 0x002F9DC0 File Offset: 0x002F7FC0
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x002F9E04 File Offset: 0x002F8004
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA1A RID: 47642 RVA: 0x002F9E48 File Offset: 0x002F8048
		[CallerCount(0)]
		public unsafe void ResizeSamplesBuffer(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_ResizeSamplesBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA1B RID: 47643 RVA: 0x002F9E9C File Offset: 0x002F809C
		[CallerCount(0)]
		public unsafe int ToBufferIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr_ToBufferIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BA1C RID: 47644 RVA: 0x002F9F00 File Offset: 0x002F8100
		[CallerCount(0)]
		public unsafe G_FpsMonitor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA1D RID: 47645 RVA: 0x002F9F4C File Offset: 0x002F814C
		// Note: this type is marked as 'beforefieldinit'.
		static G_FpsMonitor()
		{
			Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Fps", "G_FpsMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr);
			G_FpsMonitor.NativeFieldInfoPtr_m_averageSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_averageSamples");
			G_FpsMonitor.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_graphyManager");
			G_FpsMonitor.NativeFieldInfoPtr_m_currentFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_currentFps");
			G_FpsMonitor.NativeFieldInfoPtr_m_avgFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_avgFps");
			G_FpsMonitor.NativeFieldInfoPtr_m_minFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_minFps");
			G_FpsMonitor.NativeFieldInfoPtr_m_maxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_maxFps");
			G_FpsMonitor.NativeFieldInfoPtr_m_averageFpsSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_averageFpsSamples");
			G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_avgFpsSamplesOffset");
			G_FpsMonitor.NativeFieldInfoPtr_m_indexMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_indexMask");
			G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_avgFpsSamplesCapacity");
			G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_avgFpsSamplesCount");
			G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinMaxFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_timeToResetMinMaxFps");
			G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinFpsPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_timeToResetMinFpsPassed");
			G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMaxFpsPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "m_timeToResetMaxFpsPassed");
			G_FpsMonitor.NativeFieldInfoPtr_unscaledDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, "unscaledDeltaTime");
			G_FpsMonitor.NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678454);
			G_FpsMonitor.NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678455);
			G_FpsMonitor.NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678456);
			G_FpsMonitor.NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678457);
			G_FpsMonitor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678458);
			G_FpsMonitor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678459);
			G_FpsMonitor.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678460);
			G_FpsMonitor.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678461);
			G_FpsMonitor.NativeMethodInfoPtr_ResizeSamplesBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678462);
			G_FpsMonitor.NativeMethodInfoPtr_ToBufferIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678463);
			G_FpsMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr, 100678464);
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x0000210C File Offset: 0x0000030C
		public G_FpsMonitor(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x0600BA1F RID: 47647 RVA: 0x002FA184 File Offset: 0x002F8384
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_FpsMonitor>.NativeClassPtr));
			}
		}

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x0600BA20 RID: 47648 RVA: 0x002FA198 File Offset: 0x002F8398
		// (set) Token: 0x0600BA21 RID: 47649 RVA: 0x002FA1C0 File Offset: 0x002F83C0
		public unsafe int m_averageSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_averageSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_averageSamples)) = value;
			}
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x0600BA22 RID: 47650 RVA: 0x002FA1E4 File Offset: 0x002F83E4
		// (set) Token: 0x0600BA23 RID: 47651 RVA: 0x002FA218 File Offset: 0x002F8418
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x0600BA24 RID: 47652 RVA: 0x002FA240 File Offset: 0x002F8440
		// (set) Token: 0x0600BA25 RID: 47653 RVA: 0x002FA268 File Offset: 0x002F8468
		public unsafe float m_currentFps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_currentFps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_currentFps)) = value;
			}
		}

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x0600BA26 RID: 47654 RVA: 0x002FA28C File Offset: 0x002F848C
		// (set) Token: 0x0600BA27 RID: 47655 RVA: 0x002FA2B4 File Offset: 0x002F84B4
		public unsafe float m_avgFps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFps)) = value;
			}
		}

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x0600BA28 RID: 47656 RVA: 0x002FA2D8 File Offset: 0x002F84D8
		// (set) Token: 0x0600BA29 RID: 47657 RVA: 0x002FA300 File Offset: 0x002F8500
		public unsafe float m_minFps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_minFps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_minFps)) = value;
			}
		}

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x0600BA2A RID: 47658 RVA: 0x002FA324 File Offset: 0x002F8524
		// (set) Token: 0x0600BA2B RID: 47659 RVA: 0x002FA34C File Offset: 0x002F854C
		public unsafe float m_maxFps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_maxFps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_maxFps)) = value;
			}
		}

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x002FA370 File Offset: 0x002F8570
		// (set) Token: 0x0600BA2D RID: 47661 RVA: 0x002FA3A4 File Offset: 0x002F85A4
		public unsafe Il2CppStructArray<float> m_averageFpsSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_averageFpsSamples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_averageFpsSamples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x0600BA2E RID: 47662 RVA: 0x002FA3CC File Offset: 0x002F85CC
		// (set) Token: 0x0600BA2F RID: 47663 RVA: 0x002FA3F4 File Offset: 0x002F85F4
		public unsafe int m_avgFpsSamplesOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesOffset)) = value;
			}
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x0600BA30 RID: 47664 RVA: 0x002FA418 File Offset: 0x002F8618
		// (set) Token: 0x0600BA31 RID: 47665 RVA: 0x002FA440 File Offset: 0x002F8640
		public unsafe int m_indexMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_indexMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_indexMask)) = value;
			}
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x0600BA32 RID: 47666 RVA: 0x002FA464 File Offset: 0x002F8664
		// (set) Token: 0x0600BA33 RID: 47667 RVA: 0x002FA48C File Offset: 0x002F868C
		public unsafe int m_avgFpsSamplesCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCapacity)) = value;
			}
		}

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x0600BA34 RID: 47668 RVA: 0x002FA4B0 File Offset: 0x002F86B0
		// (set) Token: 0x0600BA35 RID: 47669 RVA: 0x002FA4D8 File Offset: 0x002F86D8
		public unsafe int m_avgFpsSamplesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_avgFpsSamplesCount)) = value;
			}
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x0600BA36 RID: 47670 RVA: 0x002FA4FC File Offset: 0x002F86FC
		// (set) Token: 0x0600BA37 RID: 47671 RVA: 0x002FA524 File Offset: 0x002F8724
		public unsafe int m_timeToResetMinMaxFps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinMaxFps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinMaxFps)) = value;
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x0600BA38 RID: 47672 RVA: 0x002FA548 File Offset: 0x002F8748
		// (set) Token: 0x0600BA39 RID: 47673 RVA: 0x002FA570 File Offset: 0x002F8770
		public unsafe float m_timeToResetMinFpsPassed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinFpsPassed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMinFpsPassed)) = value;
			}
		}

		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x0600BA3A RID: 47674 RVA: 0x002FA594 File Offset: 0x002F8794
		// (set) Token: 0x0600BA3B RID: 47675 RVA: 0x002FA5BC File Offset: 0x002F87BC
		public unsafe float m_timeToResetMaxFpsPassed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMaxFpsPassed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_m_timeToResetMaxFpsPassed)) = value;
			}
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x0600BA3C RID: 47676 RVA: 0x002FA5E0 File Offset: 0x002F87E0
		// (set) Token: 0x0600BA3D RID: 47677 RVA: 0x002FA608 File Offset: 0x002F8808
		public unsafe float unscaledDeltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_unscaledDeltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsMonitor.NativeFieldInfoPtr_unscaledDeltaTime)) = value;
			}
		}

		// Token: 0x04007769 RID: 30569
		private static readonly IntPtr NativeFieldInfoPtr_m_averageSamples;

		// Token: 0x0400776A RID: 30570
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x0400776B RID: 30571
		private static readonly IntPtr NativeFieldInfoPtr_m_currentFps;

		// Token: 0x0400776C RID: 30572
		private static readonly IntPtr NativeFieldInfoPtr_m_avgFps;

		// Token: 0x0400776D RID: 30573
		private static readonly IntPtr NativeFieldInfoPtr_m_minFps;

		// Token: 0x0400776E RID: 30574
		private static readonly IntPtr NativeFieldInfoPtr_m_maxFps;

		// Token: 0x0400776F RID: 30575
		private static readonly IntPtr NativeFieldInfoPtr_m_averageFpsSamples;

		// Token: 0x04007770 RID: 30576
		private static readonly IntPtr NativeFieldInfoPtr_m_avgFpsSamplesOffset;

		// Token: 0x04007771 RID: 30577
		private static readonly IntPtr NativeFieldInfoPtr_m_indexMask;

		// Token: 0x04007772 RID: 30578
		private static readonly IntPtr NativeFieldInfoPtr_m_avgFpsSamplesCapacity;

		// Token: 0x04007773 RID: 30579
		private static readonly IntPtr NativeFieldInfoPtr_m_avgFpsSamplesCount;

		// Token: 0x04007774 RID: 30580
		private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMinMaxFps;

		// Token: 0x04007775 RID: 30581
		private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMinFpsPassed;

		// Token: 0x04007776 RID: 30582
		private static readonly IntPtr NativeFieldInfoPtr_m_timeToResetMaxFpsPassed;

		// Token: 0x04007777 RID: 30583
		private static readonly IntPtr NativeFieldInfoPtr_unscaledDeltaTime;

		// Token: 0x04007778 RID: 30584
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFPS_Public_get_Single_0;

		// Token: 0x04007779 RID: 30585
		private static readonly IntPtr NativeMethodInfoPtr_get_AverageFPS_Public_get_Single_0;

		// Token: 0x0400777A RID: 30586
		private static readonly IntPtr NativeMethodInfoPtr_get_MinFPS_Public_get_Single_0;

		// Token: 0x0400777B RID: 30587
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxFPS_Public_get_Single_0;

		// Token: 0x0400777C RID: 30588
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400777D RID: 30589
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400777E RID: 30590
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x0400777F RID: 30591
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007780 RID: 30592
		private static readonly IntPtr NativeMethodInfoPtr_ResizeSamplesBuffer_Private_Void_Int32_0;

		// Token: 0x04007781 RID: 30593
		private static readonly IntPtr NativeMethodInfoPtr_ToBufferIndex_Private_Int32_Int32_0;

		// Token: 0x04007782 RID: 30594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
