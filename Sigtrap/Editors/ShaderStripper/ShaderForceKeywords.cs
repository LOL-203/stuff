using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.Rendering;

namespace Sigtrap.Editors.ShaderStripper
{
	// Token: 0x020005FD RID: 1533
	public class ShaderForceKeywords : ShaderStripperBase
	{
		// Token: 0x06007C16 RID: 31766 RVA: 0x001F2EC4 File Offset: 0x001F10C4
		[CallerCount(0)]
		public unsafe ShaderForceKeywords() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderForceKeywords.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x001F2F10 File Offset: 0x001F1110
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderForceKeywords()
		{
			Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Sigtrap.Editors.ShaderStripper", "ShaderForceKeywords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr);
			ShaderForceKeywords.NativeFieldInfoPtr__forceBuiltins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr, "_forceBuiltins");
			ShaderForceKeywords.NativeFieldInfoPtr__forceKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr, "_forceKeywords");
			ShaderForceKeywords.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr, 100673211);
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x001F2F7C File Offset: 0x001F117C
		public ShaderForceKeywords(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x06007C19 RID: 31769 RVA: 0x001F2F85 File Offset: 0x001F1185
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr));
			}
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x06007C1A RID: 31770 RVA: 0x001F2F98 File Offset: 0x001F1198
		// (set) Token: 0x06007C1B RID: 31771 RVA: 0x001F2FCC File Offset: 0x001F11CC
		public unsafe Il2CppStructArray<ShaderForceKeywords.ForceBuiltin> _forceBuiltins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.NativeFieldInfoPtr__forceBuiltins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<ShaderForceKeywords.ForceBuiltin>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.NativeFieldInfoPtr__forceBuiltins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x06007C1C RID: 31772 RVA: 0x001F2FF4 File Offset: 0x001F11F4
		// (set) Token: 0x06007C1D RID: 31773 RVA: 0x001F3028 File Offset: 0x001F1228
		public unsafe Il2CppReferenceArray<ShaderForceKeywords.ForceKeyword> _forceKeywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.NativeFieldInfoPtr__forceKeywords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ShaderForceKeywords.ForceKeyword>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.NativeFieldInfoPtr__forceKeywords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F76 RID: 20342
		private static readonly IntPtr NativeFieldInfoPtr__forceBuiltins;

		// Token: 0x04004F77 RID: 20343
		private static readonly IntPtr NativeFieldInfoPtr__forceKeywords;

		// Token: 0x04004F78 RID: 20344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005FE RID: 1534
		[Serializable]
		[StructLayout(2)]
		public struct ForceBuiltin
		{
			// Token: 0x06007C1E RID: 31774 RVA: 0x001F3050 File Offset: 0x001F1250
			// Note: this type is marked as 'beforefieldinit'.
			static ForceBuiltin()
			{
				Il2CppClassPointerStore<ShaderForceKeywords.ForceBuiltin>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr, "ForceBuiltin");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderForceKeywords.ForceBuiltin>.NativeClassPtr);
				ShaderForceKeywords.ForceBuiltin.NativeFieldInfoPtr_defineToMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords.ForceBuiltin>.NativeClassPtr, "defineToMatch");
				ShaderForceKeywords.ForceBuiltin.NativeFieldInfoPtr_defineToForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords.ForceBuiltin>.NativeClassPtr, "defineToForce");
				ShaderForceKeywords.ForceBuiltin.NativeFieldInfoPtr_invertMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords.ForceBuiltin>.NativeClassPtr, "invertMatch");
				ShaderForceKeywords.ForceBuiltin.NativeFieldInfoPtr_invertForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords.ForceBuiltin>.NativeClassPtr, "invertForce");
			}

			// Token: 0x06007C1F RID: 31775 RVA: 0x001F30CB File Offset: 0x001F12CB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderForceKeywords.ForceBuiltin>.NativeClassPtr, ref this));
			}

			// Token: 0x17002C82 RID: 11394
			// (get) Token: 0x06007C20 RID: 31776 RVA: 0x001F30DD File Offset: 0x001F12DD
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderForceKeywords.ForceBuiltin>.NativeClassPtr));
				}
			}

			// Token: 0x04004F79 RID: 20345
			private static readonly IntPtr NativeFieldInfoPtr_defineToMatch;

			// Token: 0x04004F7A RID: 20346
			private static readonly IntPtr NativeFieldInfoPtr_defineToForce;

			// Token: 0x04004F7B RID: 20347
			private static readonly IntPtr NativeFieldInfoPtr_invertMatch;

			// Token: 0x04004F7C RID: 20348
			private static readonly IntPtr NativeFieldInfoPtr_invertForce;

			// Token: 0x04004F7D RID: 20349
			[FieldOffset(0)]
			public BuiltinShaderDefine defineToMatch;

			// Token: 0x04004F7E RID: 20350
			[FieldOffset(4)]
			public BuiltinShaderDefine defineToForce;

			// Token: 0x04004F7F RID: 20351
			[FieldOffset(8)]
			public bool invertMatch;

			// Token: 0x04004F80 RID: 20352
			[FieldOffset(9)]
			public bool invertForce;
		}

		// Token: 0x020005FF RID: 1535
		[Serializable]
		[StructLayout(0)]
		public sealed class ForceKeyword : ValueType
		{
			// Token: 0x06007C21 RID: 31777 RVA: 0x001F30F0 File Offset: 0x001F12F0
			// Note: this type is marked as 'beforefieldinit'.
			static ForceKeyword()
			{
				Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderForceKeywords>.NativeClassPtr, "ForceKeyword");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr);
				ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_keywordToMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr, "keywordToMatch");
				ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_keywordToForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr, "keywordToForce");
				ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_invertMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr, "invertMatch");
				ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_invertForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr, "invertForce");
			}

			// Token: 0x06007C22 RID: 31778 RVA: 0x0002717B File Offset: 0x0002537B
			public ForceKeyword(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002C83 RID: 11395
			// (get) Token: 0x06007C23 RID: 31779 RVA: 0x001F316B File Offset: 0x001F136B
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr));
				}
			}

			// Token: 0x06007C24 RID: 31780 RVA: 0x001F317C File Offset: 0x001F137C
			public unsafe ForceKeyword()
			{
				IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr, (UIntPtr)0)];
				base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderForceKeywords.ForceKeyword>.NativeClassPtr, data));
			}

			// Token: 0x17002C84 RID: 11396
			// (get) Token: 0x06007C25 RID: 31781 RVA: 0x001F31AC File Offset: 0x001F13AC
			// (set) Token: 0x06007C26 RID: 31782 RVA: 0x001F31D5 File Offset: 0x001F13D5
			public unsafe string keywordToMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_keywordToMatch);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_keywordToMatch), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002C85 RID: 11397
			// (get) Token: 0x06007C27 RID: 31783 RVA: 0x001F31FC File Offset: 0x001F13FC
			// (set) Token: 0x06007C28 RID: 31784 RVA: 0x001F3225 File Offset: 0x001F1425
			public unsafe string keywordToForce
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_keywordToForce);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_keywordToForce), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002C86 RID: 11398
			// (get) Token: 0x06007C29 RID: 31785 RVA: 0x001F324C File Offset: 0x001F144C
			// (set) Token: 0x06007C2A RID: 31786 RVA: 0x001F3274 File Offset: 0x001F1474
			public unsafe bool invertMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_invertMatch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_invertMatch)) = value;
				}
			}

			// Token: 0x17002C87 RID: 11399
			// (get) Token: 0x06007C2B RID: 31787 RVA: 0x001F3298 File Offset: 0x001F1498
			// (set) Token: 0x06007C2C RID: 31788 RVA: 0x001F32C0 File Offset: 0x001F14C0
			public unsafe bool invertForce
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_invertForce);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderForceKeywords.ForceKeyword.NativeFieldInfoPtr_invertForce)) = value;
				}
			}

			// Token: 0x04004F81 RID: 20353
			private static readonly IntPtr NativeFieldInfoPtr_keywordToMatch;

			// Token: 0x04004F82 RID: 20354
			private static readonly IntPtr NativeFieldInfoPtr_keywordToForce;

			// Token: 0x04004F83 RID: 20355
			private static readonly IntPtr NativeFieldInfoPtr_invertMatch;

			// Token: 0x04004F84 RID: 20356
			private static readonly IntPtr NativeFieldInfoPtr_invertForce;
		}
	}
}
