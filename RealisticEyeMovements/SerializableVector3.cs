using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x0200078D RID: 1933
	[Serializable]
	[StructLayout(2)]
	public struct SerializableVector3
	{
		// Token: 0x0600A0F4 RID: 41204 RVA: 0x0028BB94 File Offset: 0x00289D94
		[CallerCount(0)]
		public unsafe SerializableVector3(float rX, float rY, float rZ)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rZ;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableVector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x0028BC00 File Offset: 0x00289E00
		[CallerCount(0)]
		public unsafe string ToString()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializableVector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x0028BC3C File Offset: 0x00289E3C
		[CallerCount(0)]
		public unsafe static implicit operator Vector3(SerializableVector3 rValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SerializableVector3.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_SerializableVector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x0028BC90 File Offset: 0x00289E90
		[CallerCount(0)]
		public unsafe static implicit operator SerializableVector3(Vector3 rValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SerializableVector3.NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableVector3_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x0028BCE4 File Offset: 0x00289EE4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableVector3()
		{
			Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "SerializableVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr);
			SerializableVector3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr, "x");
			SerializableVector3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr, "y");
			SerializableVector3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr, "z");
			SerializableVector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr, 100676070);
			SerializableVector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr, 100676071);
			SerializableVector3.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_SerializableVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr, 100676072);
			SerializableVector3.NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableVector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr, 100676073);
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x0028BDA0 File Offset: 0x00289FA0
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr, ref this));
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0600A0FA RID: 41210 RVA: 0x0028BDB2 File Offset: 0x00289FB2
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializableVector3>.NativeClassPtr));
			}
		}

		// Token: 0x0400664A RID: 26186
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400664B RID: 26187
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400664C RID: 26188
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400664D RID: 26189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x0400664E RID: 26190
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400664F RID: 26191
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_SerializableVector3_0;

		// Token: 0x04006650 RID: 26192
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableVector3_Vector3_0;

		// Token: 0x04006651 RID: 26193
		[FieldOffset(0)]
		public float x;

		// Token: 0x04006652 RID: 26194
		[FieldOffset(4)]
		public float y;

		// Token: 0x04006653 RID: 26195
		[FieldOffset(8)]
		public float z;
	}
}
