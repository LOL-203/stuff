using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace UltraReal
{
	// Token: 0x02000906 RID: 2310
	[Serializable]
	public class AnimationCurveProperty : Il2CppSystem.Object
	{
		// Token: 0x0600BD12 RID: 48402 RVA: 0x00305BC0 File Offset: 0x00303DC0
		[CallerCount(0)]
		public unsafe float EvaluateStep(float delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delta;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AnimationCurveProperty.NativeMethodInfoPtr_EvaluateStep_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BD13 RID: 48403 RVA: 0x00305C24 File Offset: 0x00303E24
		[CallerCount(0)]
		public unsafe AnimationCurveProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurveProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD14 RID: 48404 RVA: 0x00305C70 File Offset: 0x00303E70
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationCurveProperty()
		{
			Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UltraReal", "AnimationCurveProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr);
			AnimationCurveProperty.NativeFieldInfoPtr_flickerCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr, "flickerCurve");
			AnimationCurveProperty.NativeFieldInfoPtr_timeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr, "timeLength");
			AnimationCurveProperty.NativeFieldInfoPtr_randomStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr, "randomStartTime");
			AnimationCurveProperty.NativeFieldInfoPtr__startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr, "_startTime");
			AnimationCurveProperty.NativeFieldInfoPtr__currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr, "_currentTime");
			AnimationCurveProperty.NativeMethodInfoPtr_EvaluateStep_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr, 100678664);
			AnimationCurveProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr, 100678665);
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x00002988 File Offset: 0x00000B88
		public AnimationCurveProperty(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700437C RID: 17276
		// (get) Token: 0x0600BD16 RID: 48406 RVA: 0x00305D2C File Offset: 0x00303F2C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnimationCurveProperty>.NativeClassPtr));
			}
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x0600BD17 RID: 48407 RVA: 0x00305D40 File Offset: 0x00303F40
		// (set) Token: 0x0600BD18 RID: 48408 RVA: 0x00305D74 File Offset: 0x00303F74
		public unsafe AnimationCurve flickerCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr_flickerCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AnimationCurve(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr_flickerCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x0600BD19 RID: 48409 RVA: 0x00305D9C File Offset: 0x00303F9C
		// (set) Token: 0x0600BD1A RID: 48410 RVA: 0x00305DC4 File Offset: 0x00303FC4
		public unsafe float timeLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr_timeLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr_timeLength)) = value;
			}
		}

		// Token: 0x1700437F RID: 17279
		// (get) Token: 0x0600BD1B RID: 48411 RVA: 0x00305DE8 File Offset: 0x00303FE8
		// (set) Token: 0x0600BD1C RID: 48412 RVA: 0x00305E10 File Offset: 0x00304010
		public unsafe bool randomStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr_randomStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr_randomStartTime)) = value;
			}
		}

		// Token: 0x17004380 RID: 17280
		// (get) Token: 0x0600BD1D RID: 48413 RVA: 0x00305E34 File Offset: 0x00304034
		// (set) Token: 0x0600BD1E RID: 48414 RVA: 0x00305E5C File Offset: 0x0030405C
		public unsafe float _startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr__startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr__startTime)) = value;
			}
		}

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x0600BD1F RID: 48415 RVA: 0x00305E80 File Offset: 0x00304080
		// (set) Token: 0x0600BD20 RID: 48416 RVA: 0x00305EA8 File Offset: 0x003040A8
		public unsafe float _currentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr__currentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurveProperty.NativeFieldInfoPtr__currentTime)) = value;
			}
		}

		// Token: 0x04007934 RID: 31028
		private static readonly IntPtr NativeFieldInfoPtr_flickerCurve;

		// Token: 0x04007935 RID: 31029
		private static readonly IntPtr NativeFieldInfoPtr_timeLength;

		// Token: 0x04007936 RID: 31030
		private static readonly IntPtr NativeFieldInfoPtr_randomStartTime;

		// Token: 0x04007937 RID: 31031
		private static readonly IntPtr NativeFieldInfoPtr__startTime;

		// Token: 0x04007938 RID: 31032
		private static readonly IntPtr NativeFieldInfoPtr__currentTime;

		// Token: 0x04007939 RID: 31033
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateStep_Public_Single_Single_0;

		// Token: 0x0400793A RID: 31034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
