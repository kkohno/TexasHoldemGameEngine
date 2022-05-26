namespace TexasHoldem.Logic.Web;

public static class EnumerableExtensions
{
	public static WebPlayer WithUserId(this IEnumerable<WebPlayer> collection, string userId)
	{
		return collection.First(p => p.Name == userId);
	}
}