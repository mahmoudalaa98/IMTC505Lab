using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private Light roomLight;
    [SerializeField] private Light directionalLight;

    public void ToggleLight()
    {
        roomLight.enabled = !roomLight.enabled;
        directionalLight.enabled = !directionalLight.enabled;
    }
}