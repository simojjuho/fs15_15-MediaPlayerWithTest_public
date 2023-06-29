using Infrastructure.Repository;
using Moq;
using UseCase.Service;

namespace MediaPlayerTest.UseCase.Tests;

public class UserServiceTests
{
    private Mock<UserRepository> _mockUserRepo;
    private UserService _userService;

    public UserServiceTests()
    {
        _mockUserRepo = new();
        _userService = new(_mockUserRepo.Object);
    }
    
    
}