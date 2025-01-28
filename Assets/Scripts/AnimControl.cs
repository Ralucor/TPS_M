using UnityEngine;

public class AnimControl : MonoBehaviour
{
    Animator anim;

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
    }
}
