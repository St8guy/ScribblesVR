using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggerTester : MonoBehaviour
{
    int counter = 0;

    public void TestFunction (string str)
    {
        counter++;
        WallLogger.logger.DebugLog(str + counter);
    }
}
