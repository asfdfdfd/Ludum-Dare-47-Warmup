using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class ThoughtsRandomizer : MonoBehaviour
{
    private TextMeshProUGUI textView;

    private Random random = new Random();
    
    private String[] thoughts = new[]
    {
        "Something happened with me... a bad situation.",
        "I must get out of it at once.",
        "The air is getting thin.",
        "I must be careful with dangerous reefs and this fish don’t look so kind.",
        "In another life maybe, all right?",
        "Oh, no... This water got into my lungs and poisoned me.",
        "And my heart stopped... until I saw you again.",
        "Which did you choose, was it the sea bed or desire to live... in this crazy world?",
        "You are fish food."
    };
    
    private void Start()
    {
        textView = GameObject.Find("Thoughts").GetComponent<TextMeshProUGUI>();

        int thoughtIndex = random.Next(0, thoughts.Length);

        textView.text = thoughts[thoughtIndex];
    }
}
