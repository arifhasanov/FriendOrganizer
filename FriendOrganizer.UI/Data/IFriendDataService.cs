namespace FriendOrganizer.UI.Data;

public interface IFriendDataService
{
    IEnumerable<Friend> GetAll();
}