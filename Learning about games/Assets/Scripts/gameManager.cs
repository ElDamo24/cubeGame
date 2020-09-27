using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    private bool ended = false;
    private float restartDelay = 1f;
    public GameObject completeLevel;

    public void gameOver ()
    {
        if (ended == false)
        {
            ended = true;
            Invoke("restart", restartDelay);
        }
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void endGame()
    {
        completeLevel.SetActive(true);
    }
}
