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
        // If the tag was player bullet...
        if (recievedTag == "Player Bullet")
        {
            // ...target collided with players bullet
            collideWithPlayerBullet = true;
        }
        // If the tag was enemy bullet...
        if (recievedTag == "Enemy Bullet")
        {
            // ...target collided with players bullet
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
                // Before sending update time
                PlayerPrefs.SetFloat("TimeCompleted", (PlayerPrefs.GetFloat("TimeCompleted") - timeToAdd));
                OnSendScorePlayer(10);
            }
            else if(collideWithEnemyBullet == true)
            {
                // Send the score propertry to enemy
                OnSendScoreEnemy(15);
            }
        }
    }

}
