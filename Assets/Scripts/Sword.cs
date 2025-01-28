using UnityEngine;

public class Sword : MonoBehaviour
{
    Animator ani;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Attack
        }
    }
}
