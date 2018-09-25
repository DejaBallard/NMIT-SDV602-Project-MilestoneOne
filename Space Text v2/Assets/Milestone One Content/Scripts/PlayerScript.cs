using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------- Start Of PlayerScript : Mono Class ------------------------------------------------------------------------------
public class PlayerScript : MonoBehaviour {
    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
    public string _PlayerName;
    public int _PlayerHealth;
    public int _PlayerScore;
    public Dictionary<string, GameItemScript> _InventoryItemDic;
    public string _InventoryList;

    //--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------


    //-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
    // Use this for initialization
    public PlayerScript()
    {
        _InventoryItemDic = new Dictionary<string, GameItemScript>();
        GameItemScript _Keys = new GameItemScript("Keys");
        _InventoryItemDic.Add("Keys", _Keys);
        _PlayerName = "Boss";

    }
    // Update is called once per frame
    void Update()
    {

    }
    //-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
}
//------------------------------------------ End Of  : Mono Class-------------------------------------------------------------------------------