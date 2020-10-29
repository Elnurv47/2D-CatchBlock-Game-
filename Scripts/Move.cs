using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    Vector3 movement;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float delta = Input.GetAxis("Horizontal");     // We are using Rigidbody reference's movement methods which use physics
        movement = new Vector3(delta * speed, 0f, 0f); // The reason for this is that we don't want our main cube to go through walls
        rb.angularVelocity = Vector3.zero;             // This assigns object's Angular Velocity to zero
        rb.AddForce(movement, ForceMode.Impulse);      // AddForce() method helps us to move our main object
    }
}
