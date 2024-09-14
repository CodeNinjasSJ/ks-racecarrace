using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
        {
            print("You Win!");
            SceneManager.LoadScene(2);
        }
        else
        {
            print("Cheater!1!1");
           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
