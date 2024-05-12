using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005E7 RID: 1511
	public static class TransformUtils : Il2CppSystem.Object
	{
		// Token: 0x06007A7E RID: 31358 RVA: 0x001EC5DC File Offset: 0x001EA7DC
		[CallerCount(0)]
		public unsafe static TransformUtils.Packed GetWorldPacked(this Transform self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtils.NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new TransformUtils.Packed(intPtr2) : null;
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x001EC63C File Offset: 0x001EA83C
		[CallerCount(0)]
		public unsafe static bool IsSame(this Transform self, TransformUtils.Packed packed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packed);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TransformUtils.NativeMethodInfoPtr_IsSame_Public_Static_Boolean_Transform_Packed_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x001EC6AC File Offset: 0x001EA8AC
		// Note: this type is marked as 'beforefieldinit'.
		static TransformUtils()
		{
			Il2CppClassPointerStore<TransformUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TransformUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr);
			TransformUtils.NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, 100673054);
			TransformUtils.NativeMethodInfoPtr_IsSame_Public_Static_Boolean_Transform_Packed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, 100673055);
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x00002988 File Offset: 0x00000B88
		public TransformUtils(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06007A82 RID: 31362 RVA: 0x001EC704 File Offset: 0x001EA904
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr));
			}
		}

		// Token: 0x04004E70 RID: 20080
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldPacked_Public_Static_Packed_Transform_0;

		// Token: 0x04004E71 RID: 20081
		private static readonly IntPtr NativeMethodInfoPtr_IsSame_Public_Static_Boolean_Transform_Packed_0;

		// Token: 0x020005E8 RID: 1512
		public class Packed : Il2CppSystem.Object
		{
			// Token: 0x06007A83 RID: 31363 RVA: 0x001EC718 File Offset: 0x001EA918
			[CallerCount(0)]
			public unsafe Packed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtils.Packed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007A84 RID: 31364 RVA: 0x001EC764 File Offset: 0x001EA964
			// Note: this type is marked as 'beforefieldinit'.
			static Packed()
			{
				Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransformUtils>.NativeClassPtr, "Packed");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr);
				TransformUtils.Packed.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "position");
				TransformUtils.Packed.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "rotation");
				TransformUtils.Packed.NativeFieldInfoPtr_lossyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, "lossyScale");
				TransformUtils.Packed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr, 100673056);
			}

			// Token: 0x06007A85 RID: 31365 RVA: 0x00002988 File Offset: 0x00000B88
			public Packed(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002BE6 RID: 11238
			// (get) Token: 0x06007A86 RID: 31366 RVA: 0x001EC7DF File Offset: 0x001EA9DF
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TransformUtils.Packed>.NativeClassPtr));
				}
			}

			// Token: 0x17002BE7 RID: 11239
			// (get) Token: 0x06007A87 RID: 31367 RVA: 0x001EC7F0 File Offset: 0x001EA9F0
			// (set) Token: 0x06007A88 RID: 31368 RVA: 0x001EC818 File Offset: 0x001EAA18
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformUtils.Packed.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformUtils.Packed.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17002BE8 RID: 11240
			// (get) Token: 0x06007A89 RID: 31369 RVA: 0x001EC83C File Offset: 0x001EAA3C
			// (set) Token: 0x06007A8A RID: 31370 RVA: 0x001EC864 File Offset: 0x001EAA64
			public unsafe Quaternion rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformUtils.Packed.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformUtils.Packed.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x17002BE9 RID: 11241
			// (get) Token: 0x06007A8B RID: 31371 RVA: 0x001EC888 File Offset: 0x001EAA88
			// (set) Token: 0x06007A8C RID: 31372 RVA: 0x001EC8B0 File Offset: 0x001EAAB0
			public unsafe Vector3 lossyScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformUtils.Packed.NativeFieldInfoPtr_lossyScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformUtils.Packed.NativeFieldInfoPtr_lossyScale)) = value;
				}
			}

			// Token: 0x04004E72 RID: 20082
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04004E73 RID: 20083
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04004E74 RID: 20084
			private static readonly IntPtr NativeFieldInfoPtr_lossyScale;

			// Token: 0x04004E75 RID: 20085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
