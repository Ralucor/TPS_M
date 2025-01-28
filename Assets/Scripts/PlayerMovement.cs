using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] float speed = 10f;
    [SerializeField] float jump = 5f;
    [SerializeField] float gravity = -9.81f;

    Vector3 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal") * speed;
        movement.z = Input.GetAxis("Vertical") * speed;

        movement = transform.TransformDirection(movement);

        if (Input.GetKeyDown(KeyCode.Space) && touchingGround())
        {
            movement.y = jump;
        }

        movement.y += gravity * Time.deltaTime;
        controller.Move(movement * Time.deltaTime);

    }

    bool touchingGround()
    {
        return Physics.Raycast(transform.position, Vector3.down, 2);//Devuelve true si el rayo roca collider
    }
}