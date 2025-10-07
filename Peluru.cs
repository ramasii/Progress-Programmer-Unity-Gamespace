using UnityEngine;

public class Peluru : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // jalan ke sumbu y local (transform.up)
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
