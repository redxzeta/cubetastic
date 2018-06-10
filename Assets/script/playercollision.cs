
using UnityEngine;

public class playercollision : MonoBehaviour {
    public playermovement movement;
    public Rigidbody rb;

    void OnCollisionEnter (Collision collisionInfo)
    {

        
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        
        }
      
    }
  


}
