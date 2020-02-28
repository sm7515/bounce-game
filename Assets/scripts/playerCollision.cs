using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle") {
            movement.enabled = false;
        }
    }
}
