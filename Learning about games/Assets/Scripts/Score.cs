using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    public float scorePlayer;
    public float scoreCoin;
    // Start is called before the first frame update
    void Start()
    {
        scoreCoin = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        scorePlayer = player.position.z;
        score.text = "Score: " + scorePlayer.ToString("0");
    }
}
