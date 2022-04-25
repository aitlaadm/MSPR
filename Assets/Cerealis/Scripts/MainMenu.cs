using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    public void Play()
    {

        //SceneManager.LoadScene(1);
        SceneManager.LoadScene("augmented_reality");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
