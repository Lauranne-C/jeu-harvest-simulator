using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenu : MonoBehaviour
{
    private string path = "Assets/2 - Scripts/Name.txt";
    public InputField inputField;
    public void PlayGame()
    {
        if (!string.IsNullOrEmpty(inputField.text))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(inputField.text);
            writer.Close();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
