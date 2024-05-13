using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace DPI.Networking.IO
{
	// Token: 0x0200127B RID: 4731
	public static class CodeGenRpcSig : Object
	{
		// Token: 0x06015850 RID: 88144 RVA: 0x0056BFB1 File Offset: 0x0056A1B1
		// Note: this type is marked as 'beforefieldinit'.
		static CodeGenRpcSig()
		{
			Il2CppClassPointerStore<CodeGenRpcSig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "CodeGenRpcSig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeGenRpcSig>.NativeClassPtr);
			CodeGenRpcSig.NativeFieldInfoPtr_CodeGenSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeGenRpcSig>.NativeClassPtr, "CodeGenSignature");
		}

		// Token: 0x06015851 RID: 88145 RVA: 0x00002988 File Offset: 0x00000B88
		public CodeGenRpcSig(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17007942 RID: 31042
		// (get) Token: 0x06015852 RID: 88146 RVA: 0x0056BFEA File Offset: 0x0056A1EA
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CodeGenRpcSig>.NativeClassPtr));
			}
		}

		// Token: 0x17007943 RID: 31043
		// (get) Token: 0x06015853 RID: 88147 RVA: 0x0056BFFC File Offset: 0x0056A1FC
		// (set) Token: 0x06015854 RID: 88148 RVA: 0x0056C01C File Offset: 0x0056A21C
		public unsafe static string CodeGenSignature
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(CodeGenRpcSig.NativeFieldInfoPtr_CodeGenSignature, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodeGenRpcSig.NativeFieldInfoPtr_CodeGenSignature, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400DCC5 RID: 56517
		private static readonly IntPtr NativeFieldInfoPtr_CodeGenSignature;
	}
}
