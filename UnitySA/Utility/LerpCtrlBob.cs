using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnitySA.Utility
{
	// Token: 0x02000626 RID: 1574
	[Serializable]
	public class LerpCtrlBob : Object
	{
		// Token: 0x06007FF1 RID: 32753 RVA: 0x00204EF4 File Offset: 0x002030F4
		[CallerCount(0)]
		public unsafe float Offset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob.NativeMethodInfoPtr_Offset_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00204F44 File Offset: 0x00203144
		[CallerCount(0)]
		public unsafe IEnumerator DoBobCycle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob.NativeMethodInfoPtr_DoBobCycle_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x00204F9C File Offset: 0x0020319C
		[CallerCount(0)]
		public unsafe LerpCtrlBob() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x00204FE8 File Offset: 0x002031E8
		// Note: this type is marked as 'beforefieldinit'.
		static LerpCtrlBob()
		{
			Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnitySA.Utility", "LerpCtrlBob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr);
			LerpCtrlBob.NativeFieldInfoPtr_BobDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr, "BobDuration");
			LerpCtrlBob.NativeFieldInfoPtr_BobAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr, "BobAmount");
			LerpCtrlBob.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr, "m_Offset");
			LerpCtrlBob.NativeMethodInfoPtr_Offset_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr, 100673619);
			LerpCtrlBob.NativeMethodInfoPtr_DoBobCycle_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr, 100673620);
			LerpCtrlBob.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr, 100673621);
		}

		// Token: 0x06007FF5 RID: 32757 RVA: 0x00002988 File Offset: 0x00000B88
		public LerpCtrlBob(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x06007FF6 RID: 32758 RVA: 0x00205090 File Offset: 0x00203290
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr));
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x002050A4 File Offset: 0x002032A4
		// (set) Token: 0x06007FF8 RID: 32760 RVA: 0x002050CC File Offset: 0x002032CC
		public unsafe float BobDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob.NativeFieldInfoPtr_BobDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob.NativeFieldInfoPtr_BobDuration)) = value;
			}
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x06007FF9 RID: 32761 RVA: 0x002050F0 File Offset: 0x002032F0
		// (set) Token: 0x06007FFA RID: 32762 RVA: 0x00205118 File Offset: 0x00203318
		public unsafe float BobAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob.NativeFieldInfoPtr_BobAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob.NativeFieldInfoPtr_BobAmount)) = value;
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x06007FFB RID: 32763 RVA: 0x0020513C File Offset: 0x0020333C
		// (set) Token: 0x06007FFC RID: 32764 RVA: 0x00205164 File Offset: 0x00203364
		public unsafe float m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x04005204 RID: 20996
		private static readonly IntPtr NativeFieldInfoPtr_BobDuration;

		// Token: 0x04005205 RID: 20997
		private static readonly IntPtr NativeFieldInfoPtr_BobAmount;

		// Token: 0x04005206 RID: 20998
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x04005207 RID: 20999
		private static readonly IntPtr NativeMethodInfoPtr_Offset_Public_Single_0;

		// Token: 0x04005208 RID: 21000
		private static readonly IntPtr NativeMethodInfoPtr_DoBobCycle_Public_IEnumerator_0;

		// Token: 0x04005209 RID: 21001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000627 RID: 1575
		[ObfuscatedName("UnitySA.Utility.LerpCtrlBob/<DoBobCycle>d__4")]
		public sealed class _DoBobCycle_d__4 : Object
		{
			// Token: 0x06007FFD RID: 32765 RVA: 0x00205188 File Offset: 0x00203388
			[CallerCount(0)]
			public unsafe _DoBobCycle_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007FFE RID: 32766 RVA: 0x002051E8 File Offset: 0x002033E8
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007FFF RID: 32767 RVA: 0x0020522C File Offset: 0x0020342C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002DC4 RID: 11716
			// (get) Token: 0x06008000 RID: 32768 RVA: 0x0020527C File Offset: 0x0020347C
			public unsafe Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Object(intPtr2) : null;
				}
			}

			// Token: 0x06008001 RID: 32769 RVA: 0x002052D4 File Offset: 0x002034D4
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002DC5 RID: 11717
			// (get) Token: 0x06008002 RID: 32770 RVA: 0x00205318 File Offset: 0x00203518
			public unsafe Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Object(intPtr2) : null;
				}
			}

			// Token: 0x06008003 RID: 32771 RVA: 0x00205370 File Offset: 0x00203570
			// Note: this type is marked as 'beforefieldinit'.
			static _DoBobCycle_d__4()
			{
				Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LerpCtrlBob>.NativeClassPtr, "<DoBobCycle>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr);
				LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, "<>1__state");
				LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, "<>2__current");
				LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, "<>4__this");
				LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, "<t>5__2");
				LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, 100673622);
				LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, 100673623);
				LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, 100673624);
				LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, 100673625);
				LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, 100673626);
				LerpCtrlBob._DoBobCycle_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr, 100673627);
			}

			// Token: 0x06008004 RID: 32772 RVA: 0x00002988 File Offset: 0x00000B88
			public _DoBobCycle_d__4(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002DBF RID: 11711
			// (get) Token: 0x06008005 RID: 32773 RVA: 0x00205463 File Offset: 0x00203663
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LerpCtrlBob._DoBobCycle_d__4>.NativeClassPtr));
				}
			}

			// Token: 0x17002DC0 RID: 11712
			// (get) Token: 0x06008006 RID: 32774 RVA: 0x00205474 File Offset: 0x00203674
			// (set) Token: 0x06008007 RID: 32775 RVA: 0x0020549C File Offset: 0x0020369C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002DC1 RID: 11713
			// (get) Token: 0x06008008 RID: 32776 RVA: 0x002054C0 File Offset: 0x002036C0
			// (set) Token: 0x06008009 RID: 32777 RVA: 0x002054F4 File Offset: 0x002036F4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002DC2 RID: 11714
			// (get) Token: 0x0600800A RID: 32778 RVA: 0x0020551C File Offset: 0x0020371C
			// (set) Token: 0x0600800B RID: 32779 RVA: 0x00205550 File Offset: 0x00203750
			public unsafe LerpCtrlBob __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new LerpCtrlBob(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002DC3 RID: 11715
			// (get) Token: 0x0600800C RID: 32780 RVA: 0x00205578 File Offset: 0x00203778
			// (set) Token: 0x0600800D RID: 32781 RVA: 0x002055A0 File Offset: 0x002037A0
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LerpCtrlBob._DoBobCycle_d__4.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x0400520A RID: 21002
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400520B RID: 21003
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400520C RID: 21004
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400520D RID: 21005
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x0400520E RID: 21006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400520F RID: 21007
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005210 RID: 21008
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005211 RID: 21009
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005212 RID: 21010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005213 RID: 21011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
