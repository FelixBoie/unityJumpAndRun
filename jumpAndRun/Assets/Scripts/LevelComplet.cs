using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelComplet : MonoBehaviour
{
    public void LoadNextLevel()
    {
        Debug.Log("LoadNextLevel");
        // under File -> buidl settings you can find the scenes that are being loaded in Unity
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + 1);

    }



}
