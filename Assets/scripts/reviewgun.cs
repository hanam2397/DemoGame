using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reviewgun : MonoBehaviour
{
    //private bool isMovementDisabled = false;
    public float theDistance;
    public Transform destination;
    public GameObject player;
    //private FirstPersonController playerController;
    //private bool isInteracting = false;
    // Start is called before the first frame update
    private void Start()
    {
        // Lấy tham chiếu đến script PlayerController
        //if (player != null)
        //{
        //    playerController = player.GetComponent<FirstPersonController>();
        //}
    }

    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseDown()
    {
        if (theDistance < 2)
        {
            //playerController.walkSpeed = 0f;
            GetComponent<BoxCollider>().enabled = false;
            //Rigidbody rb = GetComponent<Rigidbody>();

            // Ngừng tất cả chuyển động của Rigidbody
            //rb.velocity = Vector3.zero;
           // rb.angularVelocity = Vector3.zero;
            GetComponent<Rigidbody>().isKinematic = true; // Đặt Rigidbody thành kinematic để ngăn chặn lực tác động

            // Di chuyển đối tượng đến destination
            this.transform.position = destination.position;
            this.transform.parent = GameObject.FindGameObjectWithTag("destination").transform;
        }
    }

    private void OnMouseUp()
    {
        // Khôi phục trạng thái ban đầu khi nhả chuột
        this.transform.parent = null;
        // Rigidbody rb = GetComponent<Rigidbody>();

        GetComponent<Rigidbody>().isKinematic = false; // Khôi phục Rigidbody về trạng thái không kinematic
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        //playerController.walkSpeed = 5f;
    }


}
