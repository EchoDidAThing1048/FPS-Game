using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int nextLevel;
    Respawn startPos;

    void Start()
    {
        startPos = FindFirstObjectByType<Respawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            startPos.transform.position = transform.position;
            Debug.Log("Changed Scene");
            SceneManager.LoadScene(nextLevel);
        }
    }
}
