using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallLogger : MonoBehaviour
{
    public static WallLogger logger;
    public Text mainText;
    public int maxEntries = 25;

    public Queue<string> logQueue = new Queue<string>();

    // Start is called before the first frame update
    void Start()
    {
        logger = this;    
    }

    public void DebugLog(string logText)
    {
        logQueue.Enqueue(logText);

        if (logQueue.Count > maxEntries)
        {
            logQueue.Dequeue();
        }

        UpdateText();
    }

    private void UpdateText()
    {
        mainText.text = "";

        foreach (string str in logQueue)
        {
            mainText.text += str;

            if (mainText.text != string.Empty)
            {
                string newLineText = System.Environment.NewLine;
                mainText.text += newLineText;
            }
        }
    }
}
