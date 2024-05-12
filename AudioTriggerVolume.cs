using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200013E RID: 318
public class AudioTriggerVolume : MonoBehaviour
{
	// Token: 0x06001483 RID: 5251 RVA: 0x00053208 File Offset: 0x00051408
	[CallerCount(0)]
	public unsafe void OnTriggerEnter(Collider col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioTriggerVolume.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00053264 File Offset: 0x00051464
	[CallerCount(0)]
	public unsafe void OnTriggerExit(Collider col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioTriggerVolume.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x000532C0 File Offset: 0x000514C0
	[CallerCount(0)]
	public unsafe AudioTriggerVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioTriggerVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x0005330C File Offset: 0x0005150C
	// Note: this type is marked as 'beforefieldinit'.
	static AudioTriggerVolume()
	{
		Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioTriggerVolume");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr);
		AudioTriggerVolume.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr, "source");
		AudioTriggerVolume.NativeFieldInfoPtr_fadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr, "fadeInTime");
		AudioTriggerVolume.NativeFieldInfoPtr_fadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr, "fadeOutTime");
		AudioTriggerVolume.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr, 100665006);
		AudioTriggerVolume.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr, 100665007);
		AudioTriggerVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr, 100665008);
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x0000210C File Offset: 0x0000030C
	public AudioTriggerVolume(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170006F5 RID: 1781
	// (get) Token: 0x06001488 RID: 5256 RVA: 0x000533B4 File Offset: 0x000515B4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioTriggerVolume>.NativeClassPtr));
		}
	}

	// Token: 0x170006F6 RID: 1782
	// (get) Token: 0x06001489 RID: 5257 RVA: 0x000533C8 File Offset: 0x000515C8
	// (set) Token: 0x0600148A RID: 5258 RVA: 0x000533FC File Offset: 0x000515FC
	public unsafe AudioSource source
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioTriggerVolume.NativeFieldInfoPtr_source);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AudioSource(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioTriggerVolume.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006F7 RID: 1783
	// (get) Token: 0x0600148B RID: 5259 RVA: 0x00053424 File Offset: 0x00051624
	// (set) Token: 0x0600148C RID: 5260 RVA: 0x0005344C File Offset: 0x0005164C
	public unsafe float fadeInTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioTriggerVolume.NativeFieldInfoPtr_fadeInTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioTriggerVolume.NativeFieldInfoPtr_fadeInTime)) = value;
		}
	}

	// Token: 0x170006F8 RID: 1784
	// (get) Token: 0x0600148D RID: 5261 RVA: 0x00053470 File Offset: 0x00051670
	// (set) Token: 0x0600148E RID: 5262 RVA: 0x00053498 File Offset: 0x00051698
	public unsafe float fadeOutTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioTriggerVolume.NativeFieldInfoPtr_fadeOutTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioTriggerVolume.NativeFieldInfoPtr_fadeOutTime)) = value;
		}
	}

	// Token: 0x04000D21 RID: 3361
	private static readonly IntPtr NativeFieldInfoPtr_source;

	// Token: 0x04000D22 RID: 3362
	private static readonly IntPtr NativeFieldInfoPtr_fadeInTime;

	// Token: 0x04000D23 RID: 3363
	private static readonly IntPtr NativeFieldInfoPtr_fadeOutTime;

	// Token: 0x04000D24 RID: 3364
	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

	// Token: 0x04000D25 RID: 3365
	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

	// Token: 0x04000D26 RID: 3366
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
