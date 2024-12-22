using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ghost_caught : MonoBehaviour
{
    //public float thedistance;
    public GameObject player;
    public GameObject youdeadcanvas;
    //public GameObject ghost_trigger;

    //private void OnTriggerEnter()
    //{
    //    player.GetComponent<FirstPersonController>().enabled = false;
    //    StartCoroutine(Scene_Dead());
    //}

    void Update()
    {
        //    thedistance = PlayerCasting.DistanceFromTarget;
        //    if (thedistance < 1)
        //    {
        //        player.GetComponent<FirstPersonController>().enabled = false;
        //        StartCoroutine(Scene_Dead());
        //    }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == player)
            {
                StartCoroutine(Scene_Dead());
            }
        }
    }

    


    IEnumerator Scene_Dead()
    {
        player.GetComponent<FirstPersonController>().enabled = false;
        //yield return new WaitForSeconds(1f);
        youdeadcanvas.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
    }
}
