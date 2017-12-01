using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

	public void loadScene(int dest)
	{
		print (dest);
		//Application.LoadLevel (opc);
		SceneManager.LoadScene(dest, LoadSceneMode.Single);
	}
}
