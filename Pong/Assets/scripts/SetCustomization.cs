using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class SetCustomization : MonoBehaviour
{
	private Slider barRSlider;
	private Slider barGSlider;
	private Slider barBSlider;

	private Slider ballRSlider;
	private Slider ballGSlider;
	private Slider ballBSlider;

	private Slider lineRSlider;
	private Slider lineGSlider;
	private Slider lineBSlider;

	private Slider backRSlider;
	private Slider backGSlider;
	private Slider backBSlider;

	private Material barMat;
	private Material ballMat;
	private Material lineMat;
	private Material backMat;

	private Camera cam;

	public void Start()
	{
		cam = GetComponent<Camera> ();
		backMat = Resources.Load ("Materials/MatBack") as Material;	

		barRSlider = GameObject.Find ("SliderBarR").GetComponent<Slider> ();
		barGSlider = GameObject.Find ("SliderBarG").GetComponent<Slider> ();
		barBSlider = GameObject.Find ("SliderBarB").GetComponent<Slider> ();

		ballRSlider = GameObject.Find ("SliderBallR").GetComponent<Slider> ();
		ballGSlider = GameObject.Find ("SliderBallG").GetComponent<Slider> ();
		ballBSlider = GameObject.Find ("SliderBallB").GetComponent<Slider> ();

		lineRSlider = GameObject.Find ("SliderLineR").GetComponent<Slider> ();
		lineGSlider = GameObject.Find ("SliderLineG").GetComponent<Slider> ();
		lineBSlider = GameObject.Find ("SliderLineB").GetComponent<Slider> ();

		backRSlider = GameObject.Find ("SliderBackR").GetComponent<Slider> ();
		backGSlider = GameObject.Find ("SliderBackG").GetComponent<Slider> ();
		backBSlider = GameObject.Find ("SliderBackB").GetComponent<Slider> ();

		barMat = GameObject.Find ("player_01").GetComponent<Renderer> ().sharedMaterial;
		ballMat = GameObject.Find ("ball").GetComponent<Renderer> ().sharedMaterial;
		lineMat = GameObject.Find ("linhaPNGBranca").GetComponent<Renderer> ().sharedMaterial;

		ballMat.color = new Color(PlayerPrefs.GetFloat("ballMatR"), PlayerPrefs.GetFloat("ballMatG"), PlayerPrefs.GetFloat("ballMatB"));
		barMat.color = new Color(PlayerPrefs.GetFloat("barMatR"), PlayerPrefs.GetFloat("barMatG"), PlayerPrefs.GetFloat("barMatB"));
		lineMat.color = new Color(PlayerPrefs.GetFloat("lineMatR"), PlayerPrefs.GetFloat("lineMatG"), PlayerPrefs.GetFloat("lineMatB"));
		backMat.color = new Color (PlayerPrefs.GetFloat ("backMatR"), PlayerPrefs.GetFloat ("backMatG"), PlayerPrefs.GetFloat ("backMatB"));

		cam.backgroundColor = backMat.color;

		barRSlider.value = barMat.color.r;
		barGSlider.value = barMat.color.g;
		barBSlider.value = barMat.color.b;

		ballRSlider.value = ballMat.color.r;
		ballGSlider.value = ballMat.color.g;
		ballBSlider.value = ballMat.color.b;

		lineRSlider.value = lineMat.color.r;
		lineGSlider.value = lineMat.color.g;
		lineBSlider.value = lineMat.color.b;

		backRSlider.value = cam.backgroundColor.r;
		backGSlider.value = cam.backgroundColor.g;
		backBSlider.value = cam.backgroundColor.b;

		//Adds a listener to the main slider and invokes a method when the value changes.
		barRSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
		barGSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
		barBSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });

		ballRSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
		ballGSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
		ballBSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });

		lineRSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
		lineGSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
		lineBSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });

		backRSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
		backGSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
		backBSlider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
	}

	// Invoked when the value of the slider changes.
	public void ValueChangeCheck()
	{
		Variables.barMat = new Color(barRSlider.value, barGSlider.value, barBSlider.value);
		Variables.ballMat = new Color(ballRSlider.value, ballGSlider.value, ballBSlider.value);
		Variables.lineMat = new Color(lineRSlider.value, lineGSlider.value, lineBSlider.value);

		Variables.backMat = new Color(backRSlider.value, backGSlider.value, backBSlider.value);
		cam.backgroundColor = Variables.backMat;

		barMat.color = Variables.barMat;
		ballMat.color = Variables.ballMat;
		lineMat.color = Variables.lineMat;
		backMat.color = Variables.backMat;

		PlayerPrefs.SetFloat ("backMatR", backMat.color.r);
		PlayerPrefs.SetFloat ("backMatG", backMat.color.g);
		PlayerPrefs.SetFloat ("backMatB", backMat.color.b);

		PlayerPrefs.SetFloat ("ballMatR", ballMat.color.r);
		PlayerPrefs.SetFloat ("ballMatG", ballMat.color.g);
		PlayerPrefs.SetFloat ("ballMatB", ballMat.color.b);

		PlayerPrefs.SetFloat ("barMatR", barMat.color.r);
		PlayerPrefs.SetFloat ("barMatG", barMat.color.g);
		PlayerPrefs.SetFloat ("barMatB", barMat.color.b);

		PlayerPrefs.SetFloat ("lineMatR", lineMat.color.r);
		PlayerPrefs.SetFloat ("lineMatG", lineMat.color.g);
		PlayerPrefs.SetFloat ("lineMatB", lineMat.color.b);

		PlayerPrefs.Save ();
	}
}