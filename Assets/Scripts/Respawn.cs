using UnityEngine;

public class Respawn : MonoBehaviour
{
    Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(Transform trans in FindObjectsOfType<Transform>() )
        {
            if(trans.CompareTag("Player"))
            {
                player = trans; //lol
            }
        }

        if(player)
        {
            player.position = transform.position;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
