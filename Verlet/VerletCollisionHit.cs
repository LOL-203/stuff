using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace Verlet
{
	// Token: 0x020008F9 RID: 2297
	[StructLayout(2)]
	public struct VerletCollisionHit
	{
		// Token: 0x0600BBF0 RID: 48112 RVA: 0x003012B0 File Offset: 0x002FF4B0
		// Note: this type is marked as 'beforefieldinit'.
		static VerletCollisionHit()
		{
			Il2CppClassPointerStore<VerletCollisionHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Verlet", "VerletCollisionHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerletCollisionHit>.NativeClassPtr);
			VerletCollisionHit.NativeFieldInfoPtr_ClosestPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletCollisionHit>.NativeClassPtr, "ClosestPoint");
			VerletCollisionHit.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletCollisionHit>.NativeClassPtr, "Distance");
			VerletCollisionHit.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletCollisionHit>.NativeClassPtr, "Normal");
		}

		// Token: 0x0600BBF1 RID: 48113 RVA: 0x0030131C File Offset: 0x002FF51C
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerletCollisionHit>.NativeClassPtr, ref this));
		}

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x0030132E File Offset: 0x002FF52E
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerletCollisionHit>.NativeClassPtr));
			}
		}

		// Token: 0x04007887 RID: 30855
		private static readonly IntPtr NativeFieldInfoPtr_ClosestPoint;

		// Token: 0x04007888 RID: 30856
		private static readonly IntPtr NativeFieldInfoPtr_Distance;

		// Token: 0x04007889 RID: 30857
		private static readonly IntPtr NativeFieldInfoPtr_Normal;

		// Token: 0x0400788A RID: 30858
		[FieldOffset(0)]
		public Vector3 ClosestPoint;

		// Token: 0x0400788B RID: 30859
		[FieldOffset(12)]
		public float Distance;

		// Token: 0x0400788C RID: 30860
		[FieldOffset(16)]
		public Vector3 Normal;
	}
}
