using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        // will only shown if exported, not in Unity
        Application.Quit();

        Debug.Log("Quite Game");
    }

}
