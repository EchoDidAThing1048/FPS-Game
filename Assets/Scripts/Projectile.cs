using UnityEngine;

public class Projectile : MonoBehaviour
{
    int damage = 20;
    float despawnTime; //for projectiles

    void Update()
    {
        despawnTime += Time.deltaTime;
        if(despawnTime > 5)
        {
            Destroy(gameObject);
        }
    }

    public int DealDamage()
    {   Destroy(gameObject);
        return damage;
    }
}
