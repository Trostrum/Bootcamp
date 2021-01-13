using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameMenuController : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            openMenu();
        }
    }

    private void openMenu()
    {
        anim.Play("gameMenu");
    }

    public void closeMenu()
    {
        anim.Play("gameMenu_C");
    }
    public void exitfromLevel()
    {
        SceneManager.LoadScene(0);
    }
}
