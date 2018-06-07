
using UnityEngine;

public class folllow : MonoBehaviour {
    public Transform player;
    public Vector3 offset;
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = player.position + offset;
        //transform.position = player.position + new Vector3(0f, 1.2f, -5.5f);
    }
}
