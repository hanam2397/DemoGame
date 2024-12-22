using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorghost_open : MonoBehaviour
{
    public float thedistance;
    public GameObject doorghost;
    public GameObject doorghost_trigger;
   // private bool isDoorOpen = false; // Biến để theo dõi trạng thái cửa

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        thedistance = PlayerCasting.DistanceFromTarget;
        // Kiểm tra nếu cửa chưa mở và player đang ở gần
        //if (!isDoorOpen && thedistance < 3)
        //{
        //    openghostdoor();
        //}
    }

    private void OnTriggerEnter()
    {
       // if (!isDoorOpen) { 
        //if (thedistance < 3)
        //{
            GetComponent<BoxCollider>().enabled = false;
            //isDoorOpen = true;
            doorghost.GetComponent<Animation>().Play("doorghost_open");
            doorghost_trigger.SetActive(false);
            //isDoorOpen = true; // Đánh dấu cửa đã mở
 
       // }
    }

    //        private void openghostdoor()
    //{
    //    // Chạy animation mở cửa
    //    doorghost.GetComponent<Animation>().Play("doorghost_open");
    //    doorghost_trigger.SetActive(false);
    //    isDoorOpen = true; // Đánh dấu cửa đã mở
    //}
}
