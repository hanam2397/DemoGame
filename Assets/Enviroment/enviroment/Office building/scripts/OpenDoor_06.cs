using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor_06 : MonoBehaviour
{

    public float theDistance;
    //public GameObject actiontext;
    public GameObject thedoor; //start animation opendoor
    public GameObject door06_trigger;
    public GameObject actiondisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;

    }

    private void OnMouseOver()
    {
        if (theDistance < 2) // khoảng cách <3m
        {
            actiondisplay.SetActive(true); //Hiển thị chữ [ E ] lên màn hình
            //ActionText.SetActive(true); //Hiển thị chữ 'Open Door' lên màn hình
        }

        if (Input.GetButtonDown("Action")) // nhấn nút E (Action là tên đặt cho nút E)
        {
            if (theDistance < 2)
            {
                thedoor.GetComponent<Animation>().Play("door09open");
                this.GetComponent<BoxCollider>().enabled = false;
                actiondisplay.SetActive(false);
                //ActionText.SetActive(false);
                
                //sound.Play();
            }
        }



        if (theDistance > 2)
        {
            actiondisplay.SetActive(false);
            //actiontext.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        actiondisplay.SetActive(false);
        //actiontext.SetActive(false);
    }
}
