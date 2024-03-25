using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Dialogue", menuName = "ScriptableObjects/Dialogue")]
public class Dialogue : ScriptableObject
{
    public Image Character; // Actually should be a class or smth.
    public List<string> Lines; // All the lines for the given character in the dialogue.
}
