using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

// Token: 0x02000134 RID: 308
[Serializable]
[StructLayout(0)]
public sealed class AreaVolumeHash : ValueType
{
	// Token: 0x06001377 RID: 4983 RVA: 0x0004EB74 File Offset: 0x0004CD74
	// Note: this type is marked as 'beforefieldinit'.
	static AreaVolumeHash()
	{
		Il2CppClassPointerStore<AreaVolumeHash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaVolumeHash");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaVolumeHash>.NativeClassPtr);
		AreaVolumeHash.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolumeHash>.NativeClassPtr, "Position");
		AreaVolumeHash.NativeFieldInfoPtr_Volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolumeHash>.NativeClassPtr, "Volumes");
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x0002717B File Offset: 0x0002537B
	public AreaVolumeHash(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000697 RID: 1687
	// (get) Token: 0x06001379 RID: 4985 RVA: 0x0004EBCC File Offset: 0x0004CDCC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AreaVolumeHash>.NativeClassPtr));
		}
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x0004EBE0 File Offset: 0x0004CDE0
	public unsafe AreaVolumeHash()
	{
		IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AreaVolumeHash>.NativeClassPtr, (UIntPtr)0)];
		base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AreaVolumeHash>.NativeClassPtr, data));
	}

	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x0600137B RID: 4987 RVA: 0x0004EC10 File Offset: 0x0004CE10
	// (set) Token: 0x0600137C RID: 4988 RVA: 0x0004EC38 File Offset: 0x0004CE38
	public unsafe Vector3Int Position
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolumeHash.NativeFieldInfoPtr_Position);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolumeHash.NativeFieldInfoPtr_Position)) = value;
		}
	}

	// Token: 0x17000699 RID: 1689
	// (get) Token: 0x0600137D RID: 4989 RVA: 0x0004EC5C File Offset: 0x0004CE5C
	// (set) Token: 0x0600137E RID: 4990 RVA: 0x0004EC90 File Offset: 0x0004CE90
	public unsafe Il2CppReferenceArray<AreaVolume> Volumes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolumeHash.NativeFieldInfoPtr_Volumes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<AreaVolume>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolumeHash.NativeFieldInfoPtr_Volumes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C67 RID: 3175
	private static readonly IntPtr NativeFieldInfoPtr_Position;

	// Token: 0x04000C68 RID: 3176
	private static readonly IntPtr NativeFieldInfoPtr_Volumes;
}
