using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscribeRecibeBD : MonoBehaviour
{

    //Variables para la comunicación con PHP
    public string postUrlBD;
    public string getUrlBD;

    private string _nombre = "";
    private string _apellido = "";

    //Variables para representación en pantalla
    public InputField nombreIntroducidoBD;
    public InputField apellidoIntroducidoBD;
    public Text resultadoMostradoBD;
    public Text mensajeEnviadoBD;

    //Los botones lo que hacen es llamar a las corrutinas
    public void Enviar()
    {
        StartCoroutine("SaveName");
    }

    public void Recibir()
    {
        StartCoroutine("LoadName");
    }

    //Corrutinas para la comunicación con la Web
    private IEnumerator LoadName()
    {
        Debug.Log("entro en load name");
        Debug.Log("Cogiendo el nombre desde la url" + getUrlBD);

        //Mostrar datos de retorno aquí
        string urlString = getUrlBD + "?" + "nombre=" + WWW.EscapeURL(_nombre);
        WWW getName = new WWW(getUrlBD);

        //Esperamos hasta que haya una respuesta
        yield return getName;
        resultadoMostradoBD.text = getName.text;
        Debug.Log(getName.text);
    }

    private IEnumerator SaveName()
    {
        Debug.Log("Entro en save name");
        Debug.Log(nombreIntroducidoBD.text);
        _nombre = nombreIntroducidoBD.text;
        _apellido = apellidoIntroducidoBD.text;
        //Utilizamos WWW.EscapeURL por seguridad, funcionaría sin, pero así es más seguro
        string urlString = postUrlBD + "?" + "name=" + WWW.EscapeURL(_nombre) + "&" + "apellido=" + WWW.EscapeURL(_apellido);

        Debug.Log("sending " + urlString);

        //Mandamos aquí los datos
        WWW postName = new WWW(urlString);

        yield return postName;
        mensajeEnviadoBD.text = "Datos recibidos correctamente";
        Debug.Log(postName.text);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
