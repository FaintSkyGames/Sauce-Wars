using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour {

    // Sends the score stored
    public delegate void SendScore(int theScore);
    public static event SendScore OnSendScore;

    // The score you will earn
    public int score = 10;

    // When a zombie dies this will run before its removed
    public void OnDestroy()
    {
        // If there is nothing listening to the event
        if (OnSendScore != null)
        {
            // Send the score propertry sendscore
            OnSendScore(score);
        }
    }

}
