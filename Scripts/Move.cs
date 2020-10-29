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
        float delta = Input.GetAxis("Horizontal");
        movement = new Vector3(delta * speed, 0f, 0f);
        rb.angularVelocity = Vector3.zero;
        rb.AddForce(movement, ForceMode.Impulse);
    }
}
