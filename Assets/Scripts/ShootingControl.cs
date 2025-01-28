using UnityEngine;

public class ShootingControl : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Instantiate(projectile, transform.position, transform.rotation );
        }
    }
}
