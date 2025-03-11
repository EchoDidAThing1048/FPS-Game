using UnityEngine;

public class Respawn : MonoBehaviour
{
    Transform player;
    static GameObject startPos;

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

}
