using System;
using AK.Wwise;
using DPI.Utilities;
using Il2CppSystem;
using Onward.Mutators;
using TMPro;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000459 RID: 1113
public class WristWatch : MonoBehaviour
{
	// Token: 0x06005978 RID: 22904 RVA: 0x00166024 File Offset: 0x00164224
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005979 RID: 22905 RVA: 0x00166068 File Offset: 0x00164268
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600597A RID: 22906 RVA: 0x001660AC File Offset: 0x001642AC
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600597B RID: 22907 RVA: 0x001660F0 File Offset: 0x001642F0
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600597C RID: 22908 RVA: 0x00166134 File Offset: 0x00164334
	[CallerCount(0)]
	public unsafe void OnWatchDisplayValueChange(DPIStringBuilder sb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_OnWatchDisplayValueChange_Private_Void_DPIStringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600597D RID: 22909 RVA: 0x00166190 File Offset: 0x00164390
	[CallerCount(0)]
	public unsafe void OnPlayRoundTimerBeep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_OnPlayRoundTimerBeep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600597E RID: 22910 RVA: 0x001661D4 File Offset: 0x001643D4
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600597F RID: 22911 RVA: 0x00166218 File Offset: 0x00164418
	[CallerCount(0)]
	public unsafe void AdjustWatchWristSide(int watchWristSide)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref watchWristSide;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_AdjustWatchWristSide_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005980 RID: 22912 RVA: 0x0016626C File Offset: 0x0016446C
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005981 RID: 22913 RVA: 0x001662B0 File Offset: 0x001644B0
	[CallerCount(0)]
	public unsafe void ResetWatch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_ResetWatch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005982 RID: 22914 RVA: 0x001662F4 File Offset: 0x001644F4
	[CallerCount(0)]
	public unsafe void TriggerManualBeep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr_TriggerManualBeep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005983 RID: 22915 RVA: 0x00166338 File Offset: 0x00164538
	[CallerCount(0)]
	public unsafe WristWatch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WristWatch>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WristWatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005984 RID: 22916 RVA: 0x00166384 File Offset: 0x00164584
	// Note: this type is marked as 'beforefieldinit'.
	static WristWatch()
	{
		Il2CppClassPointerStore<WristWatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WristWatch");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WristWatch>.NativeClassPtr);
		WristWatch.NativeFieldInfoPtr_OnManualBeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "OnManualBeep");
		WristWatch.NativeFieldInfoPtr_WatchText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "WatchText");
		WristWatch.NativeFieldInfoPtr_WatchScreenContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "WatchScreenContents");
		WristWatch.NativeFieldInfoPtr_ResetSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "ResetSymbol");
		WristWatch.NativeFieldInfoPtr_RoundTimerSoundPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "RoundTimerSoundPlayEvent");
		WristWatch.NativeFieldInfoPtr_VisualParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "VisualParent");
		WristWatch.NativeFieldInfoPtr_RightHanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "RightHanded");
		WristWatch.NativeFieldInfoPtr_WatchObjectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "WatchObjectTransform");
		WristWatch.NativeFieldInfoPtr_OrigWatchObjPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "OrigWatchObjPos");
		WristWatch.NativeFieldInfoPtr_OrigWatchObjRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "OrigWatchObjRot");
		WristWatch.NativeFieldInfoPtr__roundTimerBeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "_roundTimerBeep");
		WristWatch.NativeFieldInfoPtr__beepPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "_beepPlayer");
		WristWatch.NativeFieldInfoPtr__playedBeepsThisRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "_playedBeepsThisRound");
		WristWatch.NativeFieldInfoPtr__flippedRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, "_flippedRotation");
		WristWatch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670328);
		WristWatch.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670329);
		WristWatch.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670330);
		WristWatch.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670331);
		WristWatch.NativeMethodInfoPtr_OnWatchDisplayValueChange_Private_Void_DPIStringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670332);
		WristWatch.NativeMethodInfoPtr_OnPlayRoundTimerBeep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670333);
		WristWatch.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670334);
		WristWatch.NativeMethodInfoPtr_AdjustWatchWristSide_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670335);
		WristWatch.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670336);
		WristWatch.NativeMethodInfoPtr_ResetWatch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670337);
		WristWatch.NativeMethodInfoPtr_TriggerManualBeep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670338);
		WristWatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WristWatch>.NativeClassPtr, 100670339);
	}

	// Token: 0x06005985 RID: 22917 RVA: 0x0000210C File Offset: 0x0000030C
	public WristWatch(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001FE6 RID: 8166
	// (get) Token: 0x06005986 RID: 22918 RVA: 0x001665BC File Offset: 0x001647BC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WristWatch>.NativeClassPtr));
		}
	}

	// Token: 0x17001FE7 RID: 8167
	// (get) Token: 0x06005987 RID: 22919 RVA: 0x001665D0 File Offset: 0x001647D0
	// (set) Token: 0x06005988 RID: 22920 RVA: 0x001665FB File Offset: 0x001647FB
	public unsafe static Action OnManualBeep
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WristWatch.NativeFieldInfoPtr_OnManualBeep, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WristWatch.NativeFieldInfoPtr_OnManualBeep, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FE8 RID: 8168
	// (get) Token: 0x06005989 RID: 22921 RVA: 0x00166610 File Offset: 0x00164810
	// (set) Token: 0x0600598A RID: 22922 RVA: 0x00166644 File Offset: 0x00164844
	public unsafe TextMeshPro WatchText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_WatchText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new TextMeshPro(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_WatchText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FE9 RID: 8169
	// (get) Token: 0x0600598B RID: 22923 RVA: 0x0016666C File Offset: 0x0016486C
	// (set) Token: 0x0600598C RID: 22924 RVA: 0x001666A0 File Offset: 0x001648A0
	public unsafe Transform WatchScreenContents
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_WatchScreenContents);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_WatchScreenContents), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FEA RID: 8170
	// (get) Token: 0x0600598D RID: 22925 RVA: 0x001666C8 File Offset: 0x001648C8
	// (set) Token: 0x0600598E RID: 22926 RVA: 0x001666FC File Offset: 0x001648FC
	public unsafe GameObject ResetSymbol
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_ResetSymbol);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_ResetSymbol), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FEB RID: 8171
	// (get) Token: 0x0600598F RID: 22927 RVA: 0x00166724 File Offset: 0x00164924
	// (set) Token: 0x06005990 RID: 22928 RVA: 0x00166758 File Offset: 0x00164958
	public unsafe AK.Wwise.Event RoundTimerSoundPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_RoundTimerSoundPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_RoundTimerSoundPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FEC RID: 8172
	// (get) Token: 0x06005991 RID: 22929 RVA: 0x00166780 File Offset: 0x00164980
	// (set) Token: 0x06005992 RID: 22930 RVA: 0x001667B4 File Offset: 0x001649B4
	public unsafe GameObject VisualParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_VisualParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_VisualParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FED RID: 8173
	// (get) Token: 0x06005993 RID: 22931 RVA: 0x001667DC File Offset: 0x001649DC
	// (set) Token: 0x06005994 RID: 22932 RVA: 0x00166804 File Offset: 0x00164A04
	public unsafe bool RightHanded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_RightHanded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_RightHanded)) = value;
		}
	}

	// Token: 0x17001FEE RID: 8174
	// (get) Token: 0x06005995 RID: 22933 RVA: 0x00166828 File Offset: 0x00164A28
	// (set) Token: 0x06005996 RID: 22934 RVA: 0x0016685C File Offset: 0x00164A5C
	public unsafe Transform WatchObjectTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_WatchObjectTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_WatchObjectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FEF RID: 8175
	// (get) Token: 0x06005997 RID: 22935 RVA: 0x00166884 File Offset: 0x00164A84
	// (set) Token: 0x06005998 RID: 22936 RVA: 0x001668AC File Offset: 0x00164AAC
	public unsafe Vector3 OrigWatchObjPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_OrigWatchObjPos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_OrigWatchObjPos)) = value;
		}
	}

	// Token: 0x17001FF0 RID: 8176
	// (get) Token: 0x06005999 RID: 22937 RVA: 0x001668D0 File Offset: 0x00164AD0
	// (set) Token: 0x0600599A RID: 22938 RVA: 0x001668F8 File Offset: 0x00164AF8
	public unsafe Quaternion OrigWatchObjRot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_OrigWatchObjRot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr_OrigWatchObjRot)) = value;
		}
	}

	// Token: 0x17001FF1 RID: 8177
	// (get) Token: 0x0600599B RID: 22939 RVA: 0x0016691C File Offset: 0x00164B1C
	// (set) Token: 0x0600599C RID: 22940 RVA: 0x00166950 File Offset: 0x00164B50
	public unsafe RoundTimerBeep _roundTimerBeep
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr__roundTimerBeep);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RoundTimerBeep(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr__roundTimerBeep), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FF2 RID: 8178
	// (get) Token: 0x0600599D RID: 22941 RVA: 0x00166978 File Offset: 0x00164B78
	// (set) Token: 0x0600599E RID: 22942 RVA: 0x001669AC File Offset: 0x00164BAC
	public unsafe WatchBeepPlayer _beepPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr__beepPlayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WatchBeepPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr__beepPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FF3 RID: 8179
	// (get) Token: 0x0600599F RID: 22943 RVA: 0x001669D4 File Offset: 0x00164BD4
	// (set) Token: 0x060059A0 RID: 22944 RVA: 0x001669FC File Offset: 0x00164BFC
	public unsafe bool _playedBeepsThisRound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr__playedBeepsThisRound);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr__playedBeepsThisRound)) = value;
		}
	}

	// Token: 0x17001FF4 RID: 8180
	// (get) Token: 0x060059A1 RID: 22945 RVA: 0x00166A20 File Offset: 0x00164C20
	// (set) Token: 0x060059A2 RID: 22946 RVA: 0x00166A48 File Offset: 0x00164C48
	public unsafe Vector3 _flippedRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr__flippedRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WristWatch.NativeFieldInfoPtr__flippedRotation)) = value;
		}
	}

	// Token: 0x040038A1 RID: 14497
	private static readonly IntPtr NativeFieldInfoPtr_OnManualBeep;

	// Token: 0x040038A2 RID: 14498
	private static readonly IntPtr NativeFieldInfoPtr_WatchText;

	// Token: 0x040038A3 RID: 14499
	private static readonly IntPtr NativeFieldInfoPtr_WatchScreenContents;

	// Token: 0x040038A4 RID: 14500
	private static readonly IntPtr NativeFieldInfoPtr_ResetSymbol;

	// Token: 0x040038A5 RID: 14501
	private static readonly IntPtr NativeFieldInfoPtr_RoundTimerSoundPlayEvent;

	// Token: 0x040038A6 RID: 14502
	private static readonly IntPtr NativeFieldInfoPtr_VisualParent;

	// Token: 0x040038A7 RID: 14503
	private static readonly IntPtr NativeFieldInfoPtr_RightHanded;

	// Token: 0x040038A8 RID: 14504
	private static readonly IntPtr NativeFieldInfoPtr_WatchObjectTransform;

	// Token: 0x040038A9 RID: 14505
	private static readonly IntPtr NativeFieldInfoPtr_OrigWatchObjPos;

	// Token: 0x040038AA RID: 14506
	private static readonly IntPtr NativeFieldInfoPtr_OrigWatchObjRot;

	// Token: 0x040038AB RID: 14507
	private static readonly IntPtr NativeFieldInfoPtr__roundTimerBeep;

	// Token: 0x040038AC RID: 14508
	private static readonly IntPtr NativeFieldInfoPtr__beepPlayer;

	// Token: 0x040038AD RID: 14509
	private static readonly IntPtr NativeFieldInfoPtr__playedBeepsThisRound;

	// Token: 0x040038AE RID: 14510
	private static readonly IntPtr NativeFieldInfoPtr__flippedRotation;

	// Token: 0x040038AF RID: 14511
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040038B0 RID: 14512
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040038B1 RID: 14513
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040038B2 RID: 14514
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x040038B3 RID: 14515
	private static readonly IntPtr NativeMethodInfoPtr_OnWatchDisplayValueChange_Private_Void_DPIStringBuilder_0;

	// Token: 0x040038B4 RID: 14516
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayRoundTimerBeep_Private_Void_0;

	// Token: 0x040038B5 RID: 14517
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040038B6 RID: 14518
	private static readonly IntPtr NativeMethodInfoPtr_AdjustWatchWristSide_Public_Void_Int32_0;

	// Token: 0x040038B7 RID: 14519
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040038B8 RID: 14520
	private static readonly IntPtr NativeMethodInfoPtr_ResetWatch_Public_Void_0;

	// Token: 0x040038B9 RID: 14521
	private static readonly IntPtr NativeMethodInfoPtr_TriggerManualBeep_Private_Void_0;

	// Token: 0x040038BA RID: 14522
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
