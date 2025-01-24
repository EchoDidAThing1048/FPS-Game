using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int nextLevel;
    Respawn startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = FindFirstObjectByType<Respawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
