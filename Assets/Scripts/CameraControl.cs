using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform target;

    [SerializeField] float rotationSpeed = 1f;

    float mouseX, mouseY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        
        mouseY = Mathf.Clamp(mouseY, -45, 60);

        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);

        player.rotation = Quaternion.Euler(0, mouseX, 0);

    }
}
