using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Bob";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            Debug.Log("Space pressed");

            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }
}
