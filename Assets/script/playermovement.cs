
using UnityEngine;

public class playermovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float counter = 1f;
    public float forceValue = 10f;
    // Use this for initialization
    /*
	void Start () {
        rb.AddForce(0,200,500);
	}*/

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(-Vector3.up * forceValue);
        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w") && counter <=2)
        {
            
            forwardForce = forwardForce +500;
            Debug.Log(forwardForce + " " + counter);
            counter++;
        }

        if (Input.GetKey("s") && counter>= -1)
        {
            
            forwardForce = forwardForce -500;
            Debug.Log(forwardForce + " " + counter);
            counter--;
        }
        if (Input.GetKey("space"))
        {
            forwardForce = 8000;
            Debug.Log(forwardForce);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
