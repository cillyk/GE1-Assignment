using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongSpectrum : MonoBehaviour
{
    //how much to multiply the song by (adjust depending on song loudness)
    public int SongMultiplier;

    private float[] Spectrum;
    public static float SpectrumValue;

    // Start is called before the first frame update
    void Start()
    {
     Spectrum = new float[128] ;
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.GetSpectrumData(Spectrum,0 ,FFTWindow.Hamming);
        SpectrumValue = Spectrum[0] * SongMultiplier;
    }
}
