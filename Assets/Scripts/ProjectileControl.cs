

using UnityEngine;
using UnityEngine.UI;

public class ProjectileControl : MonoBehaviour
{
    Rigidbody rb ;
    [SerializeField] float power = 30;
    GameObject mira;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   mira = GameObject.FindGameObjectWithTag("Scope");
        rb = GetComponent<Rigidbody>();
        rb.AddForce (transform.TransformDirection(Vector3.MoveTowards(transform.position, mira.transform.position, Time.deltaTime * power)),
        ForceMode.Impulse);

        Invoke("Destruction", 3);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Destruction()
    {
        Destroy(gameObject);
    }

}
