using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Verlet
{
	// Token: 0x020008FF RID: 2303
	[StructLayout(2)]
	public struct VerletRopeSegment
	{
		// Token: 0x0600BC9E RID: 48286 RVA: 0x00303D10 File Offset: 0x00301F10
		[CallerCount(0)]
		public unsafe VerletRopeSegment(Vector3 pos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRopeSegment.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x00303D58 File Offset: 0x00301F58
		// Note: this type is marked as 'beforefieldinit'.
		static VerletRopeSegment()
		{
			Il2CppClassPointerStore<VerletRopeSegment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Verlet", "VerletRopeSegment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerletRopeSegment>.NativeClassPtr);
			VerletRopeSegment.NativeFieldInfoPtr_posNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRopeSegment>.NativeClassPtr, "posNow");
			VerletRopeSegment.NativeFieldInfoPtr_posOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRopeSegment>.NativeClassPtr, "posOld");
			VerletRopeSegment.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRopeSegment>.NativeClassPtr, 100678619);
		}

		// Token: 0x0600BCA0 RID: 48288 RVA: 0x00303DC4 File Offset: 0x00301FC4
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerletRopeSegment>.NativeClassPtr, ref this));
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x0600BCA1 RID: 48289 RVA: 0x00303DD6 File Offset: 0x00301FD6
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerletRopeSegment>.NativeClassPtr));
			}
		}

		// Token: 0x040078EA RID: 30954
		private static readonly IntPtr NativeFieldInfoPtr_posNow;

		// Token: 0x040078EB RID: 30955
		private static readonly IntPtr NativeFieldInfoPtr_posOld;

		// Token: 0x040078EC RID: 30956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

		// Token: 0x040078ED RID: 30957
		[FieldOffset(0)]
		public Vector3 posNow;

		// Token: 0x040078EE RID: 30958
		[FieldOffset(12)]
		public Vector3 posOld;
	}
}
