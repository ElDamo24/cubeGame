using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public gameManager game;

    void OnTriggerEnter()
    {
        game.endGame();
    }
}
