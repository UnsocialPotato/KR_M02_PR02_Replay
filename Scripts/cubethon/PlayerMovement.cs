using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    public void MoveLeft()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void MoveRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    // Marked as "Fixed"Update due to
    // messing with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   // Add a forward force

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void ResetPosition()
    {
        rb.velocity = new Vector3(0f, 0f, 0f);
        rb.angularVelocity = new Vector3(0f, 0f, 0f);
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        GetComponent<Transform>().eulerAngles = new Vector3(0f, 0f, 0f);
        transform.position = new Vector3(0.0f, 1.0f, 0.0f);
    }

    public void ResetVelocity()
    {
        rb.velocity = new Vector3(0, 0, forwardForce * Time.deltaTime);
    }
}
