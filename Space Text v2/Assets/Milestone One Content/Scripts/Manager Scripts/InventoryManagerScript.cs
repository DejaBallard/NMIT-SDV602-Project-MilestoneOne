using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//--------------------------------------- Start Of InventoryManagerScript : Mono Class ------------------------------------------------------------------------------
public class InventoryManagerScript : MonoBehaviour {

    //--------------------------------------- Start Of Top Level Variable Decalaring ------------------------------------------------------------
    public Text _InventoryOutput;

        //--------------------------------------- End Of Top Level Variable Declaring ---------------------------------------------------------


        //-------------------------------------- Start Of Methods ----------------------------------------------------------------------------	
        // Use this for initialization
        void Start()
        {
        _InventoryOutput.text = CreateList();
        }
        // Update is called once per frame
        void Update()
        {
        _InventoryOutput.text = CreateList();
    }
    private string CreateList() {
        string lcResult = "";
        foreach (KeyValuePair<string, GameItemScript> iItem in GameManagerScript._Instance._Player._InventoryItemDic)
        {
           lcResult += iItem.Value._Name;
        }
        return lcResult;

    }

        //-------------------------------------- End Of Methods ----------------------------------------------------------------------------	
    }
//------------------------------------------ End Of InventoryManagerScript : Mono Class-------------------------------------------------------------------------------