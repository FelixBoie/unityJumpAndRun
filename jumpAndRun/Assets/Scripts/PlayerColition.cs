using UnityEngine;

public class PlayerColition : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(message: collisionInfo.collider.name);

            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();

        }


    }
}
