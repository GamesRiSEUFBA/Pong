using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

	public void loadScene(int dest)
	{
		print (dest);
		if (dest == 1) {
			GameInit.vsCPU = 1;
		} else if (dest == 2) {
			GameInit.vsCPU = 0;
			dest--;
		} else if (dest == 3) {
			dest--;
		} else if (dest == 4) {
			dest--;
		}

		//Application.LoadLevel (opc);
		SceneManager.LoadScene(dest, LoadSceneMode.Single);
	}
}
