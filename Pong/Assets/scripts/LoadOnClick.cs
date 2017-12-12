using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

	public void loadScene(int dest)
	{
		print (dest);
		if (dest == 2) {
			GameInit.vsCPU = 0;
			dest--;
		} else if (dest == 3)
			dest--;
		else
			GameInit.vsCPU = 1;
		
		print (dest);
		//Application.LoadLevel (opc);
		SceneManager.LoadScene(dest, LoadSceneMode.Single);
	}
}
