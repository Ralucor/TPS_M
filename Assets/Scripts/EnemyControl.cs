using UnityEngine;

public class EnemyControl : MonoBehaviour
{
     [SerializeField] int health ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       health=3;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Projectile"))
        {
           health --;
           Destroy(other.gameObject);

        }
    }
}
