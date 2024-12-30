using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill_ghost : MonoBehaviour

{

    public int ghost_hp;
    public GameObject ghost;
    public GameObject ghost_trigger;
    //public int statuscheck;
    // Start is called before the first frame update

    public void damageghost(int damage)
    {
        ghost_hp = ghost_hp - damage; 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ghost_hp <= 0) 
        {
            ghost.GetComponent<ChaseScr>().enabled = false;
            ghost_trigger.GetComponent<ghost_caught>().enabled = false;
            ghost.GetComponent<Animation>().Stop("mixamo.com");
            ghost.GetComponent<Animation>().Play("ghostdeath");
           
            //StartCoroutine(hidetime());
            StartCoroutine(LoadSceneMode());
        }
    }

    IEnumerator hidetime()
    {
        yield return new WaitForSeconds(2f);
        //ghost.SetActive(false);
    }

    IEnumerator LoadSceneMode()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}

