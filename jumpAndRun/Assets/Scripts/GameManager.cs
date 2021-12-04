
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    

    public void CompleteLevel()
    {
        Debug.Log("Level Complete");
        completeLevelUI.SetActive(true);
        
    }

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
        Debug.Log("R");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //loads the current scene again. 
    }
}
