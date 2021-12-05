using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplet : MonoBehaviour
{
    public void LoadNextLevel()
    {
        Debug.Log("LoadNextLevel");
        // under File -> buidl settings you can find the scenes that are being loaded in Unity
        // incorrect name space used!!
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }



}
