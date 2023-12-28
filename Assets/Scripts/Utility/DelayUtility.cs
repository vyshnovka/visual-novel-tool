using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class DelayUtility
{
    /// <summary>Invoke action after given <paramref name="delay"/> in seconds.</summary>
    public static IEnumerator TimedEvent(Action targetAction, float delay)
    {
        yield return new WaitForSeconds(delay);
        targetAction.Invoke();
    }

    /// <summary>Toggle <paramref name="gameObject"/> active state after given <paramref name="delay"/> in seconds.</summary>
    public static IEnumerator ToggleActiveAfterDelay(this GameObject gameObject, float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(!gameObject.activeSelf);
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
