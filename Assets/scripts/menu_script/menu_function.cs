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
}
