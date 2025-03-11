using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    bool isShooting;
    public float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isShooting == false && Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newPro = Instantiate(projectile);
            newPro.transform.position = transform.position;
            newPro.transform.rotation = transform.rotation;
            newPro.GetComponent<Rigidbody>().AddForce(transform.up*force);

            StartCoroutine(ShootDelay());
        }
    }

    IEnumerator ShootDelay()
    {
        isShooting = true;
        yield return new WaitForSeconds(1);
        isShooting = false;
    }
}
