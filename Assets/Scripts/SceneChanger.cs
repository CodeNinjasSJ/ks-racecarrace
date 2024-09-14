using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public Button yourButton; // Reference to the button

    void Start()
    {
        // Add a listener to the button to call the ChangeScene method when clicked
        yourButton.onClick.AddListener(ChangeScene);
    }

    public void ChangeScene()
    {
        // Load the scene named "Scene1"
        SceneManager.LoadScene(1);
    }
}
