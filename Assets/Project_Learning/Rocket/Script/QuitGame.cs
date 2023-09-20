using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Update()
    {
        Quit();
    }

    void Quit()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Quitting game");
            Application.Quit();
        }
    }
}