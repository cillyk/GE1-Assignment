using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongSpectrum : MonoBehaviour
{
    //how much to multiply the song by (adjust depending on song loudness)
    public int songMultiplier = 150;

    private float[] spectrum;
    public static float spectrumValue;

    void Start()
    {
     spectrum = new float[128] ;
    }

    //store playing musics beat data into spectrum
    void Update()
    {
        AudioListener.GetSpectrumData(spectrum,0 ,FFTWindow.Hamming);
        spectrumValue = spectrum[0] * songMultiplier;
    }
}
