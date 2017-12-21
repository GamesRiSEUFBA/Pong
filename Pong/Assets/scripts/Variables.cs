using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	public static int vsCPU = 1;
	public static float barSpeed = 8;
	public static string winner = "";

	public static Color ballMat;
	public static Color barMat;
	public static Color lineMat;
	public static Color backMat;

	void Start() {
		if (PlayerPrefs.HasKey("ballMatR"))
			ballMat = new Color(PlayerPrefs.GetFloat("ballMatR"), PlayerPrefs.GetFloat("ballMatG"), PlayerPrefs.GetFloat("ballMatB"));
		else {
			PlayerPrefs.SetFloat ("ballMatR", 1);
			PlayerPrefs.SetFloat ("ballMatG", 1);
			PlayerPrefs.SetFloat ("ballMatB", 1);
			PlayerPrefs.Save ();
		}
		if (PlayerPrefs.HasKey("barMatR"))
			barMat = new Color(PlayerPrefs.GetFloat("barMatR"), PlayerPrefs.GetFloat("barMatG"), PlayerPrefs.GetFloat("barMatB"));
		else {
			PlayerPrefs.SetFloat ("barMatR", 1);
			PlayerPrefs.SetFloat ("barMatG", 1);
			PlayerPrefs.SetFloat ("barMatB", 1);
			PlayerPrefs.Save ();
		}
		if (PlayerPrefs.HasKey("lineMatR"))
			lineMat = new Color(PlayerPrefs.GetFloat("lineMatR"), PlayerPrefs.GetFloat("lineMatG"), PlayerPrefs.GetFloat("lineMatB"));
		else {
			PlayerPrefs.SetFloat ("lineMatR", 1);
			PlayerPrefs.SetFloat ("lineMatG", 1);
			PlayerPrefs.SetFloat ("lineMatB", 1);
			PlayerPrefs.Save ();
		}
		if (PlayerPrefs.HasKey ("backMatR"))
			backMat = new Color (PlayerPrefs.GetFloat ("backMatR"), PlayerPrefs.GetFloat ("backMatG"), PlayerPrefs.GetFloat ("backMatB"));
		else {
			PlayerPrefs.SetFloat ("backMatR", 0);
			PlayerPrefs.SetFloat ("backMatG", 0);
			PlayerPrefs.SetFloat ("backMatB", 0);
			PlayerPrefs.Save ();
		}
	}

}
