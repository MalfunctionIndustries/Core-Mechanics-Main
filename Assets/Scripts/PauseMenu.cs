using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	bool paused = false;

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Pause"))
		{
			if(!paused)
			{

				paused = true;
				gameObject.GetComponent<Canvas>().enabled = false;
				
			} else {
				paused = false;
				gameObject.GetComponent<Canvas>().enabled = true;
			}
		}

		if (paused) {
			Time.timeScale = 0.0f;
		} else {
			Time.timeScale = 1.0f;
		}
	}
}
