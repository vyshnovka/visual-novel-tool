using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Plot", menuName = "ScriptableObjects/Plot")]
public class Plot : ScriptableObject
{
    public Image Character; // Actually should be a class or smth.
    public List<string> Lines; // All the lines for the given character in the dialogue.
}
