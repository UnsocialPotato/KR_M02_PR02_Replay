using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public float score;
    private InputHandler _input;
    

    void Start()
    {
        _input = FindObjectOfType<InputHandler>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            _input.Replay();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }

        if (collisionInfo.collider.tag == "Pedestrian")
        {
            score += 50;
        }
    }
}
