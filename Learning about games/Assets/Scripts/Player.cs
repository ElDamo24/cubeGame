using System.Security.Permissions;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float leftRightForce;
    // Start is called before the first frame update
    void Start()
    {
        forwardForce =4000f;
        leftRightForce = 50f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(leftRightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-leftRightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<gameManager>().gameOver();
        }
    }
}
