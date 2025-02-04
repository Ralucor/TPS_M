using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    Animator anim;
    [SerializeField] GameObject scope;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal")!=0
        || Input.GetAxis("Vertical") != 0){
            //Corriendo
            anim.SetBool("IsRunning",true);
        }   else{
            //Quieto
            anim.SetBool("IsRunning", false);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetTrigger("HasJumped");
        }
        if (Input.GetMouseButton(1)){
            anim.SetBool("IsAiming", true);
            Quaternion lookOnLook =
Quaternion.LookRotation(new Vector3(scope.transform.position.x,0, scope.transform.position.z) - new Vector3(transform.position.x,0,transform.position.z));

       transform.rotation =
       Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime*5);
            //  transform.LookAt (new Vector3(scope.transform.position.x,0, scope.transform.position.z));
            // transform.rotation=Quaternion.Euler(0,transform.rotation.y, transform.rotation.z);
        }else{ anim.SetBool("IsAiming",false);}
    }
}
