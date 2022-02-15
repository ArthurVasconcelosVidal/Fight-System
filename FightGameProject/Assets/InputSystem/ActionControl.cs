// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/ActionControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ActionControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ActionControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ActionControl"",
    ""maps"": [
        {
            ""name"": ""MainAction"",
            ""id"": ""e02702c1-6ba0-4ab2-8250-b3680815d5d3"",
            ""actions"": [
                {
                    ""name"": ""Moviment"",
                    ""type"": ""Value"",
                    ""id"": ""0ee8ec3d-f769-4064-aca7-c6f72a1f3987"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SouthButton"",
                    ""type"": ""Button"",
                    ""id"": ""01e18da7-0794-475f-8297-150c3721d229"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis Keyboard"",
                    ""id"": ""8a0f9bb0-1191-4c70-874a-4daa533c2b94"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moviment"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9254046e-4e18-4d7b-990f-cd33b07aa38a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moviment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f599334c-d5b0-4ef7-aa6c-bc2f14684185"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moviment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""68444480-c74e-4944-a666-bd42962bd80a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SouthButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MainAction
        m_MainAction = asset.FindActionMap("MainAction", throwIfNotFound: true);
        m_MainAction_Moviment = m_MainAction.FindAction("Moviment", throwIfNotFound: true);
        m_MainAction_SouthButton = m_MainAction.FindAction("SouthButton", throwIfNotFound: true);
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

    // MainAction
    private readonly InputActionMap m_MainAction;
    private IMainActionActions m_MainActionActionsCallbackInterface;
    private readonly InputAction m_MainAction_Moviment;
    private readonly InputAction m_MainAction_SouthButton;
    public struct MainActionActions
    {
        private @ActionControl m_Wrapper;
        public MainActionActions(@ActionControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moviment => m_Wrapper.m_MainAction_Moviment;
        public InputAction @SouthButton => m_Wrapper.m_MainAction_SouthButton;
        public InputActionMap Get() { return m_Wrapper.m_MainAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActionActions set) { return set.Get(); }
        public void SetCallbacks(IMainActionActions instance)
        {
            if (m_Wrapper.m_MainActionActionsCallbackInterface != null)
            {
                @Moviment.started -= m_Wrapper.m_MainActionActionsCallbackInterface.OnMoviment;
                @Moviment.performed -= m_Wrapper.m_MainActionActionsCallbackInterface.OnMoviment;
                @Moviment.canceled -= m_Wrapper.m_MainActionActionsCallbackInterface.OnMoviment;
                @SouthButton.started -= m_Wrapper.m_MainActionActionsCallbackInterface.OnSouthButton;
                @SouthButton.performed -= m_Wrapper.m_MainActionActionsCallbackInterface.OnSouthButton;
                @SouthButton.canceled -= m_Wrapper.m_MainActionActionsCallbackInterface.OnSouthButton;
            }
            m_Wrapper.m_MainActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moviment.started += instance.OnMoviment;
                @Moviment.performed += instance.OnMoviment;
                @Moviment.canceled += instance.OnMoviment;
                @SouthButton.started += instance.OnSouthButton;
                @SouthButton.performed += instance.OnSouthButton;
                @SouthButton.canceled += instance.OnSouthButton;
            }
        }
    }
    public MainActionActions @MainAction => new MainActionActions(this);
    public interface IMainActionActions
    {
        void OnMoviment(InputAction.CallbackContext context);
        void OnSouthButton(InputAction.CallbackContext context);
    }
}
