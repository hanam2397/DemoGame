using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseDoor : MonoBehaviour


{

    public float theDistance;
    public GameObject actiondisplay;
    public GameObject actiontext2;
    public GameObject thedoor;
    public GameObject taygatcua;
    public GameObject maindoortrigger;

    //public GameObject actiontext2;
    public GameObject taygatcuatrigger;
    public GameObject taygatcuatrigger2;


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
        if (theDistance < 2)
        {
            actiondisplay.SetActive(true);
            actiontext2.SetActive(true);

        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance < 2)
            {
                actiontext2.SetActive(false);
                taygatcuatrigger.GetComponent<BoxCollider>().enabled = true;
                maindoortrigger.GetComponent<BoxCollider>().enabled = true;
               
                maindoortrigger.SetActive(false);
                actiondisplay.SetActive(false);
                //actiontext2.SetActive(false);
                taygatcua.GetComponent<Animation>().Play("TayCua2");
                thedoor.GetComponent<Animation>().Play("DoorClose2");

                //chees
                //StartCoroutine(OpenDoorCoroutine2());
                //IEnumerator OpenDoorCoroutine2()
                //{
                   // yield return new WaitForSeconds(1.5f);
                   // thedoor.GetComponent<Animation>().Play("DoorClose2");


                //}



                taygatcuatrigger.SetActive(true);
                taygatcuatrigger2.SetActive(false);
              

            }
        }

        if (theDistance > 2)
        {
            actiondisplay.SetActive(false);
            actiontext2.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        actiondisplay.SetActive(false);
        actiontext2.SetActive(false);
    }
}
