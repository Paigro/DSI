using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab4 : MonoBehaviour
{
    VisualElement contenedorBot, botPicante, botPrecio, item3;
    private void OnEnable()
    {
        VisualElement rootve = GetComponent<UIDocument>().rootVisualElement;

        contenedorBot = rootve.Q("Botones");
        botPicante = rootve.Q("BotPicante");
        botPrecio = rootve.Q("BotPrecio");

        item3 = new VisualElement();
        item3.name = "item3";
        item3.style.height = 200;
        item3.style.width = 200;
        item3.style.backgroundColor = Color.blue;

        contenedorBot.Add(item3);

        Debug.Log("OnEnable");
        Debug.Log(item3);
    }

    private void Update()
    {
       // Debug.Log("Update");
    }

    private void LateUpdate()
    {
       // Debug.Log("LateUpdate");
    }
}
