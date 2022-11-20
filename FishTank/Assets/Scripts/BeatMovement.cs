using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatMovement : SongMonitor
{
    public Vector3 beatScale;
	public Vector3 noBeatScale;
    
    private IEnumerator ChangeScale(Vector3 targetScale)
	{
		Vector3 currentScale = transform.localScale;
		Vector3 initialScale = currentScale;
		float timer = 0;

		while (currentScale !=targetScale)
		{
			currentScale = Vector3.Lerp(initialScale,targetScale, timer / timeToBeat);
			timer += Time.deltaTime;
			transform.localScale = currentScale;
			yield return null;
		}

		isBeat = false;
	}
    public override void Update()
	{
		base.Update();
		transform.localScale = Vector3.Lerp(transform.localScale, noBeatScale, restSmoothTime * Time.deltaTime);
	}
    
    public override void Beat()
	{
        base.Beat();
        StopCoroutine("ChangeScale");
		StartCoroutine("ChangeScale", beatScale);
	}
}
