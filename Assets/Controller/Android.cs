// GENERATED AUTOMATICALLY FROM 'Assets/Controller/Android.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Android : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Android()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Android"",
    ""maps"": [
        {
            ""name"": ""PlayerAndroid"",
            ""id"": ""6ca15045-d53c-425a-9624-28be60e39549"",
            ""actions"": [
                {
                    ""name"": ""Gyro"",
                    ""type"": ""Value"",
                    ""id"": ""e77584f0-5b4a-417e-a0e4-8751d4766e28"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c5761daa-d0b9-4c3a-8b9e-862f1eca9a11"",
                    ""path"": ""<Gyroscope>/angularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gyro"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerAndroid
        m_PlayerAndroid = asset.FindActionMap("PlayerAndroid", throwIfNotFound: true);
        m_PlayerAndroid_Gyro = m_PlayerAndroid.FindAction("Gyro", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerAndroid
    private readonly InputActionMap m_PlayerAndroid;
    private IPlayerAndroidActions m_PlayerAndroidActionsCallbackInterface;
    private readonly InputAction m_PlayerAndroid_Gyro;
    public struct PlayerAndroidActions
    {
        private @Android m_Wrapper;
        public PlayerAndroidActions(@Android wrapper) { m_Wrapper = wrapper; }
        public InputAction @Gyro => m_Wrapper.m_PlayerAndroid_Gyro;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAndroid; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerAndroidActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerAndroidActions instance)
        {
            if (m_Wrapper.m_PlayerAndroidActionsCallbackInterface != null)
            {
                @Gyro.started -= m_Wrapper.m_PlayerAndroidActionsCallbackInterface.OnGyro;
                @Gyro.performed -= m_Wrapper.m_PlayerAndroidActionsCallbackInterface.OnGyro;
                @Gyro.canceled -= m_Wrapper.m_PlayerAndroidActionsCallbackInterface.OnGyro;
            }
            m_Wrapper.m_PlayerAndroidActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Gyro.started += instance.OnGyro;
                @Gyro.performed += instance.OnGyro;
                @Gyro.canceled += instance.OnGyro;
            }
        }
    }
    public PlayerAndroidActions @PlayerAndroid => new PlayerAndroidActions(this);
    public interface IPlayerAndroidActions
    {
        void OnGyro(InputAction.CallbackContext context);
    }
}
