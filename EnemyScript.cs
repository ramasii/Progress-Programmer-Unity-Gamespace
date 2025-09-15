using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed; // ngatur kecepatan enemy

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // jalan ke atas local
        // posisi sekarang diubah ke arah posisi atas (Z local)
        transform.position += transform.up * speed * Time.deltaTime;

        // ketika posisi enemy.Y < -6 maka destroy
        if (transform.position.y < -6)
        {
            Destroy(gameObject); // destroy objek ini sendiri
        }
    }
}
