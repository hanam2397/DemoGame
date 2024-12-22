using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup_gun : MonoBehaviour


{

    public float theDistance;
    public GameObject gunontable;
    public GameObject gunpicked;
    public GameObject guntrigger;
    public GameObject actiondisplay;
    public GameObject doorghost_trigger;
    public GameObject arrow;

    public GameObject ammo_box;
    public GameObject ammo_display;

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
        if (theDistance < 2) {
            actiondisplay.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance < 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actiondisplay.SetActive(false);
                gunontable.SetActive(false);
                gunpicked.SetActive(true);
                doorghost_trigger.SetActive(true);
                arrow.SetActive(false);

                ammo_box.SetActive(true);
                ammo_display.SetActive(true);
            }
        }
        if (theDistance > 2) { 
            actiondisplay.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        actiondisplay.SetActive(false);
    }
    }
