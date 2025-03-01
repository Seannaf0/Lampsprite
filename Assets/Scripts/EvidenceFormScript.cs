using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EvidenceFormScript : MonoBehaviour
{
    public TMP_Dropdown Dropdown;
    public void GetDropDownValue()
    {
        int pickedEntryIndex = Dropdown.value;
        Debug.Log(pickedEntryIndex);
    }
}