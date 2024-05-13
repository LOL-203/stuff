using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace DPI.Networking.IO
{
	// Token: 0x0200127C RID: 4732
	public static class CodeGenEnumsSig : Object
	{
		// Token: 0x06015855 RID: 88149 RVA: 0x0056C031 File Offset: 0x0056A231
		// Note: this type is marked as 'beforefieldinit'.
		static CodeGenEnumsSig()
		{
			Il2CppClassPointerStore<CodeGenEnumsSig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "CodeGenEnumsSig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeGenEnumsSig>.NativeClassPtr);
			CodeGenEnumsSig.NativeFieldInfoPtr_CodeGenSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeGenEnumsSig>.NativeClassPtr, "CodeGenSignature");
		}

		// Token: 0x06015856 RID: 88150 RVA: 0x00002988 File Offset: 0x00000B88
		public CodeGenEnumsSig(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17007944 RID: 31044
		// (get) Token: 0x06015857 RID: 88151 RVA: 0x0056C06A File Offset: 0x0056A26A
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CodeGenEnumsSig>.NativeClassPtr));
			}
		}

		// Token: 0x17007945 RID: 31045
		// (get) Token: 0x06015858 RID: 88152 RVA: 0x0056C07C File Offset: 0x0056A27C
		// (set) Token: 0x06015859 RID: 88153 RVA: 0x0056C09C File Offset: 0x0056A29C
		public unsafe static string CodeGenSignature
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(CodeGenEnumsSig.NativeFieldInfoPtr_CodeGenSignature, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodeGenEnumsSig.NativeFieldInfoPtr_CodeGenSignature, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400DCC6 RID: 56518
		private static readonly IntPtr NativeFieldInfoPtr_CodeGenSignature;
	}
}
