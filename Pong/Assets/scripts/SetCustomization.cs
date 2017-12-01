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

	private Material barMat;
	private Material ballMat;
	private Material lineMat;

	public void Start()
	{
		barRSlider = GameObject.Find ("SliderBarR").GetComponent<Slider> ();
		barGSlider = GameObject.Find ("SliderBarG").GetComponent<Slider> ();
		barBSlider = GameObject.Find ("SliderBarB").GetComponent<Slider> ();

		ballRSlider = GameObject.Find ("SliderBallR").GetComponent<Slider> ();
		ballGSlider = GameObject.Find ("SliderBallG").GetComponent<Slider> ();
		ballBSlider = GameObject.Find ("SliderBallB").GetComponent<Slider> ();

		lineRSlider = GameObject.Find ("SliderLineR").GetComponent<Slider> ();
		lineGSlider = GameObject.Find ("SliderLineG").GetComponent<Slider> ();
		lineBSlider = GameObject.Find ("SliderLineB").GetComponent<Slider> ();

		barMat = GameObject.Find ("player_01").GetComponent<Renderer> ().sharedMaterial;
		ballMat = GameObject.Find ("ball").GetComponent<Renderer> ().sharedMaterial;
		lineMat = GameObject.Find ("linhaPNGBranca").GetComponent<Renderer> ().sharedMaterial;

		barRSlider.value = barMat.color.r;
		barGSlider.value = barMat.color.g;
		barBSlider.value = barMat.color.b;

		ballRSlider.value = ballMat.color.r;
		ballGSlider.value = ballMat.color.g;
		ballBSlider.value = ballMat.color.b;

		lineRSlider.value = lineMat.color.r;
		lineGSlider.value = lineMat.color.g;
		lineBSlider.value = lineMat.color.b;

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
	}

	// Invoked when the value of the slider changes.
	public void ValueChangeCheck()
	{
		barMat.color = new Color(barRSlider.value, barGSlider.value, barBSlider.value);

		ballMat.color = new Color(ballRSlider.value, ballGSlider.value, ballBSlider.value);

		lineMat.color = new Color(lineRSlider.value, lineGSlider.value, lineBSlider.value);
	}
}