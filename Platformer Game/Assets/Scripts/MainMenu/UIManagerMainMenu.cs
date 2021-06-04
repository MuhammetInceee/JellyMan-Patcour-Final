using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerMainMenu : MonoBehaviour
{
    public GameObject loginScreen;
    public GameObject controllerScreen;
    public GameObject SP_controllerScreen;
    public GameObject MP_controllerScreen;
    public void Controller()
    {
        loginScreen.SetActive(false);
        controllerScreen.SetActive(true);
    }
    public void ReturnMainMenu()
    {
        loginScreen.SetActive(true);
        controllerScreen.SetActive(false);
        SP_controllerScreen.SetActive(false);
        MP_controllerScreen.SetActive(false);
    }
    public void SP_Controller()
    {
        controllerScreen.SetActive(false);
        SP_controllerScreen.SetActive(true);
    }
    public void MP_Controller()
    {
        controllerScreen.SetActive(false);
        MP_controllerScreen.SetActive(true);
    }
}
