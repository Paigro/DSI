using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;

public class Lab3 : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        VisualElement tapete = root.Q("Tapete");

        //tapete.AddManipulator(new Lab3Manipulator()); // Lo quito para que no se pueda cambiar el color del borde del tapete cuando pases el raton.

        VisualElement cartas1_3 = root.Q("Cartas1-3");
        VisualElement cartas4_6 = root.Q("Cartas4-6");
        VisualElement cartas7_9 = root.Q("Cartas7-9");


        List<VisualElement> l_cartas1_3 = cartas1_3.Children().ToList();
        List<VisualElement> l_cartas4_6 = cartas4_6.Children().ToList();
        List<VisualElement> l_cartas7_9 = cartas7_9.Children().ToList();

        l_cartas1_3.ForEach(elem => elem.AddManipulator(new Lab3Manipulator()));
        l_cartas4_6.ForEach(elem => elem.AddManipulator(new Lab3Manipulator()));
        l_cartas7_9.ForEach(elem => elem.AddManipulator(new Lab3Manipulator()));

        l_cartas1_3.ForEach(elem => elem.AddManipulator(new Lab3Manipulator()));
        l_cartas4_6.ForEach(elem => elem.AddManipulator(new Lab3Manipulator()));
        l_cartas7_9.ForEach(elem => elem.AddManipulator(new Lab3Manipulator()));





        /*left.RegisterCallback<ClickEvent>(ev =>
        {
            (ev.target as VisualElement).style.backgroundColor = Color.red;
        }, TrickleDown.TrickleDown);

        right.RegisterCallback<ClickEvent>(ev =>
        {
            (ev.target as VisualElement).style.backgroundColor = Color.red;
        }, TrickleDown.TrickleDown);*/

        /*VisualElement green = root.Q("verde");
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
        });*/
    }
}
