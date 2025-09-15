using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; // mengatur kecepatan player

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

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
