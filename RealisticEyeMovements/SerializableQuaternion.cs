using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x0200078C RID: 1932
	[Serializable]
	[StructLayout(2)]
	public struct SerializableQuaternion
	{
		// Token: 0x0600A0ED RID: 41197 RVA: 0x0028B93C File Offset: 0x00289B3C
		[CallerCount(0)]
		public unsafe SerializableQuaternion(float rX, float rY, float rZ, float rW)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rZ;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rW;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableQuaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x0028B9BC File Offset: 0x00289BBC
		[CallerCount(0)]
		public unsafe string ToString()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializableQuaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x0028B9F8 File Offset: 0x00289BF8
		[CallerCount(0)]
		public unsafe static implicit operator Quaternion(SerializableQuaternion rValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SerializableQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_SerializableQuaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x0028BA4C File Offset: 0x00289C4C
		[CallerCount(0)]
		public unsafe static implicit operator SerializableQuaternion(Quaternion rValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SerializableQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableQuaternion_Quaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x0028BAA0 File Offset: 0x00289CA0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableQuaternion()
		{
			Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "SerializableQuaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr);
			SerializableQuaternion.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, "x");
			SerializableQuaternion.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, "y");
			SerializableQuaternion.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, "z");
			SerializableQuaternion.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, "w");
			SerializableQuaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, 100676066);
			SerializableQuaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, 100676067);
			SerializableQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_SerializableQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, 100676068);
			SerializableQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableQuaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, 100676069);
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x0028BB70 File Offset: 0x00289D70
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr, ref this));
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0600A0F3 RID: 41203 RVA: 0x0028BB82 File Offset: 0x00289D82
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializableQuaternion>.NativeClassPtr));
			}
		}

		// Token: 0x0400663E RID: 26174
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400663F RID: 26175
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04006640 RID: 26176
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04006641 RID: 26177
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04006642 RID: 26178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04006643 RID: 26179
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04006644 RID: 26180
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_SerializableQuaternion_0;

		// Token: 0x04006645 RID: 26181
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableQuaternion_Quaternion_0;

		// Token: 0x04006646 RID: 26182
		[FieldOffset(0)]
		public float x;

		// Token: 0x04006647 RID: 26183
		[FieldOffset(4)]
		public float y;

		// Token: 0x04006648 RID: 26184
		[FieldOffset(8)]
		public float z;

		// Token: 0x04006649 RID: 26185
		[FieldOffset(12)]
		public float w;
	}
}
