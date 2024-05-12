using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200047F RID: 1151
public class WeaponInstructionData : ScriptableObject
{
	// Token: 0x06005CA7 RID: 23719 RVA: 0x001725A0 File Offset: 0x001707A0
	[CallerCount(0)]
	public unsafe WeaponInstructionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponInstructionData>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponInstructionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005CA8 RID: 23720 RVA: 0x001725EC File Offset: 0x001707EC
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponInstructionData()
	{
		Il2CppClassPointerStore<WeaponInstructionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponInstructionData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponInstructionData>.NativeClassPtr);
		WeaponInstructionData.NativeFieldInfoPtr_Lessons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInstructionData>.NativeClassPtr, "Lessons");
		WeaponInstructionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponInstructionData>.NativeClassPtr, 100670584);
	}

	// Token: 0x06005CA9 RID: 23721 RVA: 0x0002DD3C File Offset: 0x0002BF3C
	public WeaponInstructionData(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170020F7 RID: 8439
	// (get) Token: 0x06005CAA RID: 23722 RVA: 0x00172644 File Offset: 0x00170844
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponInstructionData>.NativeClassPtr));
		}
	}

	// Token: 0x170020F8 RID: 8440
	// (get) Token: 0x06005CAB RID: 23723 RVA: 0x00172658 File Offset: 0x00170858
	// (set) Token: 0x06005CAC RID: 23724 RVA: 0x0017268C File Offset: 0x0017088C
	public unsafe Il2CppReferenceArray<WeaponInstructionData.LessonData> Lessons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.NativeFieldInfoPtr_Lessons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<WeaponInstructionData.LessonData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.NativeFieldInfoPtr_Lessons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04003A81 RID: 14977
	private static readonly IntPtr NativeFieldInfoPtr_Lessons;

	// Token: 0x04003A82 RID: 14978
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000480 RID: 1152
	public enum WeaponLesson
	{
		// Token: 0x04003A84 RID: 14980
		Reload,
		// Token: 0x04003A85 RID: 14981
		Firemode
	}

	// Token: 0x02000481 RID: 1153
	public enum WeaponInstructionPivot
	{
		// Token: 0x04003A87 RID: 14983
		Root,
		// Token: 0x04003A88 RID: 14984
		Magazine,
		// Token: 0x04003A89 RID: 14985
		Magwell,
		// Token: 0x04003A8A RID: 14986
		Bolt,
		// Token: 0x04003A8B RID: 14987
		Pin
	}

	// Token: 0x02000482 RID: 1154
	public enum WeaponInstructionSide
	{
		// Token: 0x04003A8D RID: 14989
		Left,
		// Token: 0x04003A8E RID: 14990
		Right
	}

	// Token: 0x02000483 RID: 1155
	[Serializable]
	public class LessonData : Il2CppSystem.Object
	{
		// Token: 0x06005CB3 RID: 23731 RVA: 0x00172728 File Offset: 0x00170928
		[CallerCount(0)]
		public unsafe LessonData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponInstructionData.LessonData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponInstructionData.LessonData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x00172774 File Offset: 0x00170974
		// Note: this type is marked as 'beforefieldinit'.
		static LessonData()
		{
			Il2CppClassPointerStore<WeaponInstructionData.LessonData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeaponInstructionData>.NativeClassPtr, "LessonData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponInstructionData.LessonData>.NativeClassPtr);
			WeaponInstructionData.LessonData.NativeFieldInfoPtr_Lesson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInstructionData.LessonData>.NativeClassPtr, "Lesson");
			WeaponInstructionData.LessonData.NativeFieldInfoPtr_Steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInstructionData.LessonData>.NativeClassPtr, "Steps");
			WeaponInstructionData.LessonData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponInstructionData.LessonData>.NativeClassPtr, 100670585);
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x00002988 File Offset: 0x00000B88
		public LessonData(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06005CB6 RID: 23734 RVA: 0x001727DB File Offset: 0x001709DB
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponInstructionData.LessonData>.NativeClassPtr));
			}
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x001727EC File Offset: 0x001709EC
		// (set) Token: 0x06005CB8 RID: 23736 RVA: 0x00172814 File Offset: 0x00170A14
		public unsafe WeaponInstructionData.WeaponLesson Lesson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.LessonData.NativeFieldInfoPtr_Lesson);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.LessonData.NativeFieldInfoPtr_Lesson)) = value;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x00172838 File Offset: 0x00170A38
		// (set) Token: 0x06005CBA RID: 23738 RVA: 0x0017286C File Offset: 0x00170A6C
		public unsafe Il2CppReferenceArray<WeaponInstructionData.StepData> Steps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.LessonData.NativeFieldInfoPtr_Steps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<WeaponInstructionData.StepData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.LessonData.NativeFieldInfoPtr_Steps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A8F RID: 14991
		private static readonly IntPtr NativeFieldInfoPtr_Lesson;

		// Token: 0x04003A90 RID: 14992
		private static readonly IntPtr NativeFieldInfoPtr_Steps;

		// Token: 0x04003A91 RID: 14993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x02000484 RID: 1156
	[Serializable]
	public class StepData : Il2CppSystem.Object
	{
		// Token: 0x06005CBB RID: 23739 RVA: 0x00172894 File Offset: 0x00170A94
		[CallerCount(0)]
		public unsafe StepData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponInstructionData.StepData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x001728E0 File Offset: 0x00170AE0
		// Note: this type is marked as 'beforefieldinit'.
		static StepData()
		{
			Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeaponInstructionData>.NativeClassPtr, "StepData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr);
			WeaponInstructionData.StepData.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr, "HeaderText");
			WeaponInstructionData.StepData.NativeFieldInfoPtr_BodyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr, "BodyText");
			WeaponInstructionData.StepData.NativeFieldInfoPtr_Pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr, "Pivot");
			WeaponInstructionData.StepData.NativeFieldInfoPtr_Side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr, "Side");
			WeaponInstructionData.StepData.NativeFieldInfoPtr_SideOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr, "SideOffset");
			WeaponInstructionData.StepData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr, 100670586);
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x00002988 File Offset: 0x00000B88
		public StepData(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x00172983 File Offset: 0x00170B83
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponInstructionData.StepData>.NativeClassPtr));
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06005CBF RID: 23743 RVA: 0x00172994 File Offset: 0x00170B94
		// (set) Token: 0x06005CC0 RID: 23744 RVA: 0x001729BD File Offset: 0x00170BBD
		public unsafe string HeaderText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_HeaderText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_HeaderText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06005CC1 RID: 23745 RVA: 0x001729E4 File Offset: 0x00170BE4
		// (set) Token: 0x06005CC2 RID: 23746 RVA: 0x00172A0D File Offset: 0x00170C0D
		public unsafe string BodyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_BodyText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_BodyText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06005CC3 RID: 23747 RVA: 0x00172A34 File Offset: 0x00170C34
		// (set) Token: 0x06005CC4 RID: 23748 RVA: 0x00172A5C File Offset: 0x00170C5C
		public unsafe WeaponInstructionData.WeaponInstructionPivot Pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_Pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_Pivot)) = value;
			}
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06005CC5 RID: 23749 RVA: 0x00172A80 File Offset: 0x00170C80
		// (set) Token: 0x06005CC6 RID: 23750 RVA: 0x00172AA8 File Offset: 0x00170CA8
		public unsafe WeaponInstructionData.WeaponInstructionSide Side
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_Side);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_Side)) = value;
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06005CC7 RID: 23751 RVA: 0x00172ACC File Offset: 0x00170CCC
		// (set) Token: 0x06005CC8 RID: 23752 RVA: 0x00172AF4 File Offset: 0x00170CF4
		public unsafe float SideOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_SideOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInstructionData.StepData.NativeFieldInfoPtr_SideOffset)) = value;
			}
		}

		// Token: 0x04003A92 RID: 14994
		private static readonly IntPtr NativeFieldInfoPtr_HeaderText;

		// Token: 0x04003A93 RID: 14995
		private static readonly IntPtr NativeFieldInfoPtr_BodyText;

		// Token: 0x04003A94 RID: 14996
		private static readonly IntPtr NativeFieldInfoPtr_Pivot;

		// Token: 0x04003A95 RID: 14997
		private static readonly IntPtr NativeFieldInfoPtr_Side;

		// Token: 0x04003A96 RID: 14998
		private static readonly IntPtr NativeFieldInfoPtr_SideOffset;

		// Token: 0x04003A97 RID: 14999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
