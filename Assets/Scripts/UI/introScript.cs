﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class introScript : MonoBehaviour {


    ///Games Convas
    public Canvas BG;
    public Canvas loadmenu;
    public Canvas PlayerSel;
    public Canvas PlayerSetup;

    public Canvas KartSel;
    public Canvas KartSetup;

    public Canvas SelOkReturn;


    public AudioClip PlaySound;
    /// <summary>
    /// panel showing 
    /// </summary>
    public GameObject expanel;
    public GameObject stpanel;
    public GameObject lopanel;
    public static bool ishowing = false;
    public static bool EtShowing = false;
    static int setuptoreturn =(3);



    //button showing
    GameObject PExit;
    GameObject PStart;
    GameObject Pload;

    GameObject buttonok;
    GameObject buttoncan;

    GameObject PlayerOkBn;
    GameObject PlayerRetBn;

    // Use this for initialization
    void Start () {

        ////////
        
        //loadmenu = loadmenu.GetComponent<Canvas>();
        //PlayerSel = PlayerSel.GetComponent<Canvas>();
       // PlayerSetup = PlayerSetup.GetComponent<Canvas>();
       // BG = BG.GetComponent<Canvas>();

       

        KartSel = KartSel.GetComponent<Canvas>();
        KartSetup = KartSetup.GetComponent<Canvas>();
        deflauts();

        SelOkReturn = SelOkReturn.GetComponent<Canvas>();
        ////////
        PlayerOkBn = GetComponent<GameObject>();
        PlayerOkBn = GameObject.Find("OkBn");
        PlayerRetBn = GetComponent<GameObject>();
        PlayerRetBn = GameObject.Find("ReturnBn");


        buttonok = GetComponent<GameObject>();
        buttonok = GameObject.Find("Yes");

        buttoncan = GetComponent<GameObject>();
        buttoncan = GameObject.Find("No");

        Pload  = GetComponent<GameObject>();
        Pload = GameObject.Find("Load");

        PStart = PStart.GetComponent<GameObject>();
        PStart = GameObject.Find("create");

        PStart = PStart.GetComponent<GameObject>();
        PStart = GameObject.Find("exit");

        stpanel = stpanel.GetComponent<GameObject>();
        expanel = expanel.GetComponent<GameObject>();
        lopanel = lopanel.GetComponent<GameObject>();

        


    }
	
    /// <summary>
    /// Panels this area control the panels that is use to start and exit the game and loading the load data
    /// </summary>
    public void StartPanelV()
    {
        expanel.SetActive(false);
        lopanel.SetActive(false);
        ishowing = !ishowing;
        stpanel.SetActive(ishowing);
        
        
    }

    public void deflauts()
    {
        BG.enabled = true;
    }

    public void ExitPanelV()
    {
        stpanel.SetActive(false);
        EtShowing = !EtShowing;
        expanel.SetActive(EtShowing);
        
    }
    
    public void LoadPanel()
    {
        // for now this only display words as u press the exit panel
        lopanel.SetActive(true);
        stpanel.SetActive(false);
        EtShowing = !EtShowing;
        expanel.SetActive(EtShowing);

    }


    /// <summary>
    /// this is the area is where the player selection happen's..... ahahahahha ;)
    /// </summary>
    public void SetupPlayerMenu()
    {
        PlayerSel.enabled = true;
        loadmenu.enabled  = false;
        KartSetup.enabled    = false;
        SelOkReturn.enabled = true;
    }

        public void playerSelection()
    {

    }

    public void playerok()
    {
        
        
    }

    public void playerReturn()
    {
        if (setuptoreturn ==0)
        {
          
        }
        else if(setuptoreturn==2)
        {
            
        }
        else
        {
            LoadMainMenu();
        }    
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
    
}
