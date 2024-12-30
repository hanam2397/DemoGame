using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu_function : MonoBehaviour
{
    public GameObject loadingtext;
    // Start is called before the first frame update
    public void NewGameBtn()
    {
        StartCoroutine(newgame());
    }

    IEnumerator newgame()
    {
        loadingtext.SetActive(true);
        SceneManager.LoadScene(2);
        yield return new WaitForSeconds(1f);
    }

    public void NewGameBtn_officemap()
    {
        StartCoroutine(newgame_officemap());
    }

    IEnumerator newgame_officemap()
    {
        loadingtext.SetActive(true);
        SceneManager.LoadScene(3);
        yield return new WaitForSeconds(1f);
    }

    public void ExitGame_function()
    {
        StartCoroutine(exitgame());
    }

    IEnumerator exitgame()
    {

        Application.Quit();
        yield return new WaitForSeconds(0f);

    }
}
