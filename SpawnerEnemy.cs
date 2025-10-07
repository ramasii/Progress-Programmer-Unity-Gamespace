using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public float width;
    public GameObject enemyObj;
    public float spawnDelay; // delay spawn
    private float delayProgress; // dibandingkan dengan spawnDelay

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // jika progress > spawnDelay maka spawn
        if (delayProgress > spawnDelay)
        {
            // spawn enemy objek
            Vector3 randomPos = new Vector3(Random.Range(0, width) + transform.position.x, transform.position.y, 0);
            Instantiate(enemyObj, randomPos, Quaternion.Euler(new Vector3(0, 0, 180))); // gameobjek, posisi, rotasi

            // reset progress
            delayProgress = 0;
        }
        else
        {
            delayProgress += Time.deltaTime; // progress bertambah setiap detik
        }
    }
}
