using UnityEngine;

public class playerColision : MonoBehaviour
{
    public Player movement;

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gameManager>().gameOver();
        }
    }
}
