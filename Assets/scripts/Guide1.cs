using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guide1 : MonoBehaviour
{

    public GameObject player;
    public GameObject guide_trigger;
    public GameObject guide_Arrow;
    public GameObject textbox;


    private void OnTriggerEnter(Collider other)// chỉ cần chạm vào cái trigger thì thực hiện code
    {
        player.GetComponent<Rigidbody>().isKinematic = true;
        //player.GetComponent<FirstPersonController>().enabled = false;// không cho player di chuyển
        StartCoroutine(Scene_Stop1());
    }


    IEnumerator Scene_Stop1() {
        guide_Arrow.SetActive(true);
        textbox.GetComponent<Text>().text = "look at the arrow !";
        yield return new WaitForSeconds(2.0f);
        textbox.GetComponent<Text>().text = "";
        //player.GetComponent<FirstPersonController>().enabled = true;
        player.GetComponent<Rigidbody>().isKinematic = false;

        guide_trigger.SetActive(false);

    }
  
}
