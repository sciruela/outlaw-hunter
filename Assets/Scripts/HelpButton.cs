using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButton : MonoBehaviour 
{
    public GameObject panelHelpDialog;

    public void doHelpButton() {
        panelHelpDialog.SetActive(true);
    }
}
