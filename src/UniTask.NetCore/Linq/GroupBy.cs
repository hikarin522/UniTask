﻿using Cysharp.Threading.Tasks.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
    public static partial class UniTaskAsyncEnumerable
    {
        // Ix-Async returns IGrouping but it is competely waste, use standard IGrouping.

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return new GroupBy<TSource, TKey, TSource>(source, keySelector, x => x, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupBy<TSource, TKey, TSource>(source, keySelector, x => x, comparer);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            return new GroupBy<TSource, TKey, TElement>(source, keySelector, elementSelector, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupBy<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
            return new GroupBy<TSource, TKey, TSource, TResult>(source, keySelector, x => x, resultSelector, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupBy<TSource, TKey, TSource, TResult>(source, keySelector, x => x, resultSelector, comparer);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
            return new GroupBy<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, EqualityComparer<TKey>.Default);
        }
        public static IUniTaskAsyncEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupBy<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, comparer);
        }

        // await

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupByAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector)
        {
            return new GroupByAwait<TSource, TKey, TSource>(source, keySelector, x => UniTask.FromResult(x), EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupByAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupByAwait<TSource, TKey, TSource>(source, keySelector, x => UniTask.FromResult(x), comparer);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupByAwait<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector)
        {
            return new GroupByAwait<TSource, TKey, TElement>(source, keySelector, elementSelector, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupByAwait<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupByAwait<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupByAwait<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TKey, IEnumerable<TSource>, UniTask<TResult>> resultSelector)
        {
            return new GroupByAwait<TSource, TKey, TSource, TResult>(source, keySelector, x => UniTask.FromResult(x), resultSelector, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupByAwait<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, UniTask<TResult>> resultSelector)
        {
            return new GroupByAwait<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupByAwait<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TKey, IEnumerable<TSource>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupByAwait<TSource, TKey, TSource, TResult>(source, keySelector, x => UniTask.FromResult(x), resultSelector, comparer);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupByAwait<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupByAwait<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, comparer);
        }

        // with ct

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupByAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector)
        {
            return new GroupByAwaitWithCancellation<TSource, TKey, TSource>(source, keySelector, (x, _) => UniTask.FromResult(x), EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupByAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupByAwaitWithCancellation<TSource, TKey, TSource>(source, keySelector, (x, _) => UniTask.FromResult(x), comparer);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupByAwaitWithCancellation<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector)
        {
            return new GroupByAwaitWithCancellation<TSource, TKey, TElement>(source, keySelector, elementSelector, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupByAwaitWithCancellation<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupByAwaitWithCancellation<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupByAwaitWithCancellation<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TKey, IEnumerable<TSource>, CancellationToken, UniTask<TResult>> resultSelector)
        {
            return new GroupByAwaitWithCancellation<TSource, TKey, TSource, TResult>(source, keySelector, (x, _) => UniTask.FromResult(x), resultSelector, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, CancellationToken, UniTask<TResult>> resultSelector)
        {
            return new GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, EqualityComparer<TKey>.Default);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupByAwaitWithCancellation<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TKey, IEnumerable<TSource>, CancellationToken, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupByAwaitWithCancellation<TSource, TKey, TSource, TResult>(source, keySelector, (x, _) => UniTask.FromResult(x), resultSelector, comparer);
        }

        public static IUniTaskAsyncEnumerable<TResult> GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, CancellationToken, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return new GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, comparer);
        }
    }

    internal sealed class GroupBy<TSource, TKey, TElement> : IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>>
    {
        readonly IUniTaskAsyncEnumerable<TSource> source;
        readonly Func<TSource, TKey> keySelector;
        readonly Func<TSource, TElement> elementSelector;
        readonly IEqualityComparer<TKey> comparer;

        public GroupBy(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            this.source = source;
            this.keySelector = keySelector;
            this.elementSelector = elementSelector;
            this.comparer = comparer;
        }

        public IUniTaskAsyncEnumerator<IGrouping<TKey, TElement>> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new Enumerator(source, keySelector, elementSelector, comparer, cancellationToken);
        }

        sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<IGrouping<TKey, TElement>>
        {
            readonly IUniTaskAsyncEnumerable<TSource> source;
            readonly Func<TSource, TKey> keySelector;
            readonly Func<TSource, TElement> elementSelector;
            readonly IEqualityComparer<TKey> comparer;
            CancellationToken cancellationToken;

            IEnumerator<IGrouping<TKey, TElement>> groupEnumerator;

            public Enumerator(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
            {
                this.source = source;
                this.keySelector = keySelector;
                this.elementSelector = elementSelector;
                this.comparer = comparer;
                this.cancellationToken = cancellationToken;
            }

            public IGrouping<TKey, TElement> Current { get; private set; }

            public UniTask<bool> MoveNextAsync()
            {
                cancellationToken.ThrowIfCancellationRequested();
                completionSource.Reset();

                if (groupEnumerator == null)
                {
                    CreateLookup().Forget();
                }
                else
                {
                    SourceMoveNext();
                }
                return new UniTask<bool>(this, completionSource.Version);
            }

            async UniTaskVoid CreateLookup()
            {
                try
                {
                    var lookup = await source.ToLookupAsync(keySelector, elementSelector, comparer, cancellationToken);
                    groupEnumerator = lookup.GetEnumerator();
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
                SourceMoveNext();
            }

            void SourceMoveNext()
            {
                try
                {
                    if (groupEnumerator.MoveNext())
                    {
                        Current = groupEnumerator.Current as IGrouping<TKey, TElement>;
                        completionSource.TrySetResult(true);
                    }
                    else
                    {
                        completionSource.TrySetResult(false);
                    }
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
            }

            public UniTask DisposeAsync()
            {
                if (groupEnumerator != null)
                {
                    groupEnumerator.Dispose();
                }

                return default;
            }
        }
    }

    internal sealed class GroupBy<TSource, TKey, TElement, TResult> : IUniTaskAsyncEnumerable<TResult>
    {
        readonly IUniTaskAsyncEnumerable<TSource> source;
        readonly Func<TSource, TKey> keySelector;
        readonly Func<TSource, TElement> elementSelector;
        readonly Func<TKey, IEnumerable<TElement>, TResult> resultSelector;
        readonly IEqualityComparer<TKey> comparer;

        public GroupBy(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            this.source = source;
            this.keySelector = keySelector;
            this.elementSelector = elementSelector;
            this.resultSelector = resultSelector;
            this.comparer = comparer;
        }

        public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new Enumerator(source, keySelector, elementSelector, resultSelector, comparer, cancellationToken);
        }

        sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<TResult>
        {
            readonly IUniTaskAsyncEnumerable<TSource> source;
            readonly Func<TSource, TKey> keySelector;
            readonly Func<TSource, TElement> elementSelector;
            readonly Func<TKey, IEnumerable<TElement>, TResult> resultSelector;
            readonly IEqualityComparer<TKey> comparer;
            CancellationToken cancellationToken;

            IEnumerator<IGrouping<TKey, TElement>> groupEnumerator;

            public Enumerator(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
            {
                this.source = source;
                this.keySelector = keySelector;
                this.elementSelector = elementSelector;
                this.resultSelector = resultSelector;
                this.comparer = comparer;
                this.cancellationToken = cancellationToken;
            }

            public TResult Current { get; private set; }

            public UniTask<bool> MoveNextAsync()
            {
                cancellationToken.ThrowIfCancellationRequested();
                completionSource.Reset();

                if (groupEnumerator == null)
                {
                    CreateLookup().Forget();
                }
                else
                {
                    SourceMoveNext();
                }
                return new UniTask<bool>(this, completionSource.Version);
            }

            async UniTaskVoid CreateLookup()
            {
                try
                {
                    var lookup = await source.ToLookupAsync(keySelector, elementSelector, comparer, cancellationToken);
                    groupEnumerator = lookup.GetEnumerator();
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
                SourceMoveNext();
            }

            void SourceMoveNext()
            {
                try
                {
                    if (groupEnumerator.MoveNext())
                    {
                        var current = groupEnumerator.Current;
                        Current = resultSelector(current.Key, current);
                        completionSource.TrySetResult(true);
                    }
                    else
                    {
                        completionSource.TrySetResult(false);
                    }
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
            }

            public UniTask DisposeAsync()
            {
                if (groupEnumerator != null)
                {
                    groupEnumerator.Dispose();
                }

                return default;
            }
        }
    }

    internal sealed class GroupByAwait<TSource, TKey, TElement> : IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>>
    {
        readonly IUniTaskAsyncEnumerable<TSource> source;
        readonly Func<TSource, UniTask<TKey>> keySelector;
        readonly Func<TSource, UniTask<TElement>> elementSelector;
        readonly IEqualityComparer<TKey> comparer;

        public GroupByAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer)
        {
            this.source = source;
            this.keySelector = keySelector;
            this.elementSelector = elementSelector;
            this.comparer = comparer;
        }

        public IUniTaskAsyncEnumerator<IGrouping<TKey, TElement>> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new Enumerator(source, keySelector, elementSelector, comparer, cancellationToken);
        }

        sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<IGrouping<TKey, TElement>>
        {
            readonly IUniTaskAsyncEnumerable<TSource> source;
            readonly Func<TSource, UniTask<TKey>> keySelector;
            readonly Func<TSource, UniTask<TElement>> elementSelector;
            readonly IEqualityComparer<TKey> comparer;
            CancellationToken cancellationToken;

            IEnumerator<IGrouping<TKey, TElement>> groupEnumerator;

            public Enumerator(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
            {
                this.source = source;
                this.keySelector = keySelector;
                this.elementSelector = elementSelector;
                this.comparer = comparer;
                this.cancellationToken = cancellationToken;
            }

            public IGrouping<TKey, TElement> Current { get; private set; }

            public UniTask<bool> MoveNextAsync()
            {
                cancellationToken.ThrowIfCancellationRequested();
                completionSource.Reset();

                if (groupEnumerator == null)
                {
                    CreateLookup().Forget();
                }
                else
                {
                    SourceMoveNext();
                }
                return new UniTask<bool>(this, completionSource.Version);
            }

            async UniTaskVoid CreateLookup()
            {
                try
                {
                    var lookup = await source.ToLookupAwaitAsync(keySelector, elementSelector, comparer, cancellationToken);
                    groupEnumerator = lookup.GetEnumerator();
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
                SourceMoveNext();
            }

            void SourceMoveNext()
            {
                try
                {
                    if (groupEnumerator.MoveNext())
                    {
                        Current = groupEnumerator.Current as IGrouping<TKey, TElement>;
                        completionSource.TrySetResult(true);
                    }
                    else
                    {
                        completionSource.TrySetResult(false);
                    }
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
            }

            public UniTask DisposeAsync()
            {
                if (groupEnumerator != null)
                {
                    groupEnumerator.Dispose();
                }

                return default;
            }
        }
    }

    internal sealed class GroupByAwait<TSource, TKey, TElement, TResult> : IUniTaskAsyncEnumerable<TResult>
    {
        readonly IUniTaskAsyncEnumerable<TSource> source;
        readonly Func<TSource, UniTask<TKey>> keySelector;
        readonly Func<TSource, UniTask<TElement>> elementSelector;
        readonly Func<TKey, IEnumerable<TElement>, UniTask<TResult>> resultSelector;
        readonly IEqualityComparer<TKey> comparer;

        public GroupByAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            this.source = source;
            this.keySelector = keySelector;
            this.elementSelector = elementSelector;
            this.resultSelector = resultSelector;
            this.comparer = comparer;
        }

        public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new Enumerator(source, keySelector, elementSelector, resultSelector, comparer, cancellationToken);
        }

        sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<TResult>
        {
            readonly static Action<object> ResultSelectCoreDelegate = ResultSelectCore;

            readonly IUniTaskAsyncEnumerable<TSource> source;
            readonly Func<TSource, UniTask<TKey>> keySelector;
            readonly Func<TSource, UniTask<TElement>> elementSelector;
            readonly Func<TKey, IEnumerable<TElement>, UniTask<TResult>> resultSelector;
            readonly IEqualityComparer<TKey> comparer;
            CancellationToken cancellationToken;

            IEnumerator<IGrouping<TKey, TElement>> groupEnumerator;
            UniTask<TResult>.Awaiter awaiter;

            public Enumerator(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
            {
                this.source = source;
                this.keySelector = keySelector;
                this.elementSelector = elementSelector;
                this.resultSelector = resultSelector;
                this.comparer = comparer;
                this.cancellationToken = cancellationToken;
            }

            public TResult Current { get; private set; }

            public UniTask<bool> MoveNextAsync()
            {
                cancellationToken.ThrowIfCancellationRequested();
                completionSource.Reset();

                if (groupEnumerator == null)
                {
                    CreateLookup().Forget();
                }
                else
                {
                    SourceMoveNext();
                }
                return new UniTask<bool>(this, completionSource.Version);
            }

            async UniTaskVoid CreateLookup()
            {
                try
                {
                    var lookup = await source.ToLookupAwaitAsync(keySelector, elementSelector, comparer, cancellationToken);
                    groupEnumerator = lookup.GetEnumerator();
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
                SourceMoveNext();
            }

            void SourceMoveNext()
            {
                try
                {
                    if (groupEnumerator.MoveNext())
                    {
                        var current = groupEnumerator.Current;

                        awaiter = resultSelector(current.Key, current).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            ResultSelectCore(this);
                        }
                        else
                        {
                            awaiter.SourceOnCompleted(ResultSelectCoreDelegate, this);
                        }
                        return;
                    }
                    else
                    {
                        completionSource.TrySetResult(false);
                    }
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
            }

            static void ResultSelectCore(object state)
            {
                var self = (Enumerator)state;

                if (self.TryGetResult(self.awaiter, out var result))
                {
                    self.Current = result;
                    self.completionSource.TrySetResult(true);
                }
            }

            public UniTask DisposeAsync()
            {
                if (groupEnumerator != null)
                {
                    groupEnumerator.Dispose();
                }

                return default;
            }
        }
    }

    internal sealed class GroupByAwaitWithCancellation<TSource, TKey, TElement> : IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>>
    {
        readonly IUniTaskAsyncEnumerable<TSource> source;
        readonly Func<TSource, CancellationToken, UniTask<TKey>> keySelector;
        readonly Func<TSource, CancellationToken, UniTask<TElement>> elementSelector;
        readonly IEqualityComparer<TKey> comparer;

        public GroupByAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer)
        {
            this.source = source;
            this.keySelector = keySelector;
            this.elementSelector = elementSelector;
            this.comparer = comparer;
        }

        public IUniTaskAsyncEnumerator<IGrouping<TKey, TElement>> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new Enumerator(source, keySelector, elementSelector, comparer, cancellationToken);
        }

        sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<IGrouping<TKey, TElement>>
        {
            readonly IUniTaskAsyncEnumerable<TSource> source;
            readonly Func<TSource, CancellationToken, UniTask<TKey>> keySelector;
            readonly Func<TSource, CancellationToken, UniTask<TElement>> elementSelector;
            readonly IEqualityComparer<TKey> comparer;
            CancellationToken cancellationToken;

            IEnumerator<IGrouping<TKey, TElement>> groupEnumerator;

            public Enumerator(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
            {
                this.source = source;
                this.keySelector = keySelector;
                this.elementSelector = elementSelector;
                this.comparer = comparer;
                this.cancellationToken = cancellationToken;
            }

            public IGrouping<TKey, TElement> Current { get; private set; }

            public UniTask<bool> MoveNextAsync()
            {
                cancellationToken.ThrowIfCancellationRequested();
                completionSource.Reset();

                if (groupEnumerator == null)
                {
                    CreateLookup().Forget();
                }
                else
                {
                    SourceMoveNext();
                }
                return new UniTask<bool>(this, completionSource.Version);
            }

            async UniTaskVoid CreateLookup()
            {
                try
                {
                    var lookup = await source.ToLookupAwaitWithCancellationAsync(keySelector, elementSelector, comparer, cancellationToken);
                    groupEnumerator = lookup.GetEnumerator();
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
                SourceMoveNext();
            }

            void SourceMoveNext()
            {
                try
                {
                    if (groupEnumerator.MoveNext())
                    {
                        Current = groupEnumerator.Current as IGrouping<TKey, TElement>;
                        completionSource.TrySetResult(true);
                    }
                    else
                    {
                        completionSource.TrySetResult(false);
                    }
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
            }

            public UniTask DisposeAsync()
            {
                if (groupEnumerator != null)
                {
                    groupEnumerator.Dispose();
                }

                return default;
            }
        }
    }

    internal sealed class GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult> : IUniTaskAsyncEnumerable<TResult>
    {
        readonly IUniTaskAsyncEnumerable<TSource> source;
        readonly Func<TSource, CancellationToken, UniTask<TKey>> keySelector;
        readonly Func<TSource, CancellationToken, UniTask<TElement>> elementSelector;
        readonly Func<TKey, IEnumerable<TElement>, CancellationToken, UniTask<TResult>> resultSelector;
        readonly IEqualityComparer<TKey> comparer;

        public GroupByAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, CancellationToken, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
        {
            this.source = source;
            this.keySelector = keySelector;
            this.elementSelector = elementSelector;
            this.resultSelector = resultSelector;
            this.comparer = comparer;
        }

        public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new Enumerator(source, keySelector, elementSelector, resultSelector, comparer, cancellationToken);
        }

        sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<TResult>
        {
            readonly static Action<object> ResultSelectCoreDelegate = ResultSelectCore;

            readonly IUniTaskAsyncEnumerable<TSource> source;
            readonly Func<TSource, CancellationToken, UniTask<TKey>> keySelector;
            readonly Func<TSource, CancellationToken, UniTask<TElement>> elementSelector;
            readonly Func<TKey, IEnumerable<TElement>, CancellationToken, UniTask<TResult>> resultSelector;
            readonly IEqualityComparer<TKey> comparer;
            CancellationToken cancellationToken;

            IEnumerator<IGrouping<TKey, TElement>> groupEnumerator;
            UniTask<TResult>.Awaiter awaiter;

            public Enumerator(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, CancellationToken, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
            {
                this.source = source;
                this.keySelector = keySelector;
                this.elementSelector = elementSelector;
                this.resultSelector = resultSelector;
                this.comparer = comparer;
                this.cancellationToken = cancellationToken;
            }

            public TResult Current { get; private set; }

            public UniTask<bool> MoveNextAsync()
            {
                cancellationToken.ThrowIfCancellationRequested();
                completionSource.Reset();

                if (groupEnumerator == null)
                {
                    CreateLookup().Forget();
                }
                else
                {
                    SourceMoveNext();
                }
                return new UniTask<bool>(this, completionSource.Version);
            }

            async UniTaskVoid CreateLookup()
            {
                try
                {
                    var lookup = await source.ToLookupAwaitWithCancellationAsync(keySelector, elementSelector, comparer, cancellationToken);
                    groupEnumerator = lookup.GetEnumerator();
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
                SourceMoveNext();
            }

            void SourceMoveNext()
            {
                try
                {
                    if (groupEnumerator.MoveNext())
                    {
                        var current = groupEnumerator.Current;

                        awaiter = resultSelector(current.Key, current, cancellationToken).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            ResultSelectCore(this);
                        }
                        else
                        {
                            awaiter.SourceOnCompleted(ResultSelectCoreDelegate, this);
                        }
                        return;
                    }
                    else
                    {
                        completionSource.TrySetResult(false);
                    }
                }
                catch (Exception ex)
                {
                    completionSource.TrySetException(ex);
                    return;
                }
            }

            static void ResultSelectCore(object state)
            {
                var self = (Enumerator)state;

                if (self.TryGetResult(self.awaiter, out var result))
                {
                    self.Current = result;
                    self.completionSource.TrySetResult(true);
                }
            }

            public UniTask DisposeAsync()
            {
                if (groupEnumerator != null)
                {
                    groupEnumerator.Dispose();
                }

                return default;
            }
        }
    }
}