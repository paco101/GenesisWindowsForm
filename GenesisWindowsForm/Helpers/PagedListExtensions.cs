using System.Linq;

namespace Genesis.Helpers
{
	public static class PagedListExtensions
	{
		public static PagedList<T> ToPagedList<T>(this IQueryable<T> source, int page, int pageSize)
		{
			return new PagedList<T>(source, page, pageSize);
		}
	}
}
