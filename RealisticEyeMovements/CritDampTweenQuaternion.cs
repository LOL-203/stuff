using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x0200077E RID: 1918
	[StructLayout(2)]
	public struct CritDampTweenQuaternion
	{
		// Token: 0x06009EDE RID: 40670 RVA: 0x00284178 File Offset: 0x00282378
		[CallerCount(0)]
		public unsafe static Vector4 q2v(Quaternion q)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref q;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CritDampTweenQuaternion.NativeMethodInfoPtr_q2v_Private_Static_Vector4_Quaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x06009EDF RID: 40671 RVA: 0x002841CC File Offset: 0x002823CC
		// (set) Token: 0x06009EE0 RID: 40672 RVA: 0x00284210 File Offset: 0x00282410
		public unsafe Quaternion rotation
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CritDampTweenQuaternion.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, ref this, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CritDampTweenQuaternion.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, ref this, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009EE1 RID: 40673 RVA: 0x00284258 File Offset: 0x00282458
		[CallerCount(0)]
		public unsafe CritDampTweenQuaternion(Quaternion rotation, float omega, float maxSpeed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref omega;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CritDampTweenQuaternion.NativeMethodInfoPtr__ctor_Public_Void_Quaternion_Single_Single_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EE2 RID: 40674 RVA: 0x002842C4 File Offset: 0x002824C4
		[CallerCount(0)]
		public unsafe void Step(Quaternion target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CritDampTweenQuaternion.NativeMethodInfoPtr_Step_Public_Void_Quaternion_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EE3 RID: 40675 RVA: 0x0028430C File Offset: 0x0028250C
		[CallerCount(0)]
		public unsafe static implicit operator Quaternion(CritDampTweenQuaternion m)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref m;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CritDampTweenQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_CritDampTweenQuaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009EE4 RID: 40676 RVA: 0x00284360 File Offset: 0x00282560
		// Note: this type is marked as 'beforefieldinit'.
		static CritDampTweenQuaternion()
		{
			Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "CritDampTweenQuaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr);
			CritDampTweenQuaternion.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, "_rotation");
			CritDampTweenQuaternion.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, "velocity");
			CritDampTweenQuaternion.NativeFieldInfoPtr_omega = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, "omega");
			CritDampTweenQuaternion.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, "maxSpeed");
			CritDampTweenQuaternion.NativeMethodInfoPtr_q2v_Private_Static_Vector4_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, 100675959);
			CritDampTweenQuaternion.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, 100675960);
			CritDampTweenQuaternion.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, 100675961);
			CritDampTweenQuaternion.NativeMethodInfoPtr__ctor_Public_Void_Quaternion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, 100675962);
			CritDampTweenQuaternion.NativeMethodInfoPtr_Step_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, 100675963);
			CritDampTweenQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_CritDampTweenQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, 100675964);
		}

		// Token: 0x06009EE5 RID: 40677 RVA: 0x00284458 File Offset: 0x00282658
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, ref this));
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x06009EE6 RID: 40678 RVA: 0x0028446A File Offset: 0x0028266A
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr));
			}
		}

		// Token: 0x040064DF RID: 25823
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x040064E0 RID: 25824
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x040064E1 RID: 25825
		private static readonly IntPtr NativeFieldInfoPtr_omega;

		// Token: 0x040064E2 RID: 25826
		private static readonly IntPtr NativeFieldInfoPtr_maxSpeed;

		// Token: 0x040064E3 RID: 25827
		private static readonly IntPtr NativeMethodInfoPtr_q2v_Private_Static_Vector4_Quaternion_0;

		// Token: 0x040064E4 RID: 25828
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x040064E5 RID: 25829
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x040064E6 RID: 25830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Quaternion_Single_Single_0;

		// Token: 0x040064E7 RID: 25831
		private static readonly IntPtr NativeMethodInfoPtr_Step_Public_Void_Quaternion_0;

		// Token: 0x040064E8 RID: 25832
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_CritDampTweenQuaternion_0;

		// Token: 0x040064E9 RID: 25833
		[FieldOffset(0)]
		public CritDampTweenQuaternion.QVUnion _rotation;

		// Token: 0x040064EA RID: 25834
		[FieldOffset(16)]
		public Vector4 velocity;

		// Token: 0x040064EB RID: 25835
		[FieldOffset(32)]
		public float omega;

		// Token: 0x040064EC RID: 25836
		[FieldOffset(36)]
		public readonly float maxSpeed;

		// Token: 0x0200077F RID: 1919
		[StructLayout(2)]
		public struct QVUnion
		{
			// Token: 0x06009EE7 RID: 40679 RVA: 0x0028447C File Offset: 0x0028267C
			// Note: this type is marked as 'beforefieldinit'.
			static QVUnion()
			{
				Il2CppClassPointerStore<CritDampTweenQuaternion.QVUnion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritDampTweenQuaternion>.NativeClassPtr, "QVUnion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritDampTweenQuaternion.QVUnion>.NativeClassPtr);
				CritDampTweenQuaternion.QVUnion.NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritDampTweenQuaternion.QVUnion>.NativeClassPtr, "v");
				CritDampTweenQuaternion.QVUnion.NativeFieldInfoPtr_q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritDampTweenQuaternion.QVUnion>.NativeClassPtr, "q");
			}

			// Token: 0x06009EE8 RID: 40680 RVA: 0x002844CF File Offset: 0x002826CF
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritDampTweenQuaternion.QVUnion>.NativeClassPtr, ref this));
			}

			// Token: 0x170038E2 RID: 14562
			// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x002844E1 File Offset: 0x002826E1
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CritDampTweenQuaternion.QVUnion>.NativeClassPtr));
				}
			}

			// Token: 0x040064ED RID: 25837
			private static readonly IntPtr NativeFieldInfoPtr_v;

			// Token: 0x040064EE RID: 25838
			private static readonly IntPtr NativeFieldInfoPtr_q;

			// Token: 0x040064EF RID: 25839
			[FieldOffset(0)]
			public Vector4 v;

			// Token: 0x040064F0 RID: 25840
			[FieldOffset(0)]
			public Quaternion q;
		}
	}
}
