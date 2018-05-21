using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnviaRecibeDatosWeb : MonoBehaviour {

    //Variables para la comunicación con PHP
    public string postUrl;
    public string getUrl;

    private string _player = "";

    //Variables para representación en pantalla
    public InputField nombreIntroducido;
    public Text nombreMostrado;

    //Los botones lo que hacen es llamar a las corrutinas
    public void Enviar(){
        StartCoroutine("SaveName");
    }

    public void Recibir(){
        StartCoroutine("LoadName");
    }

    //Corrutinas para la comunicación con la Web
    private IEnumerator LoadName(){
        Debug.Log("entro en load name");
        Debug.Log("Cogiendo el nombre desde la url" + getUrl);

        //Mostrar datos de retorno aquí
        WWW getName = new WWW(getUrl);

        //Esperamos hasta que haya una respuesta
        yield return getName;
        nombreMostrado.text = getName.text;
        Debug.Log(getName.text);
    }

    private IEnumerator SaveName(){
        Debug.Log("Entro en save name");
        Debug.Log(nombreIntroducido.text);
        _player = nombreIntroducido.text;
        //Utilizamos WWW.EscapeURL por seguridad, funcionaría sin, pero así es más seguro
        string urlString = postUrl + "?name=" + WWW.EscapeURL(_player);

        Debug.Log("sending " + urlString);

        //Mandamos aquí los datos
        WWW postName = new WWW(urlString);

        yield return postName;
        Debug.Log(postName.text);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
