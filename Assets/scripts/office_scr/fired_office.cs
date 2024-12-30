using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fired_office : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gunonarms;
    public AudioSource pistolsound;
    public bool isFiring = false;
    public float target_distance;
    public int damage = 5;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo_manage.ammo_count >= 1)
        //tham chiếu đến script ammo_manage và lấy biến static ammo_count
        {
            if (isFiring == false)
            {

                ammo_manage.ammo_count = ammo_manage.ammo_count - 1;
                StartCoroutine(firePistol());
            }
        }
    }

    IEnumerator firePistol()
    {
        RaycastHit hit;
        isFiring = true;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            target_distance = hit.distance;

            // gọi hàm "damageghost" và truyền vào tham số "damage"
            //hàm "damageghost" bên script "kill_ghost"
            hit.transform.SendMessage("damageghost", damage, SendMessageOptions.DontRequireReceiver);
        }

        gunonarms.GetComponent<Animation>().Play("shoot_animation_office");
        pistolsound.Play();
        yield return new WaitForSeconds(0.8f);
        isFiring = false;
        //yield return new WaitForSeconds(0.2f);
        gunonarms.GetComponent<Animation>().Play("onlyarms-ani");
        //yield return new WaitForSeconds(0.2f);
    }
}