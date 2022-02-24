using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    /**public PlayerMovement movement;
    // Start is called before the first frame update
    void onCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Obstacle!!");
            //movement.enabled = false;

        }
    }*/

    public PlayerMovement movement;
    public GameManager gameManager;
     void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }


}
