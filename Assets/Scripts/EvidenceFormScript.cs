using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EvidenceFormScript : MonoBehaviour
{
    public TMP_Dropdown Evidence1;
    public void GetDropDownValue()
    {
        int pickedEntryIndex = Evidence1.value;
        Debug.Log(pickedEntryIndex);
    }
}