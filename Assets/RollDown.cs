
using UnityEngine;

public class RollDown : MonoBehaviour {
    public Rigidbody rb;
    public float backForce = -2000f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, backForce * Time.deltaTime);
    }
}
