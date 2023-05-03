using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame. Increment the player's score based on the z-axis movement (moving forward 1 "step" -> add 1 to the score).
    void Update() {
        scoreText.text = player.position.z.ToString("0");
    }
}
