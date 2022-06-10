namespace FriendOrganizer.UI.Data;
public class FriendDataService : IFriendDataService
{
    public IEnumerable<Friend> GetAll()
    {
        yield return new Friend() { Id = 1, FirstName = "Arif", LastName = "Hasanov", Email = "ah@gmail.com" };
        yield return new Friend() { Id = 2, FirstName = "Aygun", LastName = "Gadirova", Email = "ag@gmail.com" };
        yield return new Friend() { Id = 3, FirstName = "Nezrin", LastName = "Hasanova", Email = "nh@gmail.com" };
        yield return new Friend() { Id = 4, FirstName = "Suleyman", LastName = "Hasanov", Email = "sh@gmail.com" };
    }
}
