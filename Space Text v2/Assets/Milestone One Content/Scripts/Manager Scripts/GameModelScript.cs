using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------- Start Of GameModelScript : Mono Class ------------------------------------------------------------------------------
public class GameModelScript : MonoBehaviour {
	//--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------

	public SceneScript _CurrentScene;

    private string _PlayerName;

    public SceneScript _A1Scene;
	public SceneScript _A2Scene;
	public SceneScript _A3Scene;
	public SceneScript _A4Scene;
	public SceneScript _A5Scene;
	
	public SceneScript _B1Scene;
	public SceneScript _B2Scene;
	public SceneScript _B3Scene;
	public SceneScript _B4Scene;
	public SceneScript _B5Scene;
	
	public SceneScript _C1Scene;
	public SceneScript _C2Scene;
	public SceneScript _C3Scene;
	public SceneScript _C4Scene;
	public SceneScript _C5Scene;
	
	public SceneScript _D1Scene;
	public SceneScript _D2Scene;
	public SceneScript _D3Scene;
	public SceneScript _D4Scene;
	public SceneScript _D5Scene;
	
	public SceneScript _E1Scene;
	public SceneScript _E2Scene;
	public SceneScript _E3Scene;
	public SceneScript _E4Scene;
	public SceneScript _E5Scene;
	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	public GameModelScript(){
        _PlayerName = GameManagerScript._Instance._Player._PlayerName;
        MakeGameScenes();
        LinkGameScenes();
        _CurrentScene = _E3Scene;
    }
    public void MakeGameScenes() {
        _A1Scene = new SceneScript
            ("Quardent: A1");
        _A2Scene = new SceneScript("Quardent: A2");
        _A3Scene = new SceneScript("Quardent: A3");
        _A4Scene = new SceneScript("Quardent: A4");
        _A5Scene = new SceneScript("Quardent: A5");
        _B1Scene = new SceneScript("Quardent: B1");
        _B2Scene = new SceneScript("Quardent: B2");
        _B3Scene = new SceneScript("Quardent: B3");
        _B4Scene = new SceneScript("Quardent: B4");
        _B5Scene = new SceneScript("Quardent: B5");
        _C1Scene = new SceneScript("Quardent: C1");
        _C2Scene = new SceneScript("Quardent: C2");
        _C3Scene = new SceneScript("Quardent: C3");
        _C4Scene = new SceneScript("Quardent: C4");
        _C5Scene = new SceneScript("Quardent: C5");
        _D1Scene = new SceneScript("Quardent: D1");
        _D2Scene = new SceneScript("Quardent: D2");
        _D3Scene = new SceneScript("Quardent: D3");
        _D4Scene = new SceneScript("Quardent: D4");
        _D5Scene = new SceneScript("Quardent: D5");
        _E1Scene = new SceneScript("Quardent: E1");
        _E2Scene = new SceneScript("Quardent: E2");
        _E3Scene = new SceneScript
            ("Quardent: E3 \n \n"+
            "AI:Good morning "+_PlayerName+", we have arrived. \n"+
            "AI:It has been awhile since you have woken, why not type 'show help' to get the basics?");
        _E4Scene = new SceneScript("Quardent: E4");
        _E5Scene = new SceneScript("Quardent: E5");
    }
	public void LinkGameScenes(){
	
#region Row A Scenes
		//_A1Scene._UpScene = 
		_A1Scene._DownScene = _B1Scene;
		//_A1Scene._LeftScene =
		_A1Scene._RightScene = _A2Scene;
		
		//_A2Scene._UpScene = 
		_A2Scene._DownScene = _B2Scene;
		_A2Scene._LeftScene = _A1Scene;
		_A2Scene._RightScene = _A3Scene;
		
		//_A3Scene._UpScene = 
		_A3Scene._DownScene = _B3Scene;
		_A3Scene._LeftScene = _A2Scene;
		_A3Scene._RightScene = _A4Scene;
		
		//_A4Scene._UpScene = 
		_A4Scene._DownScene = _B4Scene;
		_A4Scene._LeftScene = _A3Scene;
		_A4Scene._RightScene = _A5Scene;
		
		//_A5Scene._UpScene =
		_A5Scene._DownScene = _B5Scene;
		_A5Scene._LeftScene = _A4Scene;
		//_A5Scene._RightScene =
#endregion

#region Row B Scenes
		_B1Scene._UpScene = _A1Scene;
		_B1Scene._DownScene = _C1Scene;
		//_B1Scene._LeftScene =
		_B1Scene._RightScene = _B2Scene;
		
		_B2Scene._UpScene = _A2Scene;
		_B2Scene._DownScene = _C2Scene;
		_B2Scene._LeftScene = _B1Scene;
		_B2Scene._RightScene = _B3Scene;
		
		_B3Scene._UpScene = _A3Scene;
		_B3Scene._DownScene = _C3Scene;
		_B3Scene._LeftScene = _B2Scene;
		_B3Scene._RightScene = _B4Scene;
		
		_B4Scene._UpScene = _A4Scene;
		_B4Scene._DownScene =  _C4Scene;
		_B4Scene._LeftScene = _B3Scene;
		_B4Scene._RightScene = _B5Scene;
		
		_B5Scene._UpScene = _A5Scene;
		_B5Scene._DownScene =  _C5Scene;
		_B5Scene._LeftScene = _B4Scene;
		//_B5Scene._RightScene = 
#endregion

#region Row C Scenes
		_C1Scene._UpScene = _B1Scene;
		_C1Scene._DownScene = _D1Scene;
		//_C1Scene._LeftScene =
		_C1Scene._RightScene = _C2Scene;
		
		_C2Scene._UpScene = _B2Scene;
		_C2Scene._DownScene = _D2Scene;
		_C2Scene._LeftScene = _C1Scene;
		_C2Scene._RightScene = _C3Scene;
		
		_C3Scene._UpScene = _B3Scene;
		_C3Scene._DownScene = _D3Scene;
		_C3Scene._LeftScene = _C2Scene;
		_C3Scene._RightScene = _C4Scene;
		
		_C4Scene._UpScene = _B4Scene;
		_C4Scene._DownScene =  _D4Scene;
		_C4Scene._LeftScene = _C3Scene;
		_C4Scene._RightScene = _C5Scene;
		
		_C5Scene._UpScene = _B5Scene;
		_C5Scene._DownScene = _D5Scene;
		_C5Scene._LeftScene = _C4Scene;
		//_C5Scene._RightScene = 
#endregion

#region Row D Scenes
		_D1Scene._UpScene = _C1Scene;
		_D1Scene._DownScene = _E1Scene;
		//_D1Scene._LeftScene =
		_D1Scene._RightScene = _D2Scene;
		
		_D2Scene._UpScene = _C2Scene;
		_D2Scene._DownScene = _E2Scene;
		_D2Scene._LeftScene = _D1Scene;
		_D2Scene._RightScene = _D3Scene;
		
		_D3Scene._UpScene = _C3Scene;
		_D3Scene._DownScene = _E3Scene;
		_D3Scene._LeftScene = _D2Scene;
		_D3Scene._RightScene = _D4Scene;
		
		_D4Scene._UpScene = _C4Scene;
		_D4Scene._DownScene =  _E4Scene;
		_D4Scene._LeftScene = _D3Scene;
		_D4Scene._RightScene = _D5Scene;
		
		_D5Scene._UpScene = _C5Scene;
		_D5Scene._DownScene = _E5Scene;
		_D5Scene._LeftScene = _D4Scene;
		//_D5Scene._RightScene = 
#endregion

#region Row E Scenes
		_E1Scene._UpScene = _D1Scene;
		//_E1Scene._DownScene =
		//_E1Scene._LeftScene =
		_E1Scene._RightScene = _E2Scene;
		
		_E2Scene._UpScene = _D2Scene;
		//_E2Scene._DownScene =
		_E2Scene._LeftScene = _E1Scene;
		_E2Scene._RightScene = _E3Scene;
		
		_E3Scene._UpScene = _D3Scene;
		//_E3Scene._DownScene =
		_E3Scene._LeftScene = _E2Scene;
		_E3Scene._RightScene = _E4Scene;
		
		_E4Scene._UpScene = _D4Scene;
		//_E4Scene._DownScene =
		_E4Scene._LeftScene = _E3Scene;
		_E4Scene._RightScene = _E5Scene;
		
		_E5Scene._UpScene = _C5Scene;
		//_E5Scene._DownScene =
		_E5Scene._LeftScene = _E4Scene;
		//_E5Scene._RightScene = 
#endregion


	}
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of GameModelScript : Mono Class-------------------------------------------------------------------------------