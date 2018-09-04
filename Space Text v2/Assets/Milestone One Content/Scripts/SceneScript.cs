using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------- Start Of SceneScript : Mono Class ------------------------------------------------------------------------------
public class SceneScript : MonoBehaviour {
	//--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
	public string _SceneStory;
    public string _Items;
    public string _Help;
 
	public SceneScript _UpScene;
	public SceneScript _DownScene;
	public SceneScript _LeftScene;
	public SceneScript _RightScene;

	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	public SceneScript(string prStory){
		_SceneStory = prStory;
        _Help = "Show: \n" +
                "Map \n" +
                "Invetory \n" +
                "Terminal \n" +
                "Help \n\n" +
                "Go: \n" +
                "Up \n" +
                "Down \n" +
                "Left \n" +
                "Right";
	}
	
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}	
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of SceneScript : Mono Class-------------------------------------------------------------------------------
