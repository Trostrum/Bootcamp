using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class coll : MonoBehaviour
{
    public static bool isFinished;
    public Text finish_lable;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obs")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.CompareTag("Fns"))
        {
            isFinished = true;
            Time.timeScale = 0;
            finish_lable.text = "Congratulations";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void Start()
    {
        isFinished = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (gameObject.transform.position.y < -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }




}
