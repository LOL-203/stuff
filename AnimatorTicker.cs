using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020000C0 RID: 192
public class AnimatorTicker : MonoBehaviour
{
	// Token: 0x06000BF6 RID: 3062 RVA: 0x00030CE4 File Offset: 0x0002EEE4
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x00030D28 File Offset: 0x0002EF28
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00030D6C File Offset: 0x0002EF6C
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x00030DB0 File Offset: 0x0002EFB0
	[CallerCount(0)]
	public unsafe void ForceOn(bool on)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref on;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_ForceOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x00030E04 File Offset: 0x0002F004
	[CallerCount(0)]
	public unsafe void Tick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_Tick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x00030E48 File Offset: 0x0002F048
	[CallerCount(0)]
	public unsafe bool GetIsVisible()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_GetIsVisible_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00030E98 File Offset: 0x0002F098
	[CallerCount(0)]
	public unsafe int UpdateState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_UpdateState_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00030EE8 File Offset: 0x0002F0E8
	[CallerCount(0)]
	public unsafe void SetState(AnimatorTicker.AnimatorTickerState newState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newState;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_SetState_Protected_Void_AnimatorTickerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x00030F3C File Offset: 0x0002F13C
	[CallerCount(0)]
	public unsafe void CheckActiveScopeStateOverride()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr_CheckActiveScopeStateOverride_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x00030F80 File Offset: 0x0002F180
	[CallerCount(0)]
	public unsafe AnimatorTicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00030FCC File Offset: 0x0002F1CC
	// Note: this type is marked as 'beforefieldinit'.
	static AnimatorTicker()
	{
		Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimatorTicker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr);
		AnimatorTicker.NativeFieldInfoPtr__forceOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "_forceOn");
		AnimatorTicker.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "Animator");
		AnimatorTicker.NativeFieldInfoPtr_Cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "Cluster");
		AnimatorTicker.NativeFieldInfoPtr_VisibilityRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "VisibilityRenderers");
		AnimatorTicker.NativeFieldInfoPtr_MinimumRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "MinimumRange");
		AnimatorTicker.NativeFieldInfoPtr_MinimumFrameSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "MinimumFrameSkip");
		AnimatorTicker.NativeFieldInfoPtr_MaximumRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "MaximumRange");
		AnimatorTicker.NativeFieldInfoPtr_MaximumFrameSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "MaximumFrameSkip");
		AnimatorTicker.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "CurrentState");
		AnimatorTicker.NativeFieldInfoPtr_FrameSkipStartOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "FrameSkipStartOffset");
		AnimatorTicker.NativeFieldInfoPtr_FrameSkipCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "FrameSkipCurrent");
		AnimatorTicker.NativeFieldInfoPtr_accumulatedDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, "accumulatedDeltaTime");
		AnimatorTicker.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664230);
		AnimatorTicker.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664231);
		AnimatorTicker.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664232);
		AnimatorTicker.NativeMethodInfoPtr_ForceOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664233);
		AnimatorTicker.NativeMethodInfoPtr_Tick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664234);
		AnimatorTicker.NativeMethodInfoPtr_GetIsVisible_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664235);
		AnimatorTicker.NativeMethodInfoPtr_UpdateState_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664236);
		AnimatorTicker.NativeMethodInfoPtr_SetState_Protected_Void_AnimatorTickerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664237);
		AnimatorTicker.NativeMethodInfoPtr_CheckActiveScopeStateOverride_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664238);
		AnimatorTicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr, 100664239);
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0000210C File Offset: 0x0000030C
	public AnimatorTicker(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x06000C02 RID: 3074 RVA: 0x000311B4 File Offset: 0x0002F3B4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnimatorTicker>.NativeClassPtr));
		}
	}

	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x06000C03 RID: 3075 RVA: 0x000311C8 File Offset: 0x0002F3C8
	// (set) Token: 0x06000C04 RID: 3076 RVA: 0x000311F0 File Offset: 0x0002F3F0
	public unsafe bool _forceOn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr__forceOn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr__forceOn)) = value;
		}
	}

	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00031214 File Offset: 0x0002F414
	// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00031248 File Offset: 0x0002F448
	public unsafe Animator Animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_Animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00031270 File Offset: 0x0002F470
	// (set) Token: 0x06000C08 RID: 3080 RVA: 0x000312A4 File Offset: 0x0002F4A4
	public unsafe ClusterLODGroup Cluster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_Cluster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ClusterLODGroup(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_Cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000312CC File Offset: 0x0002F4CC
	// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00031300 File Offset: 0x0002F500
	public unsafe Il2CppReferenceArray<Renderer> VisibilityRenderers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_VisibilityRenderers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Renderer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_VisibilityRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00031328 File Offset: 0x0002F528
	// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00031350 File Offset: 0x0002F550
	public unsafe float MinimumRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_MinimumRange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_MinimumRange)) = value;
		}
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00031374 File Offset: 0x0002F574
	// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0003139C File Offset: 0x0002F59C
	public unsafe int MinimumFrameSkip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_MinimumFrameSkip);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_MinimumFrameSkip)) = value;
		}
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x06000C0F RID: 3087 RVA: 0x000313C0 File Offset: 0x0002F5C0
	// (set) Token: 0x06000C10 RID: 3088 RVA: 0x000313E8 File Offset: 0x0002F5E8
	public unsafe float MaximumRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_MaximumRange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_MaximumRange)) = value;
		}
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0003140C File Offset: 0x0002F60C
	// (set) Token: 0x06000C12 RID: 3090 RVA: 0x00031434 File Offset: 0x0002F634
	public unsafe int MaximumFrameSkip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_MaximumFrameSkip);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_MaximumFrameSkip)) = value;
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00031458 File Offset: 0x0002F658
	// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00031480 File Offset: 0x0002F680
	public unsafe AnimatorTicker.AnimatorTickerState CurrentState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_CurrentState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_CurrentState)) = value;
		}
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000314A4 File Offset: 0x0002F6A4
	// (set) Token: 0x06000C16 RID: 3094 RVA: 0x000314C2 File Offset: 0x0002F6C2
	public unsafe static int FrameSkipStartOffset
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AnimatorTicker.NativeFieldInfoPtr_FrameSkipStartOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimatorTicker.NativeFieldInfoPtr_FrameSkipStartOffset, (void*)(&value));
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000314D4 File Offset: 0x0002F6D4
	// (set) Token: 0x06000C18 RID: 3096 RVA: 0x000314FC File Offset: 0x0002F6FC
	public unsafe int FrameSkipCurrent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_FrameSkipCurrent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_FrameSkipCurrent)) = value;
		}
	}

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00031520 File Offset: 0x0002F720
	// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00031548 File Offset: 0x0002F748
	public unsafe float accumulatedDeltaTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_accumulatedDeltaTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTicker.NativeFieldInfoPtr_accumulatedDeltaTime)) = value;
		}
	}

	// Token: 0x0400073A RID: 1850
	private static readonly IntPtr NativeFieldInfoPtr__forceOn;

	// Token: 0x0400073B RID: 1851
	private static readonly IntPtr NativeFieldInfoPtr_Animator;

	// Token: 0x0400073C RID: 1852
	private static readonly IntPtr NativeFieldInfoPtr_Cluster;

	// Token: 0x0400073D RID: 1853
	private static readonly IntPtr NativeFieldInfoPtr_VisibilityRenderers;

	// Token: 0x0400073E RID: 1854
	private static readonly IntPtr NativeFieldInfoPtr_MinimumRange;

	// Token: 0x0400073F RID: 1855
	private static readonly IntPtr NativeFieldInfoPtr_MinimumFrameSkip;

	// Token: 0x04000740 RID: 1856
	private static readonly IntPtr NativeFieldInfoPtr_MaximumRange;

	// Token: 0x04000741 RID: 1857
	private static readonly IntPtr NativeFieldInfoPtr_MaximumFrameSkip;

	// Token: 0x04000742 RID: 1858
	private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

	// Token: 0x04000743 RID: 1859
	private static readonly IntPtr NativeFieldInfoPtr_FrameSkipStartOffset;

	// Token: 0x04000744 RID: 1860
	private static readonly IntPtr NativeFieldInfoPtr_FrameSkipCurrent;

	// Token: 0x04000745 RID: 1861
	private static readonly IntPtr NativeFieldInfoPtr_accumulatedDeltaTime;

	// Token: 0x04000746 RID: 1862
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

	// Token: 0x04000747 RID: 1863
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

	// Token: 0x04000748 RID: 1864
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

	// Token: 0x04000749 RID: 1865
	private static readonly IntPtr NativeMethodInfoPtr_ForceOn_Public_Void_Boolean_0;

	// Token: 0x0400074A RID: 1866
	private static readonly IntPtr NativeMethodInfoPtr_Tick_Public_Void_0;

	// Token: 0x0400074B RID: 1867
	private static readonly IntPtr NativeMethodInfoPtr_GetIsVisible_Public_Boolean_0;

	// Token: 0x0400074C RID: 1868
	private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Protected_Int32_0;

	// Token: 0x0400074D RID: 1869
	private static readonly IntPtr NativeMethodInfoPtr_SetState_Protected_Void_AnimatorTickerState_0;

	// Token: 0x0400074E RID: 1870
	private static readonly IntPtr NativeMethodInfoPtr_CheckActiveScopeStateOverride_Protected_Void_0;

	// Token: 0x0400074F RID: 1871
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020000C1 RID: 193
	public enum AnimatorTickerState
	{
		// Token: 0x04000751 RID: 1873
		Uninitialized,
		// Token: 0x04000752 RID: 1874
		CloseAutomatic,
		// Token: 0x04000753 RID: 1875
		MediumSkipping,
		// Token: 0x04000754 RID: 1876
		FarCulled,
		// Token: 0x04000755 RID: 1877
		Invisible
	}
}
