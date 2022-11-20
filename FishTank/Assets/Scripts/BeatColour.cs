using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Material))]
public class BeatColour : SongMonitor
{
    public Color beatColour;
	Color initialColour;

	[SerializeField]
	private Material mat;
	
    
    private IEnumerator ChangeColour(Color _target)
	{
		mat.EnableKeyword("_EMISSION");
		Color currentColour = mat.color;
		Color initialColour = currentColour;
		float timer = 0;
		
		while (currentColour != _target)
		{
			currentColour = Color.Lerp(initialColour, _target, timer / timeToBeat);
			timer += Time.deltaTime;
			mat.SetColor("_EmissionColor", currentColour);
			mat.color = currentColour;
			yield return null;
		}

		isBeat = false;
	}
    public override void Update()
	{
		base.Update();
		mat.color = Color.Lerp(mat.color, initialColour, restSmoothTime * Time.deltaTime);
		//DynamicGI.UpdateEnvironment();
	}

	public void RandomColour()
	{
		beatColour = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
	}

    // Update is called once per frame
    public override void Beat()
	{
		RandomColour();
        base.Beat();
		//Debug.Log("move here");
        StopCoroutine("ChangeColour");
		StartCoroutine("ChangeColour", beatColour);
	}
	

}
