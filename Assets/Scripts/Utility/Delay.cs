using System;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Utility
{
    public static class Delay
    {
        /// <summary>Invoke action after given <paramref name="delay"/> in seconds.</summary>
        public static void TimedEvent(Action targetAction, float delay)
        {
            Task.Delay(TimeSpan.FromSeconds(delay)).ContinueWith(_ => targetAction.Invoke());
        }

        public static async Task LoadSceneAfterDelay(string sceneName, float delay)
        {
            await Task.Delay(TimeSpan.FromSeconds(delay));
            SceneManager.LoadScene(sceneName);
        }

        public static async Task LoadSceneAfterDelay(int sceneIndex, float delay)
        {
            await Task.Delay(TimeSpan.FromSeconds(delay));
            SceneManager.LoadScene(sceneIndex);
        }
    }
}

