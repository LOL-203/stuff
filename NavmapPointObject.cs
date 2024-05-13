using System;
using DPI.Navigation;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010C3 RID: 4291
	public class NavmapPointObject : Il2CppSystem.Object
	{
		// Token: 0x06014427 RID: 82983 RVA: 0x00518A7C File Offset: 0x00516C7C
		[CallerCount(0)]
		public unsafe NavmapPointObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavmapPointObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014428 RID: 82984 RVA: 0x00518AC8 File Offset: 0x00516CC8
		[CallerCount(0)]
		public unsafe NavmapPointObject(NavigationNode target, Vector3 position) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(target));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavmapPointObject.NativeMethodInfoPtr__ctor_Public_Void_NavigationNode_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014429 RID: 82985 RVA: 0x00518B44 File Offset: 0x00516D44
		// Note: this type is marked as 'beforefieldinit'.
		static NavmapPointObject()
		{
			Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "NavmapPointObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr);
			NavmapPointObject.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr, "Target");
			NavmapPointObject.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr, "Position");
			NavmapPointObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr, 100689219);
			NavmapPointObject.NativeMethodInfoPtr__ctor_Public_Void_NavigationNode_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr, 100689220);
		}

		// Token: 0x0601442A RID: 82986 RVA: 0x00002988 File Offset: 0x00000B88
		public NavmapPointObject(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072C5 RID: 29381
		// (get) Token: 0x0601442B RID: 82987 RVA: 0x00518BC4 File Offset: 0x00516DC4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NavmapPointObject>.NativeClassPtr));
			}
		}

		// Token: 0x170072C6 RID: 29382
		// (get) Token: 0x0601442C RID: 82988 RVA: 0x00518BD8 File Offset: 0x00516DD8
		// (set) Token: 0x0601442D RID: 82989 RVA: 0x00518C0A File Offset: 0x00516E0A
		public NavigationNode Target
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointObject.NativeFieldInfoPtr_Target);
				return new NavigationNode(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NavigationNode>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointObject.NativeFieldInfoPtr_Target), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NavigationNode>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170072C7 RID: 29383
		// (get) Token: 0x0601442E RID: 82990 RVA: 0x00518C40 File Offset: 0x00516E40
		// (set) Token: 0x0601442F RID: 82991 RVA: 0x00518C68 File Offset: 0x00516E68
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointObject.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointObject.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x0400CF1F RID: 53023
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x0400CF20 RID: 53024
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400CF21 RID: 53025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400CF22 RID: 53026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NavigationNode_Vector3_0;
	}
}
