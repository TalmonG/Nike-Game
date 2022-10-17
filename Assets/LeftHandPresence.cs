using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class LeftHandPresence : MonoBehaviour
{
    /*public InputDeviceCharacteristics controllerCharacteristics;
    public InputDevice targetDevice;

    public float damage = 10f;
    public float range = 100f;
    public float shotPower = 100f;

    public GameObject gun;
    public Transform bulletPrefab;
    public Transform barrelLocation;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        {
            Debug.Log("Pressing Primary Button");
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
        {
            Debug.Log("Trigger Pressed" + triggerValue);
            Shoot();
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero)
        {
            Debug.Log("Primary Touchpad" + primary2DAxisValue);
        }

        

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);
    }*/
}
