using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Sigtrap.Editors.ShaderStripper
{
	// Token: 0x02000601 RID: 1537
	public class ShaderStripperBase : ScriptableObject
	{
		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x06007C3D RID: 31805 RVA: 0x001F37D8 File Offset: 0x001F19D8
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShaderStripperBase.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x001F3828 File Offset: 0x001F1A28
		[CallerCount(0)]
		public unsafe ShaderStripperBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderStripperBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x001F3874 File Offset: 0x001F1A74
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderStripperBase()
		{
			Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Sigtrap.Editors.ShaderStripper", "ShaderStripperBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr);
			ShaderStripperBase.NativeFieldInfoPtr__expanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr, "_expanded");
			ShaderStripperBase.NativeFieldInfoPtr__order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr, "_order");
			ShaderStripperBase.NativeFieldInfoPtr__active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr, "_active");
			ShaderStripperBase.NativeFieldInfoPtr__notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr, "_notes");
			ShaderStripperBase.NativeFieldInfoPtr__logOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr, "_logOutput");
			ShaderStripperBase.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr, 100673221);
			ShaderStripperBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr, 100673222);
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		public ShaderStripperBase(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x06007C41 RID: 31809 RVA: 0x001F3930 File Offset: 0x001F1B30
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr));
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x06007C42 RID: 31810 RVA: 0x001F3944 File Offset: 0x001F1B44
		// (set) Token: 0x06007C43 RID: 31811 RVA: 0x001F396C File Offset: 0x001F1B6C
		public unsafe bool _expanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__expanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__expanded)) = value;
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x06007C44 RID: 31812 RVA: 0x001F3990 File Offset: 0x001F1B90
		// (set) Token: 0x06007C45 RID: 31813 RVA: 0x001F39B8 File Offset: 0x001F1BB8
		public unsafe int _order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__order)) = value;
			}
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x06007C46 RID: 31814 RVA: 0x001F39DC File Offset: 0x001F1BDC
		// (set) Token: 0x06007C47 RID: 31815 RVA: 0x001F3A04 File Offset: 0x001F1C04
		public unsafe bool _active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__active)) = value;
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x06007C48 RID: 31816 RVA: 0x001F3A28 File Offset: 0x001F1C28
		// (set) Token: 0x06007C49 RID: 31817 RVA: 0x001F3A51 File Offset: 0x001F1C51
		public unsafe string _notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__notes);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__notes), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x06007C4A RID: 31818 RVA: 0x001F3A78 File Offset: 0x001F1C78
		// (set) Token: 0x06007C4B RID: 31819 RVA: 0x001F3AA0 File Offset: 0x001F1CA0
		public unsafe bool _logOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__logOutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.NativeFieldInfoPtr__logOutput)) = value;
			}
		}

		// Token: 0x04004F90 RID: 20368
		private static readonly IntPtr NativeFieldInfoPtr__expanded;

		// Token: 0x04004F91 RID: 20369
		private static readonly IntPtr NativeFieldInfoPtr__order;

		// Token: 0x04004F92 RID: 20370
		private static readonly IntPtr NativeFieldInfoPtr__active;

		// Token: 0x04004F93 RID: 20371
		private static readonly IntPtr NativeFieldInfoPtr__notes;

		// Token: 0x04004F94 RID: 20372
		private static readonly IntPtr NativeFieldInfoPtr__logOutput;

		// Token: 0x04004F95 RID: 20373
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04004F96 RID: 20374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000602 RID: 1538
		[Serializable]
		public class StringMatch : Il2CppSystem.Object
		{
			// Token: 0x06007C4C RID: 31820 RVA: 0x001F3AC4 File Offset: 0x001F1CC4
			[CallerCount(0)]
			public unsafe bool Evaluate(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShaderStripperBase.StringMatch.NativeMethodInfoPtr_Evaluate_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007C4D RID: 31821 RVA: 0x001F3B2C File Offset: 0x001F1D2C
			[CallerCount(0)]
			public unsafe StringMatch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderStripperBase.StringMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007C4E RID: 31822 RVA: 0x001F3B78 File Offset: 0x001F1D78
			// Note: this type is marked as 'beforefieldinit'.
			static StringMatch()
			{
				Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderStripperBase>.NativeClassPtr, "StringMatch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr);
				ShaderStripperBase.StringMatch.NativeFieldInfoPtr_matchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr, "matchType");
				ShaderStripperBase.StringMatch.NativeFieldInfoPtr_namePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr, "namePattern");
				ShaderStripperBase.StringMatch.NativeFieldInfoPtr_caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr, "caseInsensitive");
				ShaderStripperBase.StringMatch.NativeMethodInfoPtr_Evaluate_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr, 100673223);
				ShaderStripperBase.StringMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr, 100673224);
			}

			// Token: 0x06007C4F RID: 31823 RVA: 0x00002988 File Offset: 0x00000B88
			public StringMatch(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002C94 RID: 11412
			// (get) Token: 0x06007C50 RID: 31824 RVA: 0x001F3C07 File Offset: 0x001F1E07
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderStripperBase.StringMatch>.NativeClassPtr));
				}
			}

			// Token: 0x17002C95 RID: 11413
			// (get) Token: 0x06007C51 RID: 31825 RVA: 0x001F3C18 File Offset: 0x001F1E18
			// (set) Token: 0x06007C52 RID: 31826 RVA: 0x001F3C40 File Offset: 0x001F1E40
			public unsafe ShaderStripperBase.StringMatch.MatchType matchType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.StringMatch.NativeFieldInfoPtr_matchType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.StringMatch.NativeFieldInfoPtr_matchType)) = value;
				}
			}

			// Token: 0x17002C96 RID: 11414
			// (get) Token: 0x06007C53 RID: 31827 RVA: 0x001F3C64 File Offset: 0x001F1E64
			// (set) Token: 0x06007C54 RID: 31828 RVA: 0x001F3C8D File Offset: 0x001F1E8D
			public unsafe string namePattern
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.StringMatch.NativeFieldInfoPtr_namePattern);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.StringMatch.NativeFieldInfoPtr_namePattern), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002C97 RID: 11415
			// (get) Token: 0x06007C55 RID: 31829 RVA: 0x001F3CB4 File Offset: 0x001F1EB4
			// (set) Token: 0x06007C56 RID: 31830 RVA: 0x001F3CDC File Offset: 0x001F1EDC
			public unsafe bool caseInsensitive
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.StringMatch.NativeFieldInfoPtr_caseInsensitive);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperBase.StringMatch.NativeFieldInfoPtr_caseInsensitive)) = value;
				}
			}

			// Token: 0x04004F97 RID: 20375
			private static readonly IntPtr NativeFieldInfoPtr_matchType;

			// Token: 0x04004F98 RID: 20376
			private static readonly IntPtr NativeFieldInfoPtr_namePattern;

			// Token: 0x04004F99 RID: 20377
			private static readonly IntPtr NativeFieldInfoPtr_caseInsensitive;

			// Token: 0x04004F9A RID: 20378
			private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_String_0;

			// Token: 0x04004F9B RID: 20379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000603 RID: 1539
			public enum MatchType
			{
				// Token: 0x04004F9D RID: 20381
				EQUALS,
				// Token: 0x04004F9E RID: 20382
				CONTAINS,
				// Token: 0x04004F9F RID: 20383
				STARTSWITH,
				// Token: 0x04004FA0 RID: 20384
				ENDSWITH
			}
		}
	}
}
