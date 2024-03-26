using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreTextScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static int coinAmount;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
    }
}
