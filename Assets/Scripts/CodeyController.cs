using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CodeyController : MonoBehaviour
{
    public CodeyMove codeyMove; // Add a public CodeyMove variable to gain access to the Speed variable
    public Text startCountdownText;
    public Text lapTimeText;
    private float totalCountdownTime = 10f; // Example initial value
    private float totalLapTime = 60f; // Example initial value

    void Update()
    {
        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdownText.text = totalCountdownTime.ToString("F2");
           //codeyMove.Speed = 0;
        }
        else if (totalCountdownTime <= 0)
        {
            totalLapTime -= Time.deltaTime;
            lapTimeText.text = totalLapTime.ToString("F2");
            startCountdownText.text = "";
            //codeyMove.Speed = 40; // Set Codey's Speed to 40 or another value
        }

        if (totalLapTime < 0)
        {
            SceneManager.LoadScene(3);
            Debug.Log("Time is up!");
        }
    }
}
