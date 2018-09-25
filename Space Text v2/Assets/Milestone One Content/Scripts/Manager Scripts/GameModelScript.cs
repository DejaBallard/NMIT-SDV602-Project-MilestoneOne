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
        GiveGameScenesEvent();
        GiveGameScenesItems();
        LinkGameScenes();
        _CurrentScene = _E3Scene;
        _CurrentScene._Visited = true;
    }
    //("Name","Scene Story")
    public void MakeGameScenes() {
        _A1Scene = new SceneScript
            ("A1",
            "AI: " + _PlayerName + ", Looks like we are at the corner of the system \n" +
            "AI: Why not run a quick scan to see if anything is here, before turning back");
        _A2Scene = new SceneScript
            ("A2",
            "AI: Looks like something is aproaching us " + _PlayerName + "\n" +
            "AI: What do you want to do?");
        _A3Scene = new SceneScript
            ("A3",
            "AI: Well straight ahead of us is out of the system \n" +
            "AI: I can hear something to our left in A2. should we see what it is?");
        _A4Scene = new SceneScript
            ("A4",
            "AI: I have picked up a distress signal, it looks like it is at Quadrant A5");
        _A5Scene = new SceneScript
            ("A5",
            "AI: Looks like a broken down ship \n" +
            "AI: " + _PlayerName + ", run some scans to see if anyone is still alive");

        _B1Scene = new SceneScript
            ("B1",
            "AI: Its so empty here,looks like nothing here worth reporting \n" +
            "AI: Run a scan quickly and lets get out of here, i don't like this");
        _B2Scene = new SceneScript
            ("B2",
            "AI: Appoarching another planet");
        _B3Scene = new SceneScript
            ("B3",
            "AI: Im picking up something strange \n" +
            "AI: Poor guys, I wonder what happened? \n" +
            "AI: Do we run a scan to see if anyone is alive?");
        _B4Scene = new SceneScript
            ("B4",
            "AI: Hey " + _PlayerName + ", not to scare you or anything but, something is coming towards us \n" +
            "AI: What do we do?");
        _B5Scene = new SceneScript
            ("B5",
            "AI: Im detecting two signals, one at A1 and the other at B4 \n" +
            "AI: Which one should we check out?");
        _C1Scene = new SceneScript
            ("C1",
            "AI: We are aproaching another broken ship \n" +
            "AI: What is going on here?");
        _C2Scene = new SceneScript
            ("C2",
            "AI: Ive picked up a lot of old signals in the lower sector of this system \n" +
            "AI: We were told, this system has had no signs of live forms we arrived \n" +
            "AI: Scan this and lets check it out" + _PlayerName);
        _C3Scene = new SceneScript
            ("C3",
            "AI: Looks like nothing is here? \n"+
            "AI: See if the scanners can pick up anything");
        _C4Scene = new SceneScript
            ("C4",
            "AI: The General sent out a drone for us to bring all things we find back to \n"+
            "AI: Type 'Show Shop' for us to dock");
        _C5Scene = new SceneScript
            ("C5",
            "AI: Looks like we found the drone we sent out 10 years ago \n"+
            "AI: It has seen better days, I wonder if there are any parts aboard");
        _D1Scene = new SceneScript
            ("D1",
            "AI: Looks like a ship graveyard, what happened?");
        _D2Scene = new SceneScript
            ("D2",
            "AI: Woah! did you see that shooting star!");
        _D3Scene = new SceneScript
            ("D3",
            "AI: Looks like we are comming up on a unknown planet"+_PlayerName+"\n"+
            "AI: "+_PlayerName+", You should run a scan to see what we can find about the planet");
        _D4Scene = new SceneScript
            ("D4",
            _PlayerName+": So ship, What are objectives here again? \n"+
            "AI: Can you really not remeber? I'm not repeating it for the 100th time \n"+
            "AI: Type 'show quests' to see what we need to do");
        _D5Scene = new SceneScript
            ("D5",
            "AI: Can you feel that? \n"+
            _PlayerName+": no? feel what? \n"+
            "AI: Oh, nevermind");
        _E1Scene = new SceneScript
            ("E1",
            "AI: Why is this ship all the way out in the corner of the system?");
        _E2Scene = new SceneScript
            ("E2",
            "AI: So "+_PlayerName+" how was your sleep anyways? \n"+
            _PlayerName+": It could of been better, got bit of a sore back \n"+
            "AI: I wouldn't be surprised, you were asleep for about 40 years");
        _E3Scene = new SceneScript
            ("E3",
            "AI:Good morning "+_PlayerName+", we have arrived. \n"+
            "AI:It has been awhile since you have woken, why not type 'show help' to get the basics?");
        _E4Scene = new SceneScript
            ("E4",
            "AI: This area has strangely strong static \n"+
            "AI: I Wonder what is around here?");
        _E5Scene = new SceneScript
            ("E5",
            "AI: Comming up on another planet");
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
    public void GiveGameScenesEvent()
    {  // _A1Scene._Event =
        _A2Scene._Event = "Enemy";
        //_A3Scene._Event = 
        //_A4Scene._Event =
        _A5Scene._Event = "BrokenShip";

        //_B1Scene._Event =
        _B2Scene._Event = "Planet";
        _B3Scene._Event = "BrokenShip";
        _B4Scene._Event = "Enemy";
        //_B5Scene._Event =  
        _C1Scene._Event = "BrokenShip";
        _C2Scene._Event = "BrokenShip";
        //_C3Scene._Event = 
        _C4Scene._Event = "Shop";
        _C5Scene._Event = "BrokenShip";
        _D1Scene._Event = "BrokenShip";
        //_D2Scene._Event = 
        _D3Scene._Event = "Planet";
        //_D4Scene._Event =
        //_D5Scene._Event = 
        _E1Scene._Event = "BrokenShip";
        //_E2Scene._Event =
        //_E3Scene._Event =
        //_E4Scene._Event =
        _E5Scene._Event = "Planet";

    }
    public void GiveGameScenesItems() {
        _D3Scene._Item = new GameItemScript("rock");
        _D3Scene._Item._NextItem = new GameItemScript("tin");
    }
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of GameModelScript : Mono Class-------------------------------------------------------------------------------