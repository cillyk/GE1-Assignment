using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatMovement : SpectrumMonitor
{
    public Vector3 beatScale;
	public Vector3 noBeatScale;
    
    private IEnumerator MoveToScale(Vector3 _target)
	{
		Vector3 _curr = transform.localScale;
		Vector3 _initial = _curr;
		float _timer = 0;

		while (_curr != _target)
		{
			_curr = Vector3.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;
			transform.localScale = _curr;
			yield return null;
		}

		isBeat = false;
	}
    public override void Update()
	{
		base.Update();
		transform.localScale = Vector3.Lerp(transform.localScale, noBeatScale, restSmoothTime * Time.deltaTime);
	}
    // Update is called once per frame
    public override void Beat()
	{
        base.Beat();
		Debug.Log("move here");
        StopCoroutine("MoveToScale");
		StartCoroutine("MoveToScale", beatScale);
	}
}
