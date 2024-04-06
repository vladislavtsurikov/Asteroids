//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Assemblies/VladislavTsurikov/Weapons/WeaponsAction.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @WeaponsAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @WeaponsAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""WeaponsAction"",
    ""maps"": [
        {
            ""name"": ""Weapons"",
            ""id"": ""a56efec0-514d-4fb5-93e5-d894102f35b6"",
            ""actions"": [
                {
                    ""name"": ""FireBullet"",
                    ""type"": ""Button"",
                    ""id"": ""b3f701d0-079e-4edb-87ae-7b21e7ae0121"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FireLaser"",
                    ""type"": ""Button"",
                    ""id"": ""a572f26a-1c64-41a6-b01f-11d1ae069a41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""297a29c7-fdb7-4cc1-960e-5227c8d5a40e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69c22a74-77f7-4ab0-b0c3-f4987da7d57a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Weapons
        m_Weapons = asset.FindActionMap("Weapons", throwIfNotFound: true);
        m_Weapons_FireBullet = m_Weapons.FindAction("FireBullet", throwIfNotFound: true);
        m_Weapons_FireLaser = m_Weapons.FindAction("FireLaser", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Weapons
    private readonly InputActionMap m_Weapons;
    private List<IWeaponsActions> m_WeaponsActionsCallbackInterfaces = new List<IWeaponsActions>();
    private readonly InputAction m_Weapons_FireBullet;
    private readonly InputAction m_Weapons_FireLaser;
    public struct WeaponsActions
    {
        private @WeaponsAction m_Wrapper;
        public WeaponsActions(@WeaponsAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @FireBullet => m_Wrapper.m_Weapons_FireBullet;
        public InputAction @FireLaser => m_Wrapper.m_Weapons_FireLaser;
        public InputActionMap Get() { return m_Wrapper.m_Weapons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponsActions set) { return set.Get(); }
        public void AddCallbacks(IWeaponsActions instance)
        {
            if (instance == null || m_Wrapper.m_WeaponsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WeaponsActionsCallbackInterfaces.Add(instance);
            @FireBullet.started += instance.OnFireBullet;
            @FireBullet.performed += instance.OnFireBullet;
            @FireBullet.canceled += instance.OnFireBullet;
            @FireLaser.started += instance.OnFireLaser;
            @FireLaser.performed += instance.OnFireLaser;
            @FireLaser.canceled += instance.OnFireLaser;
        }

        private void UnregisterCallbacks(IWeaponsActions instance)
        {
            @FireBullet.started -= instance.OnFireBullet;
            @FireBullet.performed -= instance.OnFireBullet;
            @FireBullet.canceled -= instance.OnFireBullet;
            @FireLaser.started -= instance.OnFireLaser;
            @FireLaser.performed -= instance.OnFireLaser;
            @FireLaser.canceled -= instance.OnFireLaser;
        }

        public void RemoveCallbacks(IWeaponsActions instance)
        {
            if (m_Wrapper.m_WeaponsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWeaponsActions instance)
        {
            foreach (var item in m_Wrapper.m_WeaponsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WeaponsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WeaponsActions @Weapons => new WeaponsActions(this);
    public interface IWeaponsActions
    {
        void OnFireBullet(InputAction.CallbackContext context);
        void OnFireLaser(InputAction.CallbackContext context);
    }
}