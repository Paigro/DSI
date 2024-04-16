using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab4 : MonoBehaviour
{
    private void OnEnable()
    {
        UIDocument uidoc = GetComponent<UIDocument>();
        VisualElement rootve = uidoc.rootVisualElement;

        UQueryBuilder<VisualElement> builder = new(rootve);
        List<VisualElement> lista_ve = builder.ToList();

        lista_ve.ForEach(e => Debug.Log(e.name));
    }
}
