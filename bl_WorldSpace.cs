using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000457 RID: 1111
public class bl_WorldSpace : MonoBehaviour
{
	// Token: 0x0600595D RID: 22877 RVA: 0x00165A0C File Offset: 0x00163C0C
	[CallerCount(0)]
	public unsafe void OnDrawGizmosSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_WorldSpace.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600595E RID: 22878 RVA: 0x00165A50 File Offset: 0x00163C50
	[CallerCount(0)]
	public unsafe bl_WorldSpace() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_WorldSpace>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_WorldSpace.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600595F RID: 22879 RVA: 0x00165A9C File Offset: 0x00163C9C
	// Note: this type is marked as 'beforefieldinit'.
	static bl_WorldSpace()
	{
		Il2CppClassPointerStore<bl_WorldSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_WorldSpace");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_WorldSpace>.NativeClassPtr);
		bl_WorldSpace.NativeFieldInfoPtr_GizmoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_WorldSpace>.NativeClassPtr, "GizmoColor");
		bl_WorldSpace.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_WorldSpace>.NativeClassPtr, 100670320);
		bl_WorldSpace.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_WorldSpace>.NativeClassPtr, 100670321);
	}

	// Token: 0x06005960 RID: 22880 RVA: 0x0000210C File Offset: 0x0000030C
	public bl_WorldSpace(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001FDD RID: 8157
	// (get) Token: 0x06005961 RID: 22881 RVA: 0x00165B08 File Offset: 0x00163D08
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_WorldSpace>.NativeClassPtr));
		}
	}

	// Token: 0x17001FDE RID: 8158
	// (get) Token: 0x06005962 RID: 22882 RVA: 0x00165B1C File Offset: 0x00163D1C
	// (set) Token: 0x06005963 RID: 22883 RVA: 0x00165B44 File Offset: 0x00163D44
	public unsafe Color GizmoColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_WorldSpace.NativeFieldInfoPtr_GizmoColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_WorldSpace.NativeFieldInfoPtr_GizmoColor)) = value;
		}
	}

	// Token: 0x04003893 RID: 14483
	private static readonly IntPtr NativeFieldInfoPtr_GizmoColor;

	// Token: 0x04003894 RID: 14484
	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

	// Token: 0x04003895 RID: 14485
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
