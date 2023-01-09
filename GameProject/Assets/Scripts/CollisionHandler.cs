using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {

        switch(other.gameObject.tag)
        {
            case "Friendly":
                UnityEngine.Debug.Log("This thing is friendly");
                break;
            case "Finish":
                UnityEngine.Debug.Log("Congrats, you finished!");
                break;
            default:
                ReloadLevel();
                break;
        }
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
