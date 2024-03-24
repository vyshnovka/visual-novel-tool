using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utility
{
    //? Not nice that it requires a coroutine to start to call these methods.
    public static class Delay
    {
        /// <summary>Invoke action after given <paramref name="delay"/> in seconds.</summary>
        public static IEnumerator TimedEvent(Action targetAction, float delay)
        {
            yield return new WaitForSeconds(delay);
            targetAction.Invoke();
        }

        public static IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
        {
            yield return new WaitForSeconds(delay);
            SceneManager.LoadScene(sceneName);
        }

        public static IEnumerator LoadSceneAfterDelay(int sceneIndex, float delay)
        {
            yield return new WaitForSeconds(delay);
            SceneManager.LoadScene(sceneIndex);
        }
    }
}

