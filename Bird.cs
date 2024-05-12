using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020000B6 RID: 182
public class Bird : MonoBehaviour
{
	// Token: 0x06000B7C RID: 2940 RVA: 0x0002F308 File Offset: 0x0002D508
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x0002F34C File Offset: 0x0002D54C
	[CallerCount(0)]
	public unsafe void OnAnimatorMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_OnAnimatorMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x0002F390 File Offset: 0x0002D590
	[CallerCount(0)]
	public unsafe Vector3 GetNewPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr_GetNewPos_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x0002F3E0 File Offset: 0x0002D5E0
	[CallerCount(0)]
	public unsafe Bird() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bird>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bird.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x0002F42C File Offset: 0x0002D62C
	// Note: this type is marked as 'beforefieldinit'.
	static Bird()
	{
		Il2CppClassPointerStore<Bird>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Bird");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bird>.NativeClassPtr);
		Bird.NativeFieldInfoPtr_animCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "animCount");
		Bird.NativeFieldInfoPtr_speedX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "speedX");
		Bird.NativeFieldInfoPtr_speedY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "speedY");
		Bird.NativeFieldInfoPtr_speedZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "speedZ");
		Bird.NativeFieldInfoPtr_amplitudeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "amplitudeX");
		Bird.NativeFieldInfoPtr_amplitudeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "amplitudeY");
		Bird.NativeFieldInfoPtr_amplitudeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "amplitudeZ");
		Bird.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "anim");
		Bird.NativeFieldInfoPtr_canChangeAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "canChangeAnim");
		Bird.NativeFieldInfoPtr_angleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "angleX");
		Bird.NativeFieldInfoPtr_angleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "angleY");
		Bird.NativeFieldInfoPtr_angleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "angleZ");
		Bird.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bird>.NativeClassPtr, "lastPosition");
		Bird.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664201);
		Bird.NativeMethodInfoPtr_OnAnimatorMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664202);
		Bird.NativeMethodInfoPtr_GetNewPos_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664203);
		Bird.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bird>.NativeClassPtr, 100664204);
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x0000210C File Offset: 0x0000030C
	public Bird(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Bird>.NativeClassPtr));
		}
	}

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0002F5C4 File Offset: 0x0002D7C4
	// (set) Token: 0x06000B84 RID: 2948 RVA: 0x0002F5EC File Offset: 0x0002D7EC
	public unsafe int animCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_animCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_animCount)) = value;
		}
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0002F610 File Offset: 0x0002D810
	// (set) Token: 0x06000B86 RID: 2950 RVA: 0x0002F638 File Offset: 0x0002D838
	public unsafe float speedX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_speedX);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_speedX)) = value;
		}
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0002F65C File Offset: 0x0002D85C
	// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0002F684 File Offset: 0x0002D884
	public unsafe float speedY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_speedY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_speedY)) = value;
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0002F6A8 File Offset: 0x0002D8A8
	// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
	public unsafe float speedZ
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_speedZ);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_speedZ)) = value;
		}
	}

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0002F6F4 File Offset: 0x0002D8F4
	// (set) Token: 0x06000B8C RID: 2956 RVA: 0x0002F71C File Offset: 0x0002D91C
	public unsafe float amplitudeX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_amplitudeX);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_amplitudeX)) = value;
		}
	}

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002F740 File Offset: 0x0002D940
	// (set) Token: 0x06000B8E RID: 2958 RVA: 0x0002F768 File Offset: 0x0002D968
	public unsafe float amplitudeY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_amplitudeY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_amplitudeY)) = value;
		}
	}

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0002F78C File Offset: 0x0002D98C
	// (set) Token: 0x06000B90 RID: 2960 RVA: 0x0002F7B4 File Offset: 0x0002D9B4
	public unsafe float amplitudeZ
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_amplitudeZ);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_amplitudeZ)) = value;
		}
	}

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
	// (set) Token: 0x06000B92 RID: 2962 RVA: 0x0002F80C File Offset: 0x0002DA0C
	public unsafe Animator anim
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_anim);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0002F834 File Offset: 0x0002DA34
	// (set) Token: 0x06000B94 RID: 2964 RVA: 0x0002F85C File Offset: 0x0002DA5C
	public unsafe bool canChangeAnim
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_canChangeAnim);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_canChangeAnim)) = value;
		}
	}

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0002F880 File Offset: 0x0002DA80
	// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0002F8A8 File Offset: 0x0002DAA8
	public unsafe float angleX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_angleX);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_angleX)) = value;
		}
	}

	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0002F8CC File Offset: 0x0002DACC
	// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0002F8F4 File Offset: 0x0002DAF4
	public unsafe float angleY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_angleY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_angleY)) = value;
		}
	}

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0002F918 File Offset: 0x0002DB18
	// (set) Token: 0x06000B9A RID: 2970 RVA: 0x0002F940 File Offset: 0x0002DB40
	public unsafe float angleZ
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_angleZ);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_angleZ)) = value;
		}
	}

	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0002F964 File Offset: 0x0002DB64
	// (set) Token: 0x06000B9C RID: 2972 RVA: 0x0002F98C File Offset: 0x0002DB8C
	public unsafe Vector3 lastPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_lastPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bird.NativeFieldInfoPtr_lastPosition)) = value;
		}
	}

	// Token: 0x040006F9 RID: 1785
	private static readonly IntPtr NativeFieldInfoPtr_animCount;

	// Token: 0x040006FA RID: 1786
	private static readonly IntPtr NativeFieldInfoPtr_speedX;

	// Token: 0x040006FB RID: 1787
	private static readonly IntPtr NativeFieldInfoPtr_speedY;

	// Token: 0x040006FC RID: 1788
	private static readonly IntPtr NativeFieldInfoPtr_speedZ;

	// Token: 0x040006FD RID: 1789
	private static readonly IntPtr NativeFieldInfoPtr_amplitudeX;

	// Token: 0x040006FE RID: 1790
	private static readonly IntPtr NativeFieldInfoPtr_amplitudeY;

	// Token: 0x040006FF RID: 1791
	private static readonly IntPtr NativeFieldInfoPtr_amplitudeZ;

	// Token: 0x04000700 RID: 1792
	private static readonly IntPtr NativeFieldInfoPtr_anim;

	// Token: 0x04000701 RID: 1793
	private static readonly IntPtr NativeFieldInfoPtr_canChangeAnim;

	// Token: 0x04000702 RID: 1794
	private static readonly IntPtr NativeFieldInfoPtr_angleX;

	// Token: 0x04000703 RID: 1795
	private static readonly IntPtr NativeFieldInfoPtr_angleY;

	// Token: 0x04000704 RID: 1796
	private static readonly IntPtr NativeFieldInfoPtr_angleZ;

	// Token: 0x04000705 RID: 1797
	private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

	// Token: 0x04000706 RID: 1798
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000707 RID: 1799
	private static readonly IntPtr NativeMethodInfoPtr_OnAnimatorMove_Private_Void_0;

	// Token: 0x04000708 RID: 1800
	private static readonly IntPtr NativeMethodInfoPtr_GetNewPos_Private_Vector3_0;

	// Token: 0x04000709 RID: 1801
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
