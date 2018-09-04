using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------- Start Of PlayerScript : Mono Class ------------------------------------------------------------------------------
public class PlayerScript : MonoBehaviour {
    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
    public string _PlayerName;
    public Dictionary<string, string> _InventoryItems;

    //--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------


    //-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
    // Use this for initialization
    public PlayerScript()
    {
        _InventoryItems = new Dictionary<string, string>();
        _InventoryItems.Add("Keys", "Keys");
        _PlayerName = "Boss";
    }
    // Update is called once per frame
    void Update()
    {

    }
    //-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of  : Mono Class-------------------------------------------------------------------------------