using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--------------------------------------- Start Of CommandMapScript : Mono Class ------------------------------------------------------------------------------
public class CommandMapScript : MonoBehaviour {
	//--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
	public string _Result = "";
	
	private Dictionary<string, CommandScript> _commandsDic;
	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	public CommandMapScript(){
		_commandsDic = new Dictionary<string, CommandScript>();
		
		_commandsDic.Add("go up",new GoCommand("up"));
		_commandsDic.Add("go down",new GoCommand("down"));
		_commandsDic.Add("go left",new GoCommand("left"));
		_commandsDic.Add("go right",new GoCommand("right"));
        _commandsDic.Add("show map", new ShowCommand("map"));
        _commandsDic.Add("show terminal", new ShowCommand("terminal"));
        _commandsDic.Add("show inventory", new ShowCommand("inventory"));
        _commandsDic.Add("show help", new ShowCommand("help"));
        _commandsDic.Add("pick up", new PickCommand("up"));
        _commandsDic.Add("scan area", new ScanCommand("area"));
	}
	
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}	
//checks to see if user command in part of dictionary	
	public bool KnowsCommand(string prCommand){
		bool lcResult = false;
		CommandScript lcCommand;
		if (_commandsDic.ContainsKey(prCommand)){
			lcCommand = _commandsDic [prCommand];
			lcCommand.Do (this);
			lcResult = true;
		}
		else{
			lcResult = false;
		}
		return lcResult;
	}
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of CommandMapScript : Mono Class-------------------------------------------------------------------------------
