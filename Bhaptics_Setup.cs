using System;
using Bhaptics.Tact.Unity;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000532 RID: 1330
public class Bhaptics_Setup : MonoBehaviour
{
	// Token: 0x06006C96 RID: 27798 RVA: 0x001B3E00 File Offset: 0x001B2000
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bhaptics_Setup.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C97 RID: 27799 RVA: 0x001B3E44 File Offset: 0x001B2044
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bhaptics_Setup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C98 RID: 27800 RVA: 0x001B3E88 File Offset: 0x001B2088
	[CallerCount(0)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bhaptics_Setup.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C99 RID: 27801 RVA: 0x001B3ECC File Offset: 0x001B20CC
	[CallerCount(0)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bhaptics_Setup.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C9A RID: 27802 RVA: 0x001B3F10 File Offset: 0x001B2110
	[CallerCount(0)]
	public unsafe Bhaptics_Setup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bhaptics_Setup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C9B RID: 27803 RVA: 0x001B3F5C File Offset: 0x001B215C
	// Note: this type is marked as 'beforefieldinit'.
	static Bhaptics_Setup()
	{
		Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Bhaptics_Setup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr);
		Bhaptics_Setup.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr, "instance");
		Bhaptics_Setup.NativeFieldInfoPtr_Config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr, "Config");
		Bhaptics_Setup.NativeFieldInfoPtr_hapticClipsOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr, "hapticClipsOnAwake");
		Bhaptics_Setup.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr, 100671910);
		Bhaptics_Setup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr, 100671911);
		Bhaptics_Setup.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr, 100671912);
		Bhaptics_Setup.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr, 100671913);
		Bhaptics_Setup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr, 100671914);
	}

	// Token: 0x06006C9C RID: 27804 RVA: 0x0000210C File Offset: 0x0000030C
	public Bhaptics_Setup(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170026A5 RID: 9893
	// (get) Token: 0x06006C9D RID: 27805 RVA: 0x001B402C File Offset: 0x001B222C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Bhaptics_Setup>.NativeClassPtr));
		}
	}

	// Token: 0x170026A6 RID: 9894
	// (get) Token: 0x06006C9E RID: 27806 RVA: 0x001B4040 File Offset: 0x001B2240
	// (set) Token: 0x06006C9F RID: 27807 RVA: 0x001B406B File Offset: 0x001B226B
	public unsafe static Bhaptics_Setup instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Bhaptics_Setup.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Bhaptics_Setup(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Bhaptics_Setup.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170026A7 RID: 9895
	// (get) Token: 0x06006CA0 RID: 27808 RVA: 0x001B4080 File Offset: 0x001B2280
	// (set) Token: 0x06006CA1 RID: 27809 RVA: 0x001B40B4 File Offset: 0x001B22B4
	public unsafe BhapticsConfig Config
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bhaptics_Setup.NativeFieldInfoPtr_Config);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new BhapticsConfig(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bhaptics_Setup.NativeFieldInfoPtr_Config), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170026A8 RID: 9896
	// (get) Token: 0x06006CA2 RID: 27810 RVA: 0x001B40DC File Offset: 0x001B22DC
	// (set) Token: 0x06006CA3 RID: 27811 RVA: 0x001B4110 File Offset: 0x001B2310
	public unsafe Il2CppReferenceArray<HapticClip> hapticClipsOnAwake
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bhaptics_Setup.NativeFieldInfoPtr_hapticClipsOnAwake);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<HapticClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bhaptics_Setup.NativeFieldInfoPtr_hapticClipsOnAwake), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04004571 RID: 17777
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x04004572 RID: 17778
	private static readonly IntPtr NativeFieldInfoPtr_Config;

	// Token: 0x04004573 RID: 17779
	private static readonly IntPtr NativeFieldInfoPtr_hapticClipsOnAwake;

	// Token: 0x04004574 RID: 17780
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04004575 RID: 17781
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04004576 RID: 17782
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	// Token: 0x04004577 RID: 17783
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	// Token: 0x04004578 RID: 17784
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
