using System;
using Il2CppSystem;
using TMPro;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.GameVariants.Mercenary
{
	// Token: 0x02000FC1 RID: 4033
	public class UI_MercenaryRoundScores : MonoBehaviour
	{
		// Token: 0x17006DC8 RID: 28104
		// (get) Token: 0x060135AE RID: 79278 RVA: 0x004DE9AC File Offset: 0x004DCBAC
		// (set) Token: 0x060135AF RID: 79279 RVA: 0x004DE9FC File Offset: 0x004DCBFC
		public unsafe bool ManagedUpdateRemoval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060135B0 RID: 79280 RVA: 0x004DEA50 File Offset: 0x004DCC50
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135B1 RID: 79281 RVA: 0x004DEA94 File Offset: 0x004DCC94
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135B2 RID: 79282 RVA: 0x004DEAD8 File Offset: 0x004DCCD8
		[CallerCount(0)]
		public unsafe void OnManagedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135B3 RID: 79283 RVA: 0x004DEB1C File Offset: 0x004DCD1C
		[CallerCount(0)]
		public unsafe void OnOnScoresChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_OnOnScoresChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135B4 RID: 79284 RVA: 0x004DEB60 File Offset: 0x004DCD60
		[CallerCount(0)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135B5 RID: 79285 RVA: 0x004DEBA4 File Offset: 0x004DCDA4
		[CallerCount(0)]
		public unsafe bool GameInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_GameInProgress_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060135B6 RID: 79286 RVA: 0x004DEBF4 File Offset: 0x004DCDF4
		[CallerCount(0)]
		public unsafe bool ShouldBarBeActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_ShouldBarBeActive_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060135B7 RID: 79287 RVA: 0x004DEC44 File Offset: 0x004DCE44
		[CallerCount(0)]
		public unsafe void RefreshText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_RefreshText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135B8 RID: 79288 RVA: 0x004DEC88 File Offset: 0x004DCE88
		[CallerCount(0)]
		public unsafe string GetGradeFromNormalized(float normalized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalized;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr_GetGradeFromNormalized_Private_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060135B9 RID: 79289 RVA: 0x004DECE8 File Offset: 0x004DCEE8
		[CallerCount(0)]
		public unsafe UI_MercenaryRoundScores() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MercenaryRoundScores.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135BA RID: 79290 RVA: 0x004DED34 File Offset: 0x004DCF34
		// Note: this type is marked as 'beforefieldinit'.
		static UI_MercenaryRoundScores()
		{
			Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.Mercenary", "UI_MercenaryRoundScores");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr);
			UI_MercenaryRoundScores.NativeFieldInfoPtr_Bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "Bar");
			UI_MercenaryRoundScores.NativeFieldInfoPtr_ChallengeLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "ChallengeLevel");
			UI_MercenaryRoundScores.NativeFieldInfoPtr_ObjectiveCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "ObjectiveCompleted");
			UI_MercenaryRoundScores.NativeFieldInfoPtr_EnemiesEliminated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "EnemiesEliminated");
			UI_MercenaryRoundScores.NativeFieldInfoPtr_MissionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "MissionTime");
			UI_MercenaryRoundScores.NativeFieldInfoPtr_SurvivalRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "SurvivalRating");
			UI_MercenaryRoundScores.NativeFieldInfoPtr_RoundScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "RoundScore");
			UI_MercenaryRoundScores.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
			UI_MercenaryRoundScores.NativeFieldInfoPtr__lastTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, "_lastTick");
			UI_MercenaryRoundScores.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688008);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688009);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688010);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688011);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688012);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_OnOnScoresChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688013);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688014);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_GameInProgress_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688015);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_ShouldBarBeActive_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688016);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_RefreshText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688017);
			UI_MercenaryRoundScores.NativeMethodInfoPtr_GetGradeFromNormalized_Private_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688018);
			UI_MercenaryRoundScores.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr, 100688019);
		}

		// Token: 0x060135BB RID: 79291 RVA: 0x0000210C File Offset: 0x0000030C
		public UI_MercenaryRoundScores(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006DBE RID: 28094
		// (get) Token: 0x060135BC RID: 79292 RVA: 0x004DEF08 File Offset: 0x004DD108
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UI_MercenaryRoundScores>.NativeClassPtr));
			}
		}

		// Token: 0x17006DBF RID: 28095
		// (get) Token: 0x060135BD RID: 79293 RVA: 0x004DEF1C File Offset: 0x004DD11C
		// (set) Token: 0x060135BE RID: 79294 RVA: 0x004DEF50 File Offset: 0x004DD150
		public unsafe GameObject Bar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_Bar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_Bar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DC0 RID: 28096
		// (get) Token: 0x060135BF RID: 79295 RVA: 0x004DEF78 File Offset: 0x004DD178
		// (set) Token: 0x060135C0 RID: 79296 RVA: 0x004DEFAC File Offset: 0x004DD1AC
		public unsafe TextMeshProUGUI ChallengeLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_ChallengeLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TextMeshProUGUI(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_ChallengeLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DC1 RID: 28097
		// (get) Token: 0x060135C1 RID: 79297 RVA: 0x004DEFD4 File Offset: 0x004DD1D4
		// (set) Token: 0x060135C2 RID: 79298 RVA: 0x004DF008 File Offset: 0x004DD208
		public unsafe TextMeshProUGUI ObjectiveCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_ObjectiveCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TextMeshProUGUI(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_ObjectiveCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DC2 RID: 28098
		// (get) Token: 0x060135C3 RID: 79299 RVA: 0x004DF030 File Offset: 0x004DD230
		// (set) Token: 0x060135C4 RID: 79300 RVA: 0x004DF064 File Offset: 0x004DD264
		public unsafe TextMeshProUGUI EnemiesEliminated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_EnemiesEliminated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TextMeshProUGUI(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_EnemiesEliminated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DC3 RID: 28099
		// (get) Token: 0x060135C5 RID: 79301 RVA: 0x004DF08C File Offset: 0x004DD28C
		// (set) Token: 0x060135C6 RID: 79302 RVA: 0x004DF0C0 File Offset: 0x004DD2C0
		public unsafe TextMeshProUGUI MissionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_MissionTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TextMeshProUGUI(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_MissionTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DC4 RID: 28100
		// (get) Token: 0x060135C7 RID: 79303 RVA: 0x004DF0E8 File Offset: 0x004DD2E8
		// (set) Token: 0x060135C8 RID: 79304 RVA: 0x004DF11C File Offset: 0x004DD31C
		public unsafe TextMeshProUGUI SurvivalRating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_SurvivalRating);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TextMeshProUGUI(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_SurvivalRating), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DC5 RID: 28101
		// (get) Token: 0x060135C9 RID: 79305 RVA: 0x004DF144 File Offset: 0x004DD344
		// (set) Token: 0x060135CA RID: 79306 RVA: 0x004DF178 File Offset: 0x004DD378
		public unsafe TextMeshProUGUI RoundScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_RoundScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TextMeshProUGUI(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr_RoundScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DC6 RID: 28102
		// (get) Token: 0x060135CB RID: 79307 RVA: 0x004DF1A0 File Offset: 0x004DD3A0
		// (set) Token: 0x060135CC RID: 79308 RVA: 0x004DF1C8 File Offset: 0x004DD3C8
		public unsafe bool _ManagedUpdateRemoval_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
			}
		}

		// Token: 0x17006DC7 RID: 28103
		// (get) Token: 0x060135CD RID: 79309 RVA: 0x004DF1EC File Offset: 0x004DD3EC
		// (set) Token: 0x060135CE RID: 79310 RVA: 0x004DF214 File Offset: 0x004DD414
		public unsafe double _lastTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr__lastTick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MercenaryRoundScores.NativeFieldInfoPtr__lastTick)) = value;
			}
		}

		// Token: 0x0400C607 RID: 50695
		private static readonly IntPtr NativeFieldInfoPtr_Bar;

		// Token: 0x0400C608 RID: 50696
		private static readonly IntPtr NativeFieldInfoPtr_ChallengeLevel;

		// Token: 0x0400C609 RID: 50697
		private static readonly IntPtr NativeFieldInfoPtr_ObjectiveCompleted;

		// Token: 0x0400C60A RID: 50698
		private static readonly IntPtr NativeFieldInfoPtr_EnemiesEliminated;

		// Token: 0x0400C60B RID: 50699
		private static readonly IntPtr NativeFieldInfoPtr_MissionTime;

		// Token: 0x0400C60C RID: 50700
		private static readonly IntPtr NativeFieldInfoPtr_SurvivalRating;

		// Token: 0x0400C60D RID: 50701
		private static readonly IntPtr NativeFieldInfoPtr_RoundScore;

		// Token: 0x0400C60E RID: 50702
		private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

		// Token: 0x0400C60F RID: 50703
		private static readonly IntPtr NativeFieldInfoPtr__lastTick;

		// Token: 0x0400C610 RID: 50704
		private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400C611 RID: 50705
		private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400C612 RID: 50706
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400C613 RID: 50707
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400C614 RID: 50708
		private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400C615 RID: 50709
		private static readonly IntPtr NativeMethodInfoPtr_OnOnScoresChanged_Private_Void_0;

		// Token: 0x0400C616 RID: 50710
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x0400C617 RID: 50711
		private static readonly IntPtr NativeMethodInfoPtr_GameInProgress_Private_Boolean_0;

		// Token: 0x0400C618 RID: 50712
		private static readonly IntPtr NativeMethodInfoPtr_ShouldBarBeActive_Private_Boolean_0;

		// Token: 0x0400C619 RID: 50713
		private static readonly IntPtr NativeMethodInfoPtr_RefreshText_Private_Void_0;

		// Token: 0x0400C61A RID: 50714
		private static readonly IntPtr NativeMethodInfoPtr_GetGradeFromNormalized_Private_String_Single_0;

		// Token: 0x0400C61B RID: 50715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
