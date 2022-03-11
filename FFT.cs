using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFT : MonoBehaviour
{
	AudioSource _as;
	public float[] _samples = new float[512];
	public float[] _samples_short = new float[16];
	
    // Start is called before the first frame update
    void Start()
    {
			_as = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Fourier();
    }
	
	void Fourier()
	{
		_as.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
		
		for(int i=0; i<16; i++)
			_samples_short[i] = 0; 
	
			for(int i=0; i<2; i++)
				_samples_short[0] += _samples[i];
			for(int i=2; i<4; i++)
				_samples_short[1] += _samples[i];
			for(int i=4; i<6; i++)
				_samples_short[2] += _samples[i];
			for(int i=6; i<8; i++)
				_samples_short[3] += _samples[i];
			for(int i=8; i<12; i++)
				_samples_short[4] += _samples[i];
			for(int i=12; i<16; i++)
				_samples_short[5] += _samples[i];
			for(int i=16; i<24; i++)
				_samples_short[6] += _samples[i];
			for(int i=24; i<32; i++)
				_samples_short[7] += _samples[i];
			for(int i=32; i<48; i++)
				_samples_short[8] += _samples[i];
			for(int i=48; i<64; i++)
				_samples_short[9] += _samples[i];
			for(int i=64; i<96; i++)
				_samples_short[10] += _samples[i];
			for(int i=96; i<128; i++)
				_samples_short[11] += _samples[i];
			for(int i=128; i<192; i++)
				_samples_short[12] += _samples[i];
			for(int i=192; i<256; i++)
				_samples_short[13] += _samples[i];
			for(int i=256; i<384; i++)
				_samples_short[14] += _samples[i];
			for(int i=384; i<512; i++)
				_samples_short[15] += _samples[i];
		
		/*
		for(int j=0; j<16; j++)
		{
			_samples_short[j] = 0;
			/*for(int i=0; i<32; i++)
			{
				_samples_short[j]+=_samples[i+j*32];
			}*/
			/*for(int i=0; i<1; i++)
				_samples_short[0] += _samples[i];
			
		}	*/
	}
}
