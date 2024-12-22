using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour


{

    public float theDistance;
    public GameObject actiondisplay;
    public GameObject actiontext;
    public GameObject thedoor;
    public GameObject taygatcua;
    public GameObject maindoortrigger;

    //public GameObject actiontext2;
    public GameObject taygatcuatrigger;
    public GameObject taygatcuatrigger2;//enable cái này lên xong kéo game objec2 vào



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
            actiontext.SetActive(true);    

        }

        if (Input.GetButtonDown("Action")) {
            if (theDistance < 2) {
                this.GetComponent<BoxCollider>().enabled = false;
                maindoortrigger.GetComponent<BoxCollider>().enabled = false;
                maindoortrigger.SetActive(true);
              
                actiontext.SetActive(false);
                taygatcua.GetComponent<Animation>().Play("TayCua");
               
                thedoor.GetComponent<Animation>().Play("DoorOpen2");
                //chees
                //StartCoroutine(OpenDoorCoroutine());
                //IEnumerator OpenDoorCoroutine()
                //{

                    //    // Đợi 1 giây
                 //   yield return new WaitForSeconds(1.5f);
                  //  thedoor.GetComponent<Animation>().Play("DoorOpen2");
                    //taygatcuatrigger2.SetActive(true);
                    //yield return new WaitForSeconds(0.01f);
                    //taygatcuatrigger.SetActive(false);

               // }
                taygatcuatrigger2.SetActive(true);  
                taygatcuatrigger.SetActive(false);

                
            }
        }

        if (theDistance > 2)
        {
            actiondisplay.SetActive(false);
            actiontext.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        actiondisplay.SetActive(false);
        actiontext.SetActive(false);
    }
}
