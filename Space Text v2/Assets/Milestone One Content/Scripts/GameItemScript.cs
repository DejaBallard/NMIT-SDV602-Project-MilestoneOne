using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------- Start Of  : Mono Class ------------------------------------------------------------------------------
public class GameItemScript : MonoBehaviour {
    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
    public string _Name;
    public GameItemScript _NextItem;
    //--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------


    //-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
    // Use this for initialization
    public GameItemScript(string prName)
    {
        _Name = prName;
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    //-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of  : Mono Class-------------------------------------------------------------------------------