using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public static bool menuVisible = false;

    public GameObject menuUI;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuVisible)
            {
                closeMenu();
            } else
            {
                openMenu();
            }
        }
	}

    void closeMenu()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        menuVisible = false;
    }

    void openMenu()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        menuVisible = true;
    }

    public void rundflug()
    {

    }

    public void brunnhausBesichtigen()
    {

    }

    public void freierFlug()
    {

    }
}
