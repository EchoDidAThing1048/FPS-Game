using UnityEngine;

public class Swap : MonoBehaviour
{
    [SerializeField] GameObject sword, gun;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sword.SetActive(true);
        gun.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.mouseScrollDelta.y > 0)
        {
            sword.SetActive(true);
            gun.SetActive(false);
        }
        else if(Input.mouseScrollDelta.y < 0)
        {
            sword.SetActive(false);
            gun.SetActive(true);
        }
    }
}
