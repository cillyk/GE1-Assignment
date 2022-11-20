using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//followed youtube tutorial linked in git for this script

public class SongMonitor : MonoBehaviour
{
    public float bias;
	public float timeStep;
	public float timeToBeat;
	public float restSmoothTime;
	private float previousAudioValue;
	private float audioValue;
	private float timer;
	protected bool isBeat;

    public virtual void Beat() 
	{
        timer = 0;
		isBeat = true;
    }

    public virtual void Update()
	{ 
		
		previousAudioValue = audioValue;
		audioValue = SongSpectrum.spectrumValue;

		//if audio bias less then audio value (beat change)
		if (previousAudioValue > bias &&
			audioValue <= bias)
		{
			//checking that enough time passed for another beat
			if (timer > timeStep)
				Beat();
		}

		if (previousAudioValue <= bias &&
			audioValue > bias)
		{
			if (timer > timeStep)
				Beat();
		}

		timer += Time.deltaTime;
	}
}
