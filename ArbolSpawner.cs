//using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ArbolSpawner : MonoBehaviour
{
    public float spawnDelay = 0f; //el tiempo en que apareceran los troncos
    public GameObject arbol1, arbol2, arbol3; //se cambio
    public Transform spawnPoints; //Los puntos de referencia para los troncos.
    float nextTimeToSpawn = 0f;
    int whatToSpawn;
    public AudioSource noise1;
    public AudioSource[] sounds;

    void Start()
    {
        AudioSource[] sounds = GetComponents<AudioSource>();
        noise1 = sounds[0];
    }

    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            whatToSpawn = Random.Range(1, 3);//SpawnTronco();
            nextTimeToSpawn = Time.time + spawnDelay;   //tiempo actual y suma el valor declarado en el public class. En loop
            Transform spawnPoint = spawnPoints;
            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(arbol1);
                    break;
                case 2:
                    Instantiate(arbol2);
                    break;
                case 3:
                    Instantiate(arbol3);
                    break;
            }        
        }
    }
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

            //Destroy(other.gameObject);
        }
    }





}
