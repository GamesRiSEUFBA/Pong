using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

	public void loadScene(int opc)
	{
		print (opc);
		//Application.LoadLevel (opc);
		SceneManager.LoadScene(opc, LoadSceneMode.Additive);
	}
}
