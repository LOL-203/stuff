using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020004C6 RID: 1222
public class WarObjectiveMapReference : MonoBehaviour
{
	// Token: 0x0600627A RID: 25210 RVA: 0x0018A934 File Offset: 0x00188B34
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600627B RID: 25211 RVA: 0x0018A978 File Offset: 0x00188B78
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600627C RID: 25212 RVA: 0x0018A9BC File Offset: 0x00188BBC
	[CallerCount(0)]
	public unsafe void ObjectAppearance(bool state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref state;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference.NativeMethodInfoPtr_ObjectAppearance_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600627D RID: 25213 RVA: 0x0018AA10 File Offset: 0x00188C10
	[CallerCount(0)]
	public unsafe void CapturedHide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference.NativeMethodInfoPtr_CapturedHide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600627E RID: 25214 RVA: 0x0018AA54 File Offset: 0x00188C54
	[CallerCount(0)]
	public unsafe IEnumerator HideObjectiveAfterTime(int time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref time;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference.NativeMethodInfoPtr_HideObjectiveAfterTime_Public_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x0600627F RID: 25215 RVA: 0x0018AABC File Offset: 0x00188CBC
	[CallerCount(0)]
	public unsafe WarObjectiveMapReference() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x0018AB08 File Offset: 0x00188D08
	// Note: this type is marked as 'beforefieldinit'.
	static WarObjectiveMapReference()
	{
		Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WarObjectiveMapReference");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr);
		WarObjectiveMapReference.NativeFieldInfoPtr_MiniMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, "MiniMapIcon");
		WarObjectiveMapReference.NativeFieldInfoPtr_OSSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, "OSSpawn");
		WarObjectiveMapReference.NativeFieldInfoPtr_MarsocSpawns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, "MarsocSpawns");
		WarObjectiveMapReference.NativeFieldInfoPtr_wifiRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, "wifiRange");
		WarObjectiveMapReference.NativeFieldInfoPtr_rotateDish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, "rotateDish");
		WarObjectiveMapReference.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, 100671108);
		WarObjectiveMapReference.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, 100671109);
		WarObjectiveMapReference.NativeMethodInfoPtr_ObjectAppearance_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, 100671110);
		WarObjectiveMapReference.NativeMethodInfoPtr_CapturedHide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, 100671111);
		WarObjectiveMapReference.NativeMethodInfoPtr_HideObjectiveAfterTime_Public_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, 100671112);
		WarObjectiveMapReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, 100671113);
	}

	// Token: 0x06006281 RID: 25217 RVA: 0x0000210C File Offset: 0x0000030C
	public WarObjectiveMapReference(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002300 RID: 8960
	// (get) Token: 0x06006282 RID: 25218 RVA: 0x0018AC14 File Offset: 0x00188E14
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr));
		}
	}

	// Token: 0x17002301 RID: 8961
	// (get) Token: 0x06006283 RID: 25219 RVA: 0x0018AC28 File Offset: 0x00188E28
	// (set) Token: 0x06006284 RID: 25220 RVA: 0x0018AC5C File Offset: 0x00188E5C
	public unsafe bl_MiniMapItem MiniMapIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_MiniMapIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new bl_MiniMapItem(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_MiniMapIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002302 RID: 8962
	// (get) Token: 0x06006285 RID: 25221 RVA: 0x0018AC84 File Offset: 0x00188E84
	// (set) Token: 0x06006286 RID: 25222 RVA: 0x0018ACB8 File Offset: 0x00188EB8
	public unsafe Transform OSSpawn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_OSSpawn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_OSSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002303 RID: 8963
	// (get) Token: 0x06006287 RID: 25223 RVA: 0x0018ACE0 File Offset: 0x00188EE0
	// (set) Token: 0x06006288 RID: 25224 RVA: 0x0018AD14 File Offset: 0x00188F14
	public unsafe Il2CppReferenceArray<Transform> MarsocSpawns
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_MarsocSpawns);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_MarsocSpawns), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002304 RID: 8964
	// (get) Token: 0x06006289 RID: 25225 RVA: 0x0018AD3C File Offset: 0x00188F3C
	// (set) Token: 0x0600628A RID: 25226 RVA: 0x0018AD70 File Offset: 0x00188F70
	public unsafe MeshCollider wifiRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_wifiRange);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new MeshCollider(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_wifiRange), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002305 RID: 8965
	// (get) Token: 0x0600628B RID: 25227 RVA: 0x0018AD98 File Offset: 0x00188F98
	// (set) Token: 0x0600628C RID: 25228 RVA: 0x0018ADCC File Offset: 0x00188FCC
	public unsafe RotateDish rotateDish
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_rotateDish);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RotateDish(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference.NativeFieldInfoPtr_rotateDish), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04003E2E RID: 15918
	private static readonly IntPtr NativeFieldInfoPtr_MiniMapIcon;

	// Token: 0x04003E2F RID: 15919
	private static readonly IntPtr NativeFieldInfoPtr_OSSpawn;

	// Token: 0x04003E30 RID: 15920
	private static readonly IntPtr NativeFieldInfoPtr_MarsocSpawns;

	// Token: 0x04003E31 RID: 15921
	private static readonly IntPtr NativeFieldInfoPtr_wifiRange;

	// Token: 0x04003E32 RID: 15922
	private static readonly IntPtr NativeFieldInfoPtr_rotateDish;

	// Token: 0x04003E33 RID: 15923
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

	// Token: 0x04003E34 RID: 15924
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

	// Token: 0x04003E35 RID: 15925
	private static readonly IntPtr NativeMethodInfoPtr_ObjectAppearance_Public_Void_Boolean_0;

	// Token: 0x04003E36 RID: 15926
	private static readonly IntPtr NativeMethodInfoPtr_CapturedHide_Public_Void_0;

	// Token: 0x04003E37 RID: 15927
	private static readonly IntPtr NativeMethodInfoPtr_HideObjectiveAfterTime_Public_IEnumerator_Int32_0;

	// Token: 0x04003E38 RID: 15928
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020004C7 RID: 1223
	[ObfuscatedName("WarObjectiveMapReference/<HideObjectiveAfterTime>d__9")]
	public sealed class _HideObjectiveAfterTime_d__9 : Il2CppSystem.Object
	{
		// Token: 0x0600628D RID: 25229 RVA: 0x0018ADF4 File Offset: 0x00188FF4
		[CallerCount(0)]
		public unsafe _HideObjectiveAfterTime_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x0018AE54 File Offset: 0x00189054
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x0018AE98 File Offset: 0x00189098
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x06006290 RID: 25232 RVA: 0x0018AEE8 File Offset: 0x001890E8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x0018AF40 File Offset: 0x00189140
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06006292 RID: 25234 RVA: 0x0018AF84 File Offset: 0x00189184
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x0018AFDC File Offset: 0x001891DC
		// Note: this type is marked as 'beforefieldinit'.
		static _HideObjectiveAfterTime_d__9()
		{
			Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarObjectiveMapReference>.NativeClassPtr, "<HideObjectiveAfterTime>d__9");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr);
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, "<>1__state");
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, "<>2__current");
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, "time");
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, "<>4__this");
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, 100671114);
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, 100671115);
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, 100671116);
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, 100671117);
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, 100671118);
			WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr, 100671119);
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x00002988 File Offset: 0x00000B88
		public _HideObjectiveAfterTime_d__9(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06006295 RID: 25237 RVA: 0x0018B0CF File Offset: 0x001892CF
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarObjectiveMapReference._HideObjectiveAfterTime_d__9>.NativeClassPtr));
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06006296 RID: 25238 RVA: 0x0018B0E0 File Offset: 0x001892E0
		// (set) Token: 0x06006297 RID: 25239 RVA: 0x0018B108 File Offset: 0x00189308
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06006298 RID: 25240 RVA: 0x0018B12C File Offset: 0x0018932C
		// (set) Token: 0x06006299 RID: 25241 RVA: 0x0018B160 File Offset: 0x00189360
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600629A RID: 25242 RVA: 0x0018B188 File Offset: 0x00189388
		// (set) Token: 0x0600629B RID: 25243 RVA: 0x0018B1B0 File Offset: 0x001893B0
		public unsafe int time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600629C RID: 25244 RVA: 0x0018B1D4 File Offset: 0x001893D4
		// (set) Token: 0x0600629D RID: 25245 RVA: 0x0018B208 File Offset: 0x00189408
		public unsafe WarObjectiveMapReference __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WarObjectiveMapReference(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarObjectiveMapReference._HideObjectiveAfterTime_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E39 RID: 15929
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003E3A RID: 15930
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04003E3B RID: 15931
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04003E3C RID: 15932
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04003E3D RID: 15933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003E3E RID: 15934
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003E3F RID: 15935
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003E40 RID: 15936
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003E41 RID: 15937
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003E42 RID: 15938
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
