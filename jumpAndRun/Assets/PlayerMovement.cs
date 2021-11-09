using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb; 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()   // unity prefers FixedUpate with forces
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); //Time since the last time a frame was drawn
    }
}
