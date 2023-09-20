using Project_Learning.Rocket.Script;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private float levelLoadDelay = 1f;

    
    void Update()
    {
        RespondtoDebugKeys();    
    }

    private void RespondtoDebugKeys()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            NextLevel();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Movement>().enabled = false;
        }    
        
    }

    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly");
                break;
            case "Finish":
                StartSucessSequence();
                break;
            default:
                StartCrashSequence();
                break;
        }
    }

    private void StartSucessSequence()
    {
        GetComponent<Movement>().enabled = false;
        Invoke("NextLevel", levelLoadDelay);
    }

    private void StartCrashSequence()
    {
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay);
    }
    private void NextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        
        SceneManager.LoadScene(nextSceneIndex);
    }
    private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}