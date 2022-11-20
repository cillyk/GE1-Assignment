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
	
    //change colour and emssion colour in tune with the beat
    private IEnumerator ChangeColour(Color targetColour)
	{
		mat.EnableKeyword("_EMISSION");
		Color currentColour = mat.color;
		Color initialColour = currentColour;
		float timer = 0;
		
		while (currentColour != targetColour)
		{
			currentColour = Color.Lerp(initialColour, targetColour, timer / timeToBeat);
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
		
	}

	//gets a random high saturation colour
	public void RandomColour()
	{
		beatColour = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
	}

    //when a beat is deetected begin the colour change
    public override void Beat()
	{
		RandomColour();
        base.Beat();
        StopCoroutine("ChangeColour");
		StartCoroutine("ChangeColour", beatColour);
	}
	

}
