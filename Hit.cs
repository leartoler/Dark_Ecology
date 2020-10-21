using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hit : MonoBehaviour
{
    public AudioSource noise1;
    public AudioSource[] sounds;
    // public GameObject PlaguePrefab;
    void Start()
    {
        AudioSource[] sounds = GetComponents<AudioSource>();
        noise1 = sounds[0];
    }

    //void Update()
   // {
                
    //}
    /* private GameObject plague;

     private void Start()
     {
         plague = GameObject.FindWithTag("Plague");
     }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Plague")
            //if (Input.GetKey(KeyCode.A))
            {
            GameObject[] remainingObj = GameObject.FindGameObjectsWithTag("Plague");
            if (remainingObj.Length == 1)
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


            }
            noise1.Play();
            Destroy(other.gameObject);
        }
    }

}
