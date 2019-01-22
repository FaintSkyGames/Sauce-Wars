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

    private bool collideWithPlayerBullet = false;
    private bool collideWithEnemyBullet = false;

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
        if (recievedTag == "Enemy Bullet")
        {
            // target collided with players bullet
            collideWithEnemyBullet = true;
        }
    }

    // When a zombie dies this will run before its removed
    public void OnDestroy()
    {
        print("AddScore - OnDestroy");

        // If there is nothing listening to the event
        if ((OnSendScorePlayer != null) & (OnSendScoreEnemy != null))   //(OnSendScore != null)
        {
            print("In 1st loop");
            // if destroyed by player
            if (collideWithPlayerBullet == true)
            {
                // Send the score propertry to player
                print("send player score");
                // Before sending update time
                PlayerPrefs.SetFloat("TimeCompleted", (PlayerPrefs.GetFloat("TimeCompleted") - timeToAdd));

                print("player egg score " + 10);
                //PlayerPrefs.SetInt("PlayerScore", (PlayerPrefs.GetInt("PlayerScore") + score));
                OnSendScorePlayer(10);
            }
            else if(collideWithEnemyBullet == true)
            {
                // Send the score propertry to enemy
                print("send enemy score");

                print("enemy egg score " + 15);
                //PlayerPrefs.SetInt("EnemyScore", (PlayerPrefs.GetInt("EnemyScore") + score));
                OnSendScoreEnemy(15);
            }
            else
            {
                print("failure: no collision detected");
            }

        }
    }

}
