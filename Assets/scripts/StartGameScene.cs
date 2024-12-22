using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameScene : MonoBehaviour


{

    public GameObject playerscript;
    public GameObject startgamescene;
    public GameObject textbox;
    // Start is called before the first frame update
    void Start()
    {
        playerscript.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(scriptscene());
    }

    IEnumerator scriptscene()
    {
        yield return new WaitForSeconds(2.0f);
        startgamescene.SetActive(false);
        textbox.GetComponent<Text>().text = "I have to get out of here !";
        yield return new WaitForSeconds(1.5f);
        textbox.GetComponent<Text>().text = "";
        playerscript.GetComponent<FirstPersonController>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
