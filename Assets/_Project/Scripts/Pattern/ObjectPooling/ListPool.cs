using System.Collections.Generic;

public static class ListPool<T>
{
    private static readonly List<List<T>> pool = new List<List<T>>();

    private static readonly HashSet<List<T>> inPool = new HashSet<List<T>>();

    public static List<T> Claim()
    {
        lock (pool)
        {
            if (pool.Count > 0)
            {
                List<T> ls = pool[pool.Count - 1];
                pool.RemoveAt(pool.Count - 1);
                inPool.Add(ls);
                return ls;
            }

            return new List<T>();
        }
    }

    public static void Release(List<T> list)
    {
        list.Clear();

        lock (pool)
        {
            pool.Add(list);
        }
    }
}
