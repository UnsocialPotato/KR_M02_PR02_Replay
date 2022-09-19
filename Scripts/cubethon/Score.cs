using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text pointText;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        pointText.text = FindObjectOfType<PlayerCollision>().score.ToString("0");
    }
}
