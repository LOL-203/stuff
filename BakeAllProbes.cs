using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020000BB RID: 187
public class BakeAllProbes : MonoBehaviour
{
	// Token: 0x06000BC8 RID: 3016 RVA: 0x00030264 File Offset: 0x0002E464
	[CallerCount(0)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BakeAllProbes.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x000302BC File Offset: 0x0002E4BC
	[CallerCount(0)]
	public unsafe BakeAllProbes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BakeAllProbes>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BakeAllProbes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x00030308 File Offset: 0x0002E508
	// Note: this type is marked as 'beforefieldinit'.
	static BakeAllProbes()
	{
		Il2CppClassPointerStore<BakeAllProbes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BakeAllProbes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakeAllProbes>.NativeClassPtr);
		BakeAllProbes.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeAllProbes>.NativeClassPtr, 100664215);
		BakeAllProbes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeAllProbes>.NativeClassPtr, 100664216);
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0000210C File Offset: 0x0000030C
	public BakeAllProbes(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00030360 File Offset: 0x0002E560
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BakeAllProbes>.NativeClassPtr));
		}
	}

	// Token: 0x04000723 RID: 1827
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x04000724 RID: 1828
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020000BC RID: 188
	[ObfuscatedName("BakeAllProbes/<Start>d__0")]
	public sealed class _Start_d__0 : Il2CppSystem.Object
	{
		// Token: 0x06000BCD RID: 3021 RVA: 0x00030374 File Offset: 0x0002E574
		[CallerCount(0)]
		public unsafe _Start_d__0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BakeAllProbes._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000303D4 File Offset: 0x0002E5D4
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BakeAllProbes._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00030418 File Offset: 0x0002E618
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BakeAllProbes._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00030468 File Offset: 0x0002E668
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BakeAllProbes._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000304C0 File Offset: 0x0002E6C0
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BakeAllProbes._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00030504 File Offset: 0x0002E704
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BakeAllProbes._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0003055C File Offset: 0x0002E75C
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__0()
		{
			Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BakeAllProbes>.NativeClassPtr, "<Start>d__0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr);
			BakeAllProbes._Start_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, "<>1__state");
			BakeAllProbes._Start_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, "<>2__current");
			BakeAllProbes._Start_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, "<>4__this");
			BakeAllProbes._Start_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, 100664217);
			BakeAllProbes._Start_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, 100664218);
			BakeAllProbes._Start_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, 100664219);
			BakeAllProbes._Start_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, 100664220);
			BakeAllProbes._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, 100664221);
			BakeAllProbes._Start_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr, 100664222);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002988 File Offset: 0x00000B88
		public _Start_d__0(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0003063B File Offset: 0x0002E83B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BakeAllProbes._Start_d__0>.NativeClassPtr));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0003064C File Offset: 0x0002E84C
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00030674 File Offset: 0x0002E874
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BakeAllProbes._Start_d__0.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BakeAllProbes._Start_d__0.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00030698 File Offset: 0x0002E898
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x000306CC File Offset: 0x0002E8CC
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BakeAllProbes._Start_d__0.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BakeAllProbes._Start_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x000306F4 File Offset: 0x0002E8F4
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00030728 File Offset: 0x0002E928
		public unsafe BakeAllProbes __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BakeAllProbes._Start_d__0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new BakeAllProbes(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BakeAllProbes._Start_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
