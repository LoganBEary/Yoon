#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000005 System.Exception System.Linq.Error::NoMatch()
extern void Error_NoMatch_mA0FE78EC100066FA506B4C1C3AEC2E9E2DB79945 (void);
// 0x00000006 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000007 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000008 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000009 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000C System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000D System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000F System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000010 TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000012 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000013 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000014 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000015 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000016 TSource System.Linq.Enumerable::Last(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000017 TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000018 TSource System.Linq.Enumerable::ElementAt(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x00000019 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Empty()
// 0x0000001A System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000001B System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001C System.Boolean System.Linq.Enumerable::All(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001D System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000001E System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001F System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x00000020 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000021 System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x00000022 TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000023 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000024 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x00000025 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000026 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000027 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000028 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000029 System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x0000002A System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000002B System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x0000002C System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000002D System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x0000002E System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x0000002F System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x00000030 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000031 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000032 System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000033 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000034 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x00000035 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000036 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000037 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000038 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000039 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x0000003A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000003B System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000003C System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003D System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x0000003E System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x0000003F System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x00000040 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000041 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000042 System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000043 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x00000044 System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x00000045 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000046 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000047 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000048 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x00000049 System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x0000004A System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000004B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000004C System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x0000004D System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x0000004E System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x0000004F TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x00000050 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x00000051 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x00000052 System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x00000053 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x00000054 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x00000055 TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x00000056 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x00000057 System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x00000058 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x00000059 System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x0000005A System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x0000005B System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x0000005C System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x0000005D System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x0000005E TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x0000005F System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x00000060 System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x00000061 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000062 System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000063 System.Void System.Linq.EmptyEnumerable`1::.cctor()
// 0x00000064 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.IOrderedEnumerable`1::CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000065 System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x00000066 System.Boolean System.Linq.Set`1::Add(TElement)
// 0x00000067 System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x00000068 System.Void System.Linq.Set`1::Resize()
// 0x00000069 System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x0000006A System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x0000006B System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x0000006C System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000006D System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000006E System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x0000006F System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x00000070 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x00000071 System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x00000072 TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x00000073 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x00000074 System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x00000075 System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000076 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000077 System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x00000078 System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x00000079 System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x0000007A System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x0000007B System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x0000007C System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x0000007D System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x0000007E System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x0000007F System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000080 TElement[] System.Linq.Buffer`1::ToArray()
// 0x00000081 System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x00000082 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x00000083 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000084 System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x00000085 System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x00000086 System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x00000087 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x00000088 System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x00000089 System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x0000008A System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x0000008B System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x0000008C System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x0000008D System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000008E System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000008F System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x00000090 System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x00000091 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x00000092 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x00000093 System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x00000094 System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x00000095 System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x00000096 System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x00000097 System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x00000098 System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x00000099 System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x0000009A System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x0000009B T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x0000009C System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x0000009D System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[157] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	Error_NoMatch_mA0FE78EC100066FA506B4C1C3AEC2E9E2DB79945,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[157] = 
{
	5651,
	5651,
	5866,
	5866,
	5866,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[55] = 
{
	{ 0x02000004, { 88, 4 } },
	{ 0x02000005, { 92, 9 } },
	{ 0x02000006, { 103, 7 } },
	{ 0x02000007, { 112, 10 } },
	{ 0x02000008, { 124, 11 } },
	{ 0x02000009, { 138, 9 } },
	{ 0x0200000A, { 150, 12 } },
	{ 0x0200000B, { 165, 1 } },
	{ 0x0200000C, { 166, 2 } },
	{ 0x0200000D, { 168, 12 } },
	{ 0x0200000E, { 180, 11 } },
	{ 0x0200000F, { 191, 2 } },
	{ 0x02000011, { 193, 8 } },
	{ 0x02000013, { 201, 3 } },
	{ 0x02000014, { 206, 5 } },
	{ 0x02000015, { 211, 7 } },
	{ 0x02000016, { 218, 3 } },
	{ 0x02000017, { 221, 7 } },
	{ 0x02000018, { 228, 4 } },
	{ 0x02000019, { 232, 21 } },
	{ 0x0200001B, { 253, 2 } },
	{ 0x06000006, { 0, 10 } },
	{ 0x06000007, { 10, 10 } },
	{ 0x06000008, { 20, 5 } },
	{ 0x06000009, { 25, 5 } },
	{ 0x0600000A, { 30, 1 } },
	{ 0x0600000B, { 31, 2 } },
	{ 0x0600000C, { 33, 2 } },
	{ 0x0600000D, { 35, 1 } },
	{ 0x0600000E, { 36, 1 } },
	{ 0x0600000F, { 37, 2 } },
	{ 0x06000010, { 39, 3 } },
	{ 0x06000011, { 42, 2 } },
	{ 0x06000012, { 44, 4 } },
	{ 0x06000013, { 48, 3 } },
	{ 0x06000014, { 51, 4 } },
	{ 0x06000015, { 55, 3 } },
	{ 0x06000016, { 58, 4 } },
	{ 0x06000017, { 62, 3 } },
	{ 0x06000018, { 65, 3 } },
	{ 0x06000019, { 68, 1 } },
	{ 0x0600001A, { 69, 1 } },
	{ 0x0600001B, { 70, 3 } },
	{ 0x0600001C, { 73, 3 } },
	{ 0x0600001D, { 76, 2 } },
	{ 0x0600001E, { 78, 3 } },
	{ 0x0600001F, { 81, 2 } },
	{ 0x06000020, { 83, 5 } },
	{ 0x06000030, { 101, 2 } },
	{ 0x06000035, { 110, 2 } },
	{ 0x0600003A, { 122, 2 } },
	{ 0x06000040, { 135, 3 } },
	{ 0x06000045, { 147, 3 } },
	{ 0x0600004A, { 162, 3 } },
	{ 0x0600006D, { 204, 2 } },
};
extern const uint32_t g_rgctx_Iterator_1_t636279D5C9025C29159E9C0F450D35FFAC93279B;
extern const uint32_t g_rgctx_Iterator_1_Where_m0335429642E75AAECFBE3A2FFB3E69C0902CD0D0;
extern const uint32_t g_rgctx_TSourceU5BU5D_tB85C233E707A0361D6D93CC945959A97B295E668;
extern const uint32_t g_rgctx_WhereArrayIterator_1_t78D2E4CACFC7E7EF98F4400F475AA11085112BAB;
extern const uint32_t g_rgctx_WhereArrayIterator_1__ctor_m14EFDE07937A9AD4F82AC1A74EB288C173BFB848;
extern const uint32_t g_rgctx_List_1_tE71B82DE094FF5C3CFC4CEB615B5DF14BD949490;
extern const uint32_t g_rgctx_WhereListIterator_1_tFF147832A53F8A9DE165473807DDCFD3CC89BB27;
extern const uint32_t g_rgctx_WhereListIterator_1__ctor_m486D06E9DF259E0447D58D5862CD621A244EC394;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1_tD45416FF1F026DC4A566886D1F9A85298AE985EE;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1__ctor_m728988B0E986DD25EA1A1245D615A4D8C365CD58;
extern const uint32_t g_rgctx_Iterator_1_tC2E699D86C01BAC6905B98B63B33736C033E71D1;
extern const uint32_t g_rgctx_Iterator_1_Select_TisTResult_tEC92E99E2F99696D564F9F0BF815FEF3CB5ADB24_m0D623474504357AC2390442FA49A3614816C30EB;
extern const uint32_t g_rgctx_TSourceU5BU5D_t4F9441DF0F8CE638F5AE03184356E2547BE07D8B;
extern const uint32_t g_rgctx_WhereSelectArrayIterator_2_t2180864D420574607DB2234C9C01679FE54D8CE0;
extern const uint32_t g_rgctx_WhereSelectArrayIterator_2__ctor_mDD41DB7136FC0D1BAAD6387FDF1CD6AB89DAAFAA;
extern const uint32_t g_rgctx_List_1_t4845168BC8478686CF2BBE4464D2DAFF823D0084;
extern const uint32_t g_rgctx_WhereSelectListIterator_2_tD8B9E9B726B2A13391A120779B663B6B066FE46C;
extern const uint32_t g_rgctx_WhereSelectListIterator_2__ctor_mAEBB72130A83942691D7AD550E95275A4568F008;
extern const uint32_t g_rgctx_WhereSelectEnumerableIterator_2_tAF002CEC5D0A77CDB9D819FDC46DD0BA58C1BBA6;
extern const uint32_t g_rgctx_WhereSelectEnumerableIterator_2__ctor_m6B03D41394EC2F95D12611A98B59B9216388D808;
extern const uint32_t g_rgctx_U3CU3Ec__DisplayClass6_0_1_tAAE11763AA13976D45FD650D42F519700CF99D38;
extern const uint32_t g_rgctx_U3CU3Ec__DisplayClass6_0_1__ctor_m86EDAA3687D7C1F88D7F2948EB133CD52D1F67B4;
extern const uint32_t g_rgctx_U3CU3Ec__DisplayClass6_0_1_U3CCombinePredicatesU3Eb__0_m6AC677496E624733DBE45B58781535FBE0676A8B;
extern const uint32_t g_rgctx_Func_2_tBBA43EC3AE1D3C51038FD479D6428C8DD30B04E6;
extern const uint32_t g_rgctx_Func_2__ctor_m3DFE5D5406D3378215342C16ED24C3A1E0E779E2;
extern const uint32_t g_rgctx_U3CU3Ec__DisplayClass7_0_3_t0683908CF809AD10ED7CC6D62163918C9696939B;
extern const uint32_t g_rgctx_U3CU3Ec__DisplayClass7_0_3__ctor_m457EDCE9B47108492ADD67B0A9810080E39D1BE2;
extern const uint32_t g_rgctx_U3CU3Ec__DisplayClass7_0_3_U3CCombineSelectorsU3Eb__0_m3345F80CF52FB25D5B643E53940EC65D4DE624FF;
extern const uint32_t g_rgctx_Func_2_tD04771F273735C559AE55788BC543AC64480CCE3;
extern const uint32_t g_rgctx_Func_2__ctor_m5A1DFF0655E17E626732D3F1D7121D991CDB0179;
extern const uint32_t g_rgctx_Enumerable_SelectManyIterator_TisTSource_tBD009412AD3F1786CECED18979B2B0F140C0064A_TisTResult_t01F43662929D207091184DC2CC10747DAC9D22F9_m1610399E32CC4BAA463960D33A7E764D36866682;
extern const uint32_t g_rgctx_U3CSelectManyIteratorU3Ed__17_2_t20BDC5A431EA6AFCE07E8D5AE307A77924872724;
extern const uint32_t g_rgctx_U3CSelectManyIteratorU3Ed__17_2__ctor_m4548C69D5E8C5A0855B02A4D734A3BBF778A3E18;
extern const uint32_t g_rgctx_OrderedEnumerable_2_t015D762D3F1278F3A8095CC482498F0C833B0984;
extern const uint32_t g_rgctx_OrderedEnumerable_2__ctor_m45A55EB5FF2CE3D2BDF45E1B690EF35E0D5DE727;
extern const uint32_t g_rgctx_IOrderedEnumerable_1_CreateOrderedEnumerable_TisTKey_t02D36AA7EBCABE787524643443A1C180EB801194_m19CC62B5F0A74905DBA2306241A5677B42E07BB6;
extern const uint32_t g_rgctx_Enumerable_DistinctIterator_TisTSource_t0E571C196610719CB0262CB18C052BADF05665E1_m4905D51260B208ADC19702C44BFF6C15AF7CE7C4;
extern const uint32_t g_rgctx_U3CDistinctIteratorU3Ed__68_1_t59F098E3D4A7AA6B48A348A71D69042B7244EDF8;
extern const uint32_t g_rgctx_U3CDistinctIteratorU3Ed__68_1__ctor_m8B955A99713D9D4DCCE789E5C1AF3714F0C685F9;
extern const uint32_t g_rgctx_Buffer_1_tC5729D25A3E364254D0A1FCE4E06925DD5747329;
extern const uint32_t g_rgctx_Buffer_1__ctor_m222E095AE1BB3A973DDD54EF9E1B4D5B736CCD17;
extern const uint32_t g_rgctx_Buffer_1_ToArray_mC3E5B9F0AEC815A68ACDD77645E6B71FF4075C1D;
extern const uint32_t g_rgctx_List_1_tF50400EBC15D6DEEC3C43073E29EA18AE57314CC;
extern const uint32_t g_rgctx_List_1__ctor_m1AF07A5AAF7431D4835996D42244831EF686194F;
extern const uint32_t g_rgctx_IList_1_tCAC22142D45D9B5BEDC0EC4316FB0787780E59C0;
extern const uint32_t g_rgctx_ICollection_1_t304709A63D159EB9956CBC8F5384C8DC17DAB944;
extern const uint32_t g_rgctx_IEnumerable_1_t3EEB6E917754CC0F2D884B5BAF09F79D06A23371;
extern const uint32_t g_rgctx_IEnumerator_1_t3443F0B85E56B92C25A45DC489F4E78C696B382A;
extern const uint32_t g_rgctx_IEnumerable_1_tC3B2CE8F52F3BB899EBAA1EDCCAFC94B8C199C91;
extern const uint32_t g_rgctx_IEnumerator_1_tA6115F2D209E3052BD9C6B9ED5270B324DB8D210;
extern const uint32_t g_rgctx_Func_2_Invoke_mD3C2DB22B2853F8EE705EB307E4FF49DE6879850;
extern const uint32_t g_rgctx_IList_1_tA9AD20C95EF7B6D8E6684801D115EDC35C76816B;
extern const uint32_t g_rgctx_ICollection_1_t0756D2BE833E99CBAC7DD7113000DA8DBC47C91A;
extern const uint32_t g_rgctx_IEnumerable_1_tD1E9BC1098C430D557C3F5E7C9227B6F15E01596;
extern const uint32_t g_rgctx_IEnumerator_1_tFC7F0E9D98E7DDACBD936C35C5E0FE3B6B2B0234;
extern const uint32_t g_rgctx_IEnumerable_1_t8DB477F20651176E75D2BCAEDF981D633D80CD34;
extern const uint32_t g_rgctx_IEnumerator_1_t4B7E760977A64E74AB1647667A03A3AC39E9537F;
extern const uint32_t g_rgctx_Func_2_Invoke_m9A695867B12FDC2909EE58D3C12974290AC63570;
extern const uint32_t g_rgctx_IList_1_t9B2C39DD1935C0159FB061115AF5530046049F74;
extern const uint32_t g_rgctx_ICollection_1_t35B5CBD8B2D72DA7EC88941F6C85DA6146A26DAB;
extern const uint32_t g_rgctx_IEnumerable_1_t5586386B55A509E36FD800F6EAAE2C2F1A01CBEB;
extern const uint32_t g_rgctx_IEnumerator_1_tD60C4749BBF149AB239D1DED16B258BCBD0E5F8F;
extern const uint32_t g_rgctx_IEnumerable_1_tD0880E4FF3F8B3DBC95295C115964852F4006BDE;
extern const uint32_t g_rgctx_IEnumerator_1_t2BDF305126D656BD2B3734A2BA28F10607A82074;
extern const uint32_t g_rgctx_Func_2_Invoke_mE9A75A107233FECEE19A1C1E3AC7D3819565F736;
extern const uint32_t g_rgctx_IList_1_t307E8207DE3AA9A02CD709BD06A9B8EAC46F0357;
extern const uint32_t g_rgctx_IEnumerable_1_t91572A34863F4F06BB3B8A9F249931D7E4A5937A;
extern const uint32_t g_rgctx_IEnumerator_1_tF3682B7A6AD234903897B5FA886E746E71CF16EC;
extern const uint32_t g_rgctx_EmptyEnumerable_1_t461C324301407FD7CF00125C74C7BBB10E425032;
extern const uint32_t g_rgctx_IEnumerable_1_t6B558838B603B0E97AFA74C50F667305BDC94859;
extern const uint32_t g_rgctx_IEnumerable_1_tA56BDC4BCA945A181D326F97ACDDB3A23C56D75F;
extern const uint32_t g_rgctx_IEnumerator_1_t71577311A5349A81219A3AAA87F5D7C87441334D;
extern const uint32_t g_rgctx_Func_2_Invoke_m22BF94126E79C0060E291A3973838BE70CBE99EF;
extern const uint32_t g_rgctx_IEnumerable_1_t826591D99F39EC886748F26C7D52C94B1C4240E9;
extern const uint32_t g_rgctx_IEnumerator_1_t45B3683D4BDDC10D277E47094E9317877787CAC3;
extern const uint32_t g_rgctx_Func_2_Invoke_m1531C38ACD1E4CA7B46FA8B34CC329EDA0CC0D4B;
extern const uint32_t g_rgctx_ICollection_1_t401C1362FA9CAA778DB957CA35F29F955A470D4D;
extern const uint32_t g_rgctx_IEnumerable_1_t0AA8DC1E145B18DB5BB6E9E999383C3368225353;
extern const uint32_t g_rgctx_IEnumerable_1_t4E09BD5660E84A1966ED46BD965A81EF3BDE2D98;
extern const uint32_t g_rgctx_IEnumerator_1_t42B22C956C74AC2C5E2E4D9FAC7A3F6054A5AD92;
extern const uint32_t g_rgctx_Func_2_Invoke_m69B76648DEF403A413DD2A96679170EECFC79CF9;
extern const uint32_t g_rgctx_ICollection_1_t12A52A64081A5954F5F3EA1E13DAF2587E8C57DE;
extern const uint32_t g_rgctx_Enumerable_Contains_TisTSource_t941CC4C3B89ECA76D1FAFE3BC385974F6C8372B2_m7B5F33A4BBBBE98861FC9B38AEE5090109400C8C;
extern const uint32_t g_rgctx_EqualityComparer_1_get_Default_m0DD948D8CCA4C1DA30E417512F50E4F463CFEBC2;
extern const uint32_t g_rgctx_EqualityComparer_1_tC54E5776F429F385C6E93384568ABC1174A92F62;
extern const uint32_t g_rgctx_IEnumerable_1_t1C203359ED16BCC43AC4805C465D8D500686ADA8;
extern const uint32_t g_rgctx_IEnumerator_1_t102BE58A70A4033CB1BCB8B4D26DFB372CE314D2;
extern const uint32_t g_rgctx_IEqualityComparer_1_t0F97F8650BAFC726D27A22B8B8478C2C7DC2B103;
extern const uint32_t g_rgctx_Iterator_1_Clone_m16088BFE7F81DDE461A0BB4E1EA29363B7201A88;
extern const uint32_t g_rgctx_Iterator_1_get_Current_mBBDFA8B8A3ABB39089FBAAFB585F74B0645D5B9E;
extern const uint32_t g_rgctx_TSource_tE27C213B5C79D15F8C95F178F87A749A817CDA5D;
extern const uint32_t g_rgctx_Iterator_1_GetEnumerator_m13277F825C4179EF9CDE7A56336BA548EBDD8B66;
extern const uint32_t g_rgctx_Iterator_1__ctor_m7514E41D23F3DE4CFB867A3D46DFA8B2501AE00A;
extern const uint32_t g_rgctx_Iterator_1_t50B70FACDE0E1B34143E9F8CD22ACA0B10FEEC26;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1_tE5D85FF692C59EBD4579D71A361979792364C8C2;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1__ctor_mB813B1FE2E20D2DF6F0FAB6A3038EF326256668F;
extern const uint32_t g_rgctx_Iterator_1_Dispose_m458FCA659FADA5A1CDD35B01DC76E07FC79011F6;
extern const uint32_t g_rgctx_IEnumerable_1_t014A3E7CE41868FE585432BE1E1F32DAF551BB36;
extern const uint32_t g_rgctx_IEnumerator_1_t540613216E99A3140BFFB2141072CF8D8C55007A;
extern const uint32_t g_rgctx_Func_2_Invoke_m9F7D28A9D6156DF8A1B912FFA0F747CFDBFC8D85;
extern const uint32_t g_rgctx_Enumerable_CombinePredicates_TisTSource_t925AD170B396F364902F7FA31791C320095C54E5_m204DB79421EDD3974CD0BFE16F7EF7B4FA48F1EA;
extern const uint32_t g_rgctx_WhereSelectEnumerableIterator_2_t46C994A1424EC5EF082C585BBB32C2AD1D3D4CB3;
extern const uint32_t g_rgctx_WhereSelectEnumerableIterator_2__ctor_m08367FB68BE2F5519F0A182BD80B2D4F7424C917;
extern const uint32_t g_rgctx_Iterator_1__ctor_m26CBEC6F3738C13265ED9A1DB94EAA482E5EEA40;
extern const uint32_t g_rgctx_Iterator_1_tDCC95199B9B0AE888166B600A2150724F5886269;
extern const uint32_t g_rgctx_WhereArrayIterator_1_t20BBB4A170F4320F138F207A6EBFB6C88FA8C6A1;
extern const uint32_t g_rgctx_WhereArrayIterator_1__ctor_m035206C0A4EEE229CD66670619A7BDC8DDE59F9F;
extern const uint32_t g_rgctx_Func_2_Invoke_m8E3DE59DA6A8AE4BCFAA34FA8B17B381A99D11AE;
extern const uint32_t g_rgctx_Iterator_1_Dispose_mBF633E0AC48DC442C116F953FC60AFF40436CEA9;
extern const uint32_t g_rgctx_Enumerable_CombinePredicates_TisTSource_t78A097556235CA68272579A40AC9ABEE8E6228C8_mE267EE8715DC4D0B54E4FFA4137132863C8C05D5;
extern const uint32_t g_rgctx_WhereSelectArrayIterator_2_tF7F044DA24DECBE0E5A6AE433108FE4E8268155F;
extern const uint32_t g_rgctx_WhereSelectArrayIterator_2__ctor_m075E1384C767F3300E3B2B6BAE298A12DB74F92F;
extern const uint32_t g_rgctx_Iterator_1__ctor_mCC9DED6DA7E9DD65B1EF6F217D5806777C1C1C85;
extern const uint32_t g_rgctx_Iterator_1_t46EC0822C64AE0439F8EE76EB5155C7A9001F557;
extern const uint32_t g_rgctx_WhereListIterator_1_tADF109EE7959D1951D59B9C41E18BD70E5441BB9;
extern const uint32_t g_rgctx_WhereListIterator_1__ctor_m9002AB02279AE8B262F8BAAA95BE527B987ED958;
extern const uint32_t g_rgctx_List_1_GetEnumerator_mAFED2F8101B027035699A20B4805B534C316344E;
extern const uint32_t g_rgctx_Enumerator_get_Current_mE985AB113BB4586F6450A4754514B631705E7065;
extern const uint32_t g_rgctx_Func_2_Invoke_m91A41D91BF9C53B5FCB823CEC4C05441E7358252;
extern const uint32_t g_rgctx_Enumerator_MoveNext_mD2B6AE94B197322F4771CD14316E0B95B8D82E64;
extern const uint32_t g_rgctx_Iterator_1_Dispose_mBCB5A059BDA76FBC39499E43B3D8BB751ECA6373;
extern const uint32_t g_rgctx_Enumerable_CombinePredicates_TisTSource_tD1ACF1646AF878DBE965885289D74649B3B828A3_m88595760E15A41A2E59213D4FBDF33DC3A92E7E6;
extern const uint32_t g_rgctx_WhereSelectListIterator_2_t8A71567888F15A3623F26A2EB610FC3763B9FF64;
extern const uint32_t g_rgctx_WhereSelectListIterator_2__ctor_mCDDF6695E39D352EBF7D6737D08A17681DDBA0EB;
extern const uint32_t g_rgctx_Iterator_1__ctor_m9C015AF4A450B4E6EB725D0A6EA193EC87089916;
extern const uint32_t g_rgctx_Iterator_1_t4A1A94CD1362426652FE8007391D7ACD149C3CAA;
extern const uint32_t g_rgctx_WhereSelectEnumerableIterator_2_t7031169C0E37784A65AB4F5B17C5BF181037AF67;
extern const uint32_t g_rgctx_WhereSelectEnumerableIterator_2__ctor_mBCA01725B4D027EBDD90FF78834AF3D2322B97CD;
extern const uint32_t g_rgctx_Iterator_1_Dispose_m9F3180789FE400C31D35F9F6D743AC390A0261D1;
extern const uint32_t g_rgctx_IEnumerable_1_t59F6FB0A645176EC2A74EFC6A6954B6A0BD8613E;
extern const uint32_t g_rgctx_IEnumerator_1_tC005608F0795FDFDD43CF49AD0A68249E3CF1555;
extern const uint32_t g_rgctx_Func_2_Invoke_m80421D41060FA82A34CE13118BDD3A56276FFEC8;
extern const uint32_t g_rgctx_Func_2_Invoke_m03A1520007AD7AA7EB571079CEEBEA13E126518D;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1_tFF7F615E8575AD96233222E6633A1C896E1BF3FE;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1__ctor_m5411CF60E5F86BF7F54AFBD1E0C95C9688B29B92;
extern const uint32_t g_rgctx_Enumerable_CombineSelectors_TisTSource_tC2E77D7EA4AE607508C03DFA1362450D1DB1A2C4_TisTResult_t3163C282AB187D44EE2308497F3395E3287C66FD_TisTResult2_tFB17268A1DEC3B455218E8232DBF56A873701CCE_mA318522BDC6EBB841C57419082205164CCD9F44A;
extern const uint32_t g_rgctx_WhereSelectEnumerableIterator_2_t3E5F5CEC2B587397A95F9C132A4E93577A0E9EFA;
extern const uint32_t g_rgctx_WhereSelectEnumerableIterator_2__ctor_m5DC380D132EC785F06988E5FD0D09A247B0DF032;
extern const uint32_t g_rgctx_Iterator_1__ctor_m14C0DC72B8DD1FC0A32BA34CC7E04FF3106D72B8;
extern const uint32_t g_rgctx_Iterator_1_t8CC8E16A7609A1CB8D299492A8EA1452111C811D;
extern const uint32_t g_rgctx_WhereSelectArrayIterator_2_tC23CA6F5F16345355F547FF9E1F2156DCD628787;
extern const uint32_t g_rgctx_WhereSelectArrayIterator_2__ctor_m892A5BC3C31E7332525AE5D21A1138941C2B6DE2;
extern const uint32_t g_rgctx_Func_2_Invoke_mD9083CFC73A356C4CB6A92B62C096336829907FC;
extern const uint32_t g_rgctx_Func_2_Invoke_m5945185BD815F2681A769EACBE3C582FA97CB508;
extern const uint32_t g_rgctx_Iterator_1_Dispose_m5EC8CEF99E23E398528FE0931DCC45AED3BEBF32;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1_tE2CE3763D78D5CC8F4AC63AFE78B1CBD23278F43;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1__ctor_m86D1FEB4F9AACB36F8538594B7B38AC89E7ECB80;
extern const uint32_t g_rgctx_Enumerable_CombineSelectors_TisTSource_t6355F355A254894D36425000DA970098D26F6EF5_TisTResult_tD6A3EE7D4ACD5F7F9E7DB9F00F3C5CC598B55E0B_TisTResult2_tFB11D70CFC9A6D39CD2859C8E269998B71091CE7_m39F57864AB4D3B8C44CEC60B4BB6810ACC474BA4;
extern const uint32_t g_rgctx_WhereSelectArrayIterator_2_t738B3298CEC205A75135CED719B96FDCB3E19DB8;
extern const uint32_t g_rgctx_WhereSelectArrayIterator_2__ctor_mCC0D6C5D6838B379F2E5934F6166D00E0D30D61F;
extern const uint32_t g_rgctx_Iterator_1__ctor_mB57E6479A26693AC3E3228153DF5C3FF9244E556;
extern const uint32_t g_rgctx_Iterator_1_t82B5A713AD6A0AEEA492B6EDD94AB36C177FB31E;
extern const uint32_t g_rgctx_WhereSelectListIterator_2_t729D3E7AAD664CE67089CB48A807AC3E9301DD45;
extern const uint32_t g_rgctx_WhereSelectListIterator_2__ctor_m4243EB70AC53128B69B768C753E22F06EC6C2F95;
extern const uint32_t g_rgctx_List_1_GetEnumerator_mABC2F0913AC1FB53A0A06DE4F593B0A59BC3014C;
extern const uint32_t g_rgctx_Enumerator_get_Current_mFB62C9BD7171865F3CFC87C8311E2C462791ACA0;
extern const uint32_t g_rgctx_Func_2_Invoke_m27C03DB3F8030B00F631ADE2CD1A9DDF18D5ED23;
extern const uint32_t g_rgctx_Func_2_Invoke_mE86C4D09C2F79FDFB4EA23E08D328E5EEAEC9639;
extern const uint32_t g_rgctx_Enumerator_MoveNext_m5C1C72BBB604DBBCBC5F0B6A885FB61372D4CA65;
extern const uint32_t g_rgctx_Iterator_1_Dispose_m131C1D6FE9A3EF2550ADE8B2F01ED31A4B4CD89E;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1_tF93BB76CC2E74178734ACB7F539BF5F5781032CC;
extern const uint32_t g_rgctx_WhereEnumerableIterator_1__ctor_m5598588FA12141BFE352C9917F5398566B7074BB;
extern const uint32_t g_rgctx_Enumerable_CombineSelectors_TisTSource_t35717B0D8465F7BF2FF374E22BFDE014E9CCAB7B_TisTResult_tEC155615E1838A087179B679DA38A5AB1DCB49F6_TisTResult2_t90E635D774BCB207895EA3440CF7DA243ADF7314_m243CCC2FD2B5576E0648150487553604A7579102;
extern const uint32_t g_rgctx_WhereSelectListIterator_2_t6461584B4A18CBB697BC8E65661BD2EDC3144F29;
extern const uint32_t g_rgctx_WhereSelectListIterator_2__ctor_m0CABE000C6C9936C0A0DCBDAB0CE517E636F36F7;
extern const uint32_t g_rgctx_Func_2_Invoke_m9A6744C087A6AC603C2858E37C8EB93CC6694884;
extern const uint32_t g_rgctx_Func_2_Invoke_mAC80E45654022092175F6F9E4FF0BF5987266C9C;
extern const uint32_t g_rgctx_Func_2_Invoke_m6633A2B4AF28FAD626AC68367C19680E515B512B;
extern const uint32_t g_rgctx_U3CSelectManyIteratorU3Ed__17_2_U3CU3Em__Finally2_m3FFD56BED0FDB863A9C2DA10031FDA600374F491;
extern const uint32_t g_rgctx_U3CSelectManyIteratorU3Ed__17_2_U3CU3Em__Finally1_mB47A3E1C43AC2A85EFD3A3CD38F92BE8E96F2A8C;
extern const uint32_t g_rgctx_IEnumerable_1_tF1D4B3EECE7130AC10F19FFFEE359104AD1FB76F;
extern const uint32_t g_rgctx_IEnumerator_1_tEC0BBBE3671DE3CCC4FE7EDDD9AB2BBC545F948F;
extern const uint32_t g_rgctx_Func_2_Invoke_m7C26714D38731ED2D10249316C4FBD63C16D67F7;
extern const uint32_t g_rgctx_IEnumerable_1_t1CE564C4D81E60C7DC57A37E25C2461ED76322C9;
extern const uint32_t g_rgctx_IEnumerator_1_tFE26439A5CF8EB8A91446914DA097AAAC9C2E4BF;
extern const uint32_t g_rgctx_U3CSelectManyIteratorU3Ed__17_2_System_IDisposable_Dispose_mCB194BBAAF56C3D3B8E16EAED9AE366AA6D20B90;
extern const uint32_t g_rgctx_TResult_t814576AA1C162ACD27560F006177A8C3CD82C870;
extern const uint32_t g_rgctx_U3CSelectManyIteratorU3Ed__17_2_tBA9681E91B34DE910CC83277F47B42E2127F327E;
extern const uint32_t g_rgctx_U3CSelectManyIteratorU3Ed__17_2__ctor_m6DB08C9D8C9D09A50A4C2CFFB1045858455AE9D4;
extern const uint32_t g_rgctx_U3CSelectManyIteratorU3Ed__17_2_System_Collections_Generic_IEnumerableU3CTResultU3E_GetEnumerator_mBE99D44D1C360C9ED7B1F6EC7318B67F1209091B;
extern const uint32_t g_rgctx_U3CDistinctIteratorU3Ed__68_1_U3CU3Em__Finally1_mD4531A7D4BD3B22E8D8A0ACCA1DA1A26E5F0FCF5;
extern const uint32_t g_rgctx_Set_1_tDDEBCCD4267EADBEAD418EA68B8CFE969934E6CA;
extern const uint32_t g_rgctx_Set_1__ctor_m47D0AAC0F788D78617F248C3F8DE145BB533FB47;
extern const uint32_t g_rgctx_IEnumerable_1_tA8804804FF1BE0FF5CACECC285966CA0FC22C3E1;
extern const uint32_t g_rgctx_IEnumerator_1_tB08699944DA8173C64C3681A71470C486BB16869;
extern const uint32_t g_rgctx_Set_1_Add_mF59AF262F9DC378A888E7813216258346FE7AB7C;
extern const uint32_t g_rgctx_U3CDistinctIteratorU3Ed__68_1_System_IDisposable_Dispose_mC3516C181C0C044E2C26C45F01A8C0D3C8B30E19;
extern const uint32_t g_rgctx_TSource_t697899CBCDA152205DB88C81CCA96B258CB82796;
extern const uint32_t g_rgctx_U3CDistinctIteratorU3Ed__68_1_t6A61376FB2E7178EB6622EFD71E4A7EB03A27AF4;
extern const uint32_t g_rgctx_U3CDistinctIteratorU3Ed__68_1__ctor_m2AD2C085F4FFD62317C6BE67A330D0F35C4C915D;
extern const uint32_t g_rgctx_U3CDistinctIteratorU3Ed__68_1_System_Collections_Generic_IEnumerableU3CTSourceU3E_GetEnumerator_mE1A2A621D2345E46873DC1838C04CAA500429E98;
extern const uint32_t g_rgctx_TElementU5BU5D_t8A94C4BFBF9E6BF79B51985125A00CE6111046BD;
extern const uint32_t g_rgctx_EmptyEnumerable_1_t61D763760D8F245D25A64A37EA22E49B6A61D33F;
extern const uint32_t g_rgctx_EqualityComparer_1_get_Default_m0ACEA98E0F309527422B734EC2D6F838F42E855A;
extern const uint32_t g_rgctx_EqualityComparer_1_tE98C8758DC67BAC10BC58A6EAF2BC7702037261D;
extern const uint32_t g_rgctx_SlotU5BU5D_t59C5931DEEAB28C10C90F90194F7BA255205FF0C;
extern const uint32_t g_rgctx_Set_1_Find_m960A4C3A4D4AA1B1E999EF848750BBE1A7D926F7;
extern const uint32_t g_rgctx_Set_1_InternalGetHashCode_m9B51B4A88084A8FDB38514325ECF1F61E2D272DA;
extern const uint32_t g_rgctx_IEqualityComparer_1_t3CB967F967F4706563FB9E277A60032CD22D6832;
extern const uint32_t g_rgctx_Set_1_Resize_m93FE9D1D00D5F0FC34818A15B4F62F95E55F075A;
extern const uint32_t g_rgctx_TElement_t675859134FC8712282763A8D72CA128B8B43DD5D;
extern const uint32_t g_rgctx_U3CGetEnumeratorU3Ed__1_t5D0486AEAB09755AF78B220EFA015EA86540C4B3;
extern const uint32_t g_rgctx_U3CGetEnumeratorU3Ed__1__ctor_mD7AD8598EA220AE5C3472A7151BCEB208DA7F24F;
extern const uint32_t g_rgctx_OrderedEnumerable_1_GetEnumerator_m6DF22CD2A54FD98EE9BC3A07367C286B21F9547B;
extern const uint32_t g_rgctx_OrderedEnumerable_2_t2A47D4856AECFE1685BCA5481E27661F13EE1417;
extern const uint32_t g_rgctx_OrderedEnumerable_2__ctor_mD264D38202D3B90E502FDE99A254815B45B4BA65;
extern const uint32_t g_rgctx_Buffer_1_t7BF1A786B9BDA7D98997098F206D9FBEB8E805CE;
extern const uint32_t g_rgctx_Buffer_1__ctor_m63F874F7E854E3962714E8472CB132C035CC416B;
extern const uint32_t g_rgctx_OrderedEnumerable_1_GetEnumerableSorter_m66C26D4385449EA5B7AC0AAAE558E827A547B8CF;
extern const uint32_t g_rgctx_EnumerableSorter_1_Sort_m02DC1D19B109171CC6F0A97CA1A3A494A2F08F31;
extern const uint32_t g_rgctx_TElement_t333B92C559EDB1DAA4DB3278851F903367748A99;
extern const uint32_t g_rgctx_OrderedEnumerable_1__ctor_mE30DC877F0F5D6F8AC240D104550276A35B6852C;
extern const uint32_t g_rgctx_OrderedEnumerable_1_t50B50FFBA4235D6A79D0BD205B625DE23059AB4A;
extern const uint32_t g_rgctx_Comparer_1_get_Default_m9E7E2CD7BBA500D9A9731C5906809FCBA65E1E30;
extern const uint32_t g_rgctx_Comparer_1_tD0DB8DA2AE74C852F854EA8D9376FBD40626907C;
extern const uint32_t g_rgctx_EnumerableSorter_2_t2CEA9D5447B2F9F77A2272EFB103B886DA6A1420;
extern const uint32_t g_rgctx_EnumerableSorter_2__ctor_m100971C016BC2A43E309CE5E2D698B9D1588B033;
extern const uint32_t g_rgctx_OrderedEnumerable_1_GetEnumerableSorter_mA88206BAC41B269377165C986FA5703FE0D98BF1;
extern const uint32_t g_rgctx_EnumerableSorter_1_ComputeKeys_m83D519A95C8BF3E64F4C001F694C1BA6B5AAA627;
extern const uint32_t g_rgctx_EnumerableSorter_1_QuickSort_m1624C8412F34C475233B33FFFB9B72B17B8AB15F;
extern const uint32_t g_rgctx_EnumerableSorter_1_CompareKeys_m97F1B0F4295DCEC1F4D25AA1460D635ABDB083D7;
extern const uint32_t g_rgctx_EnumerableSorter_1__ctor_mCF1F7D79B54CC4982ACC920B5FC4820B6761D497;
extern const uint32_t g_rgctx_EnumerableSorter_1_tD898552BB1412C8F871ECEF9E1E52EB11D1D9433;
extern const uint32_t g_rgctx_TKeyU5BU5D_t6537368C948F1BE34C63755A2D32DD5D17382867;
extern const uint32_t g_rgctx_Func_2_Invoke_m5B02612CC97C4353D26D2A468F97D6FF5F3BFFA8;
extern const uint32_t g_rgctx_EnumerableSorter_1_ComputeKeys_m0E1B75812073569AF348E2322C90C5326D95A0BC;
extern const uint32_t g_rgctx_IComparer_1_t885D3AAA10BAAD12BD427225987B0FD222695EBA;
extern const uint32_t g_rgctx_EnumerableSorter_1_CompareKeys_m4A804932C38687AA4E0B8569DB03D36A04BBEE46;
extern const uint32_t g_rgctx_ICollection_1_t7C426FF7559846CA5118EB7658EEC1A091C8D99B;
extern const uint32_t g_rgctx_TElementU5BU5D_t7794BEA974AC676D685D83352F37C7ADBF84BD60;
extern const uint32_t g_rgctx_IEnumerable_1_tD73EF5A715E0D735FB8796582DF7DAAE59248A28;
extern const uint32_t g_rgctx_IEnumerator_1_t721019D94B9F297B40CA782A203E918DCEF86D3E;
extern const uint32_t g_rgctx_EqualityComparer_1_get_Default_m0E4BF9A3FBB72E07033EA16B23935DD2A753BE7E;
extern const uint32_t g_rgctx_EqualityComparer_1_t57E7B5874DDB8ED0BBCF9EA1E8EE5E482DB475BF;
extern const uint32_t g_rgctx_HashSet_1__ctor_m59687428EFF3A060C7E4A58B33D8CCB1866245DB;
extern const uint32_t g_rgctx_HashSet_1_AddIfNotPresent_mD32BD7F09DDC0123D28A33C4E91499817AEBDE5A;
extern const uint32_t g_rgctx_HashSet_1_InternalGetHashCode_mDF2E29D60C603DBF5BE68A3DAD153D124902A38D;
extern const uint32_t g_rgctx_IEqualityComparer_1_t536A87393F54B1725FFA3488A3A2D91F245BF357;
extern const uint32_t g_rgctx_HashSet_1_CopyTo_m2CEA36CE0A9828B0D2817BABB0778E9B7CC2D23B;
extern const uint32_t g_rgctx_RuntimeHelpers_IsReferenceOrContainsReferences_TisT_tFA70BB9403614A86785198F7670E8A79579D96AA_mE4CF1DE156A56C76F3D17E5D356B4592BF76045B;
extern const uint32_t g_rgctx_Enumerator_t3B01BF569E0DDC9775F15A857D58FB5891FF9794;
extern const uint32_t g_rgctx_Enumerator__ctor_mF6352008F027267A6D46E84C5EE5A593C2008B31;
extern const uint32_t g_rgctx_IComparer_1_tAC617197608B3A3B8581D014191E97687ACBDC73;
extern const uint32_t g_rgctx_TU5BU5D_t5B53AAF5CC8246F0EF74C6B8CE39B8BB71F520B1;
extern const uint32_t g_rgctx_HashSet_1_CopyTo_m3C429D78A2E5EB4297C0E1913DB8D3E719AF41E9;
extern const uint32_t g_rgctx_TU5BU5D_t5B53AAF5CC8246F0EF74C6B8CE39B8BB71F520B1;
extern const uint32_t g_rgctx_IEqualityComparer_1_t536A87393F54B1725FFA3488A3A2D91F245BF357;
extern const uint32_t g_rgctx_SlotU5BU5D_t27D40C306C68B962B6159BE0A16BC90AADB63D8C;
extern const uint32_t g_rgctx_TU5BU5D_t5B53AAF5CC8246F0EF74C6B8CE39B8BB71F520B1;
extern const uint32_t g_rgctx_HashSet_1_SetCapacity_mA30C348AE8DA2CB53D157195B16A8EF0AF88F810;
extern const uint32_t g_rgctx_HashSet_1_Initialize_m388A18FBF12F617107200961B7E4736E2B032820;
extern const uint32_t g_rgctx_HashSet_1_IncreaseCapacity_mA3287035E39B231BF0B2B4CDEFA182530F54F0DB;
extern const uint32_t g_rgctx_T_tFA70BB9403614A86785198F7670E8A79579D96AA;
extern const uint32_t g_rgctx_Enumerator_get_Current_m5AF8DAD51CCB7D8472437E484EE9ECA33FACD0C8;
extern const uint32_t g_rgctx_T_t915F5DD3D2E812A343EBC3FB68983028184D4B2A;
static const Il2CppRGCTXDefinition s_rgctxValues[255] = 
{
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_t636279D5C9025C29159E9C0F450D35FFAC93279B },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Where_m0335429642E75AAECFBE3A2FFB3E69C0902CD0D0 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TSourceU5BU5D_tB85C233E707A0361D6D93CC945959A97B295E668 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereArrayIterator_1_t78D2E4CACFC7E7EF98F4400F475AA11085112BAB },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereArrayIterator_1__ctor_m14EFDE07937A9AD4F82AC1A74EB288C173BFB848 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_tE71B82DE094FF5C3CFC4CEB615B5DF14BD949490 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereListIterator_1_tFF147832A53F8A9DE165473807DDCFD3CC89BB27 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereListIterator_1__ctor_m486D06E9DF259E0447D58D5862CD621A244EC394 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1_tD45416FF1F026DC4A566886D1F9A85298AE985EE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1__ctor_m728988B0E986DD25EA1A1245D615A4D8C365CD58 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_tC2E699D86C01BAC6905B98B63B33736C033E71D1 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Select_TisTResult_tEC92E99E2F99696D564F9F0BF815FEF3CB5ADB24_m0D623474504357AC2390442FA49A3614816C30EB },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TSourceU5BU5D_t4F9441DF0F8CE638F5AE03184356E2547BE07D8B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectArrayIterator_2_t2180864D420574607DB2234C9C01679FE54D8CE0 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectArrayIterator_2__ctor_mDD41DB7136FC0D1BAAD6387FDF1CD6AB89DAAFAA },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_t4845168BC8478686CF2BBE4464D2DAFF823D0084 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectListIterator_2_tD8B9E9B726B2A13391A120779B663B6B066FE46C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectListIterator_2__ctor_mAEBB72130A83942691D7AD550E95275A4568F008 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectEnumerableIterator_2_tAF002CEC5D0A77CDB9D819FDC46DD0BA58C1BBA6 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectEnumerableIterator_2__ctor_m6B03D41394EC2F95D12611A98B59B9216388D808 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec__DisplayClass6_0_1_tAAE11763AA13976D45FD650D42F519700CF99D38 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec__DisplayClass6_0_1__ctor_m86EDAA3687D7C1F88D7F2948EB133CD52D1F67B4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec__DisplayClass6_0_1_U3CCombinePredicatesU3Eb__0_m6AC677496E624733DBE45B58781535FBE0676A8B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_tBBA43EC3AE1D3C51038FD479D6428C8DD30B04E6 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2__ctor_m3DFE5D5406D3378215342C16ED24C3A1E0E779E2 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec__DisplayClass7_0_3_t0683908CF809AD10ED7CC6D62163918C9696939B },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec__DisplayClass7_0_3__ctor_m457EDCE9B47108492ADD67B0A9810080E39D1BE2 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec__DisplayClass7_0_3_U3CCombineSelectorsU3Eb__0_m3345F80CF52FB25D5B643E53940EC65D4DE624FF },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_tD04771F273735C559AE55788BC543AC64480CCE3 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2__ctor_m5A1DFF0655E17E626732D3F1D7121D991CDB0179 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_SelectManyIterator_TisTSource_tBD009412AD3F1786CECED18979B2B0F140C0064A_TisTResult_t01F43662929D207091184DC2CC10747DAC9D22F9_m1610399E32CC4BAA463960D33A7E764D36866682 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CSelectManyIteratorU3Ed__17_2_t20BDC5A431EA6AFCE07E8D5AE307A77924872724 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CSelectManyIteratorU3Ed__17_2__ctor_m4548C69D5E8C5A0855B02A4D734A3BBF778A3E18 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_2_t015D762D3F1278F3A8095CC482498F0C833B0984 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_2__ctor_m45A55EB5FF2CE3D2BDF45E1B690EF35E0D5DE727 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IOrderedEnumerable_1_CreateOrderedEnumerable_TisTKey_t02D36AA7EBCABE787524643443A1C180EB801194_m19CC62B5F0A74905DBA2306241A5677B42E07BB6 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_DistinctIterator_TisTSource_t0E571C196610719CB0262CB18C052BADF05665E1_m4905D51260B208ADC19702C44BFF6C15AF7CE7C4 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CDistinctIteratorU3Ed__68_1_t59F098E3D4A7AA6B48A348A71D69042B7244EDF8 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CDistinctIteratorU3Ed__68_1__ctor_m8B955A99713D9D4DCCE789E5C1AF3714F0C685F9 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Buffer_1_tC5729D25A3E364254D0A1FCE4E06925DD5747329 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Buffer_1__ctor_m222E095AE1BB3A973DDD54EF9E1B4D5B736CCD17 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Buffer_1_ToArray_mC3E5B9F0AEC815A68ACDD77645E6B71FF4075C1D },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_tF50400EBC15D6DEEC3C43073E29EA18AE57314CC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1__ctor_m1AF07A5AAF7431D4835996D42244831EF686194F },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IList_1_tCAC22142D45D9B5BEDC0EC4316FB0787780E59C0 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_t304709A63D159EB9956CBC8F5384C8DC17DAB944 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t3EEB6E917754CC0F2D884B5BAF09F79D06A23371 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t3443F0B85E56B92C25A45DC489F4E78C696B382A },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_tC3B2CE8F52F3BB899EBAA1EDCCAFC94B8C199C91 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_tA6115F2D209E3052BD9C6B9ED5270B324DB8D210 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_mD3C2DB22B2853F8EE705EB307E4FF49DE6879850 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IList_1_tA9AD20C95EF7B6D8E6684801D115EDC35C76816B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_t0756D2BE833E99CBAC7DD7113000DA8DBC47C91A },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_tD1E9BC1098C430D557C3F5E7C9227B6F15E01596 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_tFC7F0E9D98E7DDACBD936C35C5E0FE3B6B2B0234 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t8DB477F20651176E75D2BCAEDF981D633D80CD34 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t4B7E760977A64E74AB1647667A03A3AC39E9537F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m9A695867B12FDC2909EE58D3C12974290AC63570 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IList_1_t9B2C39DD1935C0159FB061115AF5530046049F74 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_t35B5CBD8B2D72DA7EC88941F6C85DA6146A26DAB },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t5586386B55A509E36FD800F6EAAE2C2F1A01CBEB },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_tD60C4749BBF149AB239D1DED16B258BCBD0E5F8F },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_tD0880E4FF3F8B3DBC95295C115964852F4006BDE },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t2BDF305126D656BD2B3734A2BA28F10607A82074 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_mE9A75A107233FECEE19A1C1E3AC7D3819565F736 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IList_1_t307E8207DE3AA9A02CD709BD06A9B8EAC46F0357 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t91572A34863F4F06BB3B8A9F249931D7E4A5937A },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_tF3682B7A6AD234903897B5FA886E746E71CF16EC },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EmptyEnumerable_1_t461C324301407FD7CF00125C74C7BBB10E425032 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t6B558838B603B0E97AFA74C50F667305BDC94859 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_tA56BDC4BCA945A181D326F97ACDDB3A23C56D75F },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t71577311A5349A81219A3AAA87F5D7C87441334D },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m22BF94126E79C0060E291A3973838BE70CBE99EF },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t826591D99F39EC886748F26C7D52C94B1C4240E9 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t45B3683D4BDDC10D277E47094E9317877787CAC3 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m1531C38ACD1E4CA7B46FA8B34CC329EDA0CC0D4B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_t401C1362FA9CAA778DB957CA35F29F955A470D4D },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t0AA8DC1E145B18DB5BB6E9E999383C3368225353 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t4E09BD5660E84A1966ED46BD965A81EF3BDE2D98 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t42B22C956C74AC2C5E2E4D9FAC7A3F6054A5AD92 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m69B76648DEF403A413DD2A96679170EECFC79CF9 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_t12A52A64081A5954F5F3EA1E13DAF2587E8C57DE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_Contains_TisTSource_t941CC4C3B89ECA76D1FAFE3BC385974F6C8372B2_m7B5F33A4BBBBE98861FC9B38AEE5090109400C8C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EqualityComparer_1_get_Default_m0DD948D8CCA4C1DA30E417512F50E4F463CFEBC2 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EqualityComparer_1_tC54E5776F429F385C6E93384568ABC1174A92F62 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t1C203359ED16BCC43AC4805C465D8D500686ADA8 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t102BE58A70A4033CB1BCB8B4D26DFB372CE314D2 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEqualityComparer_1_t0F97F8650BAFC726D27A22B8B8478C2C7DC2B103 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Clone_m16088BFE7F81DDE461A0BB4E1EA29363B7201A88 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_get_Current_mBBDFA8B8A3ABB39089FBAAFB585F74B0645D5B9E },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TSource_tE27C213B5C79D15F8C95F178F87A749A817CDA5D },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_GetEnumerator_m13277F825C4179EF9CDE7A56336BA548EBDD8B66 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1__ctor_m7514E41D23F3DE4CFB867A3D46DFA8B2501AE00A },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_t50B70FACDE0E1B34143E9F8CD22ACA0B10FEEC26 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1_tE5D85FF692C59EBD4579D71A361979792364C8C2 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1__ctor_mB813B1FE2E20D2DF6F0FAB6A3038EF326256668F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Dispose_m458FCA659FADA5A1CDD35B01DC76E07FC79011F6 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t014A3E7CE41868FE585432BE1E1F32DAF551BB36 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t540613216E99A3140BFFB2141072CF8D8C55007A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m9F7D28A9D6156DF8A1B912FFA0F747CFDBFC8D85 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_CombinePredicates_TisTSource_t925AD170B396F364902F7FA31791C320095C54E5_m204DB79421EDD3974CD0BFE16F7EF7B4FA48F1EA },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectEnumerableIterator_2_t46C994A1424EC5EF082C585BBB32C2AD1D3D4CB3 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectEnumerableIterator_2__ctor_m08367FB68BE2F5519F0A182BD80B2D4F7424C917 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1__ctor_m26CBEC6F3738C13265ED9A1DB94EAA482E5EEA40 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_tDCC95199B9B0AE888166B600A2150724F5886269 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereArrayIterator_1_t20BBB4A170F4320F138F207A6EBFB6C88FA8C6A1 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereArrayIterator_1__ctor_m035206C0A4EEE229CD66670619A7BDC8DDE59F9F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m8E3DE59DA6A8AE4BCFAA34FA8B17B381A99D11AE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Dispose_mBF633E0AC48DC442C116F953FC60AFF40436CEA9 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_CombinePredicates_TisTSource_t78A097556235CA68272579A40AC9ABEE8E6228C8_mE267EE8715DC4D0B54E4FFA4137132863C8C05D5 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectArrayIterator_2_tF7F044DA24DECBE0E5A6AE433108FE4E8268155F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectArrayIterator_2__ctor_m075E1384C767F3300E3B2B6BAE298A12DB74F92F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1__ctor_mCC9DED6DA7E9DD65B1EF6F217D5806777C1C1C85 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_t46EC0822C64AE0439F8EE76EB5155C7A9001F557 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereListIterator_1_tADF109EE7959D1951D59B9C41E18BD70E5441BB9 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereListIterator_1__ctor_m9002AB02279AE8B262F8BAAA95BE527B987ED958 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_GetEnumerator_mAFED2F8101B027035699A20B4805B534C316344E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_get_Current_mE985AB113BB4586F6450A4754514B631705E7065 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m91A41D91BF9C53B5FCB823CEC4C05441E7358252 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_MoveNext_mD2B6AE94B197322F4771CD14316E0B95B8D82E64 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Dispose_mBCB5A059BDA76FBC39499E43B3D8BB751ECA6373 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_CombinePredicates_TisTSource_tD1ACF1646AF878DBE965885289D74649B3B828A3_m88595760E15A41A2E59213D4FBDF33DC3A92E7E6 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectListIterator_2_t8A71567888F15A3623F26A2EB610FC3763B9FF64 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectListIterator_2__ctor_mCDDF6695E39D352EBF7D6737D08A17681DDBA0EB },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1__ctor_m9C015AF4A450B4E6EB725D0A6EA193EC87089916 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_t4A1A94CD1362426652FE8007391D7ACD149C3CAA },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectEnumerableIterator_2_t7031169C0E37784A65AB4F5B17C5BF181037AF67 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectEnumerableIterator_2__ctor_mBCA01725B4D027EBDD90FF78834AF3D2322B97CD },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Dispose_m9F3180789FE400C31D35F9F6D743AC390A0261D1 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t59F6FB0A645176EC2A74EFC6A6954B6A0BD8613E },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_tC005608F0795FDFDD43CF49AD0A68249E3CF1555 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m80421D41060FA82A34CE13118BDD3A56276FFEC8 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m03A1520007AD7AA7EB571079CEEBEA13E126518D },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1_tFF7F615E8575AD96233222E6633A1C896E1BF3FE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1__ctor_m5411CF60E5F86BF7F54AFBD1E0C95C9688B29B92 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_CombineSelectors_TisTSource_tC2E77D7EA4AE607508C03DFA1362450D1DB1A2C4_TisTResult_t3163C282AB187D44EE2308497F3395E3287C66FD_TisTResult2_tFB17268A1DEC3B455218E8232DBF56A873701CCE_mA318522BDC6EBB841C57419082205164CCD9F44A },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectEnumerableIterator_2_t3E5F5CEC2B587397A95F9C132A4E93577A0E9EFA },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectEnumerableIterator_2__ctor_m5DC380D132EC785F06988E5FD0D09A247B0DF032 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1__ctor_m14C0DC72B8DD1FC0A32BA34CC7E04FF3106D72B8 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_t8CC8E16A7609A1CB8D299492A8EA1452111C811D },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectArrayIterator_2_tC23CA6F5F16345355F547FF9E1F2156DCD628787 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectArrayIterator_2__ctor_m892A5BC3C31E7332525AE5D21A1138941C2B6DE2 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_mD9083CFC73A356C4CB6A92B62C096336829907FC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m5945185BD815F2681A769EACBE3C582FA97CB508 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Dispose_m5EC8CEF99E23E398528FE0931DCC45AED3BEBF32 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1_tE2CE3763D78D5CC8F4AC63AFE78B1CBD23278F43 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1__ctor_m86D1FEB4F9AACB36F8538594B7B38AC89E7ECB80 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_CombineSelectors_TisTSource_t6355F355A254894D36425000DA970098D26F6EF5_TisTResult_tD6A3EE7D4ACD5F7F9E7DB9F00F3C5CC598B55E0B_TisTResult2_tFB11D70CFC9A6D39CD2859C8E269998B71091CE7_m39F57864AB4D3B8C44CEC60B4BB6810ACC474BA4 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectArrayIterator_2_t738B3298CEC205A75135CED719B96FDCB3E19DB8 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectArrayIterator_2__ctor_mCC0D6C5D6838B379F2E5934F6166D00E0D30D61F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1__ctor_mB57E6479A26693AC3E3228153DF5C3FF9244E556 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_t82B5A713AD6A0AEEA492B6EDD94AB36C177FB31E },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectListIterator_2_t729D3E7AAD664CE67089CB48A807AC3E9301DD45 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectListIterator_2__ctor_m4243EB70AC53128B69B768C753E22F06EC6C2F95 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_GetEnumerator_mABC2F0913AC1FB53A0A06DE4F593B0A59BC3014C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_get_Current_mFB62C9BD7171865F3CFC87C8311E2C462791ACA0 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m27C03DB3F8030B00F631ADE2CD1A9DDF18D5ED23 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_mE86C4D09C2F79FDFB4EA23E08D328E5EEAEC9639 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_MoveNext_m5C1C72BBB604DBBCBC5F0B6A885FB61372D4CA65 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Iterator_1_Dispose_m131C1D6FE9A3EF2550ADE8B2F01ED31A4B4CD89E },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1_tF93BB76CC2E74178734ACB7F539BF5F5781032CC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereEnumerableIterator_1__ctor_m5598588FA12141BFE352C9917F5398566B7074BB },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerable_CombineSelectors_TisTSource_t35717B0D8465F7BF2FF374E22BFDE014E9CCAB7B_TisTResult_tEC155615E1838A087179B679DA38A5AB1DCB49F6_TisTResult2_t90E635D774BCB207895EA3440CF7DA243ADF7314_m243CCC2FD2B5576E0648150487553604A7579102 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectListIterator_2_t6461584B4A18CBB697BC8E65661BD2EDC3144F29 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_WhereSelectListIterator_2__ctor_m0CABE000C6C9936C0A0DCBDAB0CE517E636F36F7 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m9A6744C087A6AC603C2858E37C8EB93CC6694884 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_mAC80E45654022092175F6F9E4FF0BF5987266C9C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m6633A2B4AF28FAD626AC68367C19680E515B512B },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CSelectManyIteratorU3Ed__17_2_U3CU3Em__Finally2_m3FFD56BED0FDB863A9C2DA10031FDA600374F491 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CSelectManyIteratorU3Ed__17_2_U3CU3Em__Finally1_mB47A3E1C43AC2A85EFD3A3CD38F92BE8E96F2A8C },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_tF1D4B3EECE7130AC10F19FFFEE359104AD1FB76F },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_tEC0BBBE3671DE3CCC4FE7EDDD9AB2BBC545F948F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m7C26714D38731ED2D10249316C4FBD63C16D67F7 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t1CE564C4D81E60C7DC57A37E25C2461ED76322C9 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_tFE26439A5CF8EB8A91446914DA097AAAC9C2E4BF },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CSelectManyIteratorU3Ed__17_2_System_IDisposable_Dispose_mCB194BBAAF56C3D3B8E16EAED9AE366AA6D20B90 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TResult_t814576AA1C162ACD27560F006177A8C3CD82C870 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CSelectManyIteratorU3Ed__17_2_tBA9681E91B34DE910CC83277F47B42E2127F327E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CSelectManyIteratorU3Ed__17_2__ctor_m6DB08C9D8C9D09A50A4C2CFFB1045858455AE9D4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CSelectManyIteratorU3Ed__17_2_System_Collections_Generic_IEnumerableU3CTResultU3E_GetEnumerator_mBE99D44D1C360C9ED7B1F6EC7318B67F1209091B },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CDistinctIteratorU3Ed__68_1_U3CU3Em__Finally1_mD4531A7D4BD3B22E8D8A0ACCA1DA1A26E5F0FCF5 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Set_1_tDDEBCCD4267EADBEAD418EA68B8CFE969934E6CA },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Set_1__ctor_m47D0AAC0F788D78617F248C3F8DE145BB533FB47 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_tA8804804FF1BE0FF5CACECC285966CA0FC22C3E1 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_tB08699944DA8173C64C3681A71470C486BB16869 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Set_1_Add_mF59AF262F9DC378A888E7813216258346FE7AB7C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CDistinctIteratorU3Ed__68_1_System_IDisposable_Dispose_mC3516C181C0C044E2C26C45F01A8C0D3C8B30E19 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TSource_t697899CBCDA152205DB88C81CCA96B258CB82796 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CDistinctIteratorU3Ed__68_1_t6A61376FB2E7178EB6622EFD71E4A7EB03A27AF4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CDistinctIteratorU3Ed__68_1__ctor_m2AD2C085F4FFD62317C6BE67A330D0F35C4C915D },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CDistinctIteratorU3Ed__68_1_System_Collections_Generic_IEnumerableU3CTSourceU3E_GetEnumerator_mE1A2A621D2345E46873DC1838C04CAA500429E98 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TElementU5BU5D_t8A94C4BFBF9E6BF79B51985125A00CE6111046BD },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EmptyEnumerable_1_t61D763760D8F245D25A64A37EA22E49B6A61D33F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EqualityComparer_1_get_Default_m0ACEA98E0F309527422B734EC2D6F838F42E855A },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EqualityComparer_1_tE98C8758DC67BAC10BC58A6EAF2BC7702037261D },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_SlotU5BU5D_t59C5931DEEAB28C10C90F90194F7BA255205FF0C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Set_1_Find_m960A4C3A4D4AA1B1E999EF848750BBE1A7D926F7 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Set_1_InternalGetHashCode_m9B51B4A88084A8FDB38514325ECF1F61E2D272DA },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEqualityComparer_1_t3CB967F967F4706563FB9E277A60032CD22D6832 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Set_1_Resize_m93FE9D1D00D5F0FC34818A15B4F62F95E55F075A },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TElement_t675859134FC8712282763A8D72CA128B8B43DD5D },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CGetEnumeratorU3Ed__1_t5D0486AEAB09755AF78B220EFA015EA86540C4B3 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CGetEnumeratorU3Ed__1__ctor_mD7AD8598EA220AE5C3472A7151BCEB208DA7F24F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_1_GetEnumerator_m6DF22CD2A54FD98EE9BC3A07367C286B21F9547B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_2_t2A47D4856AECFE1685BCA5481E27661F13EE1417 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_2__ctor_mD264D38202D3B90E502FDE99A254815B45B4BA65 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Buffer_1_t7BF1A786B9BDA7D98997098F206D9FBEB8E805CE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Buffer_1__ctor_m63F874F7E854E3962714E8472CB132C035CC416B },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_1_GetEnumerableSorter_m66C26D4385449EA5B7AC0AAAE558E827A547B8CF },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_1_Sort_m02DC1D19B109171CC6F0A97CA1A3A494A2F08F31 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TElement_t333B92C559EDB1DAA4DB3278851F903367748A99 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_1__ctor_mE30DC877F0F5D6F8AC240D104550276A35B6852C },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_1_t50B50FFBA4235D6A79D0BD205B625DE23059AB4A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Comparer_1_get_Default_m9E7E2CD7BBA500D9A9731C5906809FCBA65E1E30 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Comparer_1_tD0DB8DA2AE74C852F854EA8D9376FBD40626907C },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_2_t2CEA9D5447B2F9F77A2272EFB103B886DA6A1420 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_2__ctor_m100971C016BC2A43E309CE5E2D698B9D1588B033 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_OrderedEnumerable_1_GetEnumerableSorter_mA88206BAC41B269377165C986FA5703FE0D98BF1 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_1_ComputeKeys_m83D519A95C8BF3E64F4C001F694C1BA6B5AAA627 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_1_QuickSort_m1624C8412F34C475233B33FFFB9B72B17B8AB15F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_1_CompareKeys_m97F1B0F4295DCEC1F4D25AA1460D635ABDB083D7 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_1__ctor_mCF1F7D79B54CC4982ACC920B5FC4820B6761D497 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_1_tD898552BB1412C8F871ECEF9E1E52EB11D1D9433 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TKeyU5BU5D_t6537368C948F1BE34C63755A2D32DD5D17382867 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Func_2_Invoke_m5B02612CC97C4353D26D2A468F97D6FF5F3BFFA8 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_1_ComputeKeys_m0E1B75812073569AF348E2322C90C5326D95A0BC },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IComparer_1_t885D3AAA10BAAD12BD427225987B0FD222695EBA },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnumerableSorter_1_CompareKeys_m4A804932C38687AA4E0B8569DB03D36A04BBEE46 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_t7C426FF7559846CA5118EB7658EEC1A091C8D99B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TElementU5BU5D_t7794BEA974AC676D685D83352F37C7ADBF84BD60 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_tD73EF5A715E0D735FB8796582DF7DAAE59248A28 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerator_1_t721019D94B9F297B40CA782A203E918DCEF86D3E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EqualityComparer_1_get_Default_m0E4BF9A3FBB72E07033EA16B23935DD2A753BE7E },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EqualityComparer_1_t57E7B5874DDB8ED0BBCF9EA1E8EE5E482DB475BF },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_HashSet_1__ctor_m59687428EFF3A060C7E4A58B33D8CCB1866245DB },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_HashSet_1_AddIfNotPresent_mD32BD7F09DDC0123D28A33C4E91499817AEBDE5A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_HashSet_1_InternalGetHashCode_mDF2E29D60C603DBF5BE68A3DAD153D124902A38D },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEqualityComparer_1_t536A87393F54B1725FFA3488A3A2D91F245BF357 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_HashSet_1_CopyTo_m2CEA36CE0A9828B0D2817BABB0778E9B7CC2D23B },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_RuntimeHelpers_IsReferenceOrContainsReferences_TisT_tFA70BB9403614A86785198F7670E8A79579D96AA_mE4CF1DE156A56C76F3D17E5D356B4592BF76045B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_t3B01BF569E0DDC9775F15A857D58FB5891FF9794 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator__ctor_mF6352008F027267A6D46E84C5EE5A593C2008B31 },
	{ (Il2CppRGCTXDataType)1, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IComparer_1_tAC617197608B3A3B8581D014191E97687ACBDC73 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TU5BU5D_t5B53AAF5CC8246F0EF74C6B8CE39B8BB71F520B1 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_HashSet_1_CopyTo_m3C429D78A2E5EB4297C0E1913DB8D3E719AF41E9 },
	{ (Il2CppRGCTXDataType)1, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TU5BU5D_t5B53AAF5CC8246F0EF74C6B8CE39B8BB71F520B1 },
	{ (Il2CppRGCTXDataType)1, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEqualityComparer_1_t536A87393F54B1725FFA3488A3A2D91F245BF357 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_SlotU5BU5D_t27D40C306C68B962B6159BE0A16BC90AADB63D8C },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TU5BU5D_t5B53AAF5CC8246F0EF74C6B8CE39B8BB71F520B1 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_HashSet_1_SetCapacity_mA30C348AE8DA2CB53D157195B16A8EF0AF88F810 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_HashSet_1_Initialize_m388A18FBF12F617107200961B7E4736E2B032820 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_HashSet_1_IncreaseCapacity_mA3287035E39B231BF0B2B4CDEFA182530F54F0DB },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_tFA70BB9403614A86785198F7670E8A79579D96AA },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_get_Current_m5AF8DAD51CCB7D8472437E484EE9ECA33FACD0C8 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t915F5DD3D2E812A343EBC3FB68983028184D4B2A },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	157,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	55,
	s_rgctxIndices,
	255,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
