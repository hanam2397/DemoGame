using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_ammo : MonoBehaviour
{

    public GameObject ammobox;
    public GameObject ammo_display;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)// chỉ cần chạm vào cái trigger thì thực hiện code
    {
        ammo_display.SetActive(true);
        ammobox.SetActive(false);
        ammo_manage.ammo_count += 7;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
