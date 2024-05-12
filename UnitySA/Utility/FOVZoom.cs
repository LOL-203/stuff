using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace UnitySA.Utility
{
	// Token: 0x02000623 RID: 1571
	[Serializable]
	public class FOVZoom : Il2CppSystem.Object
	{
		// Token: 0x06007FBA RID: 32698 RVA: 0x00204150 File Offset: 0x00202350
		[CallerCount(0)]
		public unsafe void Setup(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom.NativeMethodInfoPtr_Setup_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x002041AC File Offset: 0x002023AC
		[CallerCount(0)]
		public unsafe void CheckStatus(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom.NativeMethodInfoPtr_CheckStatus_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x00204208 File Offset: 0x00202408
		[CallerCount(0)]
		public unsafe void ChangeCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom.NativeMethodInfoPtr_ChangeCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x00204264 File Offset: 0x00202464
		[CallerCount(0)]
		public unsafe IEnumerator FOVKickUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom.NativeMethodInfoPtr_FOVKickUp_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x002042BC File Offset: 0x002024BC
		[CallerCount(0)]
		public unsafe IEnumerator FOVKickDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom.NativeMethodInfoPtr_FOVKickDown_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x00204314 File Offset: 0x00202514
		[CallerCount(0)]
		public unsafe FOVZoom() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x00204360 File Offset: 0x00202560
		// Note: this type is marked as 'beforefieldinit'.
		static FOVZoom()
		{
			Il2CppClassPointerStore<FOVZoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnitySA.Utility", "FOVZoom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr);
			FOVZoom.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, "Camera");
			FOVZoom.NativeFieldInfoPtr_originalFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, "originalFov");
			FOVZoom.NativeFieldInfoPtr_FOVIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, "FOVIncrease");
			FOVZoom.NativeFieldInfoPtr_TimeToIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, "TimeToIncrease");
			FOVZoom.NativeFieldInfoPtr_TimeToDecrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, "TimeToDecrease");
			FOVZoom.NativeFieldInfoPtr_IncreaseCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, "IncreaseCurve");
			FOVZoom.NativeMethodInfoPtr_Setup_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, 100673601);
			FOVZoom.NativeMethodInfoPtr_CheckStatus_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, 100673602);
			FOVZoom.NativeMethodInfoPtr_ChangeCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, 100673603);
			FOVZoom.NativeMethodInfoPtr_FOVKickUp_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, 100673604);
			FOVZoom.NativeMethodInfoPtr_FOVKickDown_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, 100673605);
			FOVZoom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, 100673606);
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x00002988 File Offset: 0x00000B88
		public FOVZoom(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x06007FC2 RID: 32706 RVA: 0x00204480 File Offset: 0x00202680
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr));
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x06007FC3 RID: 32707 RVA: 0x00204494 File Offset: 0x00202694
		// (set) Token: 0x06007FC4 RID: 32708 RVA: 0x002044C8 File Offset: 0x002026C8
		public unsafe Camera Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Camera(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x06007FC5 RID: 32709 RVA: 0x002044F0 File Offset: 0x002026F0
		// (set) Token: 0x06007FC6 RID: 32710 RVA: 0x00204518 File Offset: 0x00202718
		public unsafe float originalFov
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_originalFov);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_originalFov)) = value;
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x06007FC7 RID: 32711 RVA: 0x0020453C File Offset: 0x0020273C
		// (set) Token: 0x06007FC8 RID: 32712 RVA: 0x00204564 File Offset: 0x00202764
		public unsafe float FOVIncrease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_FOVIncrease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_FOVIncrease)) = value;
			}
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x00204588 File Offset: 0x00202788
		// (set) Token: 0x06007FCA RID: 32714 RVA: 0x002045B0 File Offset: 0x002027B0
		public unsafe float TimeToIncrease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_TimeToIncrease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_TimeToIncrease)) = value;
			}
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x06007FCB RID: 32715 RVA: 0x002045D4 File Offset: 0x002027D4
		// (set) Token: 0x06007FCC RID: 32716 RVA: 0x002045FC File Offset: 0x002027FC
		public unsafe float TimeToDecrease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_TimeToDecrease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_TimeToDecrease)) = value;
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x06007FCD RID: 32717 RVA: 0x00204620 File Offset: 0x00202820
		// (set) Token: 0x06007FCE RID: 32718 RVA: 0x00204654 File Offset: 0x00202854
		public unsafe AnimationCurve IncreaseCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_IncreaseCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AnimationCurve(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom.NativeFieldInfoPtr_IncreaseCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051E4 RID: 20964
		private static readonly IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x040051E5 RID: 20965
		private static readonly IntPtr NativeFieldInfoPtr_originalFov;

		// Token: 0x040051E6 RID: 20966
		private static readonly IntPtr NativeFieldInfoPtr_FOVIncrease;

		// Token: 0x040051E7 RID: 20967
		private static readonly IntPtr NativeFieldInfoPtr_TimeToIncrease;

		// Token: 0x040051E8 RID: 20968
		private static readonly IntPtr NativeFieldInfoPtr_TimeToDecrease;

		// Token: 0x040051E9 RID: 20969
		private static readonly IntPtr NativeFieldInfoPtr_IncreaseCurve;

		// Token: 0x040051EA RID: 20970
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_Camera_0;

		// Token: 0x040051EB RID: 20971
		private static readonly IntPtr NativeMethodInfoPtr_CheckStatus_Private_Void_Camera_0;

		// Token: 0x040051EC RID: 20972
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCamera_Public_Void_Camera_0;

		// Token: 0x040051ED RID: 20973
		private static readonly IntPtr NativeMethodInfoPtr_FOVKickUp_Public_IEnumerator_0;

		// Token: 0x040051EE RID: 20974
		private static readonly IntPtr NativeMethodInfoPtr_FOVKickDown_Public_IEnumerator_0;

		// Token: 0x040051EF RID: 20975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000624 RID: 1572
		[ObfuscatedName("UnitySA.Utility.FOVZoom/<FOVKickUp>d__9")]
		public sealed class _FOVKickUp_d__9 : Il2CppSystem.Object
		{
			// Token: 0x06007FCF RID: 32719 RVA: 0x0020467C File Offset: 0x0020287C
			[CallerCount(0)]
			public unsafe _FOVKickUp_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007FD0 RID: 32720 RVA: 0x002046DC File Offset: 0x002028DC
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007FD1 RID: 32721 RVA: 0x00204720 File Offset: 0x00202920
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002DB2 RID: 11698
			// (get) Token: 0x06007FD2 RID: 32722 RVA: 0x00204770 File Offset: 0x00202970
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007FD3 RID: 32723 RVA: 0x002047C8 File Offset: 0x002029C8
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002DB3 RID: 11699
			// (get) Token: 0x06007FD4 RID: 32724 RVA: 0x0020480C File Offset: 0x00202A0C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007FD5 RID: 32725 RVA: 0x00204864 File Offset: 0x00202A64
			// Note: this type is marked as 'beforefieldinit'.
			static _FOVKickUp_d__9()
			{
				Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, "<FOVKickUp>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr);
				FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, "<>1__state");
				FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, "<>2__current");
				FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, "<>4__this");
				FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, "<t>5__2");
				FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, 100673607);
				FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, 100673608);
				FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, 100673609);
				FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, 100673610);
				FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, 100673611);
				FOVZoom._FOVKickUp_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr, 100673612);
			}

			// Token: 0x06007FD6 RID: 32726 RVA: 0x00002988 File Offset: 0x00000B88
			public _FOVKickUp_d__9(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002DAD RID: 11693
			// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x00204957 File Offset: 0x00202B57
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FOVZoom._FOVKickUp_d__9>.NativeClassPtr));
				}
			}

			// Token: 0x17002DAE RID: 11694
			// (get) Token: 0x06007FD8 RID: 32728 RVA: 0x00204968 File Offset: 0x00202B68
			// (set) Token: 0x06007FD9 RID: 32729 RVA: 0x00204990 File Offset: 0x00202B90
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002DAF RID: 11695
			// (get) Token: 0x06007FDA RID: 32730 RVA: 0x002049B4 File Offset: 0x00202BB4
			// (set) Token: 0x06007FDB RID: 32731 RVA: 0x002049E8 File Offset: 0x00202BE8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002DB0 RID: 11696
			// (get) Token: 0x06007FDC RID: 32732 RVA: 0x00204A10 File Offset: 0x00202C10
			// (set) Token: 0x06007FDD RID: 32733 RVA: 0x00204A44 File Offset: 0x00202C44
			public unsafe FOVZoom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new FOVZoom(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002DB1 RID: 11697
			// (get) Token: 0x06007FDE RID: 32734 RVA: 0x00204A6C File Offset: 0x00202C6C
			// (set) Token: 0x06007FDF RID: 32735 RVA: 0x00204A94 File Offset: 0x00202C94
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickUp_d__9.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x040051F0 RID: 20976
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040051F1 RID: 20977
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040051F2 RID: 20978
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040051F3 RID: 20979
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x040051F4 RID: 20980
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040051F5 RID: 20981
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040051F6 RID: 20982
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040051F7 RID: 20983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040051F8 RID: 20984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040051F9 RID: 20985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000625 RID: 1573
		[ObfuscatedName("UnitySA.Utility.FOVZoom/<FOVKickDown>d__10")]
		public sealed class _FOVKickDown_d__10 : Il2CppSystem.Object
		{
			// Token: 0x06007FE0 RID: 32736 RVA: 0x00204AB8 File Offset: 0x00202CB8
			[CallerCount(0)]
			public unsafe _FOVKickDown_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007FE1 RID: 32737 RVA: 0x00204B18 File Offset: 0x00202D18
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007FE2 RID: 32738 RVA: 0x00204B5C File Offset: 0x00202D5C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002DB9 RID: 11705
			// (get) Token: 0x06007FE3 RID: 32739 RVA: 0x00204BAC File Offset: 0x00202DAC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007FE4 RID: 32740 RVA: 0x00204C04 File Offset: 0x00202E04
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002DBA RID: 11706
			// (get) Token: 0x06007FE5 RID: 32741 RVA: 0x00204C48 File Offset: 0x00202E48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007FE6 RID: 32742 RVA: 0x00204CA0 File Offset: 0x00202EA0
			// Note: this type is marked as 'beforefieldinit'.
			static _FOVKickDown_d__10()
			{
				Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FOVZoom>.NativeClassPtr, "<FOVKickDown>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr);
				FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, "<>1__state");
				FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, "<>2__current");
				FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, "<>4__this");
				FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, "<t>5__2");
				FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, 100673613);
				FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, 100673614);
				FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, 100673615);
				FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, 100673616);
				FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, 100673617);
				FOVZoom._FOVKickDown_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr, 100673618);
			}

			// Token: 0x06007FE7 RID: 32743 RVA: 0x00002988 File Offset: 0x00000B88
			public _FOVKickDown_d__10(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002DB4 RID: 11700
			// (get) Token: 0x06007FE8 RID: 32744 RVA: 0x00204D93 File Offset: 0x00202F93
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FOVZoom._FOVKickDown_d__10>.NativeClassPtr));
				}
			}

			// Token: 0x17002DB5 RID: 11701
			// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00204DA4 File Offset: 0x00202FA4
			// (set) Token: 0x06007FEA RID: 32746 RVA: 0x00204DCC File Offset: 0x00202FCC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002DB6 RID: 11702
			// (get) Token: 0x06007FEB RID: 32747 RVA: 0x00204DF0 File Offset: 0x00202FF0
			// (set) Token: 0x06007FEC RID: 32748 RVA: 0x00204E24 File Offset: 0x00203024
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002DB7 RID: 11703
			// (get) Token: 0x06007FED RID: 32749 RVA: 0x00204E4C File Offset: 0x0020304C
			// (set) Token: 0x06007FEE RID: 32750 RVA: 0x00204E80 File Offset: 0x00203080
			public unsafe FOVZoom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new FOVZoom(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002DB8 RID: 11704
			// (get) Token: 0x06007FEF RID: 32751 RVA: 0x00204EA8 File Offset: 0x002030A8
			// (set) Token: 0x06007FF0 RID: 32752 RVA: 0x00204ED0 File Offset: 0x002030D0
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FOVZoom._FOVKickDown_d__10.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x040051FA RID: 20986
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040051FB RID: 20987
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040051FC RID: 20988
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040051FD RID: 20989
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x040051FE RID: 20990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040051FF RID: 20991
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005200 RID: 20992
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005201 RID: 20993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005202 RID: 20994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005203 RID: 20995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
