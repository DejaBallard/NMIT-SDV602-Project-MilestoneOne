using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------- Start Of CommandScript : Mono Class ------------------------------------------------------------------------------
public class CommandScript : MonoBehaviour {
	//--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
	
	
	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	

		
	public virtual void Do(CommandMapScript prCommand){
	}
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of CommandScript : Mono Class-------------------------------------------------------------------------------




//--------------------------------------- Start Of GoCommand : CommandScript Class ------------------------------------------------------------------------------
public class GoCommand : CommandScript {
	//--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
	
	private string _direction;
	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	// Use this for initialization
	public GoCommand(string prDirection)
	{
		_direction = prDirection;
	}
	
	public override void Do (CommandMapScript prCommand)
	{
        Debug.Log("Do Command " + _direction);
        TurnOffEvent();
		SceneScript lcScene = GameManagerScript._Instance._GameModel._CurrentScene;
        Debug.Log(GameManagerScript._Instance._StarAnim);
		switch(_direction){
			case "up":
			lcScene = GameManagerScript._Instance._GameModel._CurrentScene;
                if (lcScene._UpScene._SceneStory != null)
                    HasEvent(lcScene._UpScene._Event);
                    GameManagerScript._Instance._GameModel._CurrentScene = lcScene._UpScene;
                break;
			case "down":
                
                    lcScene = GameManagerScript._Instance._GameModel._CurrentScene;
                    if (lcScene._DownScene._SceneStory != null)
                        HasEvent(lcScene._DownScene._Event);
                        GameManagerScript._Instance._GameModel._CurrentScene = lcScene._DownScene;
                    break;
                
			case "left":
			lcScene = GameManagerScript._Instance._GameModel._CurrentScene;
			if (lcScene._LeftScene._SceneStory !=null)
                HasEvent(lcScene._LeftScene._Event);
                GameManagerScript._Instance._GameModel._CurrentScene = lcScene._LeftScene;
                break;
			case "right":
			lcScene = GameManagerScript._Instance._GameModel._CurrentScene;
			if (lcScene._RightScene._SceneStory !=null)
                HasEvent(lcScene._RightScene._Event);
                GameManagerScript._Instance._GameModel._CurrentScene = lcScene._RightScene;
                break;
		}
        if (GameManagerScript._Instance._GameModel._CurrentScene._Visited == true)
        {
            prCommand._Result = GameManagerScript._Instance._GameModel._CurrentScene._SceneNotScannedDescription;
        }else
        {
            GameManagerScript._Instance._GameModel._CurrentScene._Visited = true;
            prCommand._Result = GameManagerScript._Instance._GameModel._CurrentScene._SceneStory;
        }
	}

    public void HasEvent(string prEvent)
    {
        switch (prEvent)
        {
            case "Planet":
                GameManagerScript._Instance._StarAnim.SetTrigger("Warp");
                GameManagerScript._Instance._PlanetAnim.SetBool("ShipArrived", true);
                GameManagerScript._Instance._StarAnim.SetBool("Stop", true);
                break;
            case "Shop":
                GameManagerScript._Instance._StarAnim.SetTrigger("Warp");
                GameManagerScript._Instance._StarAnim.SetBool("Stop", true);
                break;
            case "Enemy":
                GameManagerScript._Instance._StarAnim.SetTrigger("Warp");
                GameManagerScript._Instance._StarAnim.SetBool("Stop", true);
                break;
            case "BrokenShip":
                GameManagerScript._Instance._StarAnim.SetTrigger("Warp");
                GameManagerScript._Instance._StarAnim.SetBool("Stop", true);
                break;
            default:
                GameManagerScript._Instance._StarAnim.SetTrigger("Warp");
                break;
        }

    }
    public void TurnOffEvent()
    {
        GameManagerScript._Instance._StarAnim.SetBool("Stop", false);
        GameManagerScript._Instance._PlanetAnim.SetBool("ShipArrived", false);
    }
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of GoCommand : CommandScript Class -------------------------------------------------------------------------------





//--------------------------------------- Start Of PickCommand : CommandScript Class ------------------------------------------------------------------------------
public class PickCommand : CommandScript {
	//--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
	
	private string _item;
	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	public PickCommand(string prItem){
		_item = prItem;
	}
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}	
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of Command : CommandScript Class -------------------------------------------------------------------------------





//--------------------------------------- Start Of ShowCommand : CommandScript Class ------------------------------------------------------------------------------
public class ShowCommand : CommandScript
{
    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------

    private string _Display;
    //--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------


    //-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
    public ShowCommand(string prDisplay)
    {
        _Display = prDisplay;
    }

    public override void Do(CommandMapScript prCommand)
    {
        string lcResult = "What are you wanting to show?";

        switch (_Display){

            case "map":
                lcResult = "";
                GameManagerScript._Instance.SetActiveCanvas("Map Canvas");
                break;
            case "inventory":
                GameManagerScript._Instance.SetActiveCanvas("Inventory Canvas");
                
                    break;
            case "terminal":
                GameManagerScript._Instance.SetActiveCanvas("Main Canvas");
                lcResult = GameManagerScript._Instance._GameModel._CurrentScene._SceneStory;
                    break;
            case "help":
                lcResult = GameManagerScript._Instance._GameModel._CurrentScene._Help;
                break;
        }
        
        prCommand._Result = lcResult;
    }
    //-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of Command : CommandScript Class -------------------------------------------------------------------------------





//--------------------------------------- Start Of ScanCommandScript : CommandScript Class ------------------------------------------------------------------------------
public class ScanCommand : CommandScript
{
    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
    private string _Scan;

    //--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------


    //-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
    public ScanCommand(string prScan)
    {
        _Scan = prScan;
    }

    public override void Do(CommandMapScript prCommand)
    {
        string lcResult = "What are you wanting to scan?";

        switch (_Scan)
        {
            case "area":
                lcResult = "AI: Scanning Area \n" +
                            GameManagerScript._Instance._GameModel._CurrentScene._Scan + "\n" +
                            "Items found \n" +
                            GameManagerScript._Instance._GameModel._CurrentScene.AllItems();
                Debug.Log(GameManagerScript._Instance._GameModel._CurrentScene._Item._Name);
                break;
                //-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
        }
        prCommand._Result = lcResult;
    }
}
//------------------------------------------ End Of ScanCommand : CommandScript Class-------------------------------------------------------------------------------
