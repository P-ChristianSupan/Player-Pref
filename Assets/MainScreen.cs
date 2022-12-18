using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    public InputField Username;
    // Start is called before the first frame update
    public void clickSave()
    {
        PlayerPrefs.SetString("username", Username.text);
        SceneManager.LoadScene("2-GameScene");
    }
}
