using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab3 : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        VisualElement green = root.Q("verde");
        VisualElement red = root.Q("rojo");
        VisualElement oranje = root.Q("naranja");

        green.RegisterCallback<MouseDownEvent>(
            ev =>
        {
            Debug.Log("Verde phase: " + ev.propagationPhase);
            Debug.Log("Verde current target: " + (ev.currentTarget as VisualElement).name);
            Debug.Log("Verde target: " + (ev.target as VisualElement).name);
        }, TrickleDown.NoTrickleDown);

        red.RegisterCallback<MouseDownEvent>(
            ev =>
        {
            Debug.Log("Rojo phase: " + ev.propagationPhase);
            Debug.Log("Rojo current target: " + (ev.currentTarget as VisualElement).name);
            Debug.Log("Rojo target: " + (ev.target as VisualElement).name);
        }, TrickleDown.NoTrickleDown);

        oranje.RegisterCallback<MouseDownEvent>(
            ev =>
        {
            Debug.Log("Naranja phase: " + ev.propagationPhase);
            Debug.Log("Naranja current target: " + (ev.currentTarget as VisualElement).name);
            Debug.Log("Naranja target: " + (ev.target as VisualElement).name);
            ev.StopPropagation();
        });
    }









    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
