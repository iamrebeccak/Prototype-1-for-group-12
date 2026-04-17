using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleTrigger : MonoBehaviour
{
    public float spawnRate;
    public float enemyCombat;
    private bool canSpawn;

    private Scene battleScene;

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCheck()
    {
        var SpawnChance = Random.Range(0f, spawnRate);
        if (SpawnChance >= enemyChance)
        {
            Debug.Log("Battle Starts!!");
        }

    }
}
