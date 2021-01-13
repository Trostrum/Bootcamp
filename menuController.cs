using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        StartCoroutine(animationController());
    }
    // Update is called once per frame
    IEnumerator animationController()
    {
        yield return new WaitForSecondsRealtime(3);
        anim.Play("Menu_SR");
        yield return new WaitForSecondsRealtime(2);
        anim.Play("Open_B");
    }

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
