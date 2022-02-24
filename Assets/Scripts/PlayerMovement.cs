
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    
    // Update is called once per frame
    //We make "Fixed" Update because we are using it to mess with the physics of the player
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);                                      //Added a forwardForce of  on Y-axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);                                 //Added a sideways movement on X-axis
        }

        if (Input.GetKey("a"))                                                               //Added a sideways movement on X-axis
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
