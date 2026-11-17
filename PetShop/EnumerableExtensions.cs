using System.Collections.Generic;
using Training.DomainClasses;

public static class EnumerableExtensions
{
    public static IEnumerable<TPet> OneAtATime<TPet>(this IEnumerable<TPet> items)
    {
        foreach (var item in items)
        {
            yield return item;
        }
    }
}