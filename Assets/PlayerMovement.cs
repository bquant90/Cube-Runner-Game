using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;

    public float forwardForce = 2000f;
    public float sideForce = 500f;

    // Update is called once per frame
    void FixedUpdate() {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rigidBody.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) {
            rigidBody.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
