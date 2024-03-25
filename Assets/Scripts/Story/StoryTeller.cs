using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Utility;

public class StoryTeller : MonoBehaviour
{
    [FormerlySerializedAs("dialogue")] [SerializeField]
    private Dialogue1 dialogue1;

    [SerializeField]
    private Text text;

    [SerializeField]
    [Range(0, 5)]
    private float timeToWait = 0.1f;

    private int lineIndex = 0;
    private string lineToDisplay = "";
    private string partToDisplay = "";

    private Coroutine textCoroutine;
    private bool isTyping = true;

    void Start()
    {
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isTyping)
            {
                isTyping = false;
                StopCoroutine(textCoroutine);

                text.text = lineToDisplay;
            }
        }
    }

    private void StartDialogue()
    {
        lineToDisplay = dialogue1.Lines[lineIndex];

        StartCoroutine(Delay.TimedEvent(() => {
            textCoroutine = StartCoroutine(TextWritter(lineToDisplay));
            isTyping = true;
        }, 0.2f));
    }

    private IEnumerator TextWritter(string line)
    {
        lineToDisplay = line;
        isTyping = true;

        for (int i = 0; i <= line.Length; i++)
        {
            partToDisplay = line[..i];
            text.text = partToDisplay;

            yield return new WaitForSeconds(timeToWait);
        }

        isTyping = false;
        StopCoroutine(textCoroutine);
    }
}
