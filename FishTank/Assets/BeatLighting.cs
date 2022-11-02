using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Material))]
public class BeatLighting : SpectrumMonitor
{
    public Color beatColour;
	public Color noBeatColour;

	[SerializeField]
	private Material mat;
    
    private IEnumerator ChangeLight(Color _target)
	{
		Color _curr = mat.color;
		Color _initial = _curr;
		float _timer = 0;

		while (_curr != _target)
		{
			_curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;
			mat.color = _curr;
			yield return null;
		}

		isBeat = false;
	}
    public override void Update()
	{
		base.Update();
		mat.color = Color.Lerp(mat.color, noBeatColour, restSmoothTime * Time.deltaTime);
	}
    // Update is called once per frame
    public override void Beat()
	{
        base.Beat();
		Debug.Log("move here");
        StopCoroutine("ChangeLight");
		StartCoroutine("ChangeLight", beatColour);
	}
	

}
