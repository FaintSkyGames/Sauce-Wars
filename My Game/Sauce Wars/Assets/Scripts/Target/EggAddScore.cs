using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggAddScore : MonoBehaviour
{
    public int timeToAdd = 5;

    public Collision2D collider;

    // Sends the score stored
    public delegate void SendScore(int theScore);
    //public static event SendScore OnSendScore;
    public static event SendScore OnSendScorePlayer;
    public static event SendScore OnSendScoreEnemy;

    // The score you will earn
    public int score = 10;

    private bool collideWithPlayerBullet = false;

    // Recieves the tag of the bullet
    public void SetWhosBullet(string recievedTag)
    {
        print("AddScore - SetWhosBullet");

        // if the tag was player bullet
        if (recievedTag == "Player Bullet")
        {
            // target collided with players bullet
            collideWithPlayerBullet = true;
        }
    }

    // When a zombie dies this will run before its removed
    public void OnDestroy()
    {
        print("AddScore - OnDestroy");

        // If there is nothing listening to the event
        if ((OnSendScorePlayer != null) & (OnSendScorePlayer != null))   //(OnSendScore != null)
        {

            // if destroyed by player
            if (collideWithPlayerBullet == true)
            {
                // Send the score propertry to player
                print("send player score");
                // Before sending update time
                //PlayerPrefs.SetFloat("TimeCompleted", (PlayerPrefs.GetFloat("TimeCompleted") - timeToAdd));
                OnSendScorePlayer(score);
            }
            else
            {
                // Send the score propertry to enemy
                print("send enemy score");
                OnSendScoreEnemy(score + 5);
            }

        }
    }

}
