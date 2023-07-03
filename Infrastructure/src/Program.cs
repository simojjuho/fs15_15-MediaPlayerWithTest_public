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
        var userRepository = UserRepository.Instance;
        var userService = new UserService(userRepository);
        var userController = new UserController(userService);
   
        var mediaRepository = MediaRepository.Instance;
        var mediaService = new MediaService(mediaRepository, logger);
        var mediaController = new MediaController(mediaService, logger);

        var playListRepository = PlayListRepository.Instance(mediaRepository);
        var playListService = new PlayListService(playListRepository);
        var playListController = new PlayListController(playListService);

        /* command-line interface should be here. All the methods should be used from class controllers only */
        mediaController.CreateNewFile("Hell's bells", "/file/path/hells-bells.mp3", new TimeSpan(0, 0, 3, 30), MediaType.Audio);
        mediaController.CreateNewFile("Stairway to heaven", "/file/path/stairway-to-heaven.mp3", new TimeSpan(0, 0, 3, 30), MediaType.Audio);
        userController.AddNewList("Rock", user.GetId);
        userController.AddNewList("Classical", user.GetId);
        var mediaFiles = mediaRepository.GetAllFiles();
        
        var playlists = userController.GetAllList(user.GetId);
    }
}