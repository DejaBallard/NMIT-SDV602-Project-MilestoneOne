using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

//--------------------------------------- Start Of CommandProccessorScript : Mono Class ------------------------------------------------------------------------------
public class CommandProccessorScript : MonoBehaviour {
    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
    private string _PlayerName;
	
	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	// Use this for initialization
	public CommandProccessorScript () {
        _PlayerName = GameManagerScript._Instance._Player._PlayerName;
	}
	// Update is called once per frame
	void Update () {
		
	}
	
	//Divides the input into sections
	public string Parse(string prCommandStr){
		string lcResult = "AI: Sorry " + _PlayerName + ", I dont understand: " + prCommandStr; ;
		
		//Converts to lower case
		prCommandStr = prCommandStr.ToLower();
		//divides input by spacebar
		string[] lcParts = prCommandStr.Split(' ');
		if (lcParts.Length >= 2){
			string lcCommandStr = lcParts[0] + " " + lcParts[1];
			CommandMapScript lcMap = new CommandMapScript();
			
			if (lcMap.KnowsCommand(lcCommandStr)){
				lcResult = lcMap._Result;
			}
			else{
				lcResult = "AI: Sorry "+_PlayerName+", I dont understand: "+prCommandStr;
			}
		}
		//If lcParts.Length > 2
		else{
			lcResult = "AI: " + _PlayerName + ", What do you mean " + prCommandStr+"?";
		}
		return lcResult;
	}
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of CommandProccessorScript : Mono Class-------------------------------------------------------------------------------
