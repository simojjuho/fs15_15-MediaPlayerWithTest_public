using Domain.Core;
using Infrastructure.Repository;
using Infrastructure.Writer;
using Presenter;
using UseCase.Service;

namespace Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {
        // how client interact with application - via controllers
        var user = User.Instance;
        var logger = new ConsoleMessages();
        var userRepository = new UserRepository();
        var userService = new UserService(userRepository);
        var userController = new UserController(userService);
   
        var mediaRepository = new MediaRepository();
        var mediaService = new MediaService(mediaRepository, logger);
        var mediaController = new MediaController(mediaService, logger);

        var playListRepository = new PlayListRepository();
        var playListService = new PlayListService(playListRepository);
        var playListController = new PlayListController(playListService);

        /* command-line interface should be here. All the methods should be used from class controllers only */
    }
}