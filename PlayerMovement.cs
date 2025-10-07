using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; // mengatur kecepatan player
    public float shotInterval; // interval
    private float progressDelay; // untuk pembanding di kondisi menembak
    public GameObject peluru; // objek untuk dispawn

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // jika progressDelay > shotInterval maka spawn objek peluru
        if (progressDelay > shotInterval)
        {
            // maka spawn peluru 
            Instantiate(peluru, transform.position, Quaternion.identity);
            // progress direset
            progressDelay = 0;
        }
        else
        {
            progressDelay += Time.deltaTime; // bertambah setiap detik
        }

        // input player
        if (Input.GetAxis("Horizontal") != 0) // untuk gerak horizontal
        {
            // mengubuah posisi player
            transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            // transform.transform()
        }

        // gerak vertikal
        if (Input.GetAxis("Vertical") != 0)
        {
            // mengubuah posisi player
            transform.position += transform.up * Input.GetAxis("Vertical") * Time.deltaTime * speed;
        }
    }
}
