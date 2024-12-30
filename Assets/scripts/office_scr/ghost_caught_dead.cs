using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ghost_caught_dead : MonoBehaviour
{
    public GameObject player;
    public GameObject youdeadcanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            StartCoroutine(Scene_Dead());
        }
    }


    IEnumerator Scene_Dead()
    {
        player.GetComponent<FirstPersonController>().enabled = false;
        //yield return new WaitForSeconds(1f);
        youdeadcanvas.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(3);
    }
}
