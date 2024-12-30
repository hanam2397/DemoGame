using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausegame_scr : MonoBehaviour
{
    public GameObject pausedisplay;
    public bool pause_bool = false;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(pausegame());

    }


    IEnumerator pausegame()
    {
        if (pause_bool == false) { 
        if (Input.GetButtonDown("Cancel"))
        {
            pause_bool = !pause_bool;
            showcursor();
            pausedisplay.SetActive(true);
            yield return new WaitForSeconds(1f);
            }
        }

        if (pause_bool == true)
        {
            if (Input.GetButtonDown("Cancel"))
            {
                hidecursor();
                pause_bool = !pause_bool;
                pausedisplay.SetActive(false);
                yield return new WaitForSeconds(1f);
            }
        }
    }

    public void Resume_function()
    {
        StartCoroutine(resume());
    }

    IEnumerator resume()
    {

        //SceneManager.LoadScene(3);
        hidecursor();
        yield return new WaitForSeconds(0f);
        pausedisplay.SetActive(false);
        
    }

    public void Exittomenu_function()
    {
        StartCoroutine(exitmenu());
    }

    IEnumerator exitmenu()
    {

        SceneManager.LoadScene(1);
        yield return new WaitForSeconds(0f);

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

     public void showcursor()
    {
        Cursor.visible = true;
        // Đặt chuột vào vị trí giữa màn hình
        Cursor.lockState = CursorLockMode.None;
    }

    public void hidecursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
}
