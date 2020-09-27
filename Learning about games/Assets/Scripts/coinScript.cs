using UnityEngine.UI;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    public Text coin;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        coin.text = "Coins: 0";
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, 50 * Time.deltaTime);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            count++;
            coin.text = "Coins: " + count.ToString();
            Destroy(this.gameObject);
        }
    }
}
