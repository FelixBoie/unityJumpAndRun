using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardForce = 500f;
    public float sidewayForce = 500f;
    public float jumpForce = 2000f;
    public Rigidbody rb; 


    // Update is called once per frame
    void FixedUpdate()   // unity prefers FixedUpate with forces
    {
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0, -2.5f * forwardForce * Time.deltaTime);
        }
        else
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a forward force
        }

        

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
