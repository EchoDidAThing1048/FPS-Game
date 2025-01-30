using UnityEngine;

public class Sword : MonoBehaviour
{
    Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && ani.GetBool("isAttacking") == false)
        {
            ani.SetBool("isAttacking",true);
        }
        
    }

    public void StopAttacking()
    {
        ani.SetBool("isAttacking", false);
    }
}
