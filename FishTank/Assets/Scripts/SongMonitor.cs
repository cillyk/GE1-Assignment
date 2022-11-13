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

    public virtual void Beat() {

		//hit when bias is upper or lower creating a "beat
        Debug.Log("beat is happening");
        timer = 0;
		isBeat = true;
    }
    void Start()
    {
        
    }

    public virtual void Update()
	{ 
		
		previousAudioValue = audioValue;
		audioValue = SongSpectrum.SpectrumValue;

		//if audio bias less then audio value this frame
		if (previousAudioValue > bias &&
			audioValue <= bias)
		{
			// "checkin that enough time passed for another beat"
			if (timer > timeStep)
				Beat();
		}

		//if audio bias more then audio value this frame
		if (previousAudioValue <= bias &&
			audioValue > bias)
		{
			// "checkin that enough time passed for another beat"
			if (timer > timeStep)
				Beat();
		}

		//updating time
		timer += Time.deltaTime;
	}
}
