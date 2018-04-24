using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_JumpController : MonoBehaviour, IPointerDownHandler {
	[SerializeField]
	private MovementComponent movementComponent;
	// Use this for initialization
	void Awake() {
		//Destroy this script in case we are not running on mobile
		#if !(UNITY_STANDALONE || UNITY_EDITOR)
		Destroy(gameObject);
		#endif

		//Disable this script in case the Movement Component reference is not set, and leave an error message.
		if (movementComponent == null) {
			Debug.LogError("Missing reference on MovementComponent on " + gameObject.name + " to run the Controller. Please add the reference.");
			Destroy(gameObject);
		}
	}
	public void OnPointerDown(PointerEventData eventData) {
		movementComponent.Jump();
	}
}
