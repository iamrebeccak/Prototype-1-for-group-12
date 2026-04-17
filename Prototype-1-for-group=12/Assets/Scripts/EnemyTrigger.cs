using UnityEngine;
using System.Collections.Generic; 

public class EnemyTrigger : MonoBehaviour
{
    public bool isPlayerInRange = false;

   // "other" refers to the collider in the Player
   public void OnTriggerEnter2D (Collider2D other)
    {
        isPlayerInRange = true; 
        print("A collider has entered the EnemyTrigger trigger");
    }

}
