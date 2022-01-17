using TMPro;
using UnityEngine;

public class LifeDisplayer : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private PV lifeBehaviour;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        lifeBehaviour = GetComponentInParent<PV>();
    }

    public void UpdateLife()
    {
        textMesh.text = lifeBehaviour.currentHealth.ToString();
    }
}
