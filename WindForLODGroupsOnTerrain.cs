using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020001D7 RID: 471
public class WindForLODGroupsOnTerrain : MonoBehaviour
{
	// Token: 0x060021CD RID: 8653 RVA: 0x00084C38 File Offset: 0x00082E38
	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindForLODGroupsOnTerrain.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x00084C7C File Offset: 0x00082E7C
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindForLODGroupsOnTerrain.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x00084CC0 File Offset: 0x00082EC0
	[CallerCount(0)]
	public unsafe WindForLODGroupsOnTerrain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindForLODGroupsOnTerrain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x00084D0C File Offset: 0x00082F0C
	// Note: this type is marked as 'beforefieldinit'.
	static WindForLODGroupsOnTerrain()
	{
		Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WindForLODGroupsOnTerrain");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr);
		WindForLODGroupsOnTerrain.NativeFieldInfoPtr_m_WindZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, "m_WindZone");
		WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, "WindDirection");
		WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, "WindStrength");
		WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindTurbulence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, "WindTurbulence");
		WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, "WindMultiplier");
		WindForLODGroupsOnTerrain.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, "init");
		WindForLODGroupsOnTerrain.NativeFieldInfoPtr_TerrainLODWindPID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, "TerrainLODWindPID");
		WindForLODGroupsOnTerrain.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, 100665866);
		WindForLODGroupsOnTerrain.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, 100665867);
		WindForLODGroupsOnTerrain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr, 100665868);
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x0000210C File Offset: 0x0000030C
	public WindForLODGroupsOnTerrain(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000BED RID: 3053
	// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00084E04 File Offset: 0x00083004
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WindForLODGroupsOnTerrain>.NativeClassPtr));
		}
	}

	// Token: 0x17000BEE RID: 3054
	// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00084E18 File Offset: 0x00083018
	// (set) Token: 0x060021D4 RID: 8660 RVA: 0x00084E4C File Offset: 0x0008304C
	public unsafe WindZone m_WindZone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_m_WindZone);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WindZone(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_m_WindZone), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000BEF RID: 3055
	// (get) Token: 0x060021D5 RID: 8661 RVA: 0x00084E74 File Offset: 0x00083074
	// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00084E9C File Offset: 0x0008309C
	public unsafe Vector3 WindDirection
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindDirection);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindDirection)) = value;
		}
	}

	// Token: 0x17000BF0 RID: 3056
	// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00084EC0 File Offset: 0x000830C0
	// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00084EE8 File Offset: 0x000830E8
	public unsafe float WindStrength
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindStrength);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindStrength)) = value;
		}
	}

	// Token: 0x17000BF1 RID: 3057
	// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00084F0C File Offset: 0x0008310C
	// (set) Token: 0x060021DA RID: 8666 RVA: 0x00084F34 File Offset: 0x00083134
	public unsafe float WindTurbulence
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindTurbulence);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindTurbulence)) = value;
		}
	}

	// Token: 0x17000BF2 RID: 3058
	// (get) Token: 0x060021DB RID: 8667 RVA: 0x00084F58 File Offset: 0x00083158
	// (set) Token: 0x060021DC RID: 8668 RVA: 0x00084F80 File Offset: 0x00083180
	public unsafe float WindMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_WindMultiplier)) = value;
		}
	}

	// Token: 0x17000BF3 RID: 3059
	// (get) Token: 0x060021DD RID: 8669 RVA: 0x00084FA4 File Offset: 0x000831A4
	// (set) Token: 0x060021DE RID: 8670 RVA: 0x00084FCC File Offset: 0x000831CC
	public unsafe bool init
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_init);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_init)) = value;
		}
	}

	// Token: 0x17000BF4 RID: 3060
	// (get) Token: 0x060021DF RID: 8671 RVA: 0x00084FF0 File Offset: 0x000831F0
	// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00085018 File Offset: 0x00083218
	public unsafe int TerrainLODWindPID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_TerrainLODWindPID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindForLODGroupsOnTerrain.NativeFieldInfoPtr_TerrainLODWindPID)) = value;
		}
	}

	// Token: 0x04001543 RID: 5443
	private static readonly IntPtr NativeFieldInfoPtr_m_WindZone;

	// Token: 0x04001544 RID: 5444
	private static readonly IntPtr NativeFieldInfoPtr_WindDirection;

	// Token: 0x04001545 RID: 5445
	private static readonly IntPtr NativeFieldInfoPtr_WindStrength;

	// Token: 0x04001546 RID: 5446
	private static readonly IntPtr NativeFieldInfoPtr_WindTurbulence;

	// Token: 0x04001547 RID: 5447
	private static readonly IntPtr NativeFieldInfoPtr_WindMultiplier;

	// Token: 0x04001548 RID: 5448
	private static readonly IntPtr NativeFieldInfoPtr_init;

	// Token: 0x04001549 RID: 5449
	private static readonly IntPtr NativeFieldInfoPtr_TerrainLODWindPID;

	// Token: 0x0400154A RID: 5450
	private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	// Token: 0x0400154B RID: 5451
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400154C RID: 5452
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
