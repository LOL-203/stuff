using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200035C RID: 860
public class WaypointFollower : MonoBehaviour
{
	// Token: 0x060043B6 RID: 17334 RVA: 0x001108D0 File Offset: 0x0010EAD0
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointFollower.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060043B7 RID: 17335 RVA: 0x00110914 File Offset: 0x0010EB14
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointFollower.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060043B8 RID: 17336 RVA: 0x00110958 File Offset: 0x0010EB58
	[CallerCount(0)]
	public unsafe WaypointFollower() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointFollower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060043B9 RID: 17337 RVA: 0x001109A4 File Offset: 0x0010EBA4
	// Note: this type is marked as 'beforefieldinit'.
	static WaypointFollower()
	{
		Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WaypointFollower");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr);
		WaypointFollower.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "Waypoints");
		WaypointFollower.NativeFieldInfoPtr_m_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "m_animator");
		WaypointFollower.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "MoveSpeed");
		WaypointFollower.NativeFieldInfoPtr_RotSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "RotSpeed");
		WaypointFollower.NativeFieldInfoPtr_Patrol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "Patrol");
		WaypointFollower.NativeFieldInfoPtr_m_currentWayPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "m_currentWayPoint");
		WaypointFollower.NativeFieldInfoPtr_m_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "m_forward");
		WaypointFollower.NativeFieldInfoPtr_m_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "m_currentState");
		WaypointFollower.NativeFieldInfoPtr_m_stateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "m_stateTime");
		WaypointFollower.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, 100668676);
		WaypointFollower.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, 100668677);
		WaypointFollower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, 100668678);
	}

	// Token: 0x060043BA RID: 17338 RVA: 0x0000210C File Offset: 0x0000030C
	public WaypointFollower(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001804 RID: 6148
	// (get) Token: 0x060043BB RID: 17339 RVA: 0x00110AC4 File Offset: 0x0010ECC4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr));
		}
	}

	// Token: 0x17001805 RID: 6149
	// (get) Token: 0x060043BC RID: 17340 RVA: 0x00110AD8 File Offset: 0x0010ECD8
	// (set) Token: 0x060043BD RID: 17341 RVA: 0x00110B0C File Offset: 0x0010ED0C
	public unsafe Il2CppReferenceArray<WaypointFollower.WaypointInfo> Waypoints
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_Waypoints);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<WaypointFollower.WaypointInfo>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001806 RID: 6150
	// (get) Token: 0x060043BE RID: 17342 RVA: 0x00110B34 File Offset: 0x0010ED34
	// (set) Token: 0x060043BF RID: 17343 RVA: 0x00110B68 File Offset: 0x0010ED68
	public unsafe Animator m_animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001807 RID: 6151
	// (get) Token: 0x060043C0 RID: 17344 RVA: 0x00110B90 File Offset: 0x0010ED90
	// (set) Token: 0x060043C1 RID: 17345 RVA: 0x00110BB8 File Offset: 0x0010EDB8
	public unsafe float MoveSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_MoveSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_MoveSpeed)) = value;
		}
	}

	// Token: 0x17001808 RID: 6152
	// (get) Token: 0x060043C2 RID: 17346 RVA: 0x00110BDC File Offset: 0x0010EDDC
	// (set) Token: 0x060043C3 RID: 17347 RVA: 0x00110C04 File Offset: 0x0010EE04
	public unsafe float RotSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_RotSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_RotSpeed)) = value;
		}
	}

	// Token: 0x17001809 RID: 6153
	// (get) Token: 0x060043C4 RID: 17348 RVA: 0x00110C28 File Offset: 0x0010EE28
	// (set) Token: 0x060043C5 RID: 17349 RVA: 0x00110C50 File Offset: 0x0010EE50
	public unsafe bool Patrol
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_Patrol);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_Patrol)) = value;
		}
	}

	// Token: 0x1700180A RID: 6154
	// (get) Token: 0x060043C6 RID: 17350 RVA: 0x00110C74 File Offset: 0x0010EE74
	// (set) Token: 0x060043C7 RID: 17351 RVA: 0x00110C9C File Offset: 0x0010EE9C
	public unsafe int m_currentWayPoint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_currentWayPoint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_currentWayPoint)) = value;
		}
	}

	// Token: 0x1700180B RID: 6155
	// (get) Token: 0x060043C8 RID: 17352 RVA: 0x00110CC0 File Offset: 0x0010EEC0
	// (set) Token: 0x060043C9 RID: 17353 RVA: 0x00110CE8 File Offset: 0x0010EEE8
	public unsafe bool m_forward
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_forward);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_forward)) = value;
		}
	}

	// Token: 0x1700180C RID: 6156
	// (get) Token: 0x060043CA RID: 17354 RVA: 0x00110D0C File Offset: 0x0010EF0C
	// (set) Token: 0x060043CB RID: 17355 RVA: 0x00110D34 File Offset: 0x0010EF34
	public unsafe WaypointFollower.State m_currentState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_currentState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_currentState)) = value;
		}
	}

	// Token: 0x1700180D RID: 6157
	// (get) Token: 0x060043CC RID: 17356 RVA: 0x00110D58 File Offset: 0x0010EF58
	// (set) Token: 0x060043CD RID: 17357 RVA: 0x00110D80 File Offset: 0x0010EF80
	public unsafe float m_stateTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_stateTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.NativeFieldInfoPtr_m_stateTime)) = value;
		}
	}

	// Token: 0x04002B55 RID: 11093
	private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

	// Token: 0x04002B56 RID: 11094
	private static readonly IntPtr NativeFieldInfoPtr_m_animator;

	// Token: 0x04002B57 RID: 11095
	private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

	// Token: 0x04002B58 RID: 11096
	private static readonly IntPtr NativeFieldInfoPtr_RotSpeed;

	// Token: 0x04002B59 RID: 11097
	private static readonly IntPtr NativeFieldInfoPtr_Patrol;

	// Token: 0x04002B5A RID: 11098
	private static readonly IntPtr NativeFieldInfoPtr_m_currentWayPoint;

	// Token: 0x04002B5B RID: 11099
	private static readonly IntPtr NativeFieldInfoPtr_m_forward;

	// Token: 0x04002B5C RID: 11100
	private static readonly IntPtr NativeFieldInfoPtr_m_currentState;

	// Token: 0x04002B5D RID: 11101
	private static readonly IntPtr NativeFieldInfoPtr_m_stateTime;

	// Token: 0x04002B5E RID: 11102
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04002B5F RID: 11103
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04002B60 RID: 11104
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200035D RID: 861
	[Serializable]
	public class WaypointInfo : Il2CppSystem.Object
	{
		// Token: 0x060043CE RID: 17358 RVA: 0x00110DA4 File Offset: 0x0010EFA4
		[CallerCount(0)]
		public unsafe WaypointInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaypointFollower.WaypointInfo>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointFollower.WaypointInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00110DF0 File Offset: 0x0010EFF0
		// Note: this type is marked as 'beforefieldinit'.
		static WaypointInfo()
		{
			Il2CppClassPointerStore<WaypointFollower.WaypointInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaypointFollower>.NativeClassPtr, "WaypointInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointFollower.WaypointInfo>.NativeClassPtr);
			WaypointFollower.WaypointInfo.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower.WaypointInfo>.NativeClassPtr, "Location");
			WaypointFollower.WaypointInfo.NativeFieldInfoPtr_TransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointFollower.WaypointInfo>.NativeClassPtr, "TransitionTime");
			WaypointFollower.WaypointInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointFollower.WaypointInfo>.NativeClassPtr, 100668679);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x00002988 File Offset: 0x00000B88
		public WaypointInfo(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x00110E57 File Offset: 0x0010F057
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WaypointFollower.WaypointInfo>.NativeClassPtr));
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x060043D2 RID: 17362 RVA: 0x00110E68 File Offset: 0x0010F068
		// (set) Token: 0x060043D3 RID: 17363 RVA: 0x00110E9C File Offset: 0x0010F09C
		public unsafe Transform Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.WaypointInfo.NativeFieldInfoPtr_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.WaypointInfo.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x060043D4 RID: 17364 RVA: 0x00110EC4 File Offset: 0x0010F0C4
		// (set) Token: 0x060043D5 RID: 17365 RVA: 0x00110EEC File Offset: 0x0010F0EC
		public unsafe float TransitionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.WaypointInfo.NativeFieldInfoPtr_TransitionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointFollower.WaypointInfo.NativeFieldInfoPtr_TransitionTime)) = value;
			}
		}

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeFieldInfoPtr_TransitionTime;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x0200035E RID: 862
	public enum State
	{
		// Token: 0x04002B65 RID: 11109
		Idle,
		// Token: 0x04002B66 RID: 11110
		Walking
	}
}
