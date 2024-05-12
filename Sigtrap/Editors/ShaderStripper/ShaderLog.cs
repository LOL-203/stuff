using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Sigtrap.Editors.ShaderStripper
{
	// Token: 0x02000600 RID: 1536
	public class ShaderLog : Object
	{
		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x06007C2D RID: 31789 RVA: 0x001F32E4 File Offset: 0x001F14E4
		// (set) Token: 0x06007C2E RID: 31790 RVA: 0x001F3330 File Offset: 0x001F1530
		public unsafe string logName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr_get_logName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr_set_logName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x06007C2F RID: 31791 RVA: 0x001F338C File Offset: 0x001F158C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x001F33DC File Offset: 0x001F15DC
		[CallerCount(0)]
		public unsafe ShaderLog(string logName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(logName);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x001F3440 File Offset: 0x001F1640
		[CallerCount(0)]
		public unsafe void Add(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr_Add_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x001F349C File Offset: 0x001F169C
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x001F34E0 File Offset: 0x001F16E0
		[CallerCount(0)]
		public unsafe void Insert(int index, string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr_Insert_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x001F354C File Offset: 0x001F174C
		[CallerCount(0)]
		public unsafe bool Contains(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x001F35B4 File Offset: 0x001F17B4
		[CallerCount(0)]
		public unsafe Il2CppStringArray ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderLog.NativeMethodInfoPtr_ToArray_Public_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x001F360C File Offset: 0x001F180C
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderLog()
		{
			Il2CppClassPointerStore<ShaderLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Sigtrap.Editors.ShaderStripper", "ShaderLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr);
			ShaderLog.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, "log");
			ShaderLog.NativeFieldInfoPtr__logName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, "<logName>k__BackingField");
			ShaderLog.NativeMethodInfoPtr_get_logName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673212);
			ShaderLog.NativeMethodInfoPtr_set_logName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673213);
			ShaderLog.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673214);
			ShaderLog.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673215);
			ShaderLog.NativeMethodInfoPtr_Add_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673216);
			ShaderLog.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673217);
			ShaderLog.NativeMethodInfoPtr_Insert_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673218);
			ShaderLog.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673219);
			ShaderLog.NativeMethodInfoPtr_ToArray_Public_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr, 100673220);
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x00002988 File Offset: 0x00000B88
		public ShaderLog(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x06007C38 RID: 31800 RVA: 0x001F3718 File Offset: 0x001F1918
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderLog>.NativeClassPtr));
			}
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x06007C39 RID: 31801 RVA: 0x001F372C File Offset: 0x001F192C
		// (set) Token: 0x06007C3A RID: 31802 RVA: 0x001F3760 File Offset: 0x001F1960
		public unsafe List<string> log
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderLog.NativeFieldInfoPtr_log);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<string>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderLog.NativeFieldInfoPtr_log), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x06007C3B RID: 31803 RVA: 0x001F3788 File Offset: 0x001F1988
		// (set) Token: 0x06007C3C RID: 31804 RVA: 0x001F37B1 File Offset: 0x001F19B1
		public unsafe string _logName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderLog.NativeFieldInfoPtr__logName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderLog.NativeFieldInfoPtr__logName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F85 RID: 20357
		private static readonly IntPtr NativeFieldInfoPtr_log;

		// Token: 0x04004F86 RID: 20358
		private static readonly IntPtr NativeFieldInfoPtr__logName_k__BackingField;

		// Token: 0x04004F87 RID: 20359
		private static readonly IntPtr NativeMethodInfoPtr_get_logName_Public_get_String_0;

		// Token: 0x04004F88 RID: 20360
		private static readonly IntPtr NativeMethodInfoPtr_set_logName_Private_set_Void_String_0;

		// Token: 0x04004F89 RID: 20361
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04004F8A RID: 20362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04004F8B RID: 20363
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_0;

		// Token: 0x04004F8C RID: 20364
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04004F8D RID: 20365
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_String_0;

		// Token: 0x04004F8E RID: 20366
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x04004F8F RID: 20367
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_ArrayOf_0;
	}
}
