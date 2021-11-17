
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;
    public void EndGame()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Debug.Log("Game Over.");
            Invoke("Restart", 2f);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //loads the current scene again. 
    }
}
