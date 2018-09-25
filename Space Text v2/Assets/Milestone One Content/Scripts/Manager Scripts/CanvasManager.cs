using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        //-------------- Adding canvas's to instance -----------------
        Canvas[] _CanvasArray = gameObject.GetComponentsInChildren<Canvas>();
        foreach (Canvas iCanvas in _CanvasArray) {
            GameManagerScript._Instance._CanvasDic.Add(iCanvas.name, iCanvas);
            Debug.Log(name + ": " + iCanvas.name + " has been added to GameManager");
        }
	}
}
