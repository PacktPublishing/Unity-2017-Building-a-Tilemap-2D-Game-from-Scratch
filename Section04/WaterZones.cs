using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class WaterZones : MonoBehaviour {
	[SerializeField]
	private float timeDelay = 1.0f;
	[SerializeField]
	private GameObject GameOver;

	private IEnumerator restartScene() {
		GameOver.SetActive(true);

		//Wait timeDelay
		yield return new WaitForSeconds(timeDelay);

		//Restart Scene
		SceneManager.LoadScene("Scene01"); //substitute "Scene01" with the name of your level, also be sure to add the scene to the build settings

	}
	//Get the name of the current scene (i.e. level)
	//string sceneName = SceneManager.GetActiveScene().name;
	//(Re-)load the same scene / level.
	//SceneManager.LoadScene(sceneName);

	private void OnTriggerEnter2D(Collider2D collision) {
		//If the player enters within the Water Zone, then restart the scene
		if (collision.CompareTag("Player")) {
			StartCoroutine(restartScene());
		}
	}

}
