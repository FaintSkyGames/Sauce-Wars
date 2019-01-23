using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashAddScore : MonoBehaviour
{
    public float speedToAdd = 5.0f;

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
        // If the tag was player bullet...
        if (recievedTag == "Player Bullet")
        {
            // ...target collided with players bullet
            collideWithPlayerBullet = true;
        }
        // If the tag was enemy bullet...
        if (recievedTag == "Enemy Bullet")
        {
            // ...target collided with enemy bullet
            collideWithEnemyBullet = true;
        }
    }

    // When a target dies this will run before its removed
    public void OnDestroy()
    {
        // If there is nothing listening to the event
        if ((OnSendScorePlayer != null) & (OnSendScoreEnemy != null))   //(OnSendScore != null)
        {
            // if destroyed by player
            if (collideWithPlayerBullet == true)
            {
                // Send the score propertry to player
                // and add speed as long as it stays within boundaries
                if (PlayerPrefs.GetFloat("PlayerSpeed") + speedToAdd >= 7)
                {
                    if (PlayerPrefs.GetFloat("PlayerSpeed") + speedToAdd < 22)
                    {
                        PlayerPrefs.SetFloat("PlayerSpeed", (PlayerPrefs.GetFloat("PlayerSpeed") + speedToAdd));
                    }
                }

                OnSendScorePlayer(10);
            }
            else if (collideWithEnemyBullet == true)
            {
                // Send the score propertry to enemy
                // and add speed as long as it stays within boundaries
                if (PlayerPrefs.GetFloat("EnemySpeed") + speedToAdd >= 15)
                {
                    if (PlayerPrefs.GetFloat("EnemySpeed") + speedToAdd < 30)
                    {
                        PlayerPrefs.SetFloat("EnemySpeed", (PlayerPrefs.GetFloat("EnemySpeed") + speedToAdd));
                    }
                }

                OnSendScoreEnemy(10);
            }

        }
    }
}