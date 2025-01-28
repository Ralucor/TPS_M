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
    }


      // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
