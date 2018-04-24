using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class WinningZone : MonoBehaviour {

	[SerializeField]
	private float timeDelay = 1.0f;
	[SerializeField]
	private GameObject Winning;
	[SerializeField]
	private string nextLevelToLoad = "Scene02"; //substitute with the next Scene to load. Be sure it is     included in the build settings.

	private IEnumerator loadNextLevel() {
		Winning.SetActive (true);

		//Wait timeDelay
		yield return new WaitForSeconds(timeDelay);

		//Restart Scene
		SceneManager.LoadScene(nextLevelToLoad);
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		//If the player enters within the Water Zone, then restart the scene
		if (collision.CompareTag("Player")) {
			StartCoroutine(loadNextLevel());
		}
	}
}
