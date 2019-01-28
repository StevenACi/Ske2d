using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_menu : MonoBehaviour {


    public GameObject level1;
    public GameObject mainMenu;
    public Button new_game;
    public Button _continue;
    public Button _gallery;
    public Button _quit;
    private GameObject level1gen;

    // Use this for initialization
    void Start () {
        new_game.onClick.AddListener(newGame);
        _continue.onClick.AddListener(Continue);
        _gallery.onClick.AddListener(empty);
        _quit.onClick.AddListener(empty);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void newGame()
    {
        mainMenu.SetActive(false);
        level1.SetActive(true);
        level1gen = GameObject.FindGameObjectWithTag("Level1Gen");
        level1gen.GetComponent<spawning>().isActive = true;
    }

    public void Continue()
    {
        mainMenu.SetActive(false);
        level1.SetActive(true);
    }

    public void empty()
    {
        Debug.Log("empty");
    }


}
