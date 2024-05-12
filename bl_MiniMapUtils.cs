using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200045C RID: 1116
public static class bl_MiniMapUtils : Il2CppSystem.Object
{
	// Token: 0x060059B8 RID: 22968 RVA: 0x00166E88 File Offset: 0x00165088
	[CallerCount(0)]
	public unsafe static Vector3 CalculateMiniMapPosition(Vector3 viewPoint, RectTransform maxAnchor)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref viewPoint;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maxAnchor);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapUtils.NativeMethodInfoPtr_CalculateMiniMapPosition_Public_Static_Vector3_Vector3_RectTransform_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060059B9 RID: 22969 RVA: 0x00166EF3 File Offset: 0x001650F3
	// Note: this type is marked as 'beforefieldinit'.
	static bl_MiniMapUtils()
	{
		Il2CppClassPointerStore<bl_MiniMapUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_MiniMapUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MiniMapUtils>.NativeClassPtr);
		bl_MiniMapUtils.NativeMethodInfoPtr_CalculateMiniMapPosition_Public_Static_Vector3_Vector3_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapUtils>.NativeClassPtr, 100670342);
	}

	// Token: 0x060059BA RID: 22970 RVA: 0x00002988 File Offset: 0x00000B88
	public bl_MiniMapUtils(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001FFE RID: 8190
	// (get) Token: 0x060059BB RID: 22971 RVA: 0x00166F2C File Offset: 0x0016512C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MiniMapUtils>.NativeClassPtr));
		}
	}

	// Token: 0x040038C8 RID: 14536
	private static readonly IntPtr NativeMethodInfoPtr_CalculateMiniMapPosition_Public_Static_Vector3_Vector3_RectTransform_0;
}
