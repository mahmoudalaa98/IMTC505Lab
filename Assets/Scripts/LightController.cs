using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private Light roomLight;
    [SerializeField] private Light directionalLight;

    public void ToggleLight()
    {
        Debug.Log("Light button clicked");

        if (roomLight != null)
        {
            roomLight.enabled = !roomLight.enabled;
        }

        if (directionalLight != null)
        {
            directionalLight.enabled = !directionalLight.enabled;
        }
    }
}