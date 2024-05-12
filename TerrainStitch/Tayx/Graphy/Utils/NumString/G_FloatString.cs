using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Tayx.Graphy.Utils.NumString
{
	// Token: 0x020008E0 RID: 2272
	public static class G_FloatString : Object
	{
		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x0600B936 RID: 47414 RVA: 0x002F6774 File Offset: 0x002F4974
		public unsafe static bool Inited
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x0600B937 RID: 47415 RVA: 0x002F67B8 File Offset: 0x002F49B8
		public unsafe static float MinValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700421B RID: 16923
		// (get) Token: 0x0600B938 RID: 47416 RVA: 0x002F67FC File Offset: 0x002F49FC
		public unsafe static float MaxValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x002F6840 File Offset: 0x002F4A40
		[CallerCount(0)]
		public unsafe static void Init(float minNegativeValue, float maxPositiveValue, [Optional] int decimals)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minNegativeValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPositiveValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimals;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_Init_Public_Static_Void_Single_Single_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x002F68AC File Offset: 0x002F4AAC
		[CallerCount(0)]
		public unsafe static string ToStringNonAlloc(this float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x002F68FC File Offset: 0x002F4AFC
		[CallerCount(0)]
		public unsafe static string ToStringNonAlloc(this float value, string format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x002F6964 File Offset: 0x002F4B64
		[CallerCount(0)]
		public unsafe static int ToInt(this float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x002F69B8 File Offset: 0x002F4BB8
		[CallerCount(0)]
		public unsafe static float ToFloat(this int i)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref i;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToFloat_Public_Static_Single_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B93E RID: 47422 RVA: 0x002F6A0C File Offset: 0x002F4C0C
		[CallerCount(0)]
		public unsafe static int Pow(int f, int p)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_Pow_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x002F6A74 File Offset: 0x002F4C74
		[CallerCount(0)]
		public unsafe static int ToIndex(this float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToIndex_Private_Static_Int32_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x002F6AC8 File Offset: 0x002F4CC8
		[CallerCount(0)]
		public unsafe static float FromIndex(this int i)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref i;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_FromIndex_Private_Static_Single_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x002F6B1C File Offset: 0x002F4D1C
		// Note: this type is marked as 'beforefieldinit'.
		static G_FloatString()
		{
			Il2CppClassPointerStore<G_FloatString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Utils.NumString", "G_FloatString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr);
			G_FloatString.NativeFieldInfoPtr_floatFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, "floatFormat");
			G_FloatString.NativeFieldInfoPtr_decimalMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, "decimalMultiplier");
			G_FloatString.NativeFieldInfoPtr_negativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, "negativeBuffer");
			G_FloatString.NativeFieldInfoPtr_positiveBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, "positiveBuffer");
			G_FloatString.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678387);
			G_FloatString.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678388);
			G_FloatString.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678389);
			G_FloatString.NativeMethodInfoPtr_Init_Public_Static_Void_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678390);
			G_FloatString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678391);
			G_FloatString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678392);
			G_FloatString.NativeMethodInfoPtr_ToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678393);
			G_FloatString.NativeMethodInfoPtr_ToFloat_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678394);
			G_FloatString.NativeMethodInfoPtr_Pow_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678395);
			G_FloatString.NativeMethodInfoPtr_ToIndex_Private_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678396);
			G_FloatString.NativeMethodInfoPtr_FromIndex_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100678397);
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x00002988 File Offset: 0x00000B88
		public G_FloatString(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x0600B943 RID: 47427 RVA: 0x002F6C78 File Offset: 0x002F4E78
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr));
			}
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x0600B944 RID: 47428 RVA: 0x002F6C8C File Offset: 0x002F4E8C
		// (set) Token: 0x0600B945 RID: 47429 RVA: 0x002F6CAC File Offset: 0x002F4EAC
		public unsafe static string floatFormat
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(G_FloatString.NativeFieldInfoPtr_floatFormat, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_FloatString.NativeFieldInfoPtr_floatFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x0600B946 RID: 47430 RVA: 0x002F6CC4 File Offset: 0x002F4EC4
		// (set) Token: 0x0600B947 RID: 47431 RVA: 0x002F6CE2 File Offset: 0x002F4EE2
		public unsafe static float decimalMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(G_FloatString.NativeFieldInfoPtr_decimalMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_FloatString.NativeFieldInfoPtr_decimalMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x0600B948 RID: 47432 RVA: 0x002F6CF4 File Offset: 0x002F4EF4
		// (set) Token: 0x0600B949 RID: 47433 RVA: 0x002F6D1F File Offset: 0x002F4F1F
		public unsafe static Il2CppStringArray negativeBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(G_FloatString.NativeFieldInfoPtr_negativeBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_FloatString.NativeFieldInfoPtr_negativeBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x0600B94A RID: 47434 RVA: 0x002F6D34 File Offset: 0x002F4F34
		// (set) Token: 0x0600B94B RID: 47435 RVA: 0x002F6D5F File Offset: 0x002F4F5F
		public unsafe static Il2CppStringArray positiveBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(G_FloatString.NativeFieldInfoPtr_positiveBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_FloatString.NativeFieldInfoPtr_positiveBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040076EB RID: 30443
		private static readonly IntPtr NativeFieldInfoPtr_floatFormat;

		// Token: 0x040076EC RID: 30444
		private static readonly IntPtr NativeFieldInfoPtr_decimalMultiplier;

		// Token: 0x040076ED RID: 30445
		private static readonly IntPtr NativeFieldInfoPtr_negativeBuffer;

		// Token: 0x040076EE RID: 30446
		private static readonly IntPtr NativeFieldInfoPtr_positiveBuffer;

		// Token: 0x040076EF RID: 30447
		private static readonly IntPtr NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0;

		// Token: 0x040076F0 RID: 30448
		private static readonly IntPtr NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0;

		// Token: 0x040076F1 RID: 30449
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0;

		// Token: 0x040076F2 RID: 30450
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_Single_Single_Int32_0;

		// Token: 0x040076F3 RID: 30451
		private static readonly IntPtr NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_0;

		// Token: 0x040076F4 RID: 30452
		private static readonly IntPtr NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_String_0;

		// Token: 0x040076F5 RID: 30453
		private static readonly IntPtr NativeMethodInfoPtr_ToInt_Public_Static_Int32_Single_0;

		// Token: 0x040076F6 RID: 30454
		private static readonly IntPtr NativeMethodInfoPtr_ToFloat_Public_Static_Single_Int32_0;

		// Token: 0x040076F7 RID: 30455
		private static readonly IntPtr NativeMethodInfoPtr_Pow_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040076F8 RID: 30456
		private static readonly IntPtr NativeMethodInfoPtr_ToIndex_Private_Static_Int32_Single_0;

		// Token: 0x040076F9 RID: 30457
		private static readonly IntPtr NativeMethodInfoPtr_FromIndex_Private_Static_Single_Int32_0;
	}
}
