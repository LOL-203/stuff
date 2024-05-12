using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tanks.UI
{
	// Token: 0x020005C1 RID: 1473
	public class HUDMultiplayerScore : MonoBehaviour
	{
		// Token: 0x060077EF RID: 30703 RVA: 0x001E38F8 File Offset: 0x001E1AF8
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUDMultiplayerScore.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x001E3948 File Offset: 0x001E1B48
		[CallerCount(0)]
		public unsafe void UpdateScoreDisplay(Il2CppStructArray<Color> colours, Il2CppStructArray<int> scores)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colours);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scores);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUDMultiplayerScore.NativeMethodInfoPtr_UpdateScoreDisplay_Public_Void_ArrayOf_Color_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x001E39BC File Offset: 0x001E1BBC
		[CallerCount(0)]
		public unsafe HUDMultiplayerScore() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUDMultiplayerScore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x001E3A08 File Offset: 0x001E1C08
		// Note: this type is marked as 'beforefieldinit'.
		static HUDMultiplayerScore()
		{
			Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tanks.UI", "HUDMultiplayerScore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr);
			HUDMultiplayerScore.NativeFieldInfoPtr_m_TargetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr, "m_TargetValue");
			HUDMultiplayerScore.NativeFieldInfoPtr_m_ScoreParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr, "m_ScoreParent");
			HUDMultiplayerScore.NativeFieldInfoPtr_m_TeamIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr, "m_TeamIcons");
			HUDMultiplayerScore.NativeFieldInfoPtr_m_TeamScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr, "m_TeamScores");
			HUDMultiplayerScore.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr, 100672881);
			HUDMultiplayerScore.NativeMethodInfoPtr_UpdateScoreDisplay_Public_Void_ArrayOf_Color_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr, 100672882);
			HUDMultiplayerScore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr, 100672883);
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x0000210C File Offset: 0x0000030C
		public HUDMultiplayerScore(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x060077F4 RID: 30708 RVA: 0x001E3AC4 File Offset: 0x001E1CC4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HUDMultiplayerScore>.NativeClassPtr));
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x060077F5 RID: 30709 RVA: 0x001E3AD8 File Offset: 0x001E1CD8
		// (set) Token: 0x060077F6 RID: 30710 RVA: 0x001E3B0C File Offset: 0x001E1D0C
		public unsafe Text m_TargetValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUDMultiplayerScore.NativeFieldInfoPtr_m_TargetValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUDMultiplayerScore.NativeFieldInfoPtr_m_TargetValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x060077F7 RID: 30711 RVA: 0x001E3B34 File Offset: 0x001E1D34
		// (set) Token: 0x060077F8 RID: 30712 RVA: 0x001E3B68 File Offset: 0x001E1D68
		public unsafe Il2CppReferenceArray<GameObject> m_ScoreParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUDMultiplayerScore.NativeFieldInfoPtr_m_ScoreParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUDMultiplayerScore.NativeFieldInfoPtr_m_ScoreParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x060077F9 RID: 30713 RVA: 0x001E3B90 File Offset: 0x001E1D90
		// (set) Token: 0x060077FA RID: 30714 RVA: 0x001E3BC4 File Offset: 0x001E1DC4
		public unsafe Il2CppReferenceArray<Image> m_TeamIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUDMultiplayerScore.NativeFieldInfoPtr_m_TeamIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUDMultiplayerScore.NativeFieldInfoPtr_m_TeamIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x060077FB RID: 30715 RVA: 0x001E3BEC File Offset: 0x001E1DEC
		// (set) Token: 0x060077FC RID: 30716 RVA: 0x001E3C20 File Offset: 0x001E1E20
		public unsafe Il2CppReferenceArray<Text> m_TeamScores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUDMultiplayerScore.NativeFieldInfoPtr_m_TeamScores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUDMultiplayerScore.NativeFieldInfoPtr_m_TeamScores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CB6 RID: 19638
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetValue;

		// Token: 0x04004CB7 RID: 19639
		private static readonly IntPtr NativeFieldInfoPtr_m_ScoreParent;

		// Token: 0x04004CB8 RID: 19640
		private static readonly IntPtr NativeFieldInfoPtr_m_TeamIcons;

		// Token: 0x04004CB9 RID: 19641
		private static readonly IntPtr NativeFieldInfoPtr_m_TeamScores;

		// Token: 0x04004CBA RID: 19642
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004CBB RID: 19643
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScoreDisplay_Public_Void_ArrayOf_Color_ArrayOf_Int32_0;

		// Token: 0x04004CBC RID: 19644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
