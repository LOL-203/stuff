using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000385 RID: 901
public class Billboard : MonoBehaviour
{
	// Token: 0x06004765 RID: 18277 RVA: 0x0011E698 File Offset: 0x0011C898
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Billboard.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004766 RID: 18278 RVA: 0x0011E6DC File Offset: 0x0011C8DC
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Billboard.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004767 RID: 18279 RVA: 0x0011E720 File Offset: 0x0011C920
	[CallerCount(0)]
	public unsafe Billboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Billboard>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Billboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004768 RID: 18280 RVA: 0x0011E76C File Offset: 0x0011C96C
	// Note: this type is marked as 'beforefieldinit'.
	static Billboard()
	{
		Il2CppClassPointerStore<Billboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Billboard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Billboard>.NativeClassPtr);
		Billboard.NativeFieldInfoPtr_LookAtCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "LookAtCam");
		Billboard.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "active");
		Billboard.NativeFieldInfoPtr_maintainScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "maintainScale");
		Billboard.NativeFieldInfoPtr_angledBillboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "angledBillboard");
		Billboard.NativeFieldInfoPtr_scaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "scaleMultiplier");
		Billboard.NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "maxScale");
		Billboard.NativeFieldInfoPtr_RandomRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "RandomRotate");
		Billboard.NativeFieldInfoPtr_scalar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "scalar");
		Billboard.NativeFieldInfoPtr_originalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "originalScale");
		Billboard.NativeFieldInfoPtr_RndRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "RndRotate");
		Billboard.NativeFieldInfoPtr_originalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "originalRotation");
		Billboard.NativeFieldInfoPtr_originalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "originalFOV");
		Billboard.NativeFieldInfoPtr_FOVmultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Billboard>.NativeClassPtr, "FOVmultiplier");
		Billboard.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billboard>.NativeClassPtr, 100668923);
		Billboard.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billboard>.NativeClassPtr, 100668924);
		Billboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Billboard>.NativeClassPtr, 100668925);
	}

	// Token: 0x06004769 RID: 18281 RVA: 0x0000210C File Offset: 0x0000030C
	public Billboard(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700196B RID: 6507
	// (get) Token: 0x0600476A RID: 18282 RVA: 0x0011E8DC File Offset: 0x0011CADC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Billboard>.NativeClassPtr));
		}
	}

	// Token: 0x1700196C RID: 6508
	// (get) Token: 0x0600476B RID: 18283 RVA: 0x0011E8F0 File Offset: 0x0011CAF0
	// (set) Token: 0x0600476C RID: 18284 RVA: 0x0011E924 File Offset: 0x0011CB24
	public unsafe Camera LookAtCam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_LookAtCam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_LookAtCam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700196D RID: 6509
	// (get) Token: 0x0600476D RID: 18285 RVA: 0x0011E94C File Offset: 0x0011CB4C
	// (set) Token: 0x0600476E RID: 18286 RVA: 0x0011E974 File Offset: 0x0011CB74
	public unsafe bool active
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_active);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_active)) = value;
		}
	}

	// Token: 0x1700196E RID: 6510
	// (get) Token: 0x0600476F RID: 18287 RVA: 0x0011E998 File Offset: 0x0011CB98
	// (set) Token: 0x06004770 RID: 18288 RVA: 0x0011E9C0 File Offset: 0x0011CBC0
	public unsafe bool maintainScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_maintainScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_maintainScale)) = value;
		}
	}

	// Token: 0x1700196F RID: 6511
	// (get) Token: 0x06004771 RID: 18289 RVA: 0x0011E9E4 File Offset: 0x0011CBE4
	// (set) Token: 0x06004772 RID: 18290 RVA: 0x0011EA0C File Offset: 0x0011CC0C
	public unsafe bool angledBillboard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_angledBillboard);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_angledBillboard)) = value;
		}
	}

	// Token: 0x17001970 RID: 6512
	// (get) Token: 0x06004773 RID: 18291 RVA: 0x0011EA30 File Offset: 0x0011CC30
	// (set) Token: 0x06004774 RID: 18292 RVA: 0x0011EA58 File Offset: 0x0011CC58
	public unsafe float scaleMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_scaleMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_scaleMultiplier)) = value;
		}
	}

	// Token: 0x17001971 RID: 6513
	// (get) Token: 0x06004775 RID: 18293 RVA: 0x0011EA7C File Offset: 0x0011CC7C
	// (set) Token: 0x06004776 RID: 18294 RVA: 0x0011EAA4 File Offset: 0x0011CCA4
	public unsafe float maxScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_maxScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_maxScale)) = value;
		}
	}

	// Token: 0x17001972 RID: 6514
	// (get) Token: 0x06004777 RID: 18295 RVA: 0x0011EAC8 File Offset: 0x0011CCC8
	// (set) Token: 0x06004778 RID: 18296 RVA: 0x0011EAF0 File Offset: 0x0011CCF0
	public unsafe float RandomRotate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_RandomRotate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_RandomRotate)) = value;
		}
	}

	// Token: 0x17001973 RID: 6515
	// (get) Token: 0x06004779 RID: 18297 RVA: 0x0011EB14 File Offset: 0x0011CD14
	// (set) Token: 0x0600477A RID: 18298 RVA: 0x0011EB3C File Offset: 0x0011CD3C
	public unsafe float scalar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_scalar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_scalar)) = value;
		}
	}

	// Token: 0x17001974 RID: 6516
	// (get) Token: 0x0600477B RID: 18299 RVA: 0x0011EB60 File Offset: 0x0011CD60
	// (set) Token: 0x0600477C RID: 18300 RVA: 0x0011EB88 File Offset: 0x0011CD88
	public unsafe Vector3 originalScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_originalScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_originalScale)) = value;
		}
	}

	// Token: 0x17001975 RID: 6517
	// (get) Token: 0x0600477D RID: 18301 RVA: 0x0011EBAC File Offset: 0x0011CDAC
	// (set) Token: 0x0600477E RID: 18302 RVA: 0x0011EBD4 File Offset: 0x0011CDD4
	public unsafe float RndRotate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_RndRotate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_RndRotate)) = value;
		}
	}

	// Token: 0x17001976 RID: 6518
	// (get) Token: 0x0600477F RID: 18303 RVA: 0x0011EBF8 File Offset: 0x0011CDF8
	// (set) Token: 0x06004780 RID: 18304 RVA: 0x0011EC20 File Offset: 0x0011CE20
	public unsafe Quaternion originalRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_originalRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_originalRotation)) = value;
		}
	}

	// Token: 0x17001977 RID: 6519
	// (get) Token: 0x06004781 RID: 18305 RVA: 0x0011EC44 File Offset: 0x0011CE44
	// (set) Token: 0x06004782 RID: 18306 RVA: 0x0011EC6C File Offset: 0x0011CE6C
	public unsafe float originalFOV
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_originalFOV);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_originalFOV)) = value;
		}
	}

	// Token: 0x17001978 RID: 6520
	// (get) Token: 0x06004783 RID: 18307 RVA: 0x0011EC90 File Offset: 0x0011CE90
	// (set) Token: 0x06004784 RID: 18308 RVA: 0x0011ECB8 File Offset: 0x0011CEB8
	public unsafe float FOVmultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_FOVmultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Billboard.NativeFieldInfoPtr_FOVmultiplier)) = value;
		}
	}

	// Token: 0x04002D80 RID: 11648
	private static readonly IntPtr NativeFieldInfoPtr_LookAtCam;

	// Token: 0x04002D81 RID: 11649
	private static readonly IntPtr NativeFieldInfoPtr_active;

	// Token: 0x04002D82 RID: 11650
	private static readonly IntPtr NativeFieldInfoPtr_maintainScale;

	// Token: 0x04002D83 RID: 11651
	private static readonly IntPtr NativeFieldInfoPtr_angledBillboard;

	// Token: 0x04002D84 RID: 11652
	private static readonly IntPtr NativeFieldInfoPtr_scaleMultiplier;

	// Token: 0x04002D85 RID: 11653
	private static readonly IntPtr NativeFieldInfoPtr_maxScale;

	// Token: 0x04002D86 RID: 11654
	private static readonly IntPtr NativeFieldInfoPtr_RandomRotate;

	// Token: 0x04002D87 RID: 11655
	private static readonly IntPtr NativeFieldInfoPtr_scalar;

	// Token: 0x04002D88 RID: 11656
	private static readonly IntPtr NativeFieldInfoPtr_originalScale;

	// Token: 0x04002D89 RID: 11657
	private static readonly IntPtr NativeFieldInfoPtr_RndRotate;

	// Token: 0x04002D8A RID: 11658
	private static readonly IntPtr NativeFieldInfoPtr_originalRotation;

	// Token: 0x04002D8B RID: 11659
	private static readonly IntPtr NativeFieldInfoPtr_originalFOV;

	// Token: 0x04002D8C RID: 11660
	private static readonly IntPtr NativeFieldInfoPtr_FOVmultiplier;

	// Token: 0x04002D8D RID: 11661
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04002D8E RID: 11662
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04002D8F RID: 11663
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
