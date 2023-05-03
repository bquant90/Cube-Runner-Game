using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;

    public float forwardForce = 2000f;
    public float sideForce = 500f;

    // Update is called once per frame
    void FixedUpdate() {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Move right by multiplying the sideforce with time.deltatime on the x-axis.
        if (Input.GetKey("d")) {
            rigidBody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Move left by multiplying the negative of sideforce with time.deltatime on the x-axis.
        if (Input.GetKey("a")) {
            rigidBody.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // If the cube falls off the map, restart the level.
        if (rigidBody.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
