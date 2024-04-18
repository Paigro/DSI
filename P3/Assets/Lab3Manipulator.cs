using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;
using Unity.VisualScripting;

public class Lab3Manipulator : MouseManipulator
{
    Color ON_OVER_COLOR = Color.yellow; // Color que se pone cuando el raton esta encima de la carta.
    Color NORMAL_COLOR = Color.black;  // Color normal del borde cuando el raton no esta encima.

    public Lab3Manipulator()
    {
        //activators.Add(new ManipulatorActivationFilter { button = UnityEngine.UIElements.MouseButton.RightMouse }); // He supuesto que porque esto solo usa botones y eso no interesa ahora pues lo comento.
    }
    protected override void RegisterCallbacksOnTarget()
    {
        target.RegisterCallback<MouseOverEvent>(OnMouseOver);
        target.RegisterCallback<MouseLeaveEvent>(OnMouseLeave);
    }

    protected override void UnregisterCallbacksFromTarget()
    {
        target.UnregisterCallback<MouseOverEvent>(OnMouseOver);
        target.UnregisterCallback<MouseLeaveEvent>(OnMouseLeave);
    }

    private void OnMouseOver(MouseOverEvent mev)
    {
        Debug.Log("Enters: " + target.name);
        target.style.borderBottomColor = ON_OVER_COLOR;
        target.style.borderLeftColor = ON_OVER_COLOR;
        target.style.borderRightColor = ON_OVER_COLOR;
        target.style.borderTopColor = ON_OVER_COLOR;
        mev.StopPropagation();
    }

    private void OnMouseLeave(MouseLeaveEvent mev)
    {
        Debug.Log("Leaves: " + target.name);
        target.style.borderBottomColor = NORMAL_COLOR;
        target.style.borderLeftColor = NORMAL_COLOR;
        target.style.borderRightColor = NORMAL_COLOR;
        target.style.borderTopColor = NORMAL_COLOR;
        mev.StopPropagation();
    }
}