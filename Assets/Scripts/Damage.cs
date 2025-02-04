using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{

    [SerializeField] Material damageMat;
    Material normalMat;
    MeshRenderer rend;
    int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        normalMat = rend.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            Debug.Log(other.name);
            health -= 10;
            StartCoroutine(DamageAnimation());
        }

        
        
    }

    IEnumerator DamageAnimation()
    {
        rend.material = damageMat;
        yield return new WaitForSeconds(0.1f);
        rend.material = normalMat;
    }
    
}
