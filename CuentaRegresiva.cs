using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CuentaRegresiva : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 30f;

    [SerializeField] Text countdownText;

    // Use this for initialization
    void Start()
    {
        currentTime = startingTime;

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            Debug.Log("Se acabo");
            //Score.CurrentScore += 100;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }



    }
}
