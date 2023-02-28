using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button button;
    public Image image;
    public Sprite sprite;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    void OnClick() {
        text.text = "Hello World";
        image.sprite = sprite;
        panel.SetActive(!panel.activeSelf);
    }
}
