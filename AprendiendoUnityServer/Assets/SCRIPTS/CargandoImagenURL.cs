using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargandoImagenURL : MonoBehaviour {

    public string url;
    public RawImage imagenWeb;
    private WWW www;
    public Image barraCarga;
    public Text textoCarga;


	// Use this for initialization
	IEnumerator Start () {
        www = new WWW(url);
        yield return www;
        imagenWeb.texture = www.texture;
	}
	
	// Update is called once per frame
	void Update () {
        barraCarga.fillAmount = www.progress;
        textoCarga.text = www.progress.ToString("00%");
        //Debug.Log(www.progress);
	}
}
