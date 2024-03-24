using System.Collections;
using UnityEngine;

namespace Utility
{
    public static class GameObjectExtensions
    {
        /// <summary>Toggle <paramref name="gameObject"/> active state after given <paramref name="delay"/> in seconds.</summary>
        public static IEnumerator ToggleActiveAfterDelay(this GameObject gameObject, float delay)
        {
            yield return new WaitForSeconds(delay);
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }

    public static class TransformExtensions
    {
        /// <summary>Set the position of a given transform (Unity only has the implementation that also includes rotation).</summary>
        public static void SetPosition(this Transform transform, float? x = null, float? y = null, float? z = null)
        {
            var objectToMove = transform.position;
            Camera.main.transform.position = new Vector3(x ?? objectToMove.x, y ?? objectToMove.y, z ?? objectToMove.z);
        }
    }
}
