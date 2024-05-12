using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Wacki
{
	// Token: 0x02000900 RID: 2304
	public class IUILaserPointer : MonoBehaviour
	{
		// Token: 0x0600BCA2 RID: 48290 RVA: 0x00303DE8 File Offset: 0x00301FE8
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUILaserPointer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCA3 RID: 48291 RVA: 0x00303E2C File Offset: 0x0030202C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUILaserPointer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCA4 RID: 48292 RVA: 0x00303E7C File Offset: 0x0030207C
		[CallerCount(0)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUILaserPointer.NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCA5 RID: 48293 RVA: 0x00303ECC File Offset: 0x003020CC
		[CallerCount(0)]
		public unsafe void OnEnterControl(GameObject control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUILaserPointer.NativeMethodInfoPtr_OnEnterControl_Public_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x00303F30 File Offset: 0x00302130
		[CallerCount(0)]
		public unsafe void OnExitControl(GameObject control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUILaserPointer.NativeMethodInfoPtr_OnExitControl_Public_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x00303F94 File Offset: 0x00302194
		[CallerCount(0)]
		public unsafe bool ButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUILaserPointer.NativeMethodInfoPtr_ButtonDown_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BCA8 RID: 48296 RVA: 0x00303FF0 File Offset: 0x003021F0
		[CallerCount(0)]
		public unsafe bool ButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUILaserPointer.NativeMethodInfoPtr_ButtonUp_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BCA9 RID: 48297 RVA: 0x0030404C File Offset: 0x0030224C
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUILaserPointer.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCAA RID: 48298 RVA: 0x0030409C File Offset: 0x0030229C
		[CallerCount(0)]
		public unsafe void LimitLaserDistance(float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distance;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUILaserPointer.NativeMethodInfoPtr_LimitLaserDistance_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCAB RID: 48299 RVA: 0x003040FC File Offset: 0x003022FC
		[CallerCount(0)]
		public unsafe IUILaserPointer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUILaserPointer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCAC RID: 48300 RVA: 0x00304148 File Offset: 0x00302348
		// Note: this type is marked as 'beforefieldinit'.
		static IUILaserPointer()
		{
			Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Wacki", "IUILaserPointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr);
			IUILaserPointer.NativeFieldInfoPtr_showLaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "showLaser");
			IUILaserPointer.NativeFieldInfoPtr_showHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "showHit");
			IUILaserPointer.NativeFieldInfoPtr_laserThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "laserThickness");
			IUILaserPointer.NativeFieldInfoPtr_laserHitScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "laserHitScale");
			IUILaserPointer.NativeFieldInfoPtr_laserAlwaysOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "laserAlwaysOn");
			IUILaserPointer.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "color");
			IUILaserPointer.NativeFieldInfoPtr_Laser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "Laser");
			IUILaserPointer.NativeFieldInfoPtr_hitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "hitPoint");
			IUILaserPointer.NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "pointer");
			IUILaserPointer.NativeFieldInfoPtr__distanceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, "_distanceLimit");
			IUILaserPointer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678620);
			IUILaserPointer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678621);
			IUILaserPointer.NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678622);
			IUILaserPointer.NativeMethodInfoPtr_OnEnterControl_Public_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678623);
			IUILaserPointer.NativeMethodInfoPtr_OnExitControl_Public_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678624);
			IUILaserPointer.NativeMethodInfoPtr_ButtonDown_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678625);
			IUILaserPointer.NativeMethodInfoPtr_ButtonUp_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678626);
			IUILaserPointer.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678627);
			IUILaserPointer.NativeMethodInfoPtr_LimitLaserDistance_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678628);
			IUILaserPointer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr, 100678629);
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x0000210C File Offset: 0x0000030C
		public IUILaserPointer(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x0600BCAE RID: 48302 RVA: 0x00304308 File Offset: 0x00302508
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IUILaserPointer>.NativeClassPtr));
			}
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x0600BCAF RID: 48303 RVA: 0x0030431C File Offset: 0x0030251C
		// (set) Token: 0x0600BCB0 RID: 48304 RVA: 0x00304344 File Offset: 0x00302544
		public unsafe bool showLaser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_showLaser);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_showLaser)) = value;
			}
		}

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x0600BCB1 RID: 48305 RVA: 0x00304368 File Offset: 0x00302568
		// (set) Token: 0x0600BCB2 RID: 48306 RVA: 0x00304390 File Offset: 0x00302590
		public unsafe bool showHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_showHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_showHit)) = value;
			}
		}

		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x0600BCB3 RID: 48307 RVA: 0x003043B4 File Offset: 0x003025B4
		// (set) Token: 0x0600BCB4 RID: 48308 RVA: 0x003043DC File Offset: 0x003025DC
		public unsafe float laserThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_laserThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_laserThickness)) = value;
			}
		}

		// Token: 0x1700435F RID: 17247
		// (get) Token: 0x0600BCB5 RID: 48309 RVA: 0x00304400 File Offset: 0x00302600
		// (set) Token: 0x0600BCB6 RID: 48310 RVA: 0x00304428 File Offset: 0x00302628
		public unsafe float laserHitScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_laserHitScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_laserHitScale)) = value;
			}
		}

		// Token: 0x17004360 RID: 17248
		// (get) Token: 0x0600BCB7 RID: 48311 RVA: 0x0030444C File Offset: 0x0030264C
		// (set) Token: 0x0600BCB8 RID: 48312 RVA: 0x00304474 File Offset: 0x00302674
		public unsafe bool laserAlwaysOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_laserAlwaysOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_laserAlwaysOn)) = value;
			}
		}

		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x0600BCB9 RID: 48313 RVA: 0x00304498 File Offset: 0x00302698
		// (set) Token: 0x0600BCBA RID: 48314 RVA: 0x003044C0 File Offset: 0x003026C0
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17004362 RID: 17250
		// (get) Token: 0x0600BCBB RID: 48315 RVA: 0x003044E4 File Offset: 0x003026E4
		// (set) Token: 0x0600BCBC RID: 48316 RVA: 0x00304518 File Offset: 0x00302718
		public unsafe BasicLaser_v2 Laser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_Laser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new BasicLaser_v2(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_Laser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004363 RID: 17251
		// (get) Token: 0x0600BCBD RID: 48317 RVA: 0x00304540 File Offset: 0x00302740
		// (set) Token: 0x0600BCBE RID: 48318 RVA: 0x00304574 File Offset: 0x00302774
		public unsafe GameObject hitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_hitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_hitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004364 RID: 17252
		// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x0030459C File Offset: 0x0030279C
		// (set) Token: 0x0600BCC0 RID: 48320 RVA: 0x003045D0 File Offset: 0x003027D0
		public unsafe GameObject pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_pointer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr_pointer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004365 RID: 17253
		// (get) Token: 0x0600BCC1 RID: 48321 RVA: 0x003045F8 File Offset: 0x003027F8
		// (set) Token: 0x0600BCC2 RID: 48322 RVA: 0x00304620 File Offset: 0x00302820
		public unsafe float _distanceLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr__distanceLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUILaserPointer.NativeFieldInfoPtr__distanceLimit)) = value;
			}
		}

		// Token: 0x040078EF RID: 30959
		private static readonly IntPtr NativeFieldInfoPtr_showLaser;

		// Token: 0x040078F0 RID: 30960
		private static readonly IntPtr NativeFieldInfoPtr_showHit;

		// Token: 0x040078F1 RID: 30961
		private static readonly IntPtr NativeFieldInfoPtr_laserThickness;

		// Token: 0x040078F2 RID: 30962
		private static readonly IntPtr NativeFieldInfoPtr_laserHitScale;

		// Token: 0x040078F3 RID: 30963
		private static readonly IntPtr NativeFieldInfoPtr_laserAlwaysOn;

		// Token: 0x040078F4 RID: 30964
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040078F5 RID: 30965
		private static readonly IntPtr NativeFieldInfoPtr_Laser;

		// Token: 0x040078F6 RID: 30966
		private static readonly IntPtr NativeFieldInfoPtr_hitPoint;

		// Token: 0x040078F7 RID: 30967
		private static readonly IntPtr NativeFieldInfoPtr_pointer;

		// Token: 0x040078F8 RID: 30968
		private static readonly IntPtr NativeFieldInfoPtr__distanceLimit;

		// Token: 0x040078F9 RID: 30969
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040078FA RID: 30970
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040078FB RID: 30971
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0;

		// Token: 0x040078FC RID: 30972
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterControl_Public_Virtual_New_Void_GameObject_0;

		// Token: 0x040078FD RID: 30973
		private static readonly IntPtr NativeMethodInfoPtr_OnExitControl_Public_Virtual_New_Void_GameObject_0;

		// Token: 0x040078FE RID: 30974
		private static readonly IntPtr NativeMethodInfoPtr_ButtonDown_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040078FF RID: 30975
		private static readonly IntPtr NativeMethodInfoPtr_ButtonUp_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04007900 RID: 30976
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007901 RID: 30977
		private static readonly IntPtr NativeMethodInfoPtr_LimitLaserDistance_Public_Virtual_New_Void_Single_0;

		// Token: 0x04007902 RID: 30978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
