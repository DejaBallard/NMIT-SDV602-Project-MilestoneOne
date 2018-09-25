using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//--------------------------------------- Start Of InputScript : Mono Class ------------------------------------------------------------------------------
public class InputScript : MonoBehaviour {
    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
    public Text _TxtOutput;
    public Canvas _Canvas;
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
            //If this input field is attached to main canvas, show story
            if (_Canvas.name == "Main Canvas")
            {
                _TxtOutput.text = GameManagerScript._Instance._GameModel._CurrentScene._SceneStory;
            }
		}
	}
	private void submitInput(string prArg){
	
		string lcCurrentText = _TxtOutput.text;
		CommandProccessorScript lcCommandPro = new CommandProccessorScript();
			//text being checked with command proccessor
			_TxtOutput.text = lcCommandPro.Parse(prArg);
			//Reset input field to blank
			_inputField.text = "";
			//Allow input to be used again
			_inputField.ActivateInputField();
       
	}
	//-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of InputScript : Mono Class-------------------------------------------------------------------------------
