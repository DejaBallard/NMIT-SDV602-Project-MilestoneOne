using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------- Start Of SceneScript : Mono Class ------------------------------------------------------------------------------
public class SceneScript : MonoBehaviour {
    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
    public string _Name;
    //Displayed for story
    public string _SceneStory;
    //Displayed if user comes back and hasn't scanned
    public string _SceneNotScannedDescription;
    //Displayed if user comes back and has scanned
    public string _SceneScannedDescription;
    //Items in Scente
    public GameItemScript _Item;
    
    //Scan Description
    public string _Scan;
    //if planet,enemy,shop or broken ship in scene
    public string _Event;
    //If Visited
    public bool _Visited;
    //If Scaned
    public bool _Scanned;
    //Help list
    public string _Help;

    public SceneScript _UpScene;
	public SceneScript _DownScene;
	public SceneScript _LeftScene;
	public SceneScript _RightScene;

	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	public SceneScript(string prName, string prStory){
        _Name = "Quadrant " + prName + ":";
        _SceneStory = _Name +"\n" + prStory;
        _SceneNotScannedDescription = _Name + "\n"+
                                              "AI: Looks like we haven't scaned this area yet";
        _SceneScannedDescription = _Name + "\n" +
                                            "AI: We have Scanned everything in this area"; 
        _Help = "Show: \n" +
                "Map, Invetory, Terminal, Help \n" +
                "Go: \n" +
                "Up, Down, Left,Right \n"+
                "Scan: \n"+
                "Area \n"+
                "Pick: \n"+
                "Up";
	}
	
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}

    public string AllItems()
    {
        string lcResult = "";
        GameItemScript currentItem = _Item;
        if (currentItem._Name == null)
        {
            lcResult = lcResult + "nothing here.";
        }
        else
        {
            while (currentItem._Name != null)
            {
                lcResult = lcResult + "\n" + currentItem._Name;
                currentItem = currentItem._NextItem;
            }
        }
        return lcResult;
    }
        //-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
    }
//------------------------------------------ End Of SceneScript : Mono Class-------------------------------------------------------------------------------
