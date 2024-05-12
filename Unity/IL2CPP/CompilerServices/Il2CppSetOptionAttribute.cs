using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x0200098D RID: 2445
	public class Il2CppSetOptionAttribute : Attribute
	{
		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x0600CE71 RID: 52849 RVA: 0x00335224 File Offset: 0x00333424
		// (set) Token: 0x0600CE72 RID: 52850 RVA: 0x00335274 File Offset: 0x00333474
		public unsafe Option Option
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppSetOptionAttribute.NativeMethodInfoPtr_get_Option_Public_get_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSetOptionAttribute.NativeMethodInfoPtr_set_Option_Private_set_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x0600CE73 RID: 52851 RVA: 0x003352C8 File Offset: 0x003334C8
		// (set) Token: 0x0600CE74 RID: 52852 RVA: 0x00335320 File Offset: 0x00333520
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSetOptionAttribute.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Object(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSetOptionAttribute.NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600CE75 RID: 52853 RVA: 0x0033537C File Offset: 0x0033357C
		[CallerCount(0)]
		public unsafe Il2CppSetOptionAttribute(Option option, Object value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref option;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSetOptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Option_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x003353F4 File Offset: 0x003335F4
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppSetOptionAttribute()
		{
			Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Unity.IL2CPP.CompilerServices", "Il2CppSetOptionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr);
			Il2CppSetOptionAttribute.NativeFieldInfoPtr__Option_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr, "<Option>k__BackingField");
			Il2CppSetOptionAttribute.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr, "<Value>k__BackingField");
			Il2CppSetOptionAttribute.NativeMethodInfoPtr_get_Option_Public_get_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr, 100679195);
			Il2CppSetOptionAttribute.NativeMethodInfoPtr_set_Option_Private_set_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr, 100679196);
			Il2CppSetOptionAttribute.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr, 100679197);
			Il2CppSetOptionAttribute.NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr, 100679198);
			Il2CppSetOptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Option_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr, 100679199);
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x003354B0 File Offset: 0x003336B0
		public Il2CppSetOptionAttribute(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x0600CE78 RID: 52856 RVA: 0x003354B9 File Offset: 0x003336B9
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Il2CppSetOptionAttribute>.NativeClassPtr));
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x0600CE79 RID: 52857 RVA: 0x003354CC File Offset: 0x003336CC
		// (set) Token: 0x0600CE7A RID: 52858 RVA: 0x003354F4 File Offset: 0x003336F4
		public unsafe Option _Option_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppSetOptionAttribute.NativeFieldInfoPtr__Option_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppSetOptionAttribute.NativeFieldInfoPtr__Option_k__BackingField)) = value;
			}
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x0600CE7B RID: 52859 RVA: 0x00335518 File Offset: 0x00333718
		// (set) Token: 0x0600CE7C RID: 52860 RVA: 0x0033554C File Offset: 0x0033374C
		public unsafe Object _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppSetOptionAttribute.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppSetOptionAttribute.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400828D RID: 33421
		private static readonly IntPtr NativeFieldInfoPtr__Option_k__BackingField;

		// Token: 0x0400828E RID: 33422
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x0400828F RID: 33423
		private static readonly IntPtr NativeMethodInfoPtr_get_Option_Public_get_Option_0;

		// Token: 0x04008290 RID: 33424
		private static readonly IntPtr NativeMethodInfoPtr_set_Option_Private_set_Void_Option_0;

		// Token: 0x04008291 RID: 33425
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04008292 RID: 33426
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0;

		// Token: 0x04008293 RID: 33427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Option_Object_0;
	}
}
