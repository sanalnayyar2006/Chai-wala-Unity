namespace ChaiWala.Core.Application
{
    public sealed class ApplicationRoot
    {
        public void Initialize()
        {
            var sceneLoader = new SceneManagement.SceneLoader();
            sceneLoader.LoadMainMenu();
        }
    }
}