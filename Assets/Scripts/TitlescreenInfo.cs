using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlescreenInfo : MonoBehaviour
{
    [SerializeField]
    private GameObject infoScreen;

    public void ActivateScreen()
    {
        infoScreen.SetActive(true);
    }
    public void DeactivateScreen()
    {
        infoScreen.SetActive(false);
    }
}
