using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sigtrap.Editors.ShaderStripper
{
	// Token: 0x02000607 RID: 1543
	public class ShaderStripperVariantCollection : ShaderStripperBase
	{
		// Token: 0x06007C71 RID: 31857 RVA: 0x001F4190 File Offset: 0x001F2390
		[CallerCount(0)]
		public unsafe void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderStripperVariantCollection.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x001F41D4 File Offset: 0x001F23D4
		[CallerCount(0)]
		public unsafe void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderStripperVariantCollection.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x001F4218 File Offset: 0x001F2418
		[CallerCount(0)]
		public unsafe ShaderStripperVariantCollection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderStripperVariantCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x001F4264 File Offset: 0x001F2464
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderStripperVariantCollection()
		{
			Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Sigtrap.Editors.ShaderStripper", "ShaderStripperVariantCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr);
			ShaderStripperVariantCollection.NativeFieldInfoPtr__mergeToFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_mergeToFile");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__whitelistedCollections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_whitelistedCollections");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__collectionPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_collectionPaths");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__stripHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_stripHidden");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__allowVrVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_allowVrVariants");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__allowInstancedVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_allowInstancedVariants");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__ignoreShadersByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_ignoreShadersByName");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__ignorePassTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_ignorePassTypes");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_valid");
			ShaderStripperVariantCollection.NativeFieldInfoPtr__dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, "_dirty");
			ShaderStripperVariantCollection.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, 100673228);
			ShaderStripperVariantCollection.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, 100673229);
			ShaderStripperVariantCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr, 100673230);
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x001F2F7C File Offset: 0x001F117C
		public ShaderStripperVariantCollection(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x06007C76 RID: 31862 RVA: 0x001F4398 File Offset: 0x001F2598
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderStripperVariantCollection>.NativeClassPtr));
			}
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x001F43AC File Offset: 0x001F25AC
		// (set) Token: 0x06007C78 RID: 31864 RVA: 0x001F43D5 File Offset: 0x001F25D5
		public unsafe string _mergeToFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__mergeToFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__mergeToFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x001F43FC File Offset: 0x001F25FC
		// (set) Token: 0x06007C7A RID: 31866 RVA: 0x001F4430 File Offset: 0x001F2630
		public unsafe List<ShaderVariantCollection> _whitelistedCollections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__whitelistedCollections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<ShaderVariantCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__whitelistedCollections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x001F4458 File Offset: 0x001F2658
		// (set) Token: 0x06007C7C RID: 31868 RVA: 0x001F448C File Offset: 0x001F268C
		public unsafe List<string> _collectionPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__collectionPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<string>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__collectionPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x001F44B4 File Offset: 0x001F26B4
		// (set) Token: 0x06007C7E RID: 31870 RVA: 0x001F44DC File Offset: 0x001F26DC
		public unsafe bool _stripHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__stripHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__stripHidden)) = value;
			}
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x06007C7F RID: 31871 RVA: 0x001F4500 File Offset: 0x001F2700
		// (set) Token: 0x06007C80 RID: 31872 RVA: 0x001F4528 File Offset: 0x001F2728
		public unsafe bool _allowVrVariants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__allowVrVariants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__allowVrVariants)) = value;
			}
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x06007C81 RID: 31873 RVA: 0x001F454C File Offset: 0x001F274C
		// (set) Token: 0x06007C82 RID: 31874 RVA: 0x001F4574 File Offset: 0x001F2774
		public unsafe bool _allowInstancedVariants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__allowInstancedVariants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__allowInstancedVariants)) = value;
			}
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x06007C83 RID: 31875 RVA: 0x001F4598 File Offset: 0x001F2798
		// (set) Token: 0x06007C84 RID: 31876 RVA: 0x001F45CC File Offset: 0x001F27CC
		public unsafe Il2CppReferenceArray<ShaderStripperBase.StringMatch> _ignoreShadersByName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__ignoreShadersByName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ShaderStripperBase.StringMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__ignoreShadersByName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x06007C85 RID: 31877 RVA: 0x001F45F4 File Offset: 0x001F27F4
		// (set) Token: 0x06007C86 RID: 31878 RVA: 0x001F4628 File Offset: 0x001F2828
		public unsafe List<PassType> _ignorePassTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__ignorePassTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<PassType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__ignorePassTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x06007C87 RID: 31879 RVA: 0x001F4650 File Offset: 0x001F2850
		// (set) Token: 0x06007C88 RID: 31880 RVA: 0x001F4678 File Offset: 0x001F2878
		public unsafe bool _valid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__valid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__valid)) = value;
			}
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x001F469C File Offset: 0x001F289C
		// (set) Token: 0x06007C8A RID: 31882 RVA: 0x001F46C4 File Offset: 0x001F28C4
		public unsafe bool _dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperVariantCollection.NativeFieldInfoPtr__dirty)) = value;
			}
		}

		// Token: 0x04004FAA RID: 20394
		private static readonly IntPtr NativeFieldInfoPtr__mergeToFile;

		// Token: 0x04004FAB RID: 20395
		private static readonly IntPtr NativeFieldInfoPtr__whitelistedCollections;

		// Token: 0x04004FAC RID: 20396
		private static readonly IntPtr NativeFieldInfoPtr__collectionPaths;

		// Token: 0x04004FAD RID: 20397
		private static readonly IntPtr NativeFieldInfoPtr__stripHidden;

		// Token: 0x04004FAE RID: 20398
		private static readonly IntPtr NativeFieldInfoPtr__allowVrVariants;

		// Token: 0x04004FAF RID: 20399
		private static readonly IntPtr NativeFieldInfoPtr__allowInstancedVariants;

		// Token: 0x04004FB0 RID: 20400
		private static readonly IntPtr NativeFieldInfoPtr__ignoreShadersByName;

		// Token: 0x04004FB1 RID: 20401
		private static readonly IntPtr NativeFieldInfoPtr__ignorePassTypes;

		// Token: 0x04004FB2 RID: 20402
		private static readonly IntPtr NativeFieldInfoPtr__valid;

		// Token: 0x04004FB3 RID: 20403
		private static readonly IntPtr NativeFieldInfoPtr__dirty;

		// Token: 0x04004FB4 RID: 20404
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04004FB5 RID: 20405
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04004FB6 RID: 20406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
