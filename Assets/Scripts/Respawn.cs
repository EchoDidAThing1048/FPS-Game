using UnityEngine;

public class Respawn : MonoBehaviour
{
    Transform player;
    static GameObject startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (startPos == null)
        {
            startPos = gameObject;
            DontDestroyOnLoad(gameObject);
        }

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
