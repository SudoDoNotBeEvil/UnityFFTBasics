using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VisualEffectConteol : MonoBehaviour
{
	public VisualEffect _viseff;
	public FFT _fft;
	public float _scale = 3.0f;
	
	public float fsize;
	
    void Update()
    {
        _viseff.SetFloat("mus0",_fft._samples_short[0]*_scale);
        _viseff.SetFloat("mus1",_fft._samples_short[1]*_scale);
		_viseff.SetFloat("mus2",_fft._samples_short[2]*_scale);
		_viseff.SetFloat("mus3",_fft._samples_short[3]*_scale);
		_viseff.SetFloat("mus4",_fft._samples_short[4]*_scale);
		_viseff.SetFloat("mus5",_fft._samples_short[5]*_scale);
		_viseff.SetFloat("mus6",_fft._samples_short[6]*_scale);
		_viseff.SetFloat("mus7",_fft._samples_short[7]*_scale);
		_viseff.SetFloat("mus8",_fft._samples_short[8]*_scale);
		_viseff.SetFloat("mus9",_fft._samples_short[9]*_scale);
		_viseff.SetFloat("mus10",_fft._samples_short[10]*_scale);
		_viseff.SetFloat("mus11",_fft._samples_short[11]*_scale);
		_viseff.SetFloat("mus12",_fft._samples_short[12]*_scale);
		_viseff.SetFloat("mus13",_fft._samples_short[13]*_scale);
		_viseff.SetFloat("mus14",_fft._samples_short[14]*_scale);
		_viseff.SetFloat("mus15",_fft._samples_short[15]*_scale);
    }
}
