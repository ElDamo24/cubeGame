using UnityEngine.SceneManagement;
using UnityEngine;

public class loadLevel : MonoBehaviour
{
    public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
