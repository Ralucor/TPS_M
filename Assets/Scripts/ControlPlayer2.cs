using UnityEngine;
using UnityEngine.UI;

public class ControlPlayer2 : MonoBehaviour
{
    [SerializeField] Slider healthBar;
    [SerializeField] float health = 100;
    [SerializeField] float dps = 20;

    void OntriggerStay(Collider other){
         if (other.CompareTag("damage")){
            health = health - dps * Time.deltaTime;
            healthBar.value = health;
         }
         if(health<=0){
        
         }
    }


}
