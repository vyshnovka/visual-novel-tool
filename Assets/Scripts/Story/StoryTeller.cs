using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Utility;

namespace Story
{
    public class StoryTeller : MonoBehaviour
    {
        [SerializeField]
        private Dialogue dialogue;

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
            lineToDisplay = dialogue.Lines[lineIndex];

            Delay.TimedEvent(() => {
                textCoroutine = StartCoroutine(TextWritter(lineToDisplay));
                isTyping = true;
            }, 0.2f);
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
}
