using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020001AD RID: 429
public class WhiteBalanceController : MonoBehaviour
{
	// Token: 0x17000A3D RID: 2621
	// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0007401C File Offset: 0x0007221C
	// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0007406C File Offset: 0x0007226C
	public unsafe float Transparency
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WhiteBalanceController.NativeMethodInfoPtr_get_Transparency_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteBalanceController.NativeMethodInfoPtr_set_Transparency_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x000740C0 File Offset: 0x000722C0
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteBalanceController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x00074104 File Offset: 0x00072304
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteBalanceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x00074148 File Offset: 0x00072348
	[CallerCount(0)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteBalanceController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x0007418C File Offset: 0x0007238C
	[CallerCount(0)]
	public unsafe WhiteBalanceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteBalanceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x000741D8 File Offset: 0x000723D8
	// Note: this type is marked as 'beforefieldinit'.
	static WhiteBalanceController()
	{
		Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WhiteBalanceController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr);
		WhiteBalanceController.NativeFieldInfoPtr_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, "Mat");
		WhiteBalanceController.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, "Mesh");
		WhiteBalanceController.NativeFieldInfoPtr_ID_SHADER_TRANSPARENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, "ID_SHADER_TRANSPARENCY");
		WhiteBalanceController.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, "Scale");
		WhiteBalanceController.NativeFieldInfoPtr__Transparency_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, "<Transparency>k__BackingField");
		WhiteBalanceController.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, "Distance");
		WhiteBalanceController.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, "layerMask");
		WhiteBalanceController.NativeMethodInfoPtr_get_Transparency_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, 100665588);
		WhiteBalanceController.NativeMethodInfoPtr_set_Transparency_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, 100665589);
		WhiteBalanceController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, 100665590);
		WhiteBalanceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, 100665591);
		WhiteBalanceController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, 100665592);
		WhiteBalanceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr, 100665593);
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x0000210C File Offset: 0x0000030C
	public WhiteBalanceController(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000A35 RID: 2613
	// (get) Token: 0x06001D4B RID: 7499 RVA: 0x0007430C File Offset: 0x0007250C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WhiteBalanceController>.NativeClassPtr));
		}
	}

	// Token: 0x17000A36 RID: 2614
	// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00074320 File Offset: 0x00072520
	// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00074354 File Offset: 0x00072554
	public unsafe Material Mat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr_Mat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Material(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000A37 RID: 2615
	// (get) Token: 0x06001D4E RID: 7502 RVA: 0x0007437C File Offset: 0x0007257C
	// (set) Token: 0x06001D4F RID: 7503 RVA: 0x000743B0 File Offset: 0x000725B0
	public unsafe Mesh Mesh
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr_Mesh);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000A38 RID: 2616
	// (get) Token: 0x06001D50 RID: 7504 RVA: 0x000743D8 File Offset: 0x000725D8
	// (set) Token: 0x06001D51 RID: 7505 RVA: 0x00074400 File Offset: 0x00072600
	public unsafe int ID_SHADER_TRANSPARENCY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr_ID_SHADER_TRANSPARENCY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr_ID_SHADER_TRANSPARENCY)) = value;
		}
	}

	// Token: 0x17000A39 RID: 2617
	// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00074424 File Offset: 0x00072624
	// (set) Token: 0x06001D53 RID: 7507 RVA: 0x00074442 File Offset: 0x00072642
	public unsafe static float Scale
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(WhiteBalanceController.NativeFieldInfoPtr_Scale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WhiteBalanceController.NativeFieldInfoPtr_Scale, (void*)(&value));
		}
	}

	// Token: 0x17000A3A RID: 2618
	// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00074454 File Offset: 0x00072654
	// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0007447C File Offset: 0x0007267C
	public unsafe float _Transparency_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr__Transparency_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr__Transparency_k__BackingField)) = value;
		}
	}

	// Token: 0x17000A3B RID: 2619
	// (get) Token: 0x06001D56 RID: 7510 RVA: 0x000744A0 File Offset: 0x000726A0
	// (set) Token: 0x06001D57 RID: 7511 RVA: 0x000744BE File Offset: 0x000726BE
	public unsafe static float Distance
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(WhiteBalanceController.NativeFieldInfoPtr_Distance, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WhiteBalanceController.NativeFieldInfoPtr_Distance, (void*)(&value));
		}
	}

	// Token: 0x17000A3C RID: 2620
	// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000744D0 File Offset: 0x000726D0
	// (set) Token: 0x06001D59 RID: 7513 RVA: 0x000744F8 File Offset: 0x000726F8
	public unsafe int layerMask
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr_layerMask);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteBalanceController.NativeFieldInfoPtr_layerMask)) = value;
		}
	}

	// Token: 0x040012AF RID: 4783
	private static readonly IntPtr NativeFieldInfoPtr_Mat;

	// Token: 0x040012B0 RID: 4784
	private static readonly IntPtr NativeFieldInfoPtr_Mesh;

	// Token: 0x040012B1 RID: 4785
	private static readonly IntPtr NativeFieldInfoPtr_ID_SHADER_TRANSPARENCY;

	// Token: 0x040012B2 RID: 4786
	private static readonly IntPtr NativeFieldInfoPtr_Scale;

	// Token: 0x040012B3 RID: 4787
	private static readonly IntPtr NativeFieldInfoPtr__Transparency_k__BackingField;

	// Token: 0x040012B4 RID: 4788
	private static readonly IntPtr NativeFieldInfoPtr_Distance;

	// Token: 0x040012B5 RID: 4789
	private static readonly IntPtr NativeFieldInfoPtr_layerMask;

	// Token: 0x040012B6 RID: 4790
	private static readonly IntPtr NativeMethodInfoPtr_get_Transparency_Public_get_Single_0;

	// Token: 0x040012B7 RID: 4791
	private static readonly IntPtr NativeMethodInfoPtr_set_Transparency_Public_set_Void_Single_0;

	// Token: 0x040012B8 RID: 4792
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040012B9 RID: 4793
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040012BA RID: 4794
	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	// Token: 0x040012BB RID: 4795
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
