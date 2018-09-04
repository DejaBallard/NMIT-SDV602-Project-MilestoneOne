using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//--------------------------------------- Start Of InputScript : Mono Class ------------------------------------------------------------------------------
public class InputScript : MonoBehaviour {
//--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
	public Text _TxtOutput;
	
	private InputField _inputField;
	private InputField.SubmitEvent _submitEvent;
	private InputField.OnChangeEvent _onChangeEvent;

//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------


//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	// Use this for initialization
	void Start () {
	// Adding the gameobject to the variable
		_inputField = this.GetComponent<InputField>();
		
		if (_inputField != null){
			_submitEvent = new InputField.SubmitEvent();
			_submitEvent.AddListener(submitInput);
		
			_inputField.onEndEdit = _submitEvent;
            _TxtOutput.text = GameManagerScript._Instance._GameModel._CurrentScene._SceneStory;
		}
	}
	private void submitInput(string prArg){
	
		string lcCurrentText = _TxtOutput.text;
		CommandProccessorScript lcCommandPro = new CommandProccessorScript();
			//text being checked with command proccessor
			_TxtOutput.text = lcCurrentText+"\n"+ lcCommandPro.Parse(prArg)+"\n";
			//Reset input field to blank
			_inputField.text = "";
			//Allow input to be used again
			_inputField.ActivateInputField();
       
	}
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of InputScript : Mono Class-------------------------------------------------------------------------------
