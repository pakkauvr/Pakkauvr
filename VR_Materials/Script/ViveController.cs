using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViveController : MonoBehaviour {
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller {
        get {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }
    void Awake() { 
    trackedObj = GetComponent<SteamVR_TrackedObject>();
        }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
public void OnTriggerStay(Collider collider) {
    if (Controller.GetHairTriggerDown()) {
        ExecuteEvents.Execute(collider.gameObject, new
            PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
    }
}
}