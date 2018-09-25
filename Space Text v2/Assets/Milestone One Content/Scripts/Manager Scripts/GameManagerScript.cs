using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnitySceneManager = UnityEngine.SceneManagement;
//--------------------------------------- Start Of GameManagerScript : Mono Class ------------------------------------------------------------------------------
public class GameManagerScript : MonoBehaviour {
	//--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
	public static GameManagerScript _Instance;
	public GameModelScript _GameModel;
    public PlayerScript _Player;
    public static Camera _MainCamera;
    public Canvas _ActiveCanvas;
    public Dictionary<string, Canvas> _CanvasDic;
    public InputField _MainInput;
    public InputField _MapInput;
    public InputField _InvInput;
    public Animator _StarAnim;
    public Animator _PlanetAnim;
    public string _StartCanvas;
    private bool _gameRunning;
	//--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------
	
	
	//-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
	//Mono class that runs before start
	void Awake(){
	//if game manager hasn't been created yet
		if (_Instance ==null){
            Debug.Log(name + ": Created");
            _Instance = this;
			_gameRunning = true;
            attachObjects();
            _Player = new PlayerScript();
            _GameModel = new GameModelScript();
            _CanvasDic = new Dictionary<string, Canvas>();

		}
		else {
			Destroy (gameObject);
            attachObjects();
            Debug.LogWarning (name +": Duplicate destoryed");
		}
	}
    //Mono class that runs after awake
    private void Start()
    {
        SetActiveCanvas(_StartCanvas);
    }
    //Chages the Active Cancvas
    public void SetActiveCanvas(string prCanvasName)
    {
        if (_CanvasDic.ContainsKey(prCanvasName))
        {
            foreach (Canvas iCanvas in _CanvasDic.Values)
            {
                iCanvas.gameObject.SetActive(false);
            }
            _ActiveCanvas = _CanvasDic[prCanvasName];
            Debug.Log(name + ": Loaded Canvas: " + prCanvasName);
            _ActiveCanvas.gameObject.SetActive(true);
            try
            {
                SetActiveInput();
            }catch(Exception e) { }
        }
        else Debug.LogError(name + ": " + prCanvasName + " doesn't exist within dictonary");
    }

    public void SetActiveInput()
    {
        switch (_ActiveCanvas.name)
        {
            case "Main Canvas":
                _MainInput.ActivateInputField();
                break;
            case "Map Canvas":
                _MapInput.ActivateInputField();
                break;
            case "Inventory Canvas":
                _InvInput.ActivateInputField();
                break;
        }
    }
    public string CurrentUnityScene()
    {
        return UnitySceneManager.SceneManager.GetActiveScene().name;
    }

    public void ChangeUnityScene(string prUnitySceneName)
    {
        UnitySceneManager.SceneManager.LoadScene("01_Game");
        Debug.Log(name + ": Loading " + prUnitySceneName);
    }

    private void attachObjects()
    {
        try
        {
            _MainInput = GameObject.FindGameObjectWithTag("Main").GetComponent<InputField>() as InputField;
            _MapInput = GameObject.FindGameObjectWithTag("Map").GetComponent<InputField>() as InputField;
            _InvInput = GameObject.FindGameObjectWithTag("Inventory").GetComponent<InputField>() as InputField;
            _StarAnim = GameObject.FindGameObjectWithTag("Stars").GetComponent<Animator>() as Animator;
            _PlanetAnim = GameObject.FindGameObjectWithTag("Planet").GetComponent<Animator>() as Animator;
            Debug.Log(name + ": All objects attached");
        }
        catch (Exception e)
        {
            Debug.Log(name + ": Objects didn't attach");
        }
    }
    //-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of GameManagerScript : Mono Class-------------------------------------------------------------------------------