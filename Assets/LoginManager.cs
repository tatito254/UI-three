using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class LoginManager : MonoBehaviour
{
    public string contra;
    public InputField Ingresar_Contra;

    public void ChequearContra()
    {
        if (Ingresar_Contra.text == contra)
        {
            Debug.Log("Access granted");
        }

        else
        {
            Debug.Log("Access denied");

        }
    }
}
