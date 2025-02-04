using UnityEngine;

public class ShootingControl : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    // [SerializeField] GameObject mira;
   private bool aiming;

    void Start(){
        aiming=false;
    }

    void Update()
    {
        if(Input.GetMouseButton(1)){
            aiming=true;
        }else{aiming=false;}

        if (Input.GetMouseButtonDown(0)&& aiming) {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
