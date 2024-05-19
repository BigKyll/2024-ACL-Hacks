using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class UpdateCount : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] VanishManager vm;

    // Update is called once per frame
    void Update()
    {
        text.SetText("Devanishes: " + vm.numVanish);
    }
}
