using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPerson : MonoBehaviour
{
    public float speed1;
    [SerializeField] private float speedJump;
    [SerializeField] private bool onGround;
    [SerializeField] private Rigidbody cylinderRigidBody;


    private float threshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        speedJump = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        if (transform.position.y < 2.58f + threshold && transform.position.y > 2.58f - threshold)
        {
            onGround = true;
            cylinderRigidBody.velocity = new Vector3(cylinderRigidBody.velocity.x, 0, cylinderRigidBody.velocity.z);
        }

        if (Input.GetKey(KeyCode.W))
            gameObject.transform.Translate(Vector3.forward * speed1 * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Translate(Vector3.left * speed1 * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            gameObject.transform.Translate(Vector3.back * speed1 * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Translate(Vector3.right * speed1 * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            // gameObject.transform.Translate(Vector3.up * speedJump * Time.deltaTime);
            cylinderRigidBody.velocity = new Vector3(cylinderRigidBody.velocity.x, cylinderRigidBody.velocity.y + speedJump, cylinderRigidBody.velocity.z);
            //GetComponent<Rigidbody>().velocity += 5;
            onGround = false;
        }


    }
}