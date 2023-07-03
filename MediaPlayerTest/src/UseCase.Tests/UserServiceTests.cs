using Domain.Core;
using Infrastructure.Repository;
using Moq;
using UseCase.Service;

namespace MediaPlayerTest.UseCase.Tests;

public class UserServiceTests
{
    private Mock<UserRepository> _mockUserRepo;
    private UserService _userService;
    private User _user { get; set; }

    public UserServiceTests()
    {
        _mockUserRepo = new();
        _userService = new(_mockUserRepo.Object);
        _user = 
    }

    [Fact]
    public void AddNewUser_ValidValue_Passes()
    {
        
    }
}