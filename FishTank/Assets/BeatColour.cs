using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Material))]
public class BeatColour : SpectrumMonitor
{
    public Color beatColour;
	public Color noBeatColour;

	[SerializeField]
	private Material mat;
    
    private IEnumerator ChangeColour(Color _target)
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

	public void RandomColour()
	{
		beatColour = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
	}

    // Update is called once per frame
    public override void Beat()
	{
		RandomColour();
        base.Beat();
		Debug.Log("move here");
        StopCoroutine("ChangeColour");
		StartCoroutine("ChangeColour", beatColour);
	}
	

}
