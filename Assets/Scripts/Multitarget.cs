using UnityEngine;

public class Multitarget : MonoBehaviour
{
    [SerializeField] private GameObject startModel; // hace que una variable privada se vuelva publica en el inspector de Unity
    private int modelsCount;
    private int indexCurrentModel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        modelsCount = transform.childCount; // obtiene el numero de hijos del objeto al que esta atachado el script
        indexCurrentModel = startModel.transform.GetSiblingIndex(); // obtiene el indice del objeto startModel entre sus hermanos (otros objetos hijos del mismo padre)
    }

    public void ChangeModel (int index)
    {
        transform.GetChild(indexCurrentModel).gameObject.SetActive(false); // desactiva el modelo actual
        int newIndex = indexCurrentModel + index; // calcula el indice del nuevo modelo sumando el indice actual con el valor del parametro index
        if (newIndex < 0) // si el nuevo indice es menor que 0, se asigna el indice del ultimo modelo (modelsCount - 1)
        {
            newIndex = modelsCount - 1; // si el nuevo indice es menor que 0, se asigna el indice del ultimo modelo (modelsCount - 1)
        }else if (newIndex > modelsCount - 1) // si el nuevo indice es mayor que el indice del ultimo modelo, se asigna el indice del primer modelo (0)
        {
            newIndex = 0; // si el nuevo indice es mayor que el indice del ultimo modelo, se asigna el indice del primer modelo (0)
        }

        GameObject newModel = transform.GetChild(newIndex).gameObject; // obtiene el nuevo modelo utilizando el nuevo indice
        newModel.SetActive(true); // activa el nuevo modelo
        indexCurrentModel = newModel.transform.GetSiblingIndex(); // actualiza el indice del modelo actual con el indice del nuevo modelo
    }

}
