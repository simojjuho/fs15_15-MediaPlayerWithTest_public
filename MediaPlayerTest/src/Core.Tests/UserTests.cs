using Domain.Core;
using MediaPlayerTest.TestUtils;

namespace MediaPlayerTest.Core.Tests;

public class UserTests
{
    [Fact]
    public void InstanceCreation_NewUser_Successful()
    {
        Assert.IsType<User>(User.Instance);
    }

    [Fact]
    public void InstanceCreation_NewUser_SameUser()
    {
        var user1 = User.Instance;
        var user2 = User.Instance;
        
        Assert.Equal(user2, user1);
    }

    [Fact]
    public void AddPlaylist_ValidData_PlaylistAdded()
    {
        var user1 = User.Instance;
        var playlist = new PlayList("rock", user1.GetId);
        
        user1.AddNewList(playlist);

        Assert.Collection(user1.Lists, list => Assert.Equal("rock", list.ListName));
    }
    
    [Fact]
    public void RemovePlaylist_Successfully()
    {
        var user1 = User.Instance;
        var playlist = new PlayList("rock", user1.GetId);
        
        user1.AddNewList(playlist);
        Assert.Collection(user1.Lists, list => Assert.Equal("rock", list.ListName));
        
        user1.RemoveOneList(playlist);
        Assert.Empty(user1.Lists);
    }

    [Fact]
    public void EmptyOneList_ValidList_Successfully()
    {
        var user1 = User.Instance;
        var playlist = new PlayList("rock", user1.GetId);
        var sl = new StringLogger();
        var song1 = new Audio("file1", "./file1", new TimeSpan(0, 0, 0, 30), 1.0, sl.Logger);
        var song2 = new Audio("file1", "./file1", new TimeSpan(0, 0, 0, 30), 1.0, sl.Logger);

        user1.AddNewList(playlist);
        playlist.AddNewFile(song1, user1.GetId);
        playlist.AddNewFile(song2, user1.GetId);
        user1.EmptyOneList(playlist.GetId);
        
        Assert.Empty(user1.Lists[0].GetAllFiles(user1.GetId));
    }
}