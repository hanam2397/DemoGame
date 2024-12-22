using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammo_manage : MonoBehaviour
{
    public static int ammo_count; //biến static nên có thể tham chiếu đến script khác (cụ thể: gunfired)
                                  //tuy nhiên static không hiện lên trình editer
    public GameObject ammo_show;
    public int ammo_count2;       // là bản sao của biến static trên và không thể tham chiếu
                                  // tuy nhiên hiện lên trình editer

    void Update()
    {
        ammo_count2 = ammo_count;
        ammo_show.GetComponent<Text>().text = "" + ammo_count2;
    }
}
