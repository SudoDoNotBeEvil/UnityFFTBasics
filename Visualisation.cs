using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visualisation : MonoBehaviour
{	
	//public float[] _samples_short = new float[16];
	public int _narray;
	public FFT _fft;
	public float _scale = 3.0f;
	
	public GameObject _bar_prefab;
	GameObject[] _bars = new GameObject[16];
	private float[] _samples_short_max  = new float[16];
	
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<16; i++)
		{
			GameObject _instanceBar = (GameObject)Instantiate (_bar_prefab);
			_instanceBar.transform.position = this.transform.position + Vector3.forward * i;
			_instanceBar.transform.parent = this.transform;
			_instanceBar.name = "_instanceBar" + i;
			_bars[i] = _instanceBar;
		}
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<16; i++)
		{
			if(_bars != null)
				_bars[i].transform.localScale = new Vector3(0.7f, _fft._samples_short[i]*_scale,0.7f);

			if (_fft._samples_short[i] > _samples_short_max[i])
				_samples_short_max[i] = _fft._samples_short[i];

			var cubeRenderer = _bars[i].GetComponent<Renderer>();
			cubeRenderer.material.SetColor("_Color", Color.red *  _fft._samples_short[i]/_samples_short_max[i] 
+Color.blue *  (1- _fft._samples_short[i]/_samples_short_max[i])			);
		}
    }
}
